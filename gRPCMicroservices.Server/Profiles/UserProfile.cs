using AutoMapper;

namespace gRPCMicroservices.Server.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<Models.User, GetUserResponse>();
        CreateMap<CreateUserRequest, Models.User>();
        CreateMap<Models.User, CreateUserResponse>();
    }
}