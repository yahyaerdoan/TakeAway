using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;
using TakeAway.IdentityServer.Dtos;
using TakeAway.IdentityServer.Models;

namespace TakeAway.IdentityServer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LogInsController(SignInManager<ApplicationUser> signInManager) : ControllerBase
{
    private readonly SignInManager<ApplicationUser> _signInManager = signInManager;

    public async Task<IActionResult> UserLogin(LogInUserDto logInUserDto)
    {
        var result = await _signInManager.PasswordSignInAsync(logInUserDto.UserName, logInUserDto.Password, false, false);
        if (result.Succeeded)            
            return StatusCode((int)HttpStatusCode.Created, new { message = "Log In Succesfully!" });
        else
            return StatusCode((int)HttpStatusCode.BadRequest, new { message = "Log In Not Succesfully!, Has some errors!" });
    }
}
