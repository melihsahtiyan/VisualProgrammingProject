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

        public IDataResult<List<WarehouseProductsDetailDto>> GetWarehouseProductsDetailsByWarehouseId(int id)
        {
            return new SuccessDataResult<List<WarehouseProductsDetailDto>>(_warehouseProductsRepository
                .GetWarehouseProductsDetailsByWarehouseId(id));
        }

        public IDataResult<List<WarehouseProductsDetailDto>> GetWarehouseProductsDetailsByProductId(int id)
        {
            return new SuccessDataResult<List<WarehouseProductsDetailDto>>(_warehouseProductsRepository
                .GetWarehouseProductsDetailsByProductId(id));
        }

        public IDataResult<List<WarehouseProductsDetailDto>> GetWarehouseProductsDetailsByFactoryId(int id)
        {
            return new SuccessDataResult<List<WarehouseProductsDetailDto>>(_warehouseProductsRepository
                .GetWarehouseProductsDetailsByFactoryId(id));
        }

        public IDataResult<List<WarehouseProducts>> GetAllByProductIdAndWarehouseIdAndFactoryId(int productId, int warehouseId, int factoryId)
        {
            return new SuccessDataResult<List<WarehouseProducts>>(_warehouseProductsRepository
                .GetAllByProductIdAndWarehouseIdAndFactoryId(productId, warehouseId, factoryId));
        }

        public IDataResult<List<WarehouseProductsDetailDto>> GetAllDetailsByProductIdAndWarehouseIdAndFactoryId(int productId, int warehouseId, int factoryId)
        {
            return new SuccessDataResult<List<WarehouseProductsDetailDto>>(_warehouseProductsRepository
                .GetAllDetailsByProductIdAndWarehouseIdAndFactoryId(productId, warehouseId, factoryId));
        }

        public IDataResult<List<WarehouseProductsDetailDto>> GetAllDetailsByProductIdAndFactoryId(int productId, int factoryId)
        {
            return new SuccessDataResult<List<WarehouseProductsDetailDto>>(_warehouseProductsRepository
                .GetAllDetailsByProductIdAndFactoryId(productId, factoryId));
        }

        public IDataResult<int> GetTotalStockByFactoryIdAndProductId(int factoryId, int productId)
        {
            return new SuccessDataResult<int>(
                _warehouseProductsRepository.GetTotalStockByFactoryIdAndProductId(factoryId, productId));
        }
    }
}
