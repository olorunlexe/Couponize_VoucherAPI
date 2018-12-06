using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using VoucherDependencies.Domain;
using VoucherDependencies.Util;

namespace VoucherDependencies.Api
{
    public class UpdateVoucherRequest : BaseService
    {
        public UpdateVoucherRequest(IConfiguration config) : base(config)
        {
        }

        public async static Task<ServiceResponse> UpdateVoucherAsync(Voucher voucher, Discount discount, Gift gift, Redemption redemption, Code_Config codeconfig, MetaData metaData)
        {
            ServiceResponse sresponse = null;
            try
            {
                using (var conn = Connection)
                {
                    if(conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                    //Parameters Declaration to be passed into Stored procdure "InsertVoucher"..
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Code", voucher.Code);
                    parameters.Add("@VoucherType", voucher.Voucher_type);
                    parameters.Add("@DiscountType", discount.Discount_type);
                    parameters.Add("@DiscountPercentOff", discount.Percent_Off);
                    parameters.Add("@DiscountAmountOff", discount.Amount_Off);
                    parameters.Add("@DiscountAmountLimit", discount.AmountLimit);
                    parameters.Add("@DiscountUnitOff", discount.Unit_Off);
                    parameters.Add("@DiscountUnitType", discount.Unit_Type);
                    parameters.Add("@GiftAmount", gift.Amount);
                    parameters.Add("@VoucherCategory", voucher.Category);
                    parameters.Add("@VoucherAdditionalInfo", voucher.Additional_Info);
                    parameters.Add("@VoucherStartDate", voucher.Start_Date);
                    parameters.Add("@VoucherExpirationDate", voucher.Expiration_Date);
                    parameters.Add("@VoucherActiveStatus", voucher.Active);
                    parameters.Add("@RedemptionQuantity", redemption.Quantity);
                    parameters.Add("@CodePrefix", codeconfig.prefix);
                    parameters.Add("@CodeSuffix", codeconfig.suffix);
                    parameters.Add("@CodeLength", codeconfig.length);
                    parameters.Add("@CodeCharset", codeconfig.charset);
                    parameters.Add("@VoucherMetaData", metaData.Meta_Data);

                    await conn.ExecuteAsync("UpdateVoucher",parameters,commandType: System.Data.CommandType.StoredProcedure);
                    sresponse = new ServiceResponse("200","Successful","Voucher has been Updated");
                    
                }
                return sresponse;
            }
            catch (AggregateException ae)
            {
                return sresponse = new ServiceResponse("400","Unsuccessful",ae.Message);
            }
        }
    }
}
