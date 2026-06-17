using EcommerceMonolith.Models;
using EcommerceMonolith.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/orders")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _service;

    public OrderController(IOrderService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Create([FromBody] Order order)
    {
        try
        {
            _service.CreateOrder(order);
            return Ok("Order Created");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{userId}")]
    public IActionResult GetOrders(int userId)
    {
        return Ok(_service.GetUserOrders(userId));
    }
}