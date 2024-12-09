using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;
using System.Threading.Tasks;
using Week1_APIDevelopment.Models;

namespace Week1_APIDevelopment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CachingController : ControllerBase
    {
        private readonly IDistributedCache _cache;

        public CachingController(IDistributedCache cache)
        {
            _cache = cache;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductWithCache(int id)
        {
            var cacheKey = $"product_{id}";
            var cachedProduct = await _cache.GetStringAsync(cacheKey);

            if (!string.IsNullOrEmpty(cachedProduct))
            {
                return Ok(JsonSerializer.Deserialize<Product>(cachedProduct));
            }

            // Ürün yoksa simüle edilmiş veri
            var product = new Product { Id = id, Name = $"Product {id}", Price = id * 10, Stock = id + 5 };
            var serializedProduct = JsonSerializer.Serialize(product);

            await _cache.SetStringAsync(cacheKey, serializedProduct);
            return Ok(product);
        }
    }
}
