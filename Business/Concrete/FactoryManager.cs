using Business.Abstract;
using Business.Services;
using Core.Utilities.Results;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IResult Add(Factory factory)
        {
            factoryRepository.Add(factory);
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

        public IDataResult<List<Factory>> GetAll()
        {
            return new SuccessDataResult<List<Factory>>(factoryRepository.GetAll());
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
            var result = GetById(factory.Id);
            
            if (result == null)
                return new ErrorResult();

            factoryRepository.Update(factory);
            return new SuccessResult();
        }
    }
}
