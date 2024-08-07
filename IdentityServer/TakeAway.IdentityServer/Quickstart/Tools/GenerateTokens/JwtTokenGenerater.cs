using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TakeAway.IdentityServer.Quickstart.Tools.Models;

namespace TakeAway.IdentityServer.Quickstart.Tools.GenerateTokens;

public static class JwtTokenGenerater
{
    public static TokenResponseViewModel GenerateToken(GetCheckAppUserViewModel getCheckAppUserViewModel)
    {
        var claims = GetClaims(getCheckAppUserViewModel);

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaultViewModel.Key));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var expirationDate = DateTime.UtcNow.AddDays(JwtTokenDefaultViewModel.ExpirationDate);

        JwtSecurityToken jwtSecurityToken = new(
            issuer: JwtTokenDefaultViewModel.ValidIssuer,
            audience: JwtTokenDefaultViewModel.ValidAudience,
            claims: claims,
            notBefore: DateTime.UtcNow,
            expires: expirationDate,
            signingCredentials: credentials);

        JwtSecurityTokenHandler jwtSecurityTokenHandler = new();
        return new TokenResponseViewModel(jwtSecurityTokenHandler.WriteToken(jwtSecurityToken), expirationDate);
    }

    private static List<Claim> GetClaims(GetCheckAppUserViewModel getCheckAppUserViewModel)
    {
        return
        [
            new Claim(ClaimTypes.Role, getCheckAppUserViewModel.Role),
            new Claim(ClaimTypes.NameIdentifier, getCheckAppUserViewModel.Id),
            new Claim("UserName", getCheckAppUserViewModel.UserName)
        ];
    }
}
