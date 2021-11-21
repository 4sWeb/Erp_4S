using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ERPModelsView.User_VM
{
   public class User_VM
    {
        public decimal Userid { get; set; }
        public string Usercode { get; set; }
        public string Username { get; set; }
        public string Userename { get; set; }
        public string Userpassword { get; set; }
        public string Positionapps { get; set; }
        public decimal? Active { get; set; }
        public DateTime? Createdate { get; set; }
        public decimal? UsergroupId { get; set; }
        public decimal? Projectno { get; set; }
        public decimal? Privilegeid { get; set; }
        public string Salt { get; set; }
        public string Uname { get; set; }
    }
}
