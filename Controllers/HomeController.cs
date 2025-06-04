using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using escape_room.Models;
using Newtonsoft.Json;

namespace escape_room.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        return View();
    }

}
