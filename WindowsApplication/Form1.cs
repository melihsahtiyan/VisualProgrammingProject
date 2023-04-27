using Business.Abstract;
using Business.Services;

namespace WindowsApplication
{
    public partial class Form1 : Form
    {
        private readonly IProductService _productService;

        public Form1(IProductService productService)
        {
            _productService = productService;
            InitializeComponent();
        }


        private void txtChangeButton_Click(object sender, EventArgs e)
        {
            var result = _productService.GetById(1);
            productTextLabel.Text = result.Name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}