using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;


namespace BLL.ERPModelsView.Response_VM
{
    public class Response_VM<T>
    {
       
        public T Data { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
    

    }
}
