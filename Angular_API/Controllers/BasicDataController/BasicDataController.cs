using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_API.Controllers.BasicDataController
{
    public class BasicDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
