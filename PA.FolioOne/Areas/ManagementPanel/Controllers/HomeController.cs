using Microsoft.AspNetCore.Mvc;

namespace PA.FolioOne.Areas.ManagementPanel.Controllers
{
    [Area("ManagementPanel")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
