using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Week1_APIDevelopment.Models;

namespace Week1_APIDevelopment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaginationController : ControllerBase
    {
        private static List<Product> Products = Enumerable.Range(1, 100)
            .Select(i => new Product { Id = i, Name = $"Ürün {i}", Price = i * 10, Stock = i + 5 }).ToList();

        [HttpGet]
        public IActionResult GetPagedProducts(int page = 1, int pageSize = 10)
        {
            var pagedProducts = Products
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return Ok(new PagedResponse<Product>
            {
                TotalItems = Products.Count,
                Page = page,
                PageSize = pageSize,
                Items = pagedProducts
            });
        }
    }
}
