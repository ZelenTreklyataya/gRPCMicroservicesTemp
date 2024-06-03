using gRPCMicroservices.API.Dto;
using gRPCMicroservices.API.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace gRPCMicroservices.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserHandler _userHandler;
    public UserController(IUserHandler userHandler)
    {
        _userHandler = userHandler;
    }
    [HttpGet]
    public async Task<ActionResult<List<GetUserDto>>> GetUsers()
    {
        return await _userHandler.GetAllUsers();
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<GetUserDto>> GetUser(Guid id)
    {
        return await _userHandler.GetOneUser(id.ToString());
    }
    
    [HttpPost]
    public async Task<ActionResult<AddUserDto>> AddUser(AddUserDto request)
    {
        return await _userHandler.AddUser(request);
    }
}