using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PortafolioII.Models;

namespace PortafolioII.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("/")]
    public IActionResult Index()
    {
        return View("Index");
    }

    [HttpGet]
    [Route("/projects")]
    public IActionResult Projects()
    {
        return View("Projects");
    }

    [HttpGet]
    [Route("/contact")]
    public IActionResult Contact()
    {
        return View("Contact");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
