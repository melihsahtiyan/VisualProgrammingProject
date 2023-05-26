using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;

namespace WindowsApplication.Pages
{
    public partial class WarehouseStocksScreen : Form
    {
        private readonly IWarehouseProductsService _warehouseProductsService;
        public WarehouseStocksScreen(IWarehouseProductsService warehouseProductsService)
        {
            _warehouseProductsService = warehouseProductsService;
            InitializeComponent();
            
            var warehouseProducts = _warehouseProductsService.GetWarehouseProductsDetails().Data;
            foreach (var warehouseProduct in warehouseProducts)
            {
                warehouseProductsDataGridView.Rows.Add(warehouseProduct.Id, warehouseProduct.WarehouseName,
                    warehouseProduct.Address, warehouseProduct.Phone, warehouseProduct.ProductName,
                    warehouseProduct.ProductDescription,
                    warehouseProduct.Price, warehouseProduct.Quantity);
            }
        }

        private void WarehouseStocksScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
