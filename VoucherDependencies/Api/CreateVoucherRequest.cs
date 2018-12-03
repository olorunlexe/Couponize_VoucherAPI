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
    public class CreateVoucherRequest
    {
        static string strConnectionString = "User Id=sa;Password=Deolu007@;Database=VoucherTest;";

        public static async Task<ServiceResponse> CreateVoucherAsync(Voucher voucher, Discount discount, Gift gift, Redemption redemption, Code_Config code_Config, MetaData metaData) {

            try
            {
                int rowAffected = 0;
                using (IDbConnection con = new SqlConnection(strConnectionString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Code", voucher.Code);
                    parameters.Add("@GiftAmount", gift.Amount);
                    parameters.Add("@Active", voucher.Active);

                    rowAffected = con.Execute("InsertVoucher", parameters, commandType: CommandType.StoredProcedure);
                }

               ServiceResponse response = new ServiceResponse("0", "Good Request", "Request Completed");
               return response;
            }
            catch (Exception e)
            {
                //String except = e.Message;
                ServiceResponse response = new ServiceResponse("100","","Request could not be completed");
                return response;
            }
            return null;
        }

       
        
        
    }
}
