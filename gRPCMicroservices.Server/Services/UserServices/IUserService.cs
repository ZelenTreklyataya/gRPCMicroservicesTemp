using Grpc.Core;

namespace gRPCMicroservices.Server.Services.UserServices;

public interface IUserService
{
    Task<Models.User> GetUserById(string id);
    Task<List<Models.User>> AllUsers();
    Task<Models.User> AddUser(Models.User user);
}