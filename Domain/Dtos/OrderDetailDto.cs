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
        public decimal Volume { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime DateOfOrder { get; set; }
        public DateTime? EstimatedDepartureDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string FromWhere { get; set; }
        public string ToWhere { get; set; }
        public bool ApprovedByCustomer { get; set; }
        public bool ApprovedByManufacturer { get; set; }
    }
}
