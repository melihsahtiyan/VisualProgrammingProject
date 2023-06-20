using Business.Abstract;
using Core.Domain.Dtos;
using Domain.Dtos;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IWarehouseProductsService _warehouseProductsService;
        private readonly IWarehouseService _warehouseService;
        private readonly IAuthService _authService;
        private readonly IOrdersService _orderService;
        private readonly IFactoryService _factoryService;
        private readonly IUserService _userService;

        public BaseController(IProductService productService, IWarehouseProductsService warehouseProductsService,
            IWarehouseService warehouseService, IAuthService authService, IOrdersService orderService,
            IFactoryService factoryService, IUserService userService)
        {
            _productService = productService;
            _warehouseProductsService = warehouseProductsService;
            _warehouseService = warehouseService;
            _authService = authService;
            _orderService = orderService;
            _factoryService = factoryService;
            _userService = userService;
        }

        [HttpPost("registerlist")]
        public IActionResult RegisterList(List<UserForRegisterDto> users)
        {
            var result = _authService.RegisterList(users);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("addproduct")]
        public IActionResult AddProduct(ProductForCreateDto product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addproductrange")]
        public IActionResult AddProductRange(List<ProductForCreateDto> products)
        {
            var result = _productService.AddRange(products);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallproducts")]
        public IActionResult GetAllProducts()
        {
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getproductbyid")]
        public IActionResult GetProductById(int id)
        {
            var result = _productService.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addwarehouse")]
        public IActionResult AddWarehouse(WarehouseForCreateDto warehouse)
        {
            var result = _warehouseService.Add(warehouse);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addwarehouserange")]
        public IActionResult AddWarehouseRange(List<WarehouseForCreateDto> warehouses)
        {
            var result = _warehouseService.AddRange(warehouses);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getallwarehouses")]
        public IActionResult GetAllWarehouses()
        {
            var result = _warehouseService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getwarehousebyid")]
        public IActionResult GetWarehouseById(int id)
        {
            var result = _warehouseService.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addwarehouseproduct")]
        public IActionResult AddWarehouseProduct(WarehouseProductsForCreateDto warehouseProduct)
        {
            var result = _warehouseProductsService.Add(warehouseProduct);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addwarehouseproductsrange")]
        public IActionResult AddWarehouseProductsRange(List<WarehouseProductsForCreateDto> warehouseProducts)
        {
            var result = _warehouseProductsService.AddRange(warehouseProducts);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallwarehouseproducts")]
        public IActionResult GetAllWarehouseProducts()
        {
            var result = _warehouseProductsService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getwarehouseproductsdetails")]
        public IActionResult GetWarehouseProductsDetails()
        {
            var result = _warehouseProductsService.GetWarehouseProductsDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getwarehouseproductbyid")]
        public IActionResult GetWarehouseProductById(int id)
        {
            var result = _warehouseProductsService.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addorder")]
        public IActionResult AddOrder(OrdersForCreateDto order)
        {
            var result = _orderService.Add(order);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addorderrange")]
        public IActionResult AddOrderRange(List<OrdersForCreateDto> orders)
        {
            var result = _orderService.AddRange(orders);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallorders")]
        public IActionResult GetAllOrders()
        {
            var result = _orderService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getorderbyid")]
        public IActionResult GetOrderById(int id)
        {
            var result = _orderService.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallfactories")]
        public IActionResult GetAllFactories()
        {
            var result = _factoryService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getfactorybyid")]
        public IActionResult GetFactoryById(int id)
        {
            var result = _factoryService.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallusers")]
        public IActionResult GetAllUsers()
        {
            var result = _userService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
