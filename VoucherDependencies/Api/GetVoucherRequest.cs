using Dapper;
using Microsoft.Extensions.Configuration;
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
    public class GetVoucherRequest : BaseService
    {
        public GetVoucherRequest(IConfiguration config) : base(config)
        {
        }

        //Dapper method to use code param to get voucher from database..
        public static async Task<VoucherModel> GetVoucherAsync(string code)
        {
            VoucherModel voucher = new VoucherModel();

            using (var conn = Connection )
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                IDataReader reader = await conn.ExecuteReaderAsync("GetVoucherByCode",
                                new { Code = code },
                                commandType: CommandType.StoredProcedure);
               
                //Reader appending the values while stream is open to print out
                while (reader.Read())
                {
                    voucher.Code = reader["code"].ToString();
                    voucher.Amount = Convert.ToInt64(reader["giftAmount"].ToString());
                }
                reader.Close();        
            }
            return voucher;
        }

        //For Listing Vouchers
        //public static IEnumerable<VoucherModel> GetPerson()
        //{
        //    List<VoucherModel> orderList = new List<VoucherModel>();

        //    using (IDbConnection con = new SqlConnection(strConnectionString))
        //    {
        //        if (con.State == ConnectionState.Closed)
        //            con.Open();

        //        orderList = con.Query<VoucherModel>("GetVoucher").ToList();
        //    }

        //    return orderList;
        //}
    }
}
