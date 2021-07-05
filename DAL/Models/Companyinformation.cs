using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Companyinformation
    {
        public Companyinformation()
        {
            Companyresponsables = new HashSet<Companyresponsable>();
        }

        public decimal Id { get; set; }
        public string CompanyName { get; set; }
        public decimal? CompanyRecordTrading { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyLogo { get; set; }
        public string Companynametaxes { get; set; }
        public string Companyno { get; set; }
        public string Companytaxno { get; set; }

        public virtual ICollection<Companyresponsable> Companyresponsables { get; set; }
    }
}
