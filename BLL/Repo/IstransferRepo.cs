using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class IstransferRepo:Base_Repo<Istransfer>, IIstransfer
    {
        public IstransferRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
