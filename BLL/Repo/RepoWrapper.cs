using System;
using System.Collections.Generic;
using System.Text;
using BLL.IRepo;
using DAL.Entities;
namespace BLL.Repo
{
    //public class RepoWrapper : IRepoWrapper
    //{
    //    private DbContext4S  _contex;
    //    private IProjectsRepo projects;
    //    private IMembersRepo members;
    //    public RepoWrapper(DbContext4S context)
    //    {
    //        _contex = context;
    //    }
    //    public IProjectsRepo _Project 
    //    {
    //        get 
    //        {
    //           if(projects==null) projects =new  ProjectsRepo(_contex); return projects;
    //        }
    //    }

    //    public IMembersRepo _Member 
    //    {
    //        get { if (members == null) members =new  MembersRepo(_contex);return members; }
    //    }

    //    public void Save()
    //    {
    //        _contex .SaveChanges();
    //    }
    //}
}
