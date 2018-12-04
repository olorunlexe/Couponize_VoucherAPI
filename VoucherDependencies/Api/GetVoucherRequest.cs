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
        static string strConnectionString = "User Id=sa;Password=Deolu007@;Database=VoucherTest;";
        public static async Task<VoucherModel> GetVoucherAsync(string code)
        {
            try
            {
                using(IDbConnection conn = new SqlConnection(strConnectionString))
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@code", code);

                    IDataReader reader = await conn.ExecuteReaderAsync("GetVoucher",parameters,commandType: CommandType.StoredProcedure);
                    while (reader.Read())
                    {
                        
                    }
                    VoucherModel get = new VoucherModel();
                    get.Code = code;
                    return get;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
