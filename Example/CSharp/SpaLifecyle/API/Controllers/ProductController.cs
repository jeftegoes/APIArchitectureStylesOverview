using Microsoft.AspNetCore.Mvc;
using SpaLifecyle.Models;

namespace SpaLifecyle.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly List<Product> Products = new List<Product>()
    {
        new Product() { Id = 1, Name = "Apple", Price = 2.0m },
        new Product() { Id = 2, Name = "Banana", Price = 1.11m },
        new Product() { Id = 3, Name = "Lemon", Price = 0.90m },
        new Product() { Id = 4, Name = "Orange", Price = 1.41m }
    };

    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Get()
    {
        return Ok(Products);
    }
}
