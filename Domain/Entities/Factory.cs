﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Concrete;

namespace Domain.Entities
{
    public class Factory : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsCustomer { get; set; }
        public bool IsSupplier { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }
        public virtual ICollection<CustomerRequests> CustomerRequests { get; set; }
        public Factory() { }

        public Factory(int id, string name, string address, string phone, string email) : base(id)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
        }
    }
}
