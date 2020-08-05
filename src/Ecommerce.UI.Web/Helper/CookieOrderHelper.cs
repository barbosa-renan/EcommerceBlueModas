using Ecommerce.Domain;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Ecommerce.UI.Web.Helper
{
    public static class CookieOrderHelper
    {
        private const string _cookieName = "Order";

        /// <summary>
        /// Recupera os dados de um pedido se tiver um cookie já criado.
        /// </summary>
        /// <returns>Pedido do tipo order</returns>
        public static Order GetCurrentOrder(HttpContext httpContext)
        {
            Order order = new Order();
            order.Items = new List<OrderItem>();

            string cookie = httpContext.Request.Cookies[_cookieName];

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
        public static void AddToCookieData(Order order, HttpContext httpContext)
        {
            CookieOptions options = CreateOptions();

            string data = JsonConvert.SerializeObject(order);

            httpContext.Response.Cookies.Append(_cookieName, data, options);
        }

        /// <summary>
        /// Configura as opções do cookie.
        /// </summary>
        public static CookieOptions CreateOptions()
        {
            return new CookieOptions
            {
                Secure = true,
                MaxAge = TimeSpan.FromDays(30)
            };
        }

        /// <summary>
        /// Remove o cookie do pedido
        /// </summary>
        public static void DeleteCookieData(HttpContext httpContext)
        {
            httpContext.Response.Cookies.Delete(_cookieName);
        }
    }
}