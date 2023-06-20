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

        public IDataResult<List<Product>> GetAllByWarehouseId(int warehouseId)
        {
            var result = _productRepository.GetAllByWarehouseId(warehouseId);
            return new SuccessDataResult<List<Product>>(result);
        }

        public IDataResult<Product> GetByName(string name)
        {
            var result = _productRepository.Get(p => p.Name == name);
            return new SuccessDataResult<Product>(result);
        }

        public Product GetById(int id)
        {
            return _productRepository.Get(p => p.Id == id);
        }

        public IResult Add(ProductForCreateDto product)
        {
            var result = _productRepository.Get(p => p.Name == product.Name);
            if (result != null)
                return new ErrorResult("Product already exists!");
            result = new Product
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Weight = product.Weight,
                Volume = product.Volume
            };
            _productRepository.Add(result);
            return new SuccessResult("Product added!");
        }

        public IResult AddRange(List<ProductForCreateDto> products)
        {
            foreach (var product in products)
            {
                var result = Add(product);
                if (!result.Success)
                    return new ErrorResult(result.Message);
            }

            return new SuccessResult("Products added!");
        }

        public IResult Update(ProductForCreateDto product)
        {
            var result = _productRepository.Get(p => p.Id == product.Id);
            if (result == null)
                return new ErrorResult("Product not found!");
            result.Name = product.Name;
            result.Description = product.Description;
            result.Price = product.Price;
            result.Weight = product.Weight;
            _productRepository.Update(result);
            return new SuccessResult("Product updated!");
        }

        public IResult Delete(ProductForCreateDto product)
        {
            var result = _productRepository.Get(p => p.Id == product.Id);
            _productRepository.Delete(result);
            return new SuccessResult("Product deleted!");
        }
    }
}
