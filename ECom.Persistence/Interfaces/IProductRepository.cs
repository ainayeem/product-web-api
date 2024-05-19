using ECom.Persistence.Domain;
using ECom.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ECom.Persistence.Repositories.ProductRepository;

namespace ECom.Persistence.Interfaces
{
    public interface IProductRepository
    {



        Task<IEnumerable<ProductDetails>> GetAllProductDetails(
       bool? inStock = null,
       string variantColor = null,
       string variantSize = null,
       string warehouseName = null,
       string productName = null,
       string sortBy = "createdOn",
       string sortOrder = "asc",
       int pageNumber = 1,
       int pageSize = 100);



        Task<ProductDetail?> GetProductBySearchEngineFriendlyName(string searchEngineFriendlyName);

    }
}
