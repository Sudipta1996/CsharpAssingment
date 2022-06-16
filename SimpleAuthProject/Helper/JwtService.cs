using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace pharmacyManagementWebApiservice.Helper
{
    public class JwtService
    {
        private string secureKey = "this is very secure key ";//this key we have to encoded of our jwt//
        #region Generate
        public string Generate(int id)
        {
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secureKey));
            var credentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);//create credentials//
            var header = new JwtHeader(credentials);

            var payload = new JwtPayload(id.ToString(),null, null, null, DateTime.Today.AddDays(1));//payload is data that we set.Id is our Issuer,
                                                                                                    //audience,claims,notbefore,the token continue
                                                                                                    //one day after it will expire//
            var securityToken = new JwtSecurityToken(header, payload);//combine token//

            return new JwtSecurityTokenHandler().WriteToken(securityToken);//compact serialization format//
        }
        #endregion 

        #region decodeVerify
        public JwtSecurityToken Verify(string jwt)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            {
                var key = Encoding.ASCII.GetBytes(secureKey);
                //validate token//
                tokenHandler.ValidateToken(jwt, new TokenValidationParameters
                {
                    IssuerSigningKey = new SymmetricSecurityKey(key),//byte key//
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,

                }, out SecurityToken vaidatedToken);
                return (JwtSecurityToken)vaidatedToken;//casting//

            }
        }
        #endregion
    }
}
