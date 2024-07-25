// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace TakeAway.IdentityServer;

public static class Config
{
    public static IEnumerable<ApiResource> ApiResources =>
    [
       new("ResourceCatalog1"){Scopes = {"CatalogFullPermission"}},
       new ("ResourceCatalog2"){Scopes = {"CatalogReadPermission"}},

       new ("ResourceOrder"){Scopes = {"OrderFullPermission"}},
       new ("ResourceDiscount"){Scopes = {"DiscountFullPermission"}},
       new ("ResourceCargo"){Scopes = {"CargoFullPermission"}},
       new ("ResourceComment"){Scopes = {"CommentFullPermission"}},
       new ("ResourceBasket"){Scopes = {"BasketFullPermission"}},
       new ("ResourceMessage"){Scopes = {"MessageFullPermission"}},
       new ("ResourceOselot"){Scopes = {"OselotFullPermission"}},
       new (IdentityServerConstants.LocalApi.ScopeName)
    ];

    public static IEnumerable<IdentityResource> IdentityResources =>
    [
        new IdentityResources.OpenId(),
        new IdentityResources.Profile(),
        new IdentityResources.Email(),
    ];
    public static IEnumerable<ApiScope> ApiScopes =>
    [
        new ("CatalogFullPermission", "Full Authority For  Catolog Operations"),
        new ("CatalogReadPermission", "Read Authority For  Catolog Operations"),
        new ("OrderFullPermission", "Full Authority For  Order Operations"),
        new ("DiscountFullPermission", "Full Authority For  Discount Operations"),
        new ("CargoFullPermission", "Full Authority For  Cargo Operations"),
        new ("CommentFullPermission", "Full Authority For  Comment Operations"),
        new ("BasketFullPermission", "Full Authority For  Basket Operations"),
        new ("MessageFullPermission", "Full Authority For  Message Operations"),
        new ("OselotFullPermission", "Full Authority For  Oselot Operations"),
        new (IdentityServerConstants.LocalApi.ScopeName)

    ];
    public static IEnumerable<Client> Clients =>
    [
        new() {
            ClientId= "TakeAwayVisitorId",
            ClientName= "Take Away Visitor User",
            AllowedGrantTypes = GrantTypes.ClientCredentials,
            ClientSecrets = {new Secret("takeawaysecret".Sha256())},
            AllowedScopes = { "CatalogReadPermission", "CatalogFullPermission", IdentityServerConstants.LocalApi.ScopeName },
            AllowAccessTokensViaBrowser = true,
        },
        new(){
           ClientId = "TakeAwayAdminId",
           ClientName= "Take Away Visitor Admin User",
           AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
           ClientSecrets = {new Secret("takeawaysecret".Sha256())},
           AllowedScopes = { "CatalogReadPermission", "CatalogFullPermission", "OrderFullPermission", "DiscountFullPermission",
                "CargoFullPermission", "CommentFullPermission,", "BasketFullPermission", "MessageFullPermission", "OselotFullPermission",
                IdentityServerConstants.LocalApi.ScopeName,
                IdentityServerConstants.StandardScopes.OpenId,
                IdentityServerConstants.StandardScopes.Profile,
                IdentityServerConstants.StandardScopes.Email,
            },
            AccessTokenLifetime = 6000
        }
    ];
}