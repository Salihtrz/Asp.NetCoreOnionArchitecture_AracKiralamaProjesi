using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class UIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
