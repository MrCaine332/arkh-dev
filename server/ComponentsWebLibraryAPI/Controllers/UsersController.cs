using Microsoft.AspNetCore.Mvc;
using ComponentsWebLibraryAPI.Models;
using ComponentsWebLibraryAPI.Dtos;
using ComponentsWebLibraryAPI.Services;

namespace ComponentsWebLibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UsersServices _usersServices;

        public UsersController(UsersServices usersServices)
        {
            _usersServices = usersServices;
        }

        
        [HttpGet]
        public async Task<ActionResult<List<User>>> Get(int id)
        {
            List<User> users = await _usersServices.GetAll();
            return Ok(users);
        }


        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDto userData)
        {
            User candidate = new User()
            {
                Email = userData.Email,
                Password = userData.Password,
                FirstName = userData.FirstName,
                LastName = userData.LastName,
            };

            User? user = await _usersServices.Register(candidate);
            
            if (user is null)
            {
                throw new Exception();
            }

            return Created("user", user);
        }



        [HttpPost("login")]
        public async Task<ActionResult<bool>> Login()
        {
            Console.Write(DateTime.Now);

            return Ok(true);
        }



        [HttpPost("logout")]
        public async Task<ActionResult<bool>> Logout()
        {
            
            
            return Ok(true);
        }



        [HttpPost("refresh")]
        public async Task<ActionResult<bool>> Refresh()
        {


            return Ok(true);
        }
    }
}
