using DataAccess.Entites.Abstract;
using DataAccess.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entites.Concrete
{
    public class VacationRequest : IEntity
    {
        public int Id { get; set; }
        public string VacationerFullName { get; set; }
        public string VacationerPosition { get; set; }
        public string ReplacementPerson { get; set; }
        public DateTime StartVacation { get; set; }
        public DateTime EndVacation { get; set; }
        public bool IsIncludedWeekend { get; set; }
        public int VacationTypeId { get; set; }
        public VacationType VacationType { get; set; }
        public VacationRequestStatus VacationRequestStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public string RequestNo { get; set; }
    }
}
