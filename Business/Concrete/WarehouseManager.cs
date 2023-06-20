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

        public IResult Add(WarehouseForCreateDto warehouse)
        {
            var result = new Warehouse
            {
                Name = warehouse.Name,
                Address = warehouse.Address,
                Phone = warehouse.Phone,
                Email = warehouse.Email,
                FactoryId = warehouse.FactoryId
            };
            _warehouseRepository.Add(result);
            return new SuccessResult("Warehouse added!");
        }

        public IResult AddRange(List<WarehouseForCreateDto> warehouses)
        {
            foreach (var warehouse in warehouses)
            {
                var result = Add(warehouse);
                if (!result.Success)
                {
                    return new ErrorResult("Warehouse could not be added!");
                }
            }
            return new SuccessResult("Warehouses added!");
        }

        public IResult Update(WarehouseForCreateDto warehouse)
        {
            var result = GetById(warehouse.Id).Data;

            if (result == null)
            {
                return new ErrorResult("Warehouse could not be found!");
            }

            result.Name = warehouse.Name;
            result.Address = warehouse.Address;
            result.Phone = warehouse.Phone;
            result.Email = warehouse.Email;
            result.FactoryId = warehouse.FactoryId;

            _warehouseRepository.Update(result);
            return new SuccessResult("Warehouse updated!");
        }

        public IResult Delete(Warehouse warehouse)
        {
            _warehouseRepository.Delete(warehouse);
            return new SuccessResult("Warehouse deleted!");
        }
    }
}
