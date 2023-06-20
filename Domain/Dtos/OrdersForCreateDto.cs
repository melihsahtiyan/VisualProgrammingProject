using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Abstract;

namespace Domain.Dtos
{
    public class OrdersForCreateDto : IDto
    {
        public int Id { get; set; }
        public int CustomerFactoryId { get; set; }
        public int ManufacturingFactoryId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOfOrder { get; set; }
        public DateTime? EstimatedDepartureDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int ManufacturerWarehouseId { get; set; }
        public int CustomerWarehouseId { get; set; }
        public bool ApprovedByCustomer = false;
        public bool ApprovedByManufacturer = false;
    }
}
