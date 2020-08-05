using Ecommerce.Data;
using Ecommerce.Domain;
using Ecommerce.UI.Web.Helper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Ecommerce.UI.Web.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationDBContext _context;

        public ClientController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Phone")] Client client)
        {
            if (ModelState.IsValid)
            {
                Order order = CookieOrderHelper.GetCurrentOrder(HttpContext);
                order.Client = client;

                _context.Add(order);

                await _context.SaveChangesAsync();

                //Remover cookie com detalhes do pedido
                CookieOrderHelper.DeleteCookieData(HttpContext);

                return RedirectToAction("Index", "OrderComplete", new { id=order.Id });
            }

            return View();
        }
    }
}
