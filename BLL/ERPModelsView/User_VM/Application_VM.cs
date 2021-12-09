using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ERPModelsView.User_VM
{
   public class Application_VM
    {
        public string AppName       { get; set; }
        public string AppEname      { get; set; }
        public decimal? AppPosition { get; set; }
        public DateTime? Createdate { get; set; }
        public string AppType       { get; set; }
        public decimal AppId        { get; set; }
        public string Keyword       { get; set; }
    }
}
