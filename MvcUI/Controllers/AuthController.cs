using Business.Abstract;
using DataAccess.Dtos.Concrete;
using DataAccess.Entites.Enums;
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

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            var result = await _authService.Register(registerDto);
            if (result.Success)
            {
                return RedirectToAction("Login");
            }
            ViewBag.Error = result.Message;
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var result = await _authService.Login(loginDto);
            if (result.Success)
            {
                return RedirectToAction("Index", "Home",new { Area = result.Data});
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            var result = await _authService.LogOut();
            if (result.Success)
            {
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }
    }
}
