using Business.Utilities.Results.Abstract;
using DataAccess.Dtos.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IVacationRequestService
    {
        Task<IResult> Add(VacationRequestDto vacationRequestDto);
        Task<IDataResult<List<ListVacationRequestDto>>> GetMyRequests();
        Task<IResult> SendToManager(int vacationRequestId);

    }
}
