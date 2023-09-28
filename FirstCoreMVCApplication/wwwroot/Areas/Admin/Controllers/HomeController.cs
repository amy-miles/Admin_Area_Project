using Microsoft.AspNetCore.Mvc;

namespace FirstCoreMVCApplication.wwwroot.Areas.Admin
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index.cshtml");
        }
    }
}
