using Microsoft.AspNetCore.Mvc;
using RestfulApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace RestfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private List<Product> products = new List<Product>();
        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound(); // 404 Not Found
            }
            return Ok(product);
        }

        [HttpPost]
        public ActionResult<Product> AddProduct([FromBody] Product product)
        {
            products.Add(product);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, product); // 201 Created
        }


        //// POST api/<ProductController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ProductController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ProductController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{

        //}
    }
}
