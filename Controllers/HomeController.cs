using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TinyRobotsTools.Models;
using TinyRobotsTools.ViewModels;

namespace TinyRobotsTools.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public HomeController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public ViewResult Index()
        {
            var model = _orderRepository.GetAllOrders();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Order = _orderRepository.GetOrder(id),
                PageTitle = "Order Details"
            };
            return View(homeDetailsViewModel);
        }

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(OrderCreateViewModel order)
        {
            if (ModelState.IsValid)
            {
                Order newOrder = new Order
                {
                    Owner = order.Owner,
                    CupSize = order.CupSize,
                    CupStyle = order.CupStyle,
                    GlitterName = order.GlitterName,
                    Status = order.Status
                };
                _orderRepository.Add(newOrder);
                return RedirectToAction("details", new { id = newOrder.Id });
            }
            return View();
        }

        public ViewResult Edit(int id)
        {
            Order order = _orderRepository.GetOrder(id);
            OrderEditViewModel orderEditViewModel = new OrderEditViewModel
            {
                Id = order.Id,
                Owner = order.Owner,
                CupSize = order.CupSize,
                CupStyle = order.CupStyle,
                GlitterName = order.GlitterName,
                Status = order.Status
            };
            return View(orderEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(OrderEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Order order = _orderRepository.GetOrder(model.Id);
                order.Owner = model.Owner;
                order.CupSize = model.CupSize;
                order.CupStyle = model.CupStyle;
                order.GlitterName = model.GlitterName;
                order.Status = model.Status;
          
                _orderRepository.Update(order);
                return RedirectToAction("index");
            }
            return View();
        }
    }
}
