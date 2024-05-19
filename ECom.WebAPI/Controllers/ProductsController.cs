using AutoMapper;
using ECom.Persistence.Data;
using ECom.Persistence.Domain;
using ECom.Persistence.Interfaces;
using ECom.Persistence.Repositories;
using ECom.Service.DTOs;
using ECom.Service.Services;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using static ECom.Persistence.Repositories.ProductRepository;

namespace ECom.WebAPI.Controllers
{
    // api/products
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;
        private readonly IMemoryCache _cache;

        private readonly string cacheKey = "productsCacheKey";

        public ProductsController(IMapper mapper, IProductService productService, IMemoryCache cache  )
        {
            _mapper = mapper;
            _productService = productService;
            _cache = cache;
        }


        //
        [HttpGet("GetAllDetails")]
        public async Task<ActionResult<IEnumerable<ProductDetails>>> GetAllProductDetails(
            [FromQuery] bool? inStock = null,
            [FromQuery] string variantColor = null,
            [FromQuery] string variantSize = null,
            [FromQuery] string warehouseName = null,
            [FromQuery] string productName = null,
            [FromQuery] string sortBy = "createdOn",
            [FromQuery] string sortOrder = "asc",
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 100)
        {
            if (!string.IsNullOrWhiteSpace(variantColor))
            {
                variantColor = variantColor.ToLowerInvariant();
            }

            if (!string.IsNullOrWhiteSpace(variantSize))
            {
                variantSize = variantSize.ToLowerInvariant();
            }

            if (!string.IsNullOrWhiteSpace(warehouseName))
            {
                warehouseName = warehouseName.ToLowerInvariant();
            }

            if (!string.IsNullOrWhiteSpace(productName))
            {
                productName = productName.ToLowerInvariant();
            }

            //caching
            if (!_cache.TryGetValue(cacheKey, out IEnumerable<ProductDetails> productDtos))
            {
                var products = await _productService.GetAllProductDetailsAsync(
                    inStock, variantColor, variantSize, warehouseName, productName, sortBy, sortOrder, pageNumber, pageSize);

                productDtos = _mapper.Map<IEnumerable<ProductDetails>>(products);

                var cacheEntryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10),
                    SlidingExpiration = TimeSpan.FromMinutes(5)
                };

                _cache.Set(cacheKey, productDtos, cacheEntryOptions);
            }

            return Ok(productDtos);
        }


        //id
        [HttpGet("{searchEngineFriendlyName}")]
        public async Task<IActionResult> GetProductBySearchEngineFriendlyName(string searchEngineFriendlyName)
        {
            if (!_cache.TryGetValue(cacheKey, out ProductDetail productDto))
            {
                var product = await _productService.GetProductBySearchEngineFriendlyNameAsync(searchEngineFriendlyName);
                if (product == null)
                {
                    return NotFound();
                }

                productDto = _mapper.Map<ProductDetail>(product);

                var cacheEntryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10),
                    SlidingExpiration = TimeSpan.FromMinutes(5)
                };

                _cache.Set(cacheKey, productDto, cacheEntryOptions);
            }

            return Ok(productDto);
        }





    }
}