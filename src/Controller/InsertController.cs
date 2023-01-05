using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APIStock.src.Context;
using APIStock.src.Entities;

namespace APIStock.src.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class InsertController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public InsertController(DataBaseContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult InsertProduct(string name, int quantity)
        {
            if (name == null)
            {
                return BadRequest("Por favor inserir o nome do Produto");
            }

            var product = new Product(name, quantity);
            _context.Add(product);
            _context.SaveChanges();

            return Ok();
        }
    }
}
