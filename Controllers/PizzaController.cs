using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers;

public class PizzaController : Controller
{
    public IActionResult Index()
    {
        List<Pizza> listaPizze = new List<Pizza>();

        return View("Index", listaPizze);
    }
    
    public IActionResult Show(int id)
    {
        List<Pizza> listaPizze = new List<Pizza>();

        return View("Show",listaPizze[id]);
    }
    
    public IActionResult Create()
    {
        
        return View("Create");
    }
}