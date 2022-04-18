using Business.Utilities.Results.Abstract;
using DataAccess.Dtos.Concrete;
using DataAccess.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        public Task<IDataResult<User>> Login(LoginDto loginDto);
        public Task<IResult> Register(RegisterDto registerDto);
    }
}
