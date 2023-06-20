using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Concrete;

namespace Domain.Entities
{
    public class WarehouseProducts : Entity
    {
        public int WarehouseId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public virtual Product Product { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public WarehouseProducts() { }

        public WarehouseProducts(int id, int warehouseId, int productId, int quantity) : base(id)
        {
            WarehouseId = warehouseId;
            ProductId = productId;
            Quantity = quantity;
        }
    }
}
