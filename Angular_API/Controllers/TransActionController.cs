﻿using BLL.IRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransActionController : Controller
    {
        private readonly IRepoWrapper repo;
        public TransActionController(IRepoWrapper _repo)
        {
            repo = _repo;
        }
        [HttpGet ]
       public   JsonResult TransActionsList() 
        {
            return   Json(repo._StoreTrns.GetAll(), new System.Text.Json.JsonSerializerOptions());
            
        }
    }
}
