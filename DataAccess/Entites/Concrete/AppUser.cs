using DataAccess.Entites.Abstract;
using DataAccess.Entites.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entites.Concrete
{
    public class AppUser: IdentityUser
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public List<VacationRequest> VacationRequests { get; set; }
    }
}
