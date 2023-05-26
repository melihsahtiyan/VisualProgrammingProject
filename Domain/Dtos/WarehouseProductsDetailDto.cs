using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Abstract;

namespace Domain.Dtos
{
    public class WarehouseProductsDetailDto : IDto
    {
        public int Id { get; set; }
        public string WarehouseName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
