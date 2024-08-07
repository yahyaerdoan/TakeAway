using System;

namespace TakeAway.IdentityServer.Quickstart.Tools.Models;

public class TokenResponseViewModel(string token, DateTime expirationDate)
{
    public string Token { get; set; } = token;
    public DateTime ExpirationDate { get; set; } = expirationDate;
}
 