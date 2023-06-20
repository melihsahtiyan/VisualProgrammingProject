using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Abstract;

namespace Domain.Dtos
{
    public class FactoryForCreateDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string TaxNumber { get; set; }
        public bool IsCustomer { get; set; }
        public bool IsSupplier { get; set; }
    }
}
