using A2Algo_Assessment.DbInteraction;
using A2Algo_Assessment.Models;
using Microsoft.AspNetCore.Mvc;

namespace A2Algo_Assessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly InventoryContext _context;
        public SalesController(InventoryContext context) => _context = context;

        [HttpPost]
        public async Task<IActionResult> RecordSale(Sale sale)
        {
            var product = await _context.Products.FindAsync(sale.ProductId);
            if (product == null) return NotFound("Product not found");

            if (product.Quantity < sale.QuantitySold)
                return BadRequest("Not enough inventory");

            product.Quantity -= sale.QuantitySold;
            _context.Sales.Add(sale);
            await _context.SaveChangesAsync();

            return Ok(sale);
        }
    }

}
