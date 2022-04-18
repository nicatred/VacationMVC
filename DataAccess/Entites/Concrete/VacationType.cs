using DataAccess.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entites.Concrete
{
    public class VacationType:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<VacationRequest> VacationRequests { get; set; }
    }
}
