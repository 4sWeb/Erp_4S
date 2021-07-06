using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class PreferencesRepo:Base_Repo<Preference>, IPreferences
    {
        public PreferencesRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
