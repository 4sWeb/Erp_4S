using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Erp_4S.Models;
//using DAL.Entities;
using BLL.Repo;
using BLL.IRepo;

namespace Erp_4S.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepoWrapper _repo;
        public HomeController(ILogger<HomeController> logger,IRepoWrapper repo)
        {
            _logger = logger;
            _repo = repo;
        }

        public IActionResult Index()
        {
            var rr = _repo._Currencym.GetAll();
            TestQuery Test = new TestQuery();
            Test.Get();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
