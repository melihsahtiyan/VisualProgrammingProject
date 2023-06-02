using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Services;
using Core.Utilities.Results;
using Domain.Entities;

namespace Business.Concrete
{
    public class WarehouseManager : IWarehouseService
    {
        private readonly IWarehouseRepository _warehouseRepository;
        private readonly IFactoryService _factoryService;

        public WarehouseManager(IWarehouseRepository repository, IFactoryService factoryService)
        {
            _warehouseRepository = repository;
            _factoryService = factoryService;
        }
        public IDataResult<List<Warehouse>> GetAll()
        {
            return new SuccessDataResult<List<Warehouse>>(_warehouseRepository.GetAll());
        }

        public IDataResult<Warehouse> GetById(int id)
        {
            return new SuccessDataResult<Warehouse>(_warehouseRepository.Get(x => x.Id == id));
        }

        public IDataResult<List<Warehouse>> GetAllByFactoryId(int id)
        {
            return new SuccessDataResult<List<Warehouse>>(_warehouseRepository.GetAll(x => x.FactoryId == id));
        }

        public IDataResult<List<Warehouse>> GetAllByFactoryIdAndWarehouseId(int factoryId, int warehouseId)
        {
            var result = _warehouseRepository.GetAll(x => x.FactoryId == factoryId && x.Id == warehouseId);
            return new SuccessDataResult<List<Warehouse>>(result);
        }

        public IDataResult<List<Warehouse>> GetAllByWarehouseId(int id)
        {
            return new SuccessDataResult<List<Warehouse>>(_warehouseRepository.GetAll(x => x.Id == id));
        }

        public IDataResult<List<Warehouse>> GetAllByFactoryName(string factoryName)
        {
            var factory = _factoryService.GetByName(factoryName);
            var result = _warehouseRepository.GetAll(x => x.FactoryId == factory.Data.Id);
            return new SuccessDataResult<List<Warehouse>>(result);
        }

        public IDataResult<Warehouse> GetAllByWarehouseName(string warehouseName)
        {
            var result = _warehouseRepository.Get(x => x.Name == warehouseName);
            return new SuccessDataResult<Warehouse>(result);
        }

        public IResult Add(Warehouse warehouse)
        {
            _warehouseRepository.Add(warehouse);
            return new SuccessResult("Warehouse added!");
        }

        public IResult Update(Warehouse warehouse)
        {
            _warehouseRepository.Update(warehouse);
            return new SuccessResult("Warehouse updated!");
        }

        public IResult Delete(Warehouse warehouse)
        {
            _warehouseRepository.Delete(warehouse);
            return new SuccessResult("Warehouse deleted!");
        }
    }
}
