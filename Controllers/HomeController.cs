using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP06.Models;

namespace TP06.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

      public IActionResult Index()
    {
        ViewBag.ListaEquipo = BD.ListarEquipos();
        return View();
    }
/*IActionResult VerDetalleEquipo(int IdEquipo): Debe retornar la View DetalleEquipo. 
Cargar Previamente un ViewBag con los datos del Equipo y un ViewBag con la lista de jugadores de dicho equipo.*/
    public IActionResult VerDetalleEquipo(int IdEquipo)
    {
        ViewBag.UnEquipo = BD.VerInfoEquipo(IdEquipo);
        ViewBag.Jugadores = BD.ListarJugadores(IdEquipo);
        return View();
    }
    
    public IActionResult Eliminar(int id){
        BD.EliminarPelicula(id);
        return RedirectToAction("Index");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CrearPelicula(string Nombre, int Duracion, string Director){
        BD.InsertarPelicula(Nombre, Duracion, Director);
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
