using Ecommerce.Data;
using Ecommerce.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.UI.Web.Controllers
{
    public class OrderCompleteController : Controller
    {
        private readonly ApplicationDBContext _context;

        public OrderCompleteController(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .FirstOrDefaultAsync(m => m.Id == id);

            if (order == null)
            {
                return NotFound();
            }
            else
            {
                order.Client = _context.Client
                    .FirstOrDefault(c => c.Id == order.ClientId);

                order.Items = _context.OrderItem
                    .Where(o => o.OrderId == order.Id).ToList();

                foreach (OrderItem item in order.Items)
                {
                    item.Product = _context.Product
                        .FirstOrDefault(p => p.Id == item.ProductId);
                }
            }          

            return View(order);
        }
    }
}