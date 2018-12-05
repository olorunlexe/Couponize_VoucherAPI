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

      
        //Dapper method to use code param to get voucher from database..
        public static async Task<VoucherModel> GetVoucherAsync(string code)
        {
            VoucherModel voucher = new VoucherModel();

            using (var connection = new SqlConnection(strConnectionString))
            {
                await connection.OpenAsync();

                IDataReader reader = await connection.ExecuteReaderAsync("GetVoucherByCode",
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
