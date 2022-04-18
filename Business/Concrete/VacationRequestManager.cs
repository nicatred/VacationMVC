using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Business.Utilities.Results.Abstract;
using Business.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Dtos.Concrete;
using DataAccess.Entites.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VacationRequestManager : IVacationRequestService
    {
        private readonly IVacationRequestDal _vacationRequestDal;
        private readonly IMapper _mapper;
        private readonly IUserDal _userDal;

        public VacationRequestManager(IVacationRequestDal vacationRequestDal, IMapper mapper, IUserDal userDal)
        {
            _vacationRequestDal = vacationRequestDal;
            _mapper = mapper;
            _userDal = userDal;
        }

        public async Task<IResult> Add(VacationRequestDto vacationRequestDto)
        {
            var mappedEntity =  _mapper.Map<VacationRequestDto, VacationRequest>(vacationRequestDto);
            mappedEntity.CreatedDate = DateTime.Now;
            mappedEntity.VacationRequestStatus = DataAccess.Entites.Enums.VacationRequestStatus.Created;
            mappedEntity.UserId = UserIdProvaider.GetUserId();
            var lastRequest = await _vacationRequestDal.GetLast(UserIdProvaider.GetUserId());
            if (lastRequest != null) 
            {
                int lastRequestNo = Convert.ToInt32(lastRequest.RequestNo.Substring(lastRequest.RequestNo.Length - 4));
                mappedEntity.RequestNo = "Q-" + DateTime.Now.ToString("YY-MM-") + lastRequestNo ;
            }
            else
            {
                int firstRequsetNo = 0001;
                mappedEntity.RequestNo = "Q-" + DateTime.Now.ToString("YY-MM-") + firstRequsetNo;
            }

            await _vacationRequestDal.AddAsync(mappedEntity);
            return new SuccessResult(Messages.EntityAdded);
        }

        public  async Task<IDataResult<List<ListVacationRequestDto>>> GetList()
        {
            var list = await _vacationRequestDal.GetList(UserIdProvaider.GetUserId());
            return new SuccessDataResult<List<ListVacationRequestDto>>(list, Messages.EntityGetList);
        }

        public async Task<IResult> SendToManager(int vacationRequestId)
        {
            var vacationRequest = await _vacationRequestDal.GetAsync(x => x.Id == vacationRequestId);
            vacationRequest.VacationRequestStatus = DataAccess.Entites.Enums.VacationRequestStatus.WasSentToManager;
            await _vacationRequestDal.UpdateAsync(vacationRequest);
            return new SuccessResult(Messages.EntityUpdated);
        }
    }
}
