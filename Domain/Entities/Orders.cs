using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Concrete;

namespace Domain.Entities
{
    public class Orders : Entity
    {
        public int CustomerFactoryId { get; set; }
        public virtual Factory CustomerFactory { get; set; }
        public int ManufacturingFactoryId { get; set; }
        public virtual Factory ManufacturingFactory { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public Orders() { }

        public Orders(int id, int customerFactoryId, int productId, int quantity, DateTime date) : base(id)
        {
            CustomerFactoryId = customerFactoryId;
            ProductId = productId;
            Quantity = quantity;
            Date = date;
        }
    }
}
