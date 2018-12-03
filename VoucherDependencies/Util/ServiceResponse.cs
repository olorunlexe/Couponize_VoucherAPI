using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherDependencies.Util
{
    public class ServiceResponse
    {
        private string Code { get; }
        private string Message { get; }
        private string Description { get; }

        public ServiceResponse(string code, string message, string description)
        {
            this.Code = code;
            this.Message = message;
            this.Description = description;
        }

        public override string ToString()
        {
            return "Response {" + 
                "ResponseCode='" + Code + '\'' + 
                ", Message='" + Message + '\'' + 
                ", Description='" + Description + '\'' +"}";
        }
    }
}
