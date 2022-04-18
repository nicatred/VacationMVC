using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Business.Utilities.Results.Abstract;
using Business.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Dtos.Concrete;
using DataAccess.Entites.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VacationRequestManager : IVacationRequestService
    {
        private readonly IVacationRequestDal _vacationRequestDal;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;

        public VacationRequestManager(IVacationRequestDal vacationRequestDal, IMapper mapper, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _vacationRequestDal = vacationRequestDal;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<IResult> Add(VacationRequestDto vacationRequestDto)
        {
            var mappedEntity =  _mapper.Map<VacationRequestDto, VacationRequest>(vacationRequestDto);
            mappedEntity.CreatedDate = DateTime.Now;
            mappedEntity.VacationRequestStatus = DataAccess.Entites.Enums.VacationRequestStatus.Created;
            var user = await _userManager.FindByNameAsync(UserIdProvaider.GetUserId());
            mappedEntity.UserId = user.Id;
            await _vacationRequestDal.AddAsync(mappedEntity);
            var rows =    await _vacationRequestDal.GenerateAndSetRequestNo(user.Id);
            return new SuccessResult(Messages.EntityAdded);
        }

        public  async Task<IDataResult<List<ListVacationRequestDto>>> GetList()
        {
            var user = await _userManager.FindByNameAsync(UserIdProvaider.GetUserId());
            var list = await _vacationRequestDal.GetList(user.Id);
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
