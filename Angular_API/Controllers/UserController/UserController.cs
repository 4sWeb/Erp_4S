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
        public UserController(IRepoWrapper _repo)
        {
            repo = _repo;
        }

        //********************************USERS CRUD OPERTION*****************************//
        [HttpPost]
        [Route("Login")]
        public JsonResult DisplayItems([FromBody] UserCredential_VM userCredential)
        {
            User_VM user_VM = new User_VM();
           
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
                    Response_VM<User_VM> response_VM = new Response_VM<User_VM>() { Data = user_VM, StatusCode = 200, Message = "oK" };
                    return Json(response_VM, new System.Text.Json.JsonSerializerOptions());
                }
            }
           
            return Json(null, new System.Text.Json.JsonSerializerOptions());
        }
    }
}
