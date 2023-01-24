using Common;
using Customers.Server;
using Orders.Server;

namespace CustomerOrder.Server.Entities
{
    public class CustomerOrder : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public Customer Customers { get; set; }

        public Guid OrderId { get; set; }
        public Order Orders { get; set; }
        public DateTime AddedOn { get; set; }
    }
}