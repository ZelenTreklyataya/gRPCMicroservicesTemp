using AutoMapper;
using Grpc.Net.Client;
using gRPCMicroservices.API.Dto;

namespace gRPCMicroservices.API.Services;

public class UserService : IUserService
{
    private readonly IMapper _mapper;

    public UserService(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<List<GetUserDto>> GetAllUsers()
    {
        using var channel = GrpcChannel.ForAddress("https://localhost:7008");
        var client = new User.UserClient(channel);
        var result = client.GetAllUsers(new GetAllUsersRequest());
        var mapRes = _mapper.Map<List<GetUserDto>>(result.User);
        return mapRes;
    }

    public async Task<GetUserDto> GetUser(string id)
    {
        using var channel = GrpcChannel.ForAddress("https://localhost:7008");
        var client = new User.UserClient(channel);
        var result = client.GetUserById(new GetUserRequest { Id = id });
        var mapRes = _mapper.Map<GetUserDto>(result);
        return mapRes;
    }

    public async Task<AddUserDto> AddUser(AddUserDto request)
    {
        using var channel = GrpcChannel.ForAddress("https://localhost:7008");
        var client = new User.UserClient(channel);
        var user = _mapper.Map<CreateUserRequest>(request);
        var result = client.CreateUser(user);
        var mapRes = _mapper.Map<AddUserDto>(result);
        return mapRes;
    }
}