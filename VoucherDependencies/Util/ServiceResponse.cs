using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherDependencies.Util
{
    public class ServiceResponse
    {
        public string Code { get; }
        public string Message { get; }
        public string Description { get; }

        public ServiceResponse(string code, string message, string description)
        {
            this.Code = code;
            this.Message = message;
            this.Description = description;
        }


        //public override string ToString()
        //{
        //    return "Response {" + 
        //        "ResponseCode='" + Code + '\'' + 
        //        ", Message='" + Message + '\'' + 
        //        ", Description='" + Description + '\'' +"}";
        //}



    }
}
