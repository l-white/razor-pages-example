using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizzeria.Pages;

[BindProperties(SupportsGet = true)]
public class CheckoutModel : PageModel
{
    private readonly ILogger<CheckoutModel> _logger;

    public CheckoutModel(ILogger<CheckoutModel> logger)
    {
        _logger = logger;
    }

 
    public string PizzaName { get; set; }
    public float PizzaPrice { get; set; }
    public string ImageTitle { get; set; }

    // this is where we get data
    public void OnGet()
    {
        if (string.IsNullOrWhiteSpace(PizzaName))
        {
            PizzaName = "Custom";
        }
        if (string.IsNullOrWhiteSpace(ImageTitle))
        {
            ImageTitle = "Create";
        }
    }
}