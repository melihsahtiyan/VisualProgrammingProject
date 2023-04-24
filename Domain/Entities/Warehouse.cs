using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Concrete;

namespace Domain.Entities
{
    public class Warehouse : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int FactoryId { get; set; }
        public virtual Factory Factory { get; set; }
        public virtual ICollection<WarehouseProducts> WarehouseProducts { get; set; }

        public Warehouse()
        {
        }

        public Warehouse(int id, string name, string address, string phone, string email, int factoryId) : base(id)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
            FactoryId = factoryId;
        }
    }
}
