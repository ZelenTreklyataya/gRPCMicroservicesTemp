namespace gRPCMicroservices.API.Dto
{
    public class GetUserDto
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string? SubName { get; set; }
    }
}