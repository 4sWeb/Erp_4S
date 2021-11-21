using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.IRepo
{
    public interface IUsers:IBaseRepo<User>
    {
        public String HashPassword(String password, string salt);
    }
}
