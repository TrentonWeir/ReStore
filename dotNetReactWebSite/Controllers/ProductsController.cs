using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using dotNetReactWebSite.Data;
using dotNetReactWebSite.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotNetReactWebSite.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts(){
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id){
            return await _context.Products.FindAsync(id);
        }
        [HttpPost("{id}")]
        public async Task<ActionResult<Product>> PostProduct(int id){
            var product = await _context.Products.FindAsync(id);
            return Ok(product);
        }
    }
}