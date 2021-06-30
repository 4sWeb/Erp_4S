using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class MemberView
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string  Title { get; set; }
        public int ProjectId { get; set; }
    }
}
