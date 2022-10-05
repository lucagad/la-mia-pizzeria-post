namespace la_mia_pizzeria_static.Models;

public class Pizza
{
    public string Name { get; set; }
    public string Description  { get; set; }
    public string ImgUrl { get; set; }
    public double Price { get; set; }

    public Pizza(string name, string description, string imgurl , double price)
    {
        Name = name;
        Description = description;
        ImgUrl = imgurl;
        Price = price;
    }

}