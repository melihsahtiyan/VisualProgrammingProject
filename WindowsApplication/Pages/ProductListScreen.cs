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
    public partial class ProductListScreen : Form
    {
        private readonly IProductService _productService;
        public ProductListScreen(IProductService productService)
        {
            _productService = productService;
            InitializeComponent();

            var products = _productService.GetAll().Data;
            foreach (var product in products)
            {
                dataGridView1.Rows.Add(product.Id, product.Name, product.Description, product.Price, product.Weight);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
