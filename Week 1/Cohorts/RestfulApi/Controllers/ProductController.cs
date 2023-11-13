using Microsoft.AspNetCore.Mvc;
using RestfulApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private List<Product> products = new List<Product>();

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {

            if (product == null)
            {
                return BadRequest("Invalid product data");
            }

            if (string.IsNullOrWhiteSpace(product.Name))
            {
                return BadRequest("Product name is required");
            }

            product.Id = products.Count + 1;
            products.Add(product);

            return CreatedAtRoute("Post", new { id = product.Id }, product);
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] Product productModel)
        {

            if (productModel == null)
            {
                return BadRequest("Invalid product data");
            }

            if (string.IsNullOrWhiteSpace(productModel.Name))
            {
                return BadRequest("Product name is required");
            }


            var productName = productModel.Name;
            var productDescription = productModel.Description;

            var newProduct = new Product
            {
                Id = products.Count + 1,
                Name = productName,
                Description = productDescription
            };

            products.Add(newProduct);

            return Ok(newProduct);
        }



        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = products.Find(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            products.Remove(product);

            return Ok();
        }

    }
}
