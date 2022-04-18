using Business.Abstract;
using DataAccess.Dtos.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IVacationRequestService _requestService;

        public HomeController(IVacationRequestService requestService)
        {
            _requestService = requestService;
        }
       
        [HttpGet]

        public async Task<IActionResult> Index()
        {
            var list = await _requestService.GetList();
            if (list.Success)
            {
                return View(list.Data);
            }
            return UnprocessableEntity(list.Message);
        }

    }
}
