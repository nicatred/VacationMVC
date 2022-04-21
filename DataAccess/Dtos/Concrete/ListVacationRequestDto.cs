using DataAccess.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dtos.Concrete
{
    public class ListVacationRequestDto
    {
        public int Id { get; set; }
        public string VacationerFullName { get; set; }
        public string VacationerPosition { get; set; }
        public string ReplacementPerson { get; set; }
        public DateTime StartVacation { get; set; }
        public DateTime EndVacation { get; set; }
        public string VacationType { get; set; }
        public VacationRequestStatus VacationRequestStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public string RequestNo { get; set; }
        public bool IsIncludedWeekend { get; set; }

    }
}
