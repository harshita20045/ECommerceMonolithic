using EcommerceMonolith.Models;
using EcommerceMonolith.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly IUserService _service;

    public UserController(IUserService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_service.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        try
        {
            return Ok(_service.GetById(id));
        }
        catch (Exception ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpPost("register")]
    public IActionResult Register(User user)
    {
        try
        {
            return Ok(_service.Register(user));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}