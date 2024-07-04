using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using UAE_TheLearningHub.Core.Data;
using UAE_TheLearningHub.Core.Repository;
using UAE_TheLearningHub.Core.Service;

namespace UAE_TheLearningHub.Infra.Service
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public string Login(Login login)
        {
          var result = _loginRepository.Login(login);   // roleid, userid / null

            if (result == null) {
                return null;
            }
            else
            {
                var IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Believe in yourself, Keep going up and never stop.. you are almost done, you are a star and the sky is the limit"));

                var signCredentials = new SigningCredentials(IssuerSigningKey, SecurityAlgorithms.HmacSha256);

                var Tokenclaims = new List<Claim>
                {
                    new Claim("Roleid" , result.Roleid.ToString()),
                    new Claim("Userid", result.Studentid.ToString())
                };

                var tokenOptions = new JwtSecurityToken(
                    claims: Tokenclaims,
                    signingCredentials: signCredentials,
                    expires: DateTime.Now.AddSeconds(15)
                    );

                var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return token;
            }
        }
    }
}
