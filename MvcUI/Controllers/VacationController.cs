using Business.Abstract;
using DataAccess.Dtos.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Controllers
{
    public class VacationController : Controller
    {
        private readonly IVacationRequestService _requestService;
        private readonly IVacationTypeService _vacationTypeService;

        public VacationController(IVacationRequestService requestService, IVacationTypeService vacationTypeService)
        {
            _requestService = requestService;
            _vacationTypeService = vacationTypeService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> CreateVacationRequset()
        {
            var vacationTypes = await _vacationTypeService.GetAll();
            VacationRequestViewModel vacationRequestViewModel = new VacationRequestViewModel();
            if (vacationTypes.Success)
            {
                vacationRequestViewModel.VacationTypes = vacationTypes.Data;
                return View("Index",vacationRequestViewModel);
            }
            return UnprocessableEntity(vacationTypes.Message);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateVacationRequset(VacationRequestDto vacationRequestDto)
        {
            var result = await _requestService.Add(vacationRequestDto);
            if (result.Success)
            {
                return RedirectToAction("Index","Home");
            }
            return UnprocessableEntity();
        }

        [Authorize]
        [HttpGet("SendToManager/{vacationRequestId}")]
        public async Task<IActionResult> SendToManager(int vacationRequestId)
        {
            var result = await _requestService.SendToManager(vacationRequestId);
            if (result.Success)
            {
                return RedirectToAction("Index", "Home");
            }
            return UnprocessableEntity();
        }
    }
}
