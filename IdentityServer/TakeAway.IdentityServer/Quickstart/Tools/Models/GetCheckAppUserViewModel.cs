namespace TakeAway.IdentityServer.Quickstart.Tools.Models;

public class GetCheckAppUserViewModel
{
    public string Id { get; set; }
    public string UserName { get; set; } = "UserName";
    public string Role { get; set; } = "1";
    public bool IsExist { get; set; } = true;
}
