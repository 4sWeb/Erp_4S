using BLL.IRepo;
using DAL.Models;

using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class AcceptInTrnsRepo:Base_Repo<AcceptInTrn>, IAcceptInTrns
    {
        public AcceptInTrnsRepo(ModelContext dbContext4S) : base(dbContext4S)
        {

        }
    }
}
