using Microsoft.AspNetCore.Mvc;

namespace WebCoreLab.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}
