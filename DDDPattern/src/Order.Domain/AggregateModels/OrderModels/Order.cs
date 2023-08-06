using Order.Domain.Events;
using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class Order : BaseEntity, IAggregateRoot
    {

        public DateTime OrderDate { get; private set; }
        public string Description { get; private set; }
        public string OrderStatus { get; private set; }
        public Guid BuyerId { get; private set; }
        public Adress Adress { get; private set; }
        public ICollection<OrderItem> OrderItems { get; private set; }

        public Order(DateTime orderDate, string description, string orderStatus, Guid buyerId, Adress adress, ICollection<OrderItem> orderItems)
        {
            if (orderDate < DateTime.Now)
                throw new Exception("Orderdata must be greater than now");
            if (adress.City == "")
                throw new Exception("City cannot be empty");
            if (adress.Country == "")
                throw new Exception("Country cannot be empty");

            OrderDate = orderDate;
            Description = description;
            OrderStatus = orderStatus;
            BuyerId = buyerId;
            Adress = adress;
            OrderItems = orderItems;

            AddDomainEvents(new OrderStartedDomainEvent("","",this));

        }

        public void AddOrderItem(int Quantity, decimal Price, Guid ProductId)
        {
            OrderItem item = new(Quantity, Price, ProductId);
            OrderItems.Add(item);
        }
    }
}
