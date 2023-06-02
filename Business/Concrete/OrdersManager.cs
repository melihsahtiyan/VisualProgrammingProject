using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Services;
using Core.Utilities.Results;
using Domain.Dtos;
using Domain.Entities;

namespace Business.Concrete
{
    public class OrdersManager : IOrdersService
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly IUserService _userService;
        private readonly IProductService _productService;
        private readonly IFactoryService _factoryService;
        private readonly IWarehouseService _warehouseService;
        private readonly IWarehouseProductsService _warehouseProductsService;

        public OrdersManager(IOrdersRepository ordersRepository,
            IUserService userService, IProductService productService,
            IWarehouseProductsService warehouseProductsService)
        {
            _ordersRepository = ordersRepository;
            _userService = userService;
            _productService = productService;
            _warehouseProductsService = warehouseProductsService;
        }

        public IResult Add(Orders orders)
        {
            var factoryToCheck = _factoryService.GetById(orders.ManufacturingFactoryId);
            if (factoryToCheck == null)
            {
                return new ErrorResult("Factory not found!");
            }

            var productToCheck = _productService.GetById(orders.ProductId);
            if (productToCheck == null)
            {
                return new ErrorResult("Product not found!");
            }

            var stockToCheck =
                _warehouseProductsService.GetTotalStockByFactoryIdAndProductId(orders.ManufacturingFactoryId,
                    orders.ProductId);

            if (stockToCheck.Data < orders.Quantity)
            {
                return new ErrorResult("Not enough stock!");
            }

            _ordersRepository.Add(orders);
            return new SuccessResult("Order added!");
        }

        public IResult Update(Orders orders)
        {
            _ordersRepository.Update(orders);
            return new SuccessResult("Order updated!");
        }

        public IResult Delete(Orders orders)
        {
            _ordersRepository.Delete(orders);
            return new SuccessResult("Order deleted!");
        }

        public IDataResult<Orders> GetById(int id)
        {
            var result = _ordersRepository.Get(c => c.Id == id);
            if (result == null)
            {
                return new ErrorDataResult<Orders>("Order not found!");
            }
            return new SuccessDataResult<Orders>(result, "Order found!");
        }

        public IDataResult<List<Orders>> GetAll()
        {
            var result = _ordersRepository.GetAll();
            if (result == null)
            {
                return new ErrorDataResult<List<Orders>>("Orders not found!");
            }
            return new SuccessDataResult<List<Orders>>(result, "Orders found!");
        }

        public IDataResult<List<Orders>> GetByUserId(int userId)
        {
            var userToCheck = _userService.GetById(userId);
            if (userToCheck == null)
            {
                return new ErrorDataResult<List<Orders>>("User not found!");
            }

            var result = _ordersRepository.GetAll(c => c.CustomerFactoryId == userId);

            if (result == null)
            {
                return new ErrorDataResult<List<Orders>>("Orders not found!");
            }
            return new SuccessDataResult<List<Orders>>(result, "Orders found!");
        }

        public IDataResult<List<Orders>> GetByProductId(int productId)
        {
            var productToCheck = _productService.GetById(productId);
            if (productToCheck == null)
            {
                return new ErrorDataResult<List<Orders>>("Product not found!");
            }

            var result = _ordersRepository.GetAll(c => c.ProductId == productId);
            if (result == null)
            {
                return new ErrorDataResult<List<Orders>>("Orders not found!");
            }
            return new SuccessDataResult<List<Orders>>(result, "Orders found!");
        }

        public IDataResult<List<Orders>> GetByUserIdAndProductId(int userId, int productId)
        {
            var userToCheck = _userService.GetById(userId);
            if (userToCheck == null)
            {
                return new ErrorDataResult<List<Orders>>("User not found!");
            }
            var productToCheck = _productService.GetById(productId);
            if (productToCheck == null)
            {
                return new ErrorDataResult<List<Orders>>("Product not found!");
            }

            var result =
                _ordersRepository.GetAll(c => c.CustomerFactoryId == userId && c.ProductId == productId);
            if (result == null)
            {
                return new ErrorDataResult<List<Orders>>("Order not found!");
            }

            return new SuccessDataResult<List<Orders>>(result, "Order found!");
        }

        public IDataResult<List<OrderDetailDto>> GetOrderDetails()
        {
            var result = _ordersRepository.GetOrderDetails();
            if (result == null)
            {
                return new ErrorDataResult<List<OrderDetailDto>>("Order details not found!");
            }
            return new SuccessDataResult<List<OrderDetailDto>>(result, "Order details found!");
        }
    }
}
