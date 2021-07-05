using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class CommonEmployee
    {
        public decimal Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Jobtitle { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Ext { get; set; }
        public string Email { get; set; }
        public bool? Isinternalcommunicator { get; set; }
        public bool? Canviewdepartmentmessages { get; set; }
        public decimal? Department { get; set; }
        public decimal? City { get; set; }
        public decimal? Users { get; set; }
        public string Branch { get; set; }
        public bool? Isdepartmentmanager { get; set; }
        public bool? Ismanager { get; set; }
        public string Gender { get; set; }
        public bool? Isactive { get; set; }
        public decimal? Employeecode { get; set; }
        public bool? Isemployee { get; set; }
        public decimal? Attendancegroup { get; set; }
        public decimal? Attendancecode { get; set; }
        public bool? Authorityflag { get; set; }
        public bool? Canseeprivateglaccounts { get; set; }
        public bool? Canseeallstore { get; set; }
    }
}
