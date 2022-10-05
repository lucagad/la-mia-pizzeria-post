using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models;

[Table("pizza")]
public class Pizza
{
    [Key]
    public int PizzaId { get; set; }
    [Required]
    public string Name { get; set; }
    public string Description  { get; set; }
    public string ImgUrl { get; set; }
    [Required]
    public double Price { get; set; }

    public Pizza()
    {
        
    }
    public Pizza(string name, string description, string img , double price)
    {
        Name = name;
        Description = description;
        ImgUrl = img;
        Price = price;
    }

}