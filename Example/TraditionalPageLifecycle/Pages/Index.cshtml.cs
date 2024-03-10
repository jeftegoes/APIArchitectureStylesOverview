using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TraditionalPageLifecycle.Models;

namespace TraditionalPageLifecycle.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public readonly List<Product> Products = new List<Product>()
    {
        new Product() { Id = 1, Name = "Apple", Price = 2.0m },
        new Product() { Id = 2, Name = "Banana", Price = 1.11m },
        new Product() { Id = 3, Name = "Lemon", Price = 0.90m },
        new Product() { Id = 4, Name = "Orange", Price = 1.41m }
    };

    public string Test { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
