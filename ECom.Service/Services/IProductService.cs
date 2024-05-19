using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ECom.Persistence.Repositories.ProductRepository;

namespace ECom.Service.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDetails>> GetAllProductDetailsAsync(
            bool? inStock = null,
            string variantColor = null,
            string variantSize = null,
            string warehouseName = null,
            string productName = null,
            string sortBy = "createdOn",
            string sortOrder = "asc",
            int pageNumber = 1,
            int pageSize = 100);

        Task<ProductDetail?> GetProductBySearchEngineFriendlyNameAsync(string searchEngineFriendlyName);
    }
}
