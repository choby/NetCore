// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace Inman.IdentityServer.Data
{
    public class TestUsers
    {
        public static List<TestUser> Users = new List<TestUser>
        {
            new TestUser{SubjectId = "818727", Username = "alice", Password = "alice", 
                Claims = 
                {
                    new Claim("openid", "xxxxx-xxxxx-xxxxxx-xxxxx"),
                    new Claim(JwtClaimTypes.Name, "Alice Smith"),
                    //new Claim(JwtClaimTypes.GivenName, "Alice"),
                    //new Claim(JwtClaimTypes.FamilyName, "Smith"),
                    //new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
                    //new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    //new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                   // new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServerConstants.ClaimValueTypes.Json),
                    new Claim(JwtClaimTypes.NickName, "昵称"),
                    new Claim(JwtClaimTypes.Role, "角色1"),//这个信息能否显示，需要配置IdentityClaims表包含在用于授权的IdentityResources中，比如用户授权了profile,而IdentityResources表中的profile记录包含的IdentityClaims记录只有username，那么客户端只能获取到username
                }
            },
            new TestUser{SubjectId = "88421113", Username = "bob", Password = "bob", 
                Claims = 
                {
                    new Claim(JwtClaimTypes.Name, "Bob Smith"),
                    new Claim(JwtClaimTypes.GivenName, "Bob"),
                    new Claim(JwtClaimTypes.FamilyName, "Smith"),
                    new Claim(JwtClaimTypes.Email, "BobSmith@email.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "http://bob.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServerConstants.ClaimValueTypes.Json),
                    new Claim("location", "somewhere"),
                }
            },
        };
    }
}