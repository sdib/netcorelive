using Microsoft.AspNetCore.Mvc;

namespace netcorelive
{
    public class HomeController : Controller 
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}