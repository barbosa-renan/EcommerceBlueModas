using Ecommerce.Data;
using Ecommerce.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.UI.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDBContext _context;

        public OrderController(ILogger<HomeController> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            //TODO: Recuperar order armazenado nos cookies
            return View(GetCurrentOrder());
        }

        [HttpPost]
        [Route("add-to-cart")]
        public void AddToCart([FromBody] int productId)
        {
            OrderItem orderItem = null;

            var product = _context.Product.Where(p => p.Id == productId)
                                  .FirstOrDefault();

            if (product != null)
            {
                Order order = GetCurrentOrder();

                orderItem = order.Items.Where(o => o.Product.Id == productId)
                                          .FirstOrDefault();

                if (orderItem == null)
                {
                    orderItem = new OrderItem
                    {
                        Product = product,
                        Quantity = 1
                    };
                }
                else
                {
                    order.Items.Remove(orderItem);
                    orderItem.Quantity++;
                }

                order.Items.Add(orderItem);

                //TODO: incluir order em cookie e atualizar contador do carrinho
            }
        }

        private Order GetCurrentOrder()
        {
            //TODO: Recuperar order armazenado em cookie
            Order order = new Order();
            order.Items = new List<OrderItem>();

            foreach (Product product in _context.Product.ToList())
            {
                OrderItem item = new OrderItem
                {
                    OrderId = order.Id,
                    Product = product,
                    Quantity = 1
                };

                order.Items.Add(item);
            }

            return order;
        }
    }
}
