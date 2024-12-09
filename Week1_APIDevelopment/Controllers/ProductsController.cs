using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Week1_APIDevelopment.Models;

namespace Week1_APIDevelopment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Pantolon", Price = 1500, Stock = 10 },
            new Product { Id = 2, Name = "Kazak", Price = 800, Stock = 25 }
        };

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(Products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound("Ürün bulunamadı!");
            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] Product newProduct)
        {
            Products.Add(newProduct);
            return CreatedAtAction(nameof(GetProductById), new { id = newProduct.Id }, newProduct);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product updatedProduct)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound("Ürün bulunamadı!");

            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            product.Stock = updatedProduct.Stock;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound("Ürün bulunamadı!");

            Products.Remove(product);
            return NoContent();
        }

        
    }
}
