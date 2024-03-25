using BharatWTAPI.Models.DTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BharatWTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;

        public AuthController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpGet]
        [Route("register")]
        public async Task<IActionResult> Register(RegisterRequestDTO model)
        {
            var identityUser = new IdentityUser
            {
                UserName = model.UserName,
                Email = model.UserName
            };
            var identityResult = await userManager.CreateAsync(identityUser);

            if (identityResult.Succeeded)
            {
                //Adding Roles Here
                if (model.Roles != null)
                {
                    identityResult = await userManager.AddToRolesAsync(identityUser, model.Roles);
                    if (identityResult.Succeeded)
                    {
                        return Ok("User Registered");
                    }

                }

            }

            return BadRequest("Error");
        }
    }
}
