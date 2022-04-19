using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Business.Utilities.Results.Abstract;
using Business.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Dtos.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdminActionsManager : IAdminActionsService
    {
        private readonly IVacationRequestDal _vacationRequestDal;
        private readonly IMapper _mapper;

        public AdminActionsManager(IVacationRequestDal vacationRequestDal, IMapper mapper)
        {
            _vacationRequestDal = vacationRequestDal;
            _mapper = mapper;
        }

        public async Task<IResult> AcceptRequest(int vacationRequestId)
        {
            var vacationRequest = await _vacationRequestDal.GetAsync(x => x.Id == vacationRequestId);
            vacationRequest.VacationRequestStatus = DataAccess.Entites.Enums.VacationRequestStatus.Accepted;
            await _vacationRequestDal.UpdateAsync(vacationRequest);
            return new SuccessResult(Messages.EntityUpdated);
        }

        public async Task<IDataResult<List<ListVacationRequestDto>>> GetAllVacationRequest()
        {
            var list = await _vacationRequestDal.GetAllList();
            return new SuccessDataResult<List<ListVacationRequestDto>>(list, Messages.EntityGetList);
        }

        public async Task<IResult> RejectRequest(int vacationRequestId)
        {
            var vacationRequest = await _vacationRequestDal.GetAsync(x => x.Id == vacationRequestId);
            vacationRequest.VacationRequestStatus = DataAccess.Entites.Enums.VacationRequestStatus.Rejected;
            await _vacationRequestDal.UpdateAsync(vacationRequest);
            return new SuccessResult(Messages.EntityUpdated);
        }
    }
}
