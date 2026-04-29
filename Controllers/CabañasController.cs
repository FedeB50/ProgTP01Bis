using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tp01Bis.Models;
namespace Tp01Bis.Controllers;
public class CabañasController : Controller
{
    public IActionResult Index()
    {
        Complejo complejo = new Complejo();
        complejo.cargarCabañas();
        ViewBag.Cabañas = complejo.ObtenerTodasLasCabañas();
        return View();
    }
    public IActionResult Cabaña(int id)
    {
        Cabaña cabaña = Complejo.Instancia.ObtenerCabaña(id);
        ViewBag.Cabaña = cabaña;
        return View();
    }
}
