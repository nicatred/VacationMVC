using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using DataAccess.Dtos.Concrete;
using DataAccess.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfVacationRequestDal : EfReporitoryBase<VacationRequest, VacationContext>, IVacationRequestDal
    {
        public async Task<int> GenerateAndSetRequestNo(string userId)
        {
            using (var context = new VacationContext())
            {
               // _context.Database.SqlQuery<ProjectsModel>("exec dbo.[GetProjectListByID] @ProjectID", new SqlParameter("@ProjectID", projectId)).FirstOrDefault();
               int rows =  await context.Database.ExecuteSqlInterpolatedAsync($"EXEC  GenerateRequestNumber {userId}");
                return rows;
            }
        }

        public async Task<List<ListVacationRequestDto>> GetAllList()
        {
            using (var context = new VacationContext())
            {
                var result = from request in context.VacationRequests
                             join vacationType in context.VacationTypes on request.VacationTypeId equals vacationType.Id
                             where request.VacationRequestStatus == Entites.Enums.VacationRequestStatus.WasSentToManager
                             orderby request.CreatedDate descending
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
                return await result.OrderByDescending(x => x.CreatedDate).ToListAsync();
            }
        }

        public async Task<VacationRequest> GetLast(string userId)
        {
            using (var context = new VacationContext())
            {
                return await context.VacationRequests.Where(x => x.UserId == userId).OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            }
        }

        public async Task<List<ListVacationRequestDto>> GetMyRequests(string userId)
        {
            using (var context = new VacationContext())
            {
                var result = from request in context.VacationRequests
                             join vacationType in context.VacationTypes on request.VacationTypeId equals vacationType.Id
                             where request.UserId==userId
                             orderby request.CreatedDate descending
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
                return await result.OrderByDescending(x => x.CreatedDate).ToListAsync();
            }
        }
    }
}
