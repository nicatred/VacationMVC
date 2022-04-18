using Business.Utilities.Results.Abstract;
using DataAccess.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IVacationTypeService
    {
        Task<IDataResult<List<VacationType>>> GetAll();
    }
}
