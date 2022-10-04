using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizzeria.Pages;

public class ThankYouModel : PageModel
{
    private readonly ILogger<ThankYouModel> _logger;

    public ThankYouModel(ILogger<ThankYouModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}