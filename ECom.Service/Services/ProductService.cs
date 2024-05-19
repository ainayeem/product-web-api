using ECom.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ECom.Persistence.Repositories.ProductRepository;

namespace ECom.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<ProductDetails>> GetAllProductDetailsAsync(
            bool? inStock = null,
            string variantColor = null,
            string variantSize = null,
            string warehouseName = null,
            string productName = null,
            string sortBy = "createdOn",
            string sortOrder = "asc",
            int pageNumber = 1,
            int pageSize = 100)
        {
            var productDetails = await _productRepository.GetAllProductDetails(inStock, variantColor, variantSize, warehouseName, productName, sortBy, sortOrder, pageNumber, pageSize);
            return productDetails;
        }

        public async Task<ProductDetail?> GetProductBySearchEngineFriendlyNameAsync(string searchEngineFriendlyName)
        {
            return await _productRepository.GetProductBySearchEngineFriendlyName(searchEngineFriendlyName);
        }
    }
}
