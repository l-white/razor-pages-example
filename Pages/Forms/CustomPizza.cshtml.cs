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

}