using Microsoft.AspNetCore.Mvc;
using WebHelloMVCEMpty.Models;

namespace WebHelloMVCEMpty.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Start(Person p)
        {
            return View(p);
        }
    }
}
