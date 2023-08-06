using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class OrderItem : BaseEntity
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Guid ProductId { get; set; }

        public OrderItem(int quantity, decimal price, Guid productId)
        {
            Quantity = quantity;
            Price = price;
            ProductId = productId;
        }
    }
}
