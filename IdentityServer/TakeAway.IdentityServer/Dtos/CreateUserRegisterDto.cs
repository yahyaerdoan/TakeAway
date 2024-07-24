namespace TakeAway.IdentityServer.Dtos;

public class CreateUserRegisterDto
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; } 
}
