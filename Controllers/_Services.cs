using Microsoft.AspNetCore.Mvc;

namespace beautynew.Controllers
{
    public class _Services : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
