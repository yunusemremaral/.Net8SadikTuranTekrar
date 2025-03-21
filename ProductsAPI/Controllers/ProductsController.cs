using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Models;

namespace ProductsAPI.Controllers
{
    // localhost:5000/api/products

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static List<Product>? _products;

        public ProductsController()
        {
            _products =
            [
                new Product { ProductId = 1, ProductName = "IPhone 15", Price = 50000, IsActive = false },
                new Product { ProductId = 2, ProductName = "IPhone 16", Price = 50000, IsActive = false },
                new Product { ProductId = 3, ProductName = "IPhone 17", Price = 50000, IsActive = false },
                new Product { ProductId = 4, ProductName = "IPhone 18", Price = 50000, IsActive = false },
            ];
        }



        // localhost:5000/api/products => GET
        [HttpGet]
        public  IActionResult GetProducts()
        {
            var products = _products.ToList();
            return Ok(products);
        }

        // localhost:5000/api/products/5 => GET
        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var p = _products.FirstOrDefault(x => x.ProductId == id);

            if (p == null)
            {
                return NotFound();
            }

            return Ok(p);
        }

        [HttpPost]
        public IActionResult CreateProduct(Product entity)
        {
            _products.Add(entity);

            return CreatedAtAction(nameof(GetProduct), new { id = entity.ProductId }, entity);
        }

        // localhost:5000/api/products/5 => PUT
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product entity)
        {
            if (id != entity.ProductId)
            {
                return BadRequest();
            }

            var product = _products.FirstOrDefault(i => i.ProductId == id);

            if (product == null)
            {
                return NotFound();
            }

            product.ProductName = entity.ProductName;
            product.Price = entity.Price;
            product.IsActive = entity.IsActive;

            return Ok(_products);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _products.FirstOrDefault(i => i.ProductId == id);

            if (product == null)
            {
                return NotFound();
            }

            _products.Remove(product);

            return Ok(_products);
        }

       
    }


}