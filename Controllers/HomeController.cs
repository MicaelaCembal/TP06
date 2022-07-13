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
/*IActionResult Index: Debe retornar la view Index. Cargar previamente en un ViewBag la lista de Equipos.*/
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
        return View(VerDetalleEquipo);
    }
    /*IActionResult VerDetalleJugador(int IdJugador): Debe retornar la View DetalleJugador. Cargar previamente en un ViewBag los datos del jugador.*/
    public IActionResult VerDetalleJugador(int IdJugador)
    {
        ViewBag.Jugador = BD.ListarJugadores(IdJugador);
        return View(VerDetalleJugador);
    }
    /*VEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER*/
    /*IActionResult AgregarJugador(IdEquipo): Debe devolver una View con el formulario de Jugadores para cargar. Cargar en un ViewBag el IdEquipo.*/
    public IActionResult AgregarJugador(int IdEquipo){
        /*muestre formulario input ocuylto hidden id equipo*/

        ViewBag.UnEquipo = BD.VerInfoEquipo(IdEquipo);
        return View(AgregarJugador);
    }
    /*[HttpPost] IActionResult GuardarJugador(Jugador): Debe guardar en la base de datos el Jugador Agregado e ir al detalle de Equipo (Volver a cargar los ViewBags del punto 2)*/
  [HttpPost]
   public IActionResult GuardarJugador(Jugador Jug)
   {
    BD.AgregarJugador(Jug.IdJugador, Jug.IdEquipo, Jug.Nombre, Jug.FechaNacimiento, Jug.Foto, Jug.EquipoActual);
   ViewBag.UnEquipo = BD.VerInfoEquipo(Jug.IdEquipo);
        ViewBag.Jugadores = BD.ListarJugadores(Jug.IdEquipo);
     return View(VerDetalleEquipo);
    }
/*IActionResult EliminarJugador(int IdJugador, int IdEquipo): Debe eliminar el jugador recibido como parámetro y volver al detalle de Equipo  (Volver a cargar los ViewBags del punto 2)*/
   public IActionResult EliminarJugador(int IdJugador, int IdEquipo)
   {
        BD.EliminarJugador(IdJugador);
        ViewBag.UnEquipo = BD.VerInfoEquipo(IdEquipo);
        ViewBag.Jugadores = BD.ListarJugadores(IdEquipo);
        return View(VerDetalleEquipo);
    }
}
