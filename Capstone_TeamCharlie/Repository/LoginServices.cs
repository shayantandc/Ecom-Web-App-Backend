using Login.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Login.Repository
{
    public class LoginServices : ILogin
    {
        private readonly EcomContext _data;
        private IConfiguration _configuration;


        public LoginServices(EcomContext data, IConfiguration config)
        {
            _configuration = config;
            _data = data;
        }
        private string GenerateToken(EcomLogin user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,user.UserEmail),
                new Claim(ClaimTypes.Role,user.LoginRole)
            };
            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);



            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public EcomLogin register(EcomLogin cust)
        {
            var generatedToken = GenerateToken(cust);
            cust.Token = generatedToken;
            DateTime aDate = DateTime.Now;
            cust.DateTimeStamp = Convert.ToDateTime(aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"));

            _data.EcomLogin.Add(cust);
            _data.SaveChanges();
            return _data.EcomLogin.SingleOrDefault(x => x.Token == generatedToken);
        }

        public EcomLogin getUsersbyId(string mail)
        {
            var usr = _data.EcomLogin.FirstOrDefault(o => o.UserEmail == mail);
            return usr;
        }

        public IEnumerable<EcomLogin> getUsers()
        {
            return _data.EcomLogin.ToList();
        }

        
    }

}
