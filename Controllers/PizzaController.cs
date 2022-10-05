using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers;

public class PizzaController : Controller
{
    public IActionResult Index()
    {
        List<Pizza> pizzes;
        
        using (PizzaContext db = new PizzaContext())
        {
            pizzes = db.Pizzas.ToList<Pizza>();
        }

        return View("Index", pizzes);
    }
    
    public IActionResult Show(int id)
    {
        Pizza pizzaSelected;
        
        using (PizzaContext db = new PizzaContext())
        {
            pizzaSelected = db.Pizzas.Where(pizza => pizza.PizzaId == id).First();
        }
        return View("Show",pizzaSelected);
    }
    
    public IActionResult Create()
    {
        
        return View("Create");
    }
}