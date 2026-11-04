using Microsoft.AspNetCore.Mvc;
using PA.FolioOne.Models;
using System.Diagnostics;

namespace PA.FolioOne.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult Portfolio()
    {
        return View();
    }

    public IActionResult PortfolioDetail()
    {
        return View();
    }

    public IActionResult Resume()
    {
        return View();
    }

    public IActionResult Services()
    {
        return View();
    }

    public IActionResult ServiceDetail()
    {
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
