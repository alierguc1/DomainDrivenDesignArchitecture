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
        public DateTime OrderDate { get; set; }
        public string Description { get; set; }
        public string OrderStatus { get; set; }
        public Guid BuyerId { get; set; }
        public Adress Adress { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
