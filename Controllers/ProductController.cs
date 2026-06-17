using Microsoft.AspNetCore.Mvc;
using EcommerceMonolith.Models;
using EcommerceMonolith.Services;

namespace EcommerceMonolith.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    private readonly IProductService _service;

    public ProductController(IProductService service)
    {
        _service = service;
    }

    // GET: api/products
    [HttpGet]
    public IActionResult GetAll()
    {
        var products = _service.GetAll();
        return Ok(products);
    }

    // GET: api/products/1
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        try
        {
            var product = _service.GetById(id);
            return Ok(product);
        }
        catch (Exception ex)
        {
            return NotFound(ex.Message);
        }
    }

    // POST: api/products
    [HttpPost]
    public IActionResult Create([FromBody] Product product)
    {
        try
        {
            var created = _service.Create(product);
            return Ok(created);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}