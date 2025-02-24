

namespace Kutuphane.Controllers;

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Kutuphane.Models;
using Kutuphane.Controllers;

public class CustomerOrdersController : Controller
{
    public ActionResult Index()
    {
        // Örnek müşteri ve siparişler
        var customer = new Kutuphane
        {
            Id = 1,
            FirstName = "Ali",
            LastName = "Yılmaz",
            Email = "ali.yilmaz@example.com"
        };

        var orders = new List<Order>
        {
            new Order { Id = 1, ProductName = "Laptop", Price = 15000, Quantity = 1 },
            new Order { Id = 2, ProductName = "Mouse", Price = 500, Quantity = 2 }
        };

        // ViewModel oluşturma
        var viewModel = new CustomerOrderViewModel
        {
            Customer = customer,
            Orders = orders
        };

        return View(viewModel);
    }
}
