using AutoMapper;
using gRPCMicroservices.API.Dto;

namespace gRPCMicroservices.API.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<GetUserResponse, GetUserDto>();
        CreateMap<AddUserDto, CreateUserRequest>();
        CreateMap<CreateUserResponse, AddUserDto>();
        CreateMap<GetAllUsersResponse, List<GetUserDto>>();
    }
}