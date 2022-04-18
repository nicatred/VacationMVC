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
using Microsoft.AspNetCore.Http;
using DataAccess.Entites.Concrete;
using DataAccess.Dtos.Concrete;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly IUserDal _userDal;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthManager(IUserDal userDal, IMapper mapper, ITokenService tokenService, IConfiguration configuration)
        {
            _userDal = userDal;
            _mapper = mapper;
            _tokenService = tokenService;
            _configuration = configuration;
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
        }
        public async Task<IDataResult<User>> Login(LoginDto loginDto)
        {
            var existUser = await _userDal.GetAsync(x => x.Email == loginDto.Email);
            if (existUser == null)
            {
                return new ErrorDataResult<User>(Messages.NotExsistUser);
            }
            if (!HashingHelper.VerifyPasswordHash(loginDto.Password, existUser.PasswordHash, existUser.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.FailLoginUser);
            }
            return new SuccessDataResult<User>(existUser,Messages.SuccessLogin);
            //var generatedToken = _tokenService.BuildToken(_configuration["Jwt:Key"].ToString(), _configuration["Jwt:Issuer"].ToString(), existUser);
            //if (generatedToken != null)
            //{
            //_httpContextAccessor.HttpContext.Request.Headers.Add("Authorization", "Bearer " + generatedToken);
            //_httpContextAccessor.HttpContext.Session.SetString();
            //   HttpContext.Session.SetString("Token", generatedToken);

            //Headers.Add("Authorization", "Bearer " + generatedToken);

            //}
            //return new ErrorResult(Messages.ErrorAccessTokenCreating);
        }

        public async Task<IResult> Register(RegisterDto registerDto)
        {
            var existEmail = await _userDal.GetAsync(x => x.Email == registerDto.Email);
            if (existEmail != null)
            {
                return new ErrorResult(Messages.AlreadyExsistEmail);
            }
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(registerDto.Password, out passwordHash, out passwordSalt);
            var mappedUser = _mapper.Map<RegisterDto, User>(registerDto);
            mappedUser.PasswordHash = passwordHash;
            mappedUser.PasswordSalt = passwordSalt;
            await _userDal.AddAsync(mappedUser);
            return new SuccessResult(Messages.SuccessRegister);
        }
    }
}
