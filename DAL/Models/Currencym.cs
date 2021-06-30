using System;
using System.Collections.Generic;

namespace ERPCOREDAL.Models
{
    public partial class Currencym
    {
        public Currencym()
        {
            //Accountstree = new HashSet<Accountstree>();
            //Currencyo = new HashSet<Currencyo>();
            //Dimensionsdetails = new HashSet<Dimensionsdetails>();
            //StoreAllcodesBegin = new HashSet<StoreAllcodesBegin>();
        }

        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Shortname { get; set; }
        public string Isdefault { get; set; }
        public string AcurrUnit1 { get; set; }
        public string AcurrUnit2 { get; set; }
        public string AcurrUnit3 { get; set; }
        public string AcurrUnit4 { get; set; }
        public string AfracUnit1 { get; set; }
        public string AfracUnit2 { get; set; }
        public string AfracUnit3 { get; set; }
        public string AfracUnit4 { get; set; }
        public string EcurrUnit1 { get; set; }
        public string EcurrUnit2 { get; set; }
        public string EcurrUnit3 { get; set; }
        public string EcurrUnit4 { get; set; }
        public string EfracUnit1 { get; set; }
        public string EfracUnit2 { get; set; }
        public string EfracUnit3 { get; set; }
        public string EfracUnit4 { get; set; }
        public int Id { get; set; }

        //public virtual ICollection<Accountstree> Accountstree { get; set; }
        //public virtual ICollection<Currencyo> Currencyo { get; set; }
        //public virtual ICollection<Dimensionsdetails> Dimensionsdetails { get; set; }
        //public virtual ICollection<StoreAllcodesBegin> StoreAllcodesBegin { get; set; }
    }
}
