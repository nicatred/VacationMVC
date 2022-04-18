using DataAccess.Dtos.Concrete;
using DataAccess.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.ViewModels
{
    public class VacationRequestViewModel
    {
        public VacationRequestDto VacationRequestDto { get; set; }
        public List<VacationType> VacationTypes { get; set; }
        public VacationType VacationType { get; set; }
    }
}
