﻿using Ecommerce.Data;
using Ecommerce.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

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
            return View(GetCurrentOrder());
        }

        /// <summary>
        /// Adiciona um produto ao carrinho com base no id informado.
        /// </summary>
        /// <param name="productId">Primary key do produto</param>
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

                AddToCookieData(order);
            }
        }

        /// <summary>
        /// Recupera os dados de um pedido se tiver um cookie já criado.
        /// </summary>
        /// <returns>Pedido do tipo order</returns>
        private Order GetCurrentOrder()
        {
            Order order = new Order();
            order.Items = new List<OrderItem>();

            string cookie = HttpContext.Request.Cookies[_cookieName];

            if (cookie != null)
            {
                order = JsonConvert.DeserializeObject<Order>(cookie);
            }

            return order;
        }

        /// <summary>
        /// Adiciona o pedido ao cookie
        /// </summary>
        /// <param name="order">Pedido com os produtos selecionados</param>
        private void AddToCookieData(Order order)
        {
            CookieOptions options = CreateOptions();

            string data = JsonConvert.SerializeObject(order);

            HttpContext.Response.Cookies.Append(_cookieName, data, options);
        }

        /// <summary>
        /// Configura as opções do cookie.
        /// </summary>
        private CookieOptions CreateOptions()
        {
            return new CookieOptions
            {
                Secure = true,
                MaxAge = TimeSpan.FromDays(30)
            };
        }
    }
}
