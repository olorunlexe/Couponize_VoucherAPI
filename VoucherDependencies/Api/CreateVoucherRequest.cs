using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoucherDependencies.Domain;
using VoucherDependencies.Util;

namespace VoucherDependencies.Api
{
    public class CreateVoucherRequest
    {

        public static async Task<ServiceResponse> CreateVoucherAsync(Voucher voucher, Discount discount, Gift gift, Redemption redemption, Code_Config code_Config, MetaData metaData) {

            try
            {
                
                
                PrintVoucher(voucher);

                ServiceResponse response = new ServiceResponse("0", "Good Request", "Request Completed");
                return response;
            }
            catch (Exception e)
            {
                ServiceResponse response = new ServiceResponse("","","");
            }
            return null;
        }

        public static void PrintVoucher(Voucher voucher)
        {
            Console.WriteLine(voucher.ToString());
        }

       
        
        
    }
}
