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
        //Database connection string.
        static string strConnectionString = "User Id=sa;Password=Deolu007@;Database=VoucherTest;";

        public static async Task<ServiceResponse> CreateVoucherAsync(Voucher voucher, Discount discount, Gift gift, Redemption redemption, Code_Config code_Config, MetaData metaData) {

            try
            {
                int rowAffected = 0;
                using (IDbConnection con = new SqlConnection(strConnectionString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    //Parameters Declaration to be passed into Stored procdure "InsertVoucher"..
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Code", voucher.Code);
                    parameters.Add("@VoucherType", voucher.Voucher_type);
                    parameters.Add("@DiscountType", discount.Discount_type);
                    parameters.Add("@DiscountPercentOff", discount.Percent_Off);
                    parameters.Add("@DiscountAmountOff", discount.Amount_Off);
                    parameters.Add("@DiscountAmountLimit", discount.AmountLimit);
                    parameters.Add("@DiscountUnitOff", discount.Unit_Off);
                    parameters.Add("@DiscountUnitType",discount.Unit_Type);
                    parameters.Add("@GiftAmount", gift.Amount);
                    parameters.Add("@VoucherCategory", voucher.Category);
                    parameters.Add("@VoucherAdditionalInfo", voucher.Additional_Info);
                    parameters.Add("@VoucherStartDate", voucher.Start_Date);
                    parameters.Add("@VoucherExpirationDate", voucher.Expiration_Date);
                    parameters.Add("@VoucherActiveStatus", voucher.Active);
                    parameters.Add("@RedemptionQuantity", redemption.Quantity);
                    parameters.Add("@CodePrefix", code_Config.prefix);
                    parameters.Add("@CodeSuffix", code_Config.suffix);
                    parameters.Add("@CodeLength", code_Config.length);
                    parameters.Add("@CodeCharset", code_Config.charset);
                    parameters.Add("@VoucherMetaData",metaData.Meta_Data);

                    rowAffected = await con.ExecuteAsync("InsertVoucher", parameters, commandType: CommandType.StoredProcedure);
                }

                //response using predefined serviceresponse class
               ServiceResponse response = new ServiceResponse("0", "Good Request", "Request Completed");
               return response;
            }
            catch (Exception e)
            {
                //error response
                ServiceResponse response = new ServiceResponse("100","Unsuccessful","Request could not be completed");
                return response;
            }
            
        }

       
        
        
    }
}
