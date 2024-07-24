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
public class RegistersController(UserManager<ApplicationUser> userManager) : ControllerBase
{
    private readonly UserManager<ApplicationUser> userManager = userManager;

    [HttpPost]
    public async Task<IActionResult> Register(CreateUserRegisterDto createUserRegisterDto)
    {
        var values = new ApplicationUser()
        {
            FirstName = createUserRegisterDto.FirstName,
            LastName = createUserRegisterDto.LastName,
            UserName = createUserRegisterDto.UserName,
            Email = createUserRegisterDto.Email
        };
        var result = await userManager.CreateAsync(values, createUserRegisterDto.Password);

        if (result.Succeeded) { return StatusCode((int)HttpStatusCode.Created, new { message = "Created." }); }
        return StatusCode((int)HttpStatusCode.BadRequest, new { message = "Not Created." });
    }
}
