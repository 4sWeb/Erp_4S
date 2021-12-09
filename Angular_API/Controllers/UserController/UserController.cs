using Angular_API.StatusCodes;
using BLL.ERPModelsView.Response_VM;
using BLL.ERPModelsView.User_VM;
using BLL.IRepo;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_API.Controllers.UserController
{
    [ApiController]
    [Route("User")]
    [EnableCors("MyAllowSpecificOrigins")]
    public class UserController : Controller
    {
        private readonly IRepoWrapper repo;
        CustomeStatusCodes StatusCodes = new CustomeStatusCodes();
        public UserController(IRepoWrapper _repo)
        {
            repo = _repo;
        }

        //********************************USERS CRUD OPERTION*****************************//
        [HttpPost]
        [Route("Login")]
        public JsonResult Login([FromBody] UserCredential_VM userCredential)
        {
           

            User_VM user_VM = new User_VM();
            Response_VM response_VM = new Response_VM();


             user_VM = repo._Users.GetByCondition(s => s.Username == userCredential.Username).Result.Select
                (
                s=>new User_VM
                {
                   Salt=s.Salt,
                   Userid=s.Userid,
                   Usercode=s.Usercode,
                   Username=s.Username,
                   Userpassword=s.Userpassword,
                }).FirstOrDefault();
            if (user_VM != null)
            {
              string encryptedPassword=  repo._Users.HashPassword(userCredential.Userpassword, user_VM.Salt);
                if (string.Compare(encryptedPassword, user_VM.Userpassword) == 0)
                {
                     response_VM = new Response_VM() { Data = user_VM, StatusCode = 200, Message = CustomeStatusCodes.ErrorCodes[200] };
                    return Json(response_VM);
                }
                else
                {
                    response_VM=new Response_VM() { Data = null, StatusCode =401, Message = CustomeStatusCodes.ErrorCodes[401] };
                }
                return Json(response_VM);
            }
            response_VM = new Response_VM() { Data = null, StatusCode = 400, Message = CustomeStatusCodes.ErrorCodes[400] };
            return Json(response_VM);
        }



        [HttpGet]
        [Route("DisplayAllModules")]
        public JsonResult DisplayAllModules()
        {
           List< Application_VM> applications_VM = new List< Application_VM>();
            Response_VM response_VM = new Response_VM();
            applications_VM =repo._Application.GetAll().Result.Select
                (
                s => new Application_VM { AppEname = s.AppEname, AppId = s.AppId, AppName = s.AppName, AppType = s.AppType }
                ).ToList();
            if (applications_VM.Count >0)
            {


                response_VM = new Response_VM() { Data = applications_VM, StatusCode = 200, Message = CustomeStatusCodes.ErrorCodes[200] };
            }
            else
            {
                response_VM = new Response_VM() { Data = null, StatusCode = 500, Message = CustomeStatusCodes.ErrorCodes[500] };
            }
            return Json(response_VM);

        }
    }
}
