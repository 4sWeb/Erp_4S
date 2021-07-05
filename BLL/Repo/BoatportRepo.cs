using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class BoatportRepo:Base_Repo<Boatport>,IBoatport
    {
        public BoatportRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
