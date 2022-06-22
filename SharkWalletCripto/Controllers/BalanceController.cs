using Microsoft.AspNetCore.Mvc;

namespace SharkWalletCripto.Controllers
{
    public class BalanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
