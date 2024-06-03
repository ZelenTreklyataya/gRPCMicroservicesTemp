using gRPCMicroservices.API.Dto;
using Microsoft.AspNetCore.Mvc;

namespace gRPCMicroservices.API.Handlers;

public interface IUserHandler
{
    Task<ActionResult<List<GetUserDto>>> GetAllUsers();
    Task<ActionResult<GetUserDto>> GetOneUser(string id);
    Task<ActionResult<AddUserDto>> AddUser(AddUserDto request);
}