using Microsoft.AspNetCore.Mvc;
using MvcUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index(ErrorViewModel errorViewModel)
        {
            return View(errorViewModel);
        }
    }
}
