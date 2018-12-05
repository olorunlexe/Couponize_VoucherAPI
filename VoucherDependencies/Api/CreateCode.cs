using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoucherDependencies.Domain;
using VoucherDependencies.Util;

namespace VoucherDependencies.Api
{
    public class CreateCode
    {

        public static async Task<string> createCode(Code_Config code_Config)
        {

            try
            {
                CodeGenerator codeGenerator = new CodeGenerator();
                string result=await codeGenerator.GetGeneratedCode(code_Config.prefix, code_Config.suffix, code_Config.length, code_Config.charset);

                //response using predefined serviceresponse class
                ServiceResponse response = new ServiceResponse("0", "Good Request", "Request Completed");
                return result;
            }
            catch (Exception e)
            {
                //error response
                ServiceResponse response = new ServiceResponse("100", "Unsuccessful", "Request could not be completed");
              
            }
            return null;
        }
    }
}