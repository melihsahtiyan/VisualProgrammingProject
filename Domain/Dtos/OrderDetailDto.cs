using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Abstract;

namespace Domain.Dtos
{
    public class OrderDetailDto : IDto
    {
        public int Id { get; set; }
        public string CustomerFactoryName { get; set; }
        public string ManufacturerFactoryName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
