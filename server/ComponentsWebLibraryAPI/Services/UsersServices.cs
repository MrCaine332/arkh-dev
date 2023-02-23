using ComponentsWebLibraryAPI.DataAccess;
using ComponentsWebLibraryAPI.Dtos;
using ComponentsWebLibraryAPI.Exceptions;
using ComponentsWebLibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ComponentsWebLibraryAPI.Services
{
    public class UsersServices
    {

        private readonly MySQLDbContext _context;

        public UsersServices(MySQLDbContext context)
        {
            _context = context;
        }

        public async Task<User?> Register(User user)
        {
            bool isEmailInUse = await _context.Users.AnyAsync(x => x.Email == user.Email);
            if (isEmailInUse)
            {
                throw ApiError.BadRequest("This e-mail already is used");
            }
            
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            
            User? addedUser = await _context.Users.FirstOrDefaultAsync(x => x.Email == user.Email);
            return addedUser;
        }

        public async Task<List<User>> GetAll()
        {
            List<User> users = await _context.Users.Select(user => user).ToListAsync();
            return users;
        }

    }
}
