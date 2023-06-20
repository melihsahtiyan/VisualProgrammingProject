using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Abstract;

namespace Domain.Dtos
{
    public class FactoryListDto : IDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TaxNumber { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public bool IsCustomer { get; set; }
        public bool IsSupplier { get; set; }
    }
}
