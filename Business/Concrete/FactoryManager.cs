using Business.Abstract;
using Business.Services;
using Core.Utilities.Results;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Dtos;

namespace Business.Concrete
{
    public class FactoryManager : IFactoryService
    {
        private readonly IFactoryRepository factoryRepository;
        public FactoryManager(IFactoryRepository factoryRepository)
        {
            this.factoryRepository = factoryRepository;
        }

        public IDataResult<Factory> GetByEmail(string email)
        {
            var result = factoryRepository.Get(f => f.Email == email);
            if (result == null)
            {
                return new ErrorDataResult<Factory>();
            }
            return new SuccessDataResult<Factory>(result);
        }

        public IDataResult<Factory> GetByName(string factoryName)
        {
            var result = factoryRepository.Get(f => f.Name == factoryName);
            return new SuccessDataResult<Factory>(result);
        }

        public IResult Add(FactoryForCreateDto factory)
        {
            var result = factoryRepository.Get(f => f.TaxNumber == factory.TaxNumber);
            if (result != null)
                return new ErrorResult();
            result = new Factory
            {
                TaxNumber = factory.TaxNumber,
                Name = factory.Name,
                Email = factory.Email,
                Country = factory.Country,
                Phone = factory.Phone,
                Status = factory.Status,
                IsSupplier = factory.IsSupplier,
                IsCustomer = factory.IsCustomer,
                PasswordHash = factory.PasswordHash,
                PasswordSalt = factory.PasswordSalt,
                TradeGrade = 100
            };
            factoryRepository.Add(result);
            return new SuccessResult();
        }

        public IResult Delete(int id)
        {
            var result = GetById(id);
            if (result.Success)
            {
                factoryRepository.Delete(result.Data);
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        public IDataResult<List<FactoryListDto>> GetAll()
        {
            var result = factoryRepository.GetAllFactories();
            return new SuccessDataResult<List<FactoryListDto>>(result);
        }

        public IDataResult<List<Factory>> GetAllManufacturer()
        {
            var result = factoryRepository.GetAll(f => f.IsSupplier == true);
            return new SuccessDataResult<List<Factory>>(result);
        }

        public IDataResult<List<Factory>> GetAllCustomer()
        {
            var result = factoryRepository.GetAll(f => f.IsSupplier == false);
            return new SuccessDataResult<List<Factory>>(result);
        }

        public IDataResult<Factory> GetById(int id)
        {
            var result = factoryRepository.Get(f => f.Id == id);
            if(result == null)
            {
                return new ErrorDataResult<Factory>();
            }
            return new SuccessDataResult<Factory>(result);
        }

        public IResult Update(Factory factory)
        {
            var result = GetById(factory.Id).Data;
            
            if (result == null)
                return new ErrorResult();

            result.Name = factory.Name;
            result.Email = factory.Email;
            result.Country = factory.Country;
            result.Phone = factory.Phone;
            result.Status = factory.Status;
            result.IsSupplier = factory.IsSupplier;
            result.IsCustomer = factory.IsCustomer;
            result.TaxNumber = factory.TaxNumber;

            factoryRepository.Update(result);
            return new SuccessResult();
        }
    }
}
