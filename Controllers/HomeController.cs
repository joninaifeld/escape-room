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

// cuando empieza el juego, guardar en session el COTO inicializado, y cada vez q se emtre a una sala pedirlo del session para tener la info de la sala
// cada vez q se gana la sala se pide y se actualiza la variable de salas completadas
    public IActionResult Index()
    {
        
        return View();
    }

    public IActionResult IrASala()
    {
        
        return View();
    }
}