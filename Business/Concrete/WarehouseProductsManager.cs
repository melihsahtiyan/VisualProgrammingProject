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
    public class WarehouseProductsManager : IWarehouseProductsService
    {
        private readonly IWarehouseProductsRepository _warehouseProductsRepository;

        public WarehouseProductsManager(IWarehouseProductsRepository warehouseProductsRepository)
        {
            _warehouseProductsRepository = warehouseProductsRepository;
        }
        public IDataResult<List<WarehouseProducts>> GetAll()
        {
            var result = _warehouseProductsRepository.GetAll();
            return new SuccessDataResult<List<WarehouseProducts>>(result);
        }

        public IDataResult<List<WarehouseProductsDetailDto>> GetWarehouseProductsDetails()
        {
            var result = _warehouseProductsRepository.GetWarehouseProductsDetails();
            return new SuccessDataResult<List<WarehouseProductsDetailDto>>(result);
        }

        public IDataResult<WarehouseProducts> GetById(int id)
        {
            var result = _warehouseProductsRepository.Get(w => w.Id == id);
            if (result == null)
            {
                return new ErrorDataResult<WarehouseProducts>();
            }
            return new SuccessDataResult<WarehouseProducts>(result);
        }

        public IResult Add(WarehouseProducts warehouseProducts)
        {
            _warehouseProductsRepository.Add(warehouseProducts);
            return new SuccessResult();
        }

        public IResult Update(WarehouseProducts warehouseProducts)
        {
            _warehouseProductsRepository.Update(warehouseProducts);
            return new SuccessResult();
        }

        public IResult Delete(WarehouseProducts warehouseProducts)
        {
            _warehouseProductsRepository.Delete(warehouseProducts);
            return new SuccessResult();
        }
    }
}
