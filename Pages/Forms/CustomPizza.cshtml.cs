using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizzeria.Pages;

public class CustomPizzaModel : PageModel
{
    private readonly ILogger<CustomPizzaModel> _logger;

    public CustomPizzaModel(ILogger<CustomPizzaModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}