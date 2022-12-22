using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using P228FirstAPI.DTOs.AccountDTOs;
using P228FirstAPI.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace P228FirstAPI.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        private readonly UserManager<AppUser> _userManager;

        public AccountController(IConfiguration configuration,
            UserManager<AppUser> userManager)
        {
            Configuration = configuration;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            //AppUser appUser = await _userManager.FindByEmailAsync(loginDto.Email);

            //if (appUser == null)
            //{
            //    return BadRequest("Email Or Password Is Incorrect");
            //}

            //if (!await _userManager.CheckPasswordAsync(appUser, loginDto.Password))
            //{
            //    return BadRequest("Email Or Password Is Incorrect");
            //}

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,"Hamid"),
                new Claim(ClaimTypes.Email,"hamidvm@code.edu.az"),
                new Claim(ClaimTypes.NameIdentifier,"15"),
                new Claim(ClaimTypes.Role, "Admin"),
                new Claim(ClaimTypes.Role, "Manager"),
            };

            SymmetricSecurityKey symmetricSecurityKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(Configuration.GetSection("JWT:SecretKey").ToString()));
            SigningCredentials signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha512Signature);

            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(
                claims: claims,
                signingCredentials: signingCredentials,
                expires:DateTime.UtcNow.AddHours(4)
                );

            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();

            LoginResponseDto loginResponseDto = new LoginResponseDto
            {
                Token = jwtSecurityTokenHandler.WriteToken(jwtSecurityToken)
            };
            return Ok(loginResponseDto);
        }
    }
}
