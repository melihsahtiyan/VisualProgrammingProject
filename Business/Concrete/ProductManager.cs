using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Services;
using Core.Persistence.Paging;
using Core.Utilities.Results;
using Domain.Dtos;
using Domain.Entities;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        protected IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IPaginate<Product>> GetAllAsyncByDynamic(DynamicQueryDto request)
        {
            IPaginate<Product> products =
                await _productRepository.GetListByDynamicAsync(request.Dynamic, index: request.Index,
                    size: request.Size);
            return products;
        }

        public IDataResult<List<Product>> GetAll()
        {
            var result = _productRepository.GetAll();
            if(result == null)
                return new ErrorDataResult<List<Product>>("Products not found!");

            return new SuccessDataResult<List<Product>>(result);
        }

        public Product GetById(int id)
        {
            return _productRepository.Get(p => p.Id == id);
        }

        public async void AddAsync(Product product)
        {
            var result = await _productRepository.AddAsync(product);
        }

        public async void UpdateAsync(Product product)
        {
            await _productRepository.UpdateAsync(product);
        }

        public async void DeleteAsync(Product product)
        {
            await _productRepository.DeleteAsync(product);
        }
    }
}
