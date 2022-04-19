using Business.Utilities.Results.Abstract;
using DataAccess.Dtos.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdminActionsService
    {
        Task<IDataResult<List<ListVacationRequestDto>>> GetAllVacationRequest();
        Task<IResult> AcceptRequest(int vacationRequestId);
        Task<IResult> RejectRequest(int vacationRequestId);
    }
}
