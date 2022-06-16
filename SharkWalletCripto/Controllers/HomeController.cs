using Microsoft.AspNetCore.Mvc;

namespace SharkWalletCripto.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
