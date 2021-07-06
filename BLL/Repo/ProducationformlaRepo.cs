using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class ProducationformlaRepo:Base_Repo<Producationformla>, IProducationformla
    {
        public ProducationformlaRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }   
    }
}
