using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using TakeAway.IdentityServer.Dtos;
using TakeAway.IdentityServer.Models;
using TakeAway.IdentityServer.Quickstart.Tools.GenerateTokens;
using TakeAway.IdentityServer.Quickstart.Tools.Models;

namespace TakeAway.IdentityServer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LogInsController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager) : ControllerBase
{
    private readonly SignInManager<ApplicationUser> _signInManager = signInManager;
    private readonly UserManager<ApplicationUser> _userManager = userManager;

    [HttpPost]
    public async Task<IActionResult> UserLogin(LogInUserDto logInUserDto)
    {
        var result = await _signInManager.PasswordSignInAsync(logInUserDto.UserName, logInUserDto.Password, false, false);
        var userInfo = await _userManager.FindByNameAsync(logInUserDto.UserName);
        if (result.Succeeded)
        {
            GetCheckAppUserViewModel getCheckAppUserViewModel = new()
            {
                Id = userInfo.Id,
                UserName = logInUserDto.UserName,
            };
            var token = JwtTokenGenerater.GenerateToken(getCheckAppUserViewModel);
            return StatusCode((int)HttpStatusCode.Created, new { message = "Log In Succesfully!", token });
        }

        else
            return StatusCode((int)HttpStatusCode.BadRequest, new { message = "Log In Not Succesfully!, Has some errors!" });
    }
}
