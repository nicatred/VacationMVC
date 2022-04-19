using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Areas.Admin.Controllers
{
 
    [Area("admin")]
    [Authorize(Roles ="admin")]
    public class HomeController : Controller
    {
        private readonly IAdminActionsService _adminActionsService;

        public HomeController(IAdminActionsService adminActionsService)
        {
            _adminActionsService = adminActionsService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _adminActionsService.GetAllVacationRequest();
            if (list.Success)
            {
                return View(list.Data);
            }
            return UnprocessableEntity(list.Message);
        }
        [HttpGet("AcceptRequest/{vacationRequestId}")]
        public async Task<IActionResult> AcceptRequest(int vacationRequestId)
        {
            var list = await _adminActionsService.AcceptRequest(vacationRequestId);
            if (list.Success)
            {
                return RedirectToAction("Index", "Home");
            }
            return UnprocessableEntity(list.Message);
        }
        [HttpGet("RejectRequest/{vacationRequestId}")]

        public async Task<IActionResult> RejectRequest(int vacationRequestId)
        {
            var list = await _adminActionsService.RejectRequest(vacationRequestId);
            if (list.Success)
            {
                return RedirectToAction("Index", "Home");
            }
            return UnprocessableEntity(list.Message);
        }
    }
}
