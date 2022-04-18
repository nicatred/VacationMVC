using Business.Abstract;
using DataAccess.Dtos.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        private readonly ITokenService _tokenService;
        private readonly IConfiguration _configuration;

        public AuthController(IAuthService authService, ITokenService tokenService, IConfiguration configuration)
        {
            _authService = authService;
            _tokenService = tokenService;
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return  View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            var result = await _authService.Register(registerDto);
            if (!result.Success)
            {
                return UnprocessableEntity(result.Message);
            }
            return RedirectToAction("Login", "Auth", result.Message);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var result = await _authService.Login(loginDto);
            if (!result.Success)
            {
                return Unauthorized(result.Message);
            }
            var generatedToken = _tokenService.BuildToken(_configuration["Jwt:Key"].ToString(), _configuration["Jwt:Issuer"].ToString(),result.Data);
            if (generatedToken != null)
            {
                //_httpContextAccessor.HttpContext.Request.Headers.Add("Authorization", "Bearer " + generatedToken);
                HttpContext.Session.SetString("Token", generatedToken);


                //Headers.Add("Authorization", "Bearer " + generatedToken);

                return RedirectToAction("Index", "Home", result.Message);
            }
            return UnprocessableEntity();
        }
    }
}
