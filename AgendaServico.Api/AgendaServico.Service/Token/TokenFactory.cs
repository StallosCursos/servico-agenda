using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AgendaServico.Service.Token
{
    public static class TokenFactory
    {
        private static string JWTSecret => "1321546587897213132165465489";

        public static byte[] Key => Encoding.ASCII.GetBytes(JWTSecret);
        public static int ExpiredTimeToken => 10;

        public static string GenerateJWT(string UserName)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Name, UserName)
                }),
                Expires = ExpireIn(),
                SigningCredentials = new SigningCredentials(
                   new SymmetricSecurityKey(Key), SecurityAlgorithms.HmacSha256Signature
                )
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        public static DateTime ExpireIn()
        {
            return DateTime.UtcNow.AddMinutes(ExpiredTimeToken);
        }
    }
}
