using DataAccess.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, User user);
        bool ValidateToken(string key, string issuer,  string token);
    }

}
