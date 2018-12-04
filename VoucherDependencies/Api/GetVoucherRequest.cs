using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoucherDependencies.Model;

namespace VoucherDependencies.Api
{
    public class GetVoucherRequest
    {
        string strConnectionString = "User Id=sa;Password=Deolu007@;Database=VoucherTest;";
        public static async Task<VoucherModel> GetVoucherAsync(string code)
        {
            try
            {
                
                VoucherModel get = new VoucherModel();
                get.Code = code;
                return get;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
