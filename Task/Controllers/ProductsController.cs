using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task.Model;


namespace Task.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductContext _context;

        public ProductsController(ProductContext context)
        {
            _context = context;

            if (_context.SingleProducts.Count() == 0)
            {
                // Create a new SingleProduct if collection is empty,
                // which means you can't delete all Products.
                _context.SingleProducts.Add(new SingleProduct { Name = "Oriflame Dark Wood Parfume" , Description ="jfkskjfsdj", Price = 300});
                _context.SingleProducts.Add(new SingleProduct { Name = "TV LG 9asf2" , Description = "jfkskjfsdj", Price = 50000 });
                _context.SingleProducts.Add(new SingleProduct { Name = "Mobile Phone", Description = "Lorem mdkf", Price = 3000 });
                _context.SaveChanges();
            }
        }

        // GET: api/products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleProduct>>> GetAllProducts()
        {
            return await _context.SingleProducts.ToListAsync();
        }

        // GET: api/product/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleProduct>> GetSingleProduct(long id)
        {
            var singleProduct = await _context.SingleProducts.FindAsync(id);

            if (singleProduct == null)
            {
                return NotFound();
            }

            return singleProduct;
        }
        // PUT: api/product/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleProduct(long id, SingleProduct product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/product/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(long id)
        {
            var product = await _context.SingleProducts.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            _context.SingleProducts.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }

}
