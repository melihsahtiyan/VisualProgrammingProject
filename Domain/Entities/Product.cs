using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Concrete;

namespace Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public virtual ICollection<WarehouseProducts> WarehouseProducts { get; set; }
        public virtual ICollection<CustomerRequests> CustomerRequests { get; set; }

        public Product() {}

        public Product(int id, string name, string description, decimal price, decimal weight) : base(id)
        {
            Name = name;
            Description = description;
            Price = price;
            Weight = weight;
        }
    }
}
