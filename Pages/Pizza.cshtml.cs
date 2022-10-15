using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Model;

namespace RazorPizzeria.Pages;

public class PizzaModel : PageModel
{
    private readonly ILogger<PizzaModel> _logger;

    public PizzaModel(ILogger<PizzaModel> logger)
    {
        _logger = logger;
    }
    public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
    {
        new PizzasModel(){
            ImageTitle="Magarita",
            PizzaName="Magarita",
            BasePrice=2,
            TomatoSauce=true,
            Cheese=true,
            FinalPrice=4
        }
    };

    public void OnGet()
    {

    }
}