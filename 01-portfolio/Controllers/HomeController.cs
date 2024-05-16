using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _01_portfolio.Models;

namespace _01_portfolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var projects = GetProyects().Take(2).ToList();
        var model = new HomeIndexViewModel() { Projects = projects };
        return View(model);
    }

    private List<ProjectViewModel> GetProyects()
    {
        return new List<ProjectViewModel>()
        {
            new ProjectViewModel
            {
                Title = "Continental School",
                Description = "Web Page",
                Link = "https://continentaltiamarita.com",
                ImageUrl =
                    "https://continentaltiamarita.com/_next/image?url=%2Fimg%2Flogo.png&w=64&q=75"
            },
            new ProjectViewModel
            {
                Title = "Sonibel",
                Description = "E-commerce Web Page",
                Link = "https://sonibelec.com/",
                ImageUrl = "https://sonibelec.com/images/logo.png"
            }
        };
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }
}
