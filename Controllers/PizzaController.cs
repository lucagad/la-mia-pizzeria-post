using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers;

public class PizzaController : Controller
{
    public IActionResult Index()
    {
        List<Pizza> listaPizze = new List<Pizza>();

        listaPizze.Add(new Pizza("Pizza Margherita", "Pizza con Pomodoro e Mozzarella", "/img/pizza_margherita.jpg", 6));
        listaPizze.Add( new Pizza("Pizza Wurstel", "Pizza con Pomodoro, Mozzarella e Wurstel", "/img/pizza_wurstel.jpg", 8));
        listaPizze.Add(new Pizza("Pizza 4 Stagioni", "Pizza con Pomodoro, Mozzarella, Carciofini, Funghi, Olive e Prosciutto Cotto", "/img/pizza_quattro_stagioni.jpg", 9));
        
        
        return View("Index", listaPizze);
    }
    
    public IActionResult Show(int id)
    {
        List<Pizza> listaPizze = new List<Pizza>();

        listaPizze.Add(new Pizza("Pizza Margherita", "Pizza con Pomodoro e Mozzarella", "/img/pizza_margherita.jpg", 6));
        listaPizze.Add( new Pizza("Pizza Wurstel", "Pizza con Pomodoro, Mozzarella e Wurstel", "/img/pizza_wurstel.jpg", 8));
        listaPizze.Add(new Pizza("Pizza 4 Stagioni", "Pizza con Pomodoro, Mozzarella, Carciofini, Funghi, Olive e Prosciutto Cotto", "/img/pizza_quattro_stagioni.jpg", 9));

        return View("Show",listaPizze[id]);
    }
    
    public IActionResult Create()
    {
        List<Pizza> listaPizze = new List<Pizza>();
        
        return View("Create");
    }
}