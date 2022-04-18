using DataAccess.Dtos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dtos.Concrete
{
    public class VacationRequestDto:IDto
    {
        public string VacationerFullName { get; set; }
        public string VacationerPosition { get; set; }
        public string ReplacementPerson { get; set; }
        public DateTime StartVacation { get; set; }
        public DateTime EndVacation { get; set; }
        public int VacationTypeId { get; set; }
        public bool IsIncludedWeekend { get; set; }
    }
}
