using gRPCMicroservices.API.Dto;
using gRPCMicroservices.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace gRPCMicroservices.API.Handlers;

public class UserHandler : IUserHandler
{
    private readonly IUserService _userService;
    public UserHandler(IUserService userService)
    {
        _userService = userService;
    }
    public async Task<ActionResult<List<GetUserDto>>> GetAllUsers()
    {
        try
        {
            var result = await _userService.GetAllUsers();
            return new OkObjectResult(result);
        }
        catch (Exception ex)
        {
            return new BadRequestObjectResult(ex.Message);
        }
    }

    public async Task<ActionResult<GetUserDto>> GetOneUser(string id)
    {
        try
        {
            var result = await _userService.GetUser(id);
            return new OkObjectResult(result);
        }
        catch (Exception ex)
        {
            return new BadRequestObjectResult(ex.Message);
        }
    }

    public async Task<ActionResult<AddUserDto>> AddUser(AddUserDto request)
    {
        try
        {
            var result = await _userService.AddUser(request);
            return new OkObjectResult(result);
        }
        catch (Exception ex)
        {
            return new BadRequestObjectResult(ex.Message);
        }
    }
}