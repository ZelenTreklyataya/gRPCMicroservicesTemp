using gRPCMicroservices.API.Dto;

namespace gRPCMicroservices.API.Services;

public interface IUserService
{
    Task<List<GetUserDto>> GetAllUsers();
    Task<GetUserDto> GetUser(string id);
    Task<AddUserDto> AddUser(AddUserDto request);
}