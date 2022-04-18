using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Business.Security;
using Business.Utilities.IoC;
using Business.Utilities.Results.Abstract;
using Business.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using DataAccess.Entites.Concrete;
using DataAccess.Dtos.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMapper _mapper;
        public AuthManager(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            _signInManager = signInManager;
            _roleManager = roleManager;
            _userManager = userManager;
            _mapper = mapper;
        }
        public async Task<IResult> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            var result = await _userManager.CheckPasswordAsync(user, loginDto.Password);
            if (result)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return new SuccessResult(Messages.SuccessLogin);
            }
            return new ErrorResult(Messages.FailLoginUser);
        }

        public async Task<IResult> Register(RegisterDto registerDto)
        {
            var mappedEntity = _mapper.Map<RegisterDto, AppUser>(registerDto);
            mappedEntity.UserName = registerDto.Name + registerDto.SurName;
            var result = await _userManager.CreateAsync(mappedEntity, registerDto.Password);
              
            var resultaa =   await _roleManager.CreateAsync(new IdentityRole("vacationer"));
            var roles = await _roleManager.Roles.ToListAsync();
            await _userManager.AddToRoleAsync(mappedEntity,"vacationer");
            if (result.Succeeded)
            {
                return new SuccessResult(Messages.SuccessRegister);
            }
            return new ErrorResult(Messages.ErrorEntityAdded);
        }

    }
}
