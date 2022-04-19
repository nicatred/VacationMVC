using DataAccess.Dtos.Concrete;
using DataAccess.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IVacationRequestDal:IEntityRepository<VacationRequest>
    {
        Task<VacationRequest> GetLast(string userId);
        Task<List<ListVacationRequestDto>> GetMyRequests(string userId);
        Task<List<ListVacationRequestDto>> GetAllList();
        Task<int>  GenerateAndSetRequestNo(string userId);
    }
}
