using DataAccess.Entites.Abstract;
using DataAccess.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entites.Concrete
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public VacationRequest VacationRequest { get; set; }
    }
}
