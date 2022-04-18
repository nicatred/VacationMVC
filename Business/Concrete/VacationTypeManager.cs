using Business.Abstract;
using Business.Constants;
using Business.Utilities.Results.Abstract;
using Business.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VacationTypeManager : IVacationTypeService
    {
        private readonly IVacationTypeDal _vacationTypeDal;

        public VacationTypeManager(IVacationTypeDal vacationTypeDal)
        {
            _vacationTypeDal = vacationTypeDal;
        }

        public async Task<IDataResult<List<VacationType>>> GetAll()
        {
            var list =  await _vacationTypeDal.GetAllAsync();
            return new SuccessDataResult<List<VacationType>>(list, Messages.EntityGetList);
        }
    }
}
