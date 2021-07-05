using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ActionTaken
    {
        public string Id { get; set; }
        public string UnitSchdHistId { get; set; }
        public string ScheduleId { get; set; }
        public string RateNo { get; set; }
        public string IssueId { get; set; }
        public DateTime CreationDate { get; set; }
        public string ActionType { get; set; }
        public string UnitId { get; set; }
        public string CancelReason { get; set; }
        public string ReadingCounter { get; set; }
        public string CreatedBy { get; set; }
    }
}
