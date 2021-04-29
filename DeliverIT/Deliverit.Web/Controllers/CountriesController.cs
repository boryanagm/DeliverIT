using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliverit.Web.Controllers
{
    public class CountriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
