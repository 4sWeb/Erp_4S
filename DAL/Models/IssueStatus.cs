using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class IssueStatus
    {
        public string StatusId { get; set; }
        public string StatusName { get; set; }
        public string IssueTitle { get; set; }
        public string StatusNote { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? BeginDate { get; set; }
        public string TotalTime { get; set; }
        public string CauseDescription { get; set; }
        public string ActionTaken { get; set; }
        public string PreventionTaken { get; set; }
        public string BusinessObjId { get; set; }
        public string ObjectType { get; set; }
        public string ParentId { get; set; }
        public string CreatedBy { get; set; }
    }
}
