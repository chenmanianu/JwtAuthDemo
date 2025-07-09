using JwtAuthDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtAuthDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly string _key = "u3pL9@#bZ7rD!gYqM4xT2vNc8sWe$KmFqA1Hu%VzB6NtRjXp";

        [HttpPost("login")]
        public IActionResult Login(LoginModel login)
        {
            if (login.Username == "admin" && login.Password == "password")
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var keyBytes = Encoding.UTF8.GetBytes(_key); // same 32+ character key

                var tokenDescriptor = new SecurityTokenDescriptor
{
    
    SigningCredentials = new SigningCredentials(
        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_key)),  // <-- use 32+ char key here
        SecurityAlgorithms.HmacSha256Signature)
};

                var token = tokenHandler.CreateToken(tokenDescriptor);

                return Ok(new { token = tokenHandler.WriteToken(token) });
            }

            return Unauthorized();
        }
    }
}
