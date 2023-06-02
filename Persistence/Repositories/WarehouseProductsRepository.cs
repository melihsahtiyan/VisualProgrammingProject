using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Services;
using Core.Persistence.EntityFramework;
using Domain.Dtos;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class WarehouseProductsRepository : EfRepositoryBase<WarehouseProducts, BaseDbContext>,
    IWarehouseProductsRepository
{
    public WarehouseProductsRepository(BaseDbContext context) : base(context)
    { }

    public List<WarehouseProductsDetailDto> GetWarehouseProductsDetails()
    {
        var result = (from wp in Context.WarehouseProducts
                      join w in Context.Warehouses on wp.WarehouseId equals w.Id
                      join p in Context.Products on wp.ProductId equals p.Id
                      select new WarehouseProductsDetailDto
                      {
                          Id = wp.Id,
                          WarehouseName = w.Name,
                          Address = w.Address,
                          Phone = w.Phone,
                          ProductName = p.Name,
                          ProductDescription = p.Description,
                          Price = p.Price,
                          Quantity = wp.Quantity
                      }).ToList();
        return result;
    }

    public List<WarehouseProductsDetailDto> GetWarehouseProductsDetailsByWarehouseId(int id)
    {
        var result = (from warehouseProducts in Context.WarehouseProducts
            join warehouses in Context.Warehouses on warehouseProducts.WarehouseId equals warehouses.Id
            join products in Context.Products on warehouseProducts.ProductId equals products.Id
            where warehouseProducts.WarehouseId == id
            select new WarehouseProductsDetailDto()
            {
                Id = warehouseProducts.Id,
                WarehouseName = warehouses.Name,
                Address = warehouses.Address,
                Phone = warehouses.Phone,
                ProductName = products.Name,
                ProductDescription = products.Description,
                Price = products.Price,
                Quantity = warehouseProducts.Quantity
            }).ToList();

        return result;
    }

    public List<WarehouseProductsDetailDto> GetWarehouseProductsDetailsByProductId(int id)
    {
        var result = (from warehouseProducts in Context.WarehouseProducts
            join warehouses in Context.Warehouses on warehouseProducts.WarehouseId equals warehouses.Id
            join products in Context.Products on warehouseProducts.ProductId equals products.Id
            where warehouseProducts.ProductId == id
            select new WarehouseProductsDetailDto()
            {
                Id = warehouseProducts.Id,
                WarehouseName = warehouses.Name,
                Address = warehouses.Address,
                Phone = warehouses.Phone,
                ProductName = products.Name,
                ProductDescription = products.Description,
                Price = products.Price,
                Quantity = warehouseProducts.Quantity
            }).ToList();

        return result;
    }

    public List<WarehouseProductsDetailDto> GetWarehouseProductsDetailsByFactoryId(int id)
    {
        var result = (from warehouseProducts in Context.WarehouseProducts
            join warehouses in Context.Warehouses on warehouseProducts.WarehouseId equals warehouses.Id
            join products in Context.Products on warehouseProducts.ProductId equals products.Id
            join factories in Context.Factories on warehouses.FactoryId equals factories.Id
            where factories.Id == id
            select new WarehouseProductsDetailDto()
            {
                Id = warehouseProducts.Id,
                WarehouseName = warehouses.Name,
                Address = warehouses.Address,
                Phone = warehouses.Phone,
                ProductName = products.Name,
                ProductDescription = products.Description,
                Price = products.Price,
                Quantity = warehouseProducts.Quantity
            }).ToList();

        return result;
    }
    

    public List<WarehouseProducts> GetAllByProductIdAndWarehouseIdAndFactoryId(int productId, int warehouseId, int factoryId)
    {
        var result = (from warehouseProducts in Context.WarehouseProducts
            join warehouses in Context.Warehouses on warehouseProducts.WarehouseId equals warehouses.Id
            join products in Context.Products on warehouseProducts.ProductId equals products.Id
            join factories in Context.Factories on warehouses.FactoryId equals factories.Id
            where factories.Id == factoryId && warehouses.Id == warehouseId && products.Id == productId
            select new WarehouseProducts()
            {
                Id = warehouseProducts.Id,
                WarehouseId = warehouses.Id,
                ProductId = products.Id,
                Quantity = warehouseProducts.Quantity
            }).ToList();

        return result;
    }

    public List<WarehouseProductsDetailDto> GetAllDetailsByProductIdAndWarehouseIdAndFactoryId(int productId, int warehouseId, int factoryId)
    {
        var result = (from warehouseProducts in Context.WarehouseProducts
            join warehouses in Context.Warehouses on warehouseProducts.WarehouseId equals warehouses.Id
            join products in Context.Products on warehouseProducts.ProductId equals products.Id
            join factories in Context.Factories on warehouses.FactoryId equals factories.Id
            where factories.Id == factoryId && warehouses.Id == warehouseId && products.Id == productId
            select new WarehouseProductsDetailDto()
            {
                Id = warehouseProducts.Id,
                WarehouseName = warehouses.Name,
                Address = warehouses.Address,
                Phone = warehouses.Phone,
                ProductName = products.Name,
                ProductDescription = products.Description,
                Price = products.Price,
                Quantity = warehouseProducts.Quantity
            }).ToList();

        return result;
    }

    public List<WarehouseProductsDetailDto> GetAllDetailsByProductIdAndFactoryId(int productId, int factoryId)
    {
        var result = (from warehouseProducts in Context.WarehouseProducts
            join warehouses in Context.Warehouses on warehouseProducts.WarehouseId equals warehouses.Id
            join products in Context.Products on warehouseProducts.ProductId equals products.Id
            join factories in Context.Factories on warehouses.FactoryId equals factories.Id
            where factories.Id == factoryId && products.Id == productId
            select new WarehouseProductsDetailDto()
            {
                Id = warehouseProducts.Id,
                WarehouseName = warehouses.Name,
                Address = warehouses.Address,
                Phone = warehouses.Phone,
                ProductName = products.Name,
                ProductDescription = products.Description,
                Price = products.Price,
                Quantity = warehouseProducts.Quantity
            }).ToList();

        return result;
    }

    public int GetTotalStockByFactoryIdAndProductId(int factoryId, int productId)
    {
        var result = (from warehouseProducts in Context.WarehouseProducts
            join warehouses in Context.Warehouses on warehouseProducts.WarehouseId equals warehouses.Id
            join products in Context.Products on warehouseProducts.ProductId equals products.Id
            join factories in Context.Factories on warehouses.FactoryId equals factories.Id
            where factories.Id == factoryId && products.Id == productId
            select warehouseProducts.Quantity).Sum();

        return result;
    }
}

