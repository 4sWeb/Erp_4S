using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BLL.Repo
{
    public class UsersRepo:Base_Repo<User>, IUsers
    {
        public UsersRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
        public  String HashPassword(String password, string salt)
        {
            string combinedPassword = String.Concat(password, salt);
            SHA256CryptoServiceProvider sha = new SHA256CryptoServiceProvider();
            byte[] bytes = UTF8Encoding.UTF8.GetBytes(combinedPassword);
            return Convert.ToBase64String(sha.ComputeHash(bytes));
        }
    }
}
