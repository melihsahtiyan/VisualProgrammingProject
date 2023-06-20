using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Concrete;

namespace Domain.Entities
{
    public class Orders : Entity
    {
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
        public bool ApprovedByCustomer { get; set; }
        public bool ApprovedByManufacturer { get; set; }
        public bool IsCanceled { get; set; }
        public virtual Factory CustomerFactory { get; set; }
        public virtual Factory ManufacturingFactory { get; set; }
        public virtual Product Product { get; set; }
        public virtual Warehouse ManufacturerWarehouse { get; set; }
        public virtual Warehouse CustomerWarehouse { get; set; }
        public Orders() { }

        public Orders(int id, int customerFactoryId, int manufacturingFactoryId, int productId, int quantity,
            DateTime dateOfOrder, DateTime estimatedDepartureDate, DateTime estimatedDeliveryDate,
            bool approvedByCustomer, bool approvedByManufacturer, int customerWarehouseId,
            int manufacturerWarehouseId) : base(id)

        {
            CustomerFactoryId = customerFactoryId;
            ManufacturingFactoryId = manufacturingFactoryId;
            ProductId = productId;
            Quantity = quantity;
            DateOfOrder = dateOfOrder;
            EstimatedDepartureDate = estimatedDepartureDate;
            EstimatedDeliveryDate = estimatedDeliveryDate;
            ApprovedByCustomer = approvedByCustomer;
            ApprovedByManufacturer = approvedByManufacturer;
            CustomerWarehouseId = customerWarehouseId;
            ManufacturerWarehouseId = manufacturerWarehouseId;
        }
    }
}
