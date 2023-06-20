using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Domain.Dtos;
using Domain.Entities;

namespace Business.Abstract
{
    public interface IOrdersService
    {
        IResult Add(OrdersForCreateDto orders);
        IResult AddRange(List<OrdersForCreateDto> orders);
        IResult Update(Orders orders);
        IResult Delete(Orders orders);
        IResult ApproveOrderByManufacturer(int orderId, DateTime estimatedDepartureDate, DateTime estimatedDeliveryDate);
        IResult DepartOrderByManufacturer(int orderId, DateTime? estimatedDeliveryDate);
        IResult ApproveOrderByCustomer(int orderId);
        IResult CancelOrderByManufacturer(int orderId, int factoryId);
        IDataResult<Orders> GetById(int id);
        IDataResult<List<Orders>> GetAll();
        IDataResult<List<Orders>> GetByUserId(int userId);
        IDataResult<List<Orders>> GetByProductId(int productId);
        IDataResult<List<Orders>> GetByUserIdAndProductId(int userId, int productId);
        IDataResult<List<OrderDetailDto>> GetOrderDetails();
    }
}
