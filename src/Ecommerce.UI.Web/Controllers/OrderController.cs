using Ecommerce.Data;
using Ecommerce.Domain;
using Ecommerce.UI.Web.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.UI.Web.Controllers
{
    public class OrderController : Controller
    {
        private const string _cookieName = "Order";
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDBContext _context;

        public OrderController(ILogger<HomeController> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(CookieOrderHelper.GetCurrentOrder(HttpContext));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Order order)
        {
            return RedirectToAction("Index", "Client");
        }

        /// <summary>
        /// Atualiza a lista de itens do pedido com as quantidades selecionadas
        /// </summary>
        /// <param name="items">Itens do pedido</param>
        [HttpPost]
        [Route("check-out")]
        public bool CheckOut([FromBody] OrderItem[] items)
        {
            bool result = false;

            try
            {
                Order order = CookieOrderHelper.GetCurrentOrder(HttpContext);

                for (int i = 0; i < items.Length; i++)
                {
                    OrderItem orderItem = order.Items
                                               .Where(o => o.Product.Id == items[i].Product.Id)
                                               .FirstOrDefault();

                    order.Items.Remove(orderItem);
                    orderItem.Quantity = items[i].Quantity;
                    order.Items.Add(orderItem);
                }

                CookieOrderHelper.AddToCookieData(order, HttpContext);

                result = true;
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Adiciona um produto ao carrinho com base no id informado.
        /// </summary>
        /// <param name="productId">Primary key do produto</param>
        [HttpPost]
        [Route("add-to-cart")]
        public int AddToCart([FromBody] int productId)
        {
            int result = 0;
            OrderItem orderItem = null;

            try
            {
                var product = _context.Product.Where(p => p.Id == productId)
                                          .FirstOrDefault();

                if (product != null)
                {
                    Order order = CookieOrderHelper.GetCurrentOrder(HttpContext);

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

                    CookieOrderHelper.AddToCookieData(order, HttpContext);

                    result = order.Items.Sum(x => x.Quantity);
                }
            }
            catch (Exception)
            {
                result = -1;
            }

            return result;
        }

        /// <summary>
        /// Remove um produto do carrinho com base no id informado.
        /// </summary>
        /// <param name="productId">Primary key do produto</param>
        [HttpPost]
        [Route("remove-from-cart")]
        public bool RemoveFromCart([FromBody] int productId)
        {
            bool result = false;

            try
            {
                Order order = CookieOrderHelper.GetCurrentOrder(HttpContext);
                order.Items.RemoveAll(o => o.Product.Id == productId);

                CookieOrderHelper.AddToCookieData(order, HttpContext);

                result = true;
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Retorna o total de itens da cesta de compras
        /// </summary>
        [Route("get-total-cart")]
        public int GetTotalCart()
        {
            Order order = CookieOrderHelper.GetCurrentOrder(HttpContext);
            return order.Items.Sum(x => x.Quantity);
        }
    }
}