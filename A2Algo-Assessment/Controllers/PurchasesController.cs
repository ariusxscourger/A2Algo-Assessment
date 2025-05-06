using A2Algo_Assessment.DbInteraction;
using A2Algo_Assessment.Models;
using Microsoft.AspNetCore.Mvc;

namespace A2Algo_Assessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {
        private readonly InventoryContext _context;
        public PurchasesController(InventoryContext context) => _context = context;

        [HttpPost]
        public async Task<IActionResult> RecordPurchase(Purchase purchase)
        {
            var product = await _context.Products.FindAsync(purchase.ProductId);
            if (product == null) return NotFound("Product not found");

            product.Quantity += purchase.QuantityPurchased;
            _context.Purchases.Add(purchase);
            await _context.SaveChangesAsync();

            return Ok(purchase);
        }
    }

}
