using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Abstract;
using Domain.Entities;

namespace Domain.Dtos
{
    public class WarehouseProductsForCreateDto : IDto
    {
        public int Id { get; set; }
        public int WarehouseId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
