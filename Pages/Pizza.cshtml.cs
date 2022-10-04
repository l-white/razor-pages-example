using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizzeria.Pages;

public class PizzaModel : PageModel
{
    private readonly ILogger<PizzaModel> _logger;

    public PizzaModel(ILogger<PizzaModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}