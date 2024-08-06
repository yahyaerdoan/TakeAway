using System;

namespace TakeAway.IdentityServer.Quickstart.Tools.Models;

public class TokenResponseViewModel(string token, DateTime expireDate)
{
    public string Token { get; set; } = token;
    public DateTime ExpireDate { get; set; } = expireDate;
}
