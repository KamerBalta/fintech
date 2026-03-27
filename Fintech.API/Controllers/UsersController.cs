using Fintech.Business.Abstract;
using Fintech.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Fintech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        // Constructor: Sistem IUserService istediğinde UserManager'ı otomatik getirir
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // Kullanıcı Kaydı: POST api/Users/register
        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            try 
            {
                _userService.Add(user);
                return Ok(new { 
                    message = "Kullanıcı kaydı başarılı!", 
                    customerNumber = user.CustomerNumber 
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}