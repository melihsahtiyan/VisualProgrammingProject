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
            IWarehouseProductsService warehouseProductsService, IFactoryService factoryService)
        {
            _factoryService = factoryService;
            _ordersRepository = ordersRepository;
            _userService = userService;
            _productService = productService;
            _warehouseProductsService = warehouseProductsService;
        }

        public IResult Add(OrdersForCreateDto orders)
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

            if (stockToCheck.Data < orders.Quantity && orders.Quantity > 0)
            {
                return new ErrorResult("Not enough stock!");
            }

            var result = new Orders
            {
                DateOfOrder = DateTime.UtcNow,
                DeliveryDate = null,
                DepartureDate = null,
                EstimatedDeliveryDate = orders.EstimatedDeliveryDate,
                EstimatedDepartureDate = orders.EstimatedDepartureDate,
                ProductId = orders.ProductId,
                CustomerFactoryId = orders.CustomerFactoryId,
                ManufacturingFactoryId = orders.ManufacturingFactoryId,
                Quantity = orders.Quantity,
                CustomerWarehouseId = orders.CustomerWarehouseId,
                ManufacturerWarehouseId = orders.ManufacturerWarehouseId,
                IsCanceled = false,
            };

            _ordersRepository.Add(result);
            return new SuccessResult("Order added!");
        }

        public IResult AddRange(List<OrdersForCreateDto> orders)
        {
            foreach (var order in orders)
            {
                var result = Add(order);
                if (!result.Success)
                {
                    return new ErrorResult(result.Message);
                }
            }
            return new SuccessResult("Orders added!");
        }

        public IResult Update(Orders orders)
        {
            var orderToCheck = _ordersRepository.Get(c => c.Id == orders.Id);
            if (orderToCheck == null)
            {
                return new ErrorResult("Order not found!");
            }

            orderToCheck.DateOfOrder = orders.DateOfOrder;
            orderToCheck.DeliveryDate = orders.DeliveryDate;
            orderToCheck.DepartureDate = orders.DepartureDate;
            orderToCheck.EstimatedDeliveryDate = orders.EstimatedDeliveryDate;
            orderToCheck.EstimatedDepartureDate = orders.EstimatedDepartureDate;
            orderToCheck.CustomerWarehouseId = orders.CustomerWarehouseId;
            orderToCheck.ManufacturerWarehouseId = orders.ManufacturerWarehouseId;
            orderToCheck.ApprovedByCustomer = orders.ApprovedByCustomer;
            orderToCheck.ApprovedByManufacturer = orders.ApprovedByManufacturer;
            orderToCheck.ProductId = orders.ProductId;
            orderToCheck.CustomerFactoryId = orders.CustomerFactoryId;
            orderToCheck.ManufacturingFactoryId = orders.ManufacturingFactoryId;
            orderToCheck.Quantity = orders.Quantity;

            return new SuccessResult("Order updated!");
        }

        public IResult Delete(Orders orders)
        {
            _ordersRepository.Delete(orders);
            return new SuccessResult("Order deleted!");
        }

        public IResult ApproveOrderByManufacturer(int orderId, DateTime estimatedDepartureDate, DateTime estimatedDeliveryDate)
        {
            var result = _ordersRepository.Get(c => c.Id == orderId);
            if (result == null)
            {
                return new ErrorResult("Order not found!");
            }

            var factory = _factoryService.GetById(result.ManufacturingFactoryId).Data;
            if (factory == null)
            {
                return new ErrorResult("Factory not found!");
            }

            factory.TradeGrade += 0.5;

            result.ApprovedByManufacturer = true;
            result.EstimatedDepartureDate = estimatedDepartureDate;
            result.EstimatedDeliveryDate = estimatedDeliveryDate;
            
            Update(result);
            return new SuccessResult("Order approved!");
        }

        public IResult DepartOrderByManufacturer(int orderId, DateTime? estimatedDeliveryDate)
        {
            var result = _ordersRepository.Get(c => c.Id == orderId);
            if (result == null)
            {
                return new ErrorResult("Order not found!");
            }
            result.DepartureDate = DateTime.UtcNow;
            Update(result);
            return new SuccessResult("Order departed!");
        }

        public IResult ApproveOrderByCustomer(int orderId)
        {
            var result = _ordersRepository.Get(c => c.Id == orderId);
            if (result == null)
            {
                return new ErrorResult("Order not found!");
            }

            var factory = _factoryService.GetById(result.CustomerFactoryId).Data;
            if (factory == null)
            {
                return new ErrorResult("Factory not found!");
            }

            factory.TradeGrade += 0.5;

            result.ApprovedByCustomer = true;
            result.DeliveryDate = DateTime.UtcNow;
            Update(result);
            return new SuccessResult("Order approved!");
        }

        public IResult CancelOrderByManufacturer(int orderId, int factoryId)
        {
            var result = _ordersRepository.Get(c => c.Id == orderId);
            if (result == null)
            {
                return new ErrorResult("Order not found!");
            }
            var factory = _factoryService.GetById(factoryId).Data;
            if (factory == null)
            {
                return new ErrorResult("Factory not found!");
            }
            result.IsCanceled = true;
            result.ApprovedByCustomer = false;
            result.ApprovedByManufacturer = false;
            Update(result);

            factory.TradeGrade -= 5;
            _factoryService.Update(factory);

            return new SuccessResult("Order canceled!");
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
