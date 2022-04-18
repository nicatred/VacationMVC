using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using DataAccess.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfVacationTypeDal:EfReporitoryBase<VacationType,VacationContext>,IVacationTypeDal
    {
    }
}
