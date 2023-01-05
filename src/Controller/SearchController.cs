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
    public class SearchController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public SearchController(DataBaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<Product> SearchProduct(string? name)
        {

            if (name == "" || name == null)
            {
                var result = _context.Products;
                return Ok(result);
            }

            var resultWithName = _context.Products.Where(p => p.Name == name);

            if (resultWithName == null)
                return NotFound($"{name} não encontrado no cadastro.");

            return Ok(resultWithName);
        }
    }
}