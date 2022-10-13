using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Model;

namespace RazorPizzeria.Pages.Forms;

public class CustomPizzaModel : PageModel
{
    private readonly ILogger<CustomPizzaModel> _logger;

    public CustomPizzaModel(ILogger<CustomPizzaModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public PizzasModel Pizza { get; set; }
    public float PizzaPrice { get; set; }
    public void OnGet()
    {

    }

    // form submits here and post action is called
    public IActionResult OnPost()
    {
        PizzaPrice = Pizza.BasePrice;

        if (Pizza.TomatoSauce) PizzaPrice += 1;
        if (Pizza.Cheese) PizzaPrice += 1;
        if (Pizza.Peperoni) PizzaPrice += 1;
        if (Pizza.Mushroom) PizzaPrice += 1;
        if (Pizza.Tuna) PizzaPrice += 1;
        if (Pizza.Pineapple) PizzaPrice += 2;
        if (Pizza.Ham) PizzaPrice += 1;
        if (Pizza.Beef) PizzaPrice += 1;

        return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });

    }

}