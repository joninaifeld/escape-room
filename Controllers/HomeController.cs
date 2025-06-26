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
        Coto coto = new Coto();
        HttpContext.Session.SetString("coto", Objeto.ObjectToString<Coto>(coto));
        ViewBag.titulo = coto.salas[coto.salasCompletadas].titulo;
        ViewBag.descripcion = coto.salas[coto.salasCompletadas].frase;
        return View();
    }

    public IActionResult IrASala(string ans)
    {
        Coto coto = Objeto.StringToObject<Coto>(HttpContext.Session.GetString("coto"));
        if(coto.salas[coto.salasCompletadas].comprobarRespuesta(ans)){
            coto.salasCompletadas++;
            ViewBag.mensaje = "";
        }
        else{
            ViewBag.mensaje = "Respuesta incorrecta";
        }
        ViewBag.titulo = coto.salas[coto.salasCompletadas].titulo;
        ViewBag.descripcion = coto.salas[coto.salasCompletadas].frase;

        HttpContext.Session.SetString("coto", Objeto.ObjectToString<Coto>(coto));
        return View(coto.salas[coto.salasCompletadas].nombre);
    }
    public IActionResult VolverATermica(int cantBotonesTocados){
        Coto coto = Objeto.StringToObject<Coto>(HttpContext.Session.GetString("coto"));
        ViewBag.titulo = coto.salas[coto.salasCompletadas].titulo;
        ViewBag.descripcion = coto.salas[coto.salasCompletadas].frase;
        ViewBag.cantBotonesTocados = cantBotonesTocados;
        return View("Termica");
    }

    public IActionResult RevisarLetras(string letra)
    {
        Coto coto = Objeto.StringToObject<Coto>(HttpContext.Session.GetString("coto"));
        coto.termicaArriesgo += letra[0];
        HttpContext.Session.SetString("coto", Objeto.ObjectToString<Coto>(coto));

        if (coto.termicaArriesgo.Length == 6)
        {
            string palabra = coto.termicaArriesgo;
            coto.termicaArriesgo = "";
            HttpContext.Session.SetString("coto", Objeto.ObjectToString<Coto>(coto));
            return RedirectToAction("IrASala", new { ans = palabra });
        }
        else
        {
            return RedirectToAction("VolverATermica", new { cantBotonesTocados = coto.termicaArriesgo.Length });
        }
    }
}
