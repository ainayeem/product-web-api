using ECom.Persistence.Data;
using ECom.Persistence.Domain;
using ECom.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ECom.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly EComDbContext _dbContext;

        public ProductRepository(EComDbContext dbContext)
        {
            _dbContext = dbContext;
        }




        //
        public async Task<IEnumerable<ProductDetails>> GetAllProductDetails(bool? inStock = null, string variantColor = null, string variantSize = null, string? warehouseName = null, string productName = null, string sortBy = "createdOn", string sortOrder = "asc", int pageNumber = 1, int pageSize = 100)
        {
            var products = _dbContext.Products
                .AsNoTracking()
                .Include(p => p.Variants)
                .ThenInclude(v => v.Stocks)
                .ThenInclude(s => s.Warehouse)
                .AsQueryable();

            if (inStock.HasValue)
            {
                if (inStock.Value)
                {
                    products = products.Where(p => p.Variants.Any(v => v.Stocks.Sum(s => s.Quantity) > 0));
                }
                else
                {
                    products = products.Where(p => p.Variants.All(v => v.Stocks.Sum(s => s.Quantity) == 0));
                }
            }

            if (!string.IsNullOrWhiteSpace(variantColor))
            {
                products = products.Where(p => p.Variants.Any(v => v.Color == variantColor));

            }

            if (!string.IsNullOrWhiteSpace(variantSize))
            {
                products = products.Where(p => p.Variants.Any(v => v.Size == variantSize));
            }

            // Filter by warehouseName 
            if (!string.IsNullOrWhiteSpace(warehouseName))
            {
                var warehouseId = await _dbContext.Warehouses
                    .Where(w => w.Name == warehouseName)
                    .Select(w => w.Id)
                    .FirstOrDefaultAsync();

                products = products.Where(p => p.Variants.Any(v => v.Stocks.Any(s => s.WarehouseId == warehouseId)));
            }

            if (!string.IsNullOrWhiteSpace(productName))
            {
                products = products.Where(p => p.Name.Contains(productName));
            }

            var productDetails = await products
                .Select(p => new
                {
                    Product = p,
                    TotalStockQuantity = p.Variants.Sum(v => v.Stocks.Sum(s => s.Quantity))
                })
                .SelectMany(p => p.Product.Variants.Where(v =>
            (string.IsNullOrWhiteSpace(variantColor) || v.Color == variantColor) &&
            (string.IsNullOrWhiteSpace(variantSize) || v.Size == variantSize)
        ).Select(v => new ProductDetails
        {
            ProductId = p.Product.Id,
            ProductName = p.Product.Name,
            SearchEngineFriendlyName = p.Product.SearchEngineFriendlyName,
            VariantId = v.Id,
            VariantColor = v.Color,
            VariantSize = v.Size,
            StockQuantity = v.Stocks.Sum(s => s.Quantity),
            WarehouseName = v.Stocks.FirstOrDefault().Warehouse.Name,
            WarehouseLocation = v.Stocks.FirstOrDefault().Warehouse.Location,
            WarehouseId = v.Stocks.FirstOrDefault().WarehouseId,
            CreatedOn = p.Product.CreatedOn,
            TotalStockQuantity = p.TotalStockQuantity
        }))
                .ToListAsync();


            // apply sort
            switch (sortBy.ToLower())
            {
                case "createdon":
                    productDetails = sortOrder.ToLower() == "desc"
                        ? productDetails.OrderByDescending(p => p.CreatedOn).ToList()
                        : productDetails.OrderBy(p => p.CreatedOn).ToList();
                    break;
                case "cumulativestocks":
                    productDetails = sortOrder.ToLower() == "desc"
                        ? productDetails.OrderByDescending(p => p.TotalStockQuantity).ToList()
                        : productDetails.OrderBy(p => p.TotalStockQuantity).ToList();
                    break;
                default:
                    productDetails = sortOrder.ToLower() == "desc"
                        ? productDetails.OrderByDescending(p => p.CreatedOn).ToList()
                        : productDetails.OrderBy(p => p.CreatedOn).ToList();
                    break;
            }
            // pagination
            var skipResults = (pageNumber - 1) * pageSize;


            //return productDetails;
            return productDetails.Skip(skipResults).Take(pageSize).ToList();
        }


        //
        public async Task<ProductDetail?> GetProductBySearchEngineFriendlyName(string searchEngineFriendlyName)
        {
            var product = await _dbContext.Products
                .AsNoTracking()
                .Include(p => p.Variants)
                .ThenInclude(v => v.Stocks)
                .ThenInclude(s => s.Warehouse)
                .FirstOrDefaultAsync(p => p.SearchEngineFriendlyName == searchEngineFriendlyName);

            if (product == null)
                return null;

            // Map to ProductDetails
            var productDetail = new ProductDetail
            {
                ProductId = product.Id,
                ProductName = product.Name,
                SearchEngineFriendlyName = product.SearchEngineFriendlyName,
                CreatedOn = product.CreatedOn,
                TotalStockQuantity = product.Variants.Sum(v => v.Stocks.Sum(s => s.Quantity)),
                Variants = product.Variants.Select(v => new VariantDetails
                {
                    VariantId = v.Id,
                    Color = v.Color,
                    Size = v.Size,
                    StockQuantity = v.Stocks.Sum(s => s.Quantity),
                    WarehouseName = v.Stocks.FirstOrDefault()?.Warehouse.Name,
                    WarehouseLocation = v.Stocks.FirstOrDefault()?.Warehouse.Location
                }).ToList()
            };

            return productDetail;
        }





        public class ProductDetails
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string SearchEngineFriendlyName { get; set; }
            public int VariantId { get; set; }
            public string VariantColor { get; set; }
            public string VariantSize { get; set; }
            public int StockQuantity { get; set; }
            public string WarehouseName { get; set; }
            public string WarehouseLocation { get; set; }
            public int? WarehouseId { get; set; }
            public DateTime CreatedOn { get; set; }
            public int TotalStockQuantity { get; internal set; }
        }
        public class ProductDetail
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string SearchEngineFriendlyName { get; set; }
            public DateTime CreatedOn { get; set; }
            public int TotalStockQuantity { get; internal set; }
            public object Variants { get; internal set; }
        }
        public class VariantDetails
        {
            public int VariantId { get; set; }
            public string Color { get; set; }
            public string Size { get; set; }
            public int StockQuantity { get; set; }
            public string WarehouseName { get; set; }
            public string WarehouseLocation { get; set; }
        }

    }


}

