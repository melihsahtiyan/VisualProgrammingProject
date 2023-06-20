using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Concrete;
using Domain.Entities;

namespace Domain.Entities
{
    public class Factory : User
    {
        public string Country { get; set; }
        public string Phone { get; set; }
        public string TaxNumber { get; set; }
        public bool IsCustomer { get; set; }
        public bool IsSupplier { get; set; }
        public double TradeGrade { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public Factory() { }

        public Factory(int id, string name, string email, byte[] passwordHash, byte[] passwordSalt, bool status,
            string country, string phone, bool ısCustomer, bool ısSupplier, string taxNumber) : base(id, name, email, passwordHash,
            passwordSalt, status)

        {
            Country = country;
            Phone = phone;
            IsCustomer = ısCustomer;
            IsSupplier = ısSupplier;
            TaxNumber = taxNumber;
        }
    }
}
