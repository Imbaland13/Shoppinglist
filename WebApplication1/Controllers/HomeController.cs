using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult ProductForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult ProductForm(Product product)
        {
            Repository.AddResponse(product);
            return View();
        }
        public ViewResult ShoppingList()
        {
            return View(Repository.Responses);
        }
    }
}