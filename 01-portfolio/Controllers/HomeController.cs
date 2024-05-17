using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _01_portfolio.Models;
using _01_portfolio.Services;

namespace _01_portfolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IProjectsService _projectsService;

    public HomeController(ILogger<HomeController> logger, IProjectsService projectsService)
    {
        _logger = logger;
        _projectsService = projectsService;
    }

    public IActionResult Index()
    {
        var projects = _projectsService.GetProjects().Take(2).ToList();
        var model = new HomeIndexViewModel() { Projects = projects };
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Projects()
    {
        var projects = _projectsService.GetProjects().Take(2).ToList();
        return View(projects);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }
}
