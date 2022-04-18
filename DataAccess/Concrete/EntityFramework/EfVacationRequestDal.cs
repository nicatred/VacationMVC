using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using DataAccess.Dtos.Concrete;
using DataAccess.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfVacationRequestDal : EfReporitoryBase<VacationRequest, VacationContext>, IVacationRequestDal
    {
        public async Task<VacationRequest> GetLast(int userId)
        {
            using(var context = new VacationContext())
            {
                return  await context.VacationRequests.Where(x => x.UserId == userId).OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            }
        }

        public async Task<List<ListVacationRequestDto>> GetList(int userId)
        {
            using (var context = new VacationContext())
            {
                var result = from request in context.VacationRequests
                             join vacationType in context.VacationTypes on request.VacationTypeId equals vacationType.Id
                             select new ListVacationRequestDto
                             {
                                 CreatedDate = request.CreatedDate,
                                 EndVacation = request.EndVacation,
                                 Id = request.Id,
                                 ReplacementPerson = request.ReplacementPerson,
                                 RequestNo = request.RequestNo,
                                 StartVacation = request.StartVacation,
                                 VacationRequestStatus = request.VacationRequestStatus,
                                 VacationerFullName = request.VacationerFullName,
                                 VacationerPosition = request.VacationerPosition,
                                 VacationType = vacationType.Name
                             };
                return await result.OrderByDescending(x=>x.CreatedDate).ToListAsync();
            }
        }
    }
}
