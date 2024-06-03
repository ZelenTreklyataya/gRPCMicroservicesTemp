using Grpc.Core;
using gRPCMicroservices.Server.Db;
using Microsoft.EntityFrameworkCore;

namespace gRPCMicroservices.Server.Services.UserServices;

public class UserService : User.UserBase, IUserService
{
    private readonly ApplicationDbContext _db;
    public UserService(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<Models.User> GetUserById(string id)
    {
        return await _db.Users.FirstOrDefaultAsync(u => u.Id.ToString() == id);
    }

    public async Task<List<Models.User>> AllUsers()
    {
        return await _db.Users.OrderByDescending(u => u.CreateDate).ToListAsync();
    }

    public async Task<Models.User> AddUser(Models.User user)
    {
        if (user is not null)
        {
            await _db.Users.AddAsync(user);
            await _db.SaveChangesAsync();
        }
        return user;
    }
}