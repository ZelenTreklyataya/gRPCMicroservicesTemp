using AutoMapper;
using Grpc.Core;
using gRPCMicroservices.Server.Services.UserServices;

namespace gRPCMicroservices.Server.Services.gRPCServices;

public class UserGrpcService : User.UserBase
{
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public UserGrpcService(IMapper mapper, IUserService userService)
    {
        _mapper = mapper;
        _userService = userService;
    }

    public override async Task<GetUserResponse> GetUserById(GetUserRequest request, ServerCallContext context)
    {
        var user = await _userService.GetUserById(request.Id);
        if (user is not null)
        {
            var mapUser = _mapper.Map<GetUserResponse>(user);
            return await Task.FromResult(mapUser);
        }

        throw new RpcException(new Status(StatusCode.NotFound, "Not found"));
    }

    public override async Task<GetAllUsersResponse> GetAllUsers(GetAllUsersRequest request, ServerCallContext context)
    {
        var response = new GetAllUsersResponse();
        var users = await _userService.AllUsers();
        foreach (var user in users)
        {
            var mapUser = _mapper.Map<GetUserResponse>(user);
            response.User.Add(mapUser);
        }

        return await Task.FromResult(response);
    }

    public override async Task<CreateUserResponse> CreateUser(CreateUserRequest request, ServerCallContext context)
    {
        var mapRequest = _mapper.Map<Models.User>(request);
        var res = await _userService.AddUser(mapRequest);
        if (res is not null)
        {
            var mapRes = _mapper.Map<CreateUserResponse>(res);
            return await Task.FromResult(mapRes);
        }

        throw new RpcException(new Status(StatusCode.Cancelled, "Create user failed"));
    }
}