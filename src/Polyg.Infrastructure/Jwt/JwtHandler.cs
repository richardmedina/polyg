using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Polyg.Common.Infrastructure.Jwt;
using Polyg.Contract.Domain;
using Polyg.Contract.Services.AuthUser;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Polyg.Infrastructure.Jwt
{
    public class JwtHandler : IJwtHandler
    {
        private readonly IConfiguration _configuration;

        public JwtHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public AuthToken CreateToken(string userName)
        {
            var configSection = _configuration.GetSection("jwt");
            var issuer = configSection.GetValue<string>("issuer");
            var secretKey = configSection.GetValue<string>("secretKey");
            var expires = DateTime.Now.AddMinutes(1);

            var issuerSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));


            var jwtSecurityToken = new JwtSecurityToken(
                issuer: issuer,
                audience: null,
                claims: new[]{
                    new Claim(ClaimTypes.Name, userName)
                },
                expires: expires,
                signingCredentials: new SigningCredentials(issuerSecurityKey, SecurityAlgorithms.HmacSha256)
            );

            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwtSecurityToken);

            return new AuthToken
            {
                Token = token,
                Expiration = 0
            };
        }
    }
}
