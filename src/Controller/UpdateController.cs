using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APIStock.src.Entities;
using APIStock.src.Context;

namespace APIStock.src.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class UpdateController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public UpdateController(DataBaseContext context)
        {
            _context = context;
        }

        [HttpPut]
        public ActionResult UpdateQuantity(string name, int quantity)
        {
            var DBProduct = _context.Products.FirstOrDefault(p => p.Name == name);

            if (DBProduct == null)
            return NotFound();

            int result = DBProduct.Quantity + quantity;

            if (result < 0)
            return BadRequest("Quantidade indisponível em estoque.");

            DBProduct.Quantity = result;
            _context.Products.Update(DBProduct);
            _context.SaveChanges();
            return Ok($"Quantidade do produto {DBProduct.Name} atualizado para {DBProduct.Quantity}");
        }
    }
}