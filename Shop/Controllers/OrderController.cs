using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout()    // IActionResult возвращает html страницу, на которой будут происходить какие-то действия (принимать данные, введенные в формы)
        {
            return View();
        }

        [HttpPost] // срабатывает только при отправке данных
        public IActionResult Checkout(Order order)
        {
            shopCart.listShopItems = shopCart.getShopItems();

            if (shopCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("", "Для покупки необходимо выбрать хотя бы один товар.");
            }

            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан.";
            return View();
        }

    }
}
