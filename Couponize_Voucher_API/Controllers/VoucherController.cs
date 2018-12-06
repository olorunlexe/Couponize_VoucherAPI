using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VoucherDependencies.Api;
using VoucherDependencies.Domain;
using VoucherDependencies.Model;
using VoucherDependencies.Util;

namespace Couponize_Voucher_API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        //Welcome Screen to Hold docs later
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> VoucherApi()
        { 
            return await Task.Run(()=> new JsonResult("Welcome to Voucher Api"));
        }


        //Post request using code at path to pass in values for Voucher creation
        [HttpPost("{code}")]
        public async Task<ActionResult> CreateVoucher(string code, [FromBody] VoucherModel create)
        {
            //Passing in values using "VoucherModel" into the Different Model to use params
            Voucher voucher = new Voucher(create.Code, create.Voucher_Type, create.Category, create.AdditionalInfo, create.StartDate, create.ExpirationDate, create.Active);
            Discount discount = new Discount(create.Discount_Type, create.Percent_Off, create.Amount_Off, create.AmountLimit, create.Unit_Off, create.UnitType);
            Gift gift = new Gift(create.Amount);
            Redemption redemption = new Redemption(create.Quantity);
            Code_Config code_Config = new Code_Config(create.Prefix, create.Suffix, create.CodeLength, create.CharSet);
            MetaData metadata = new MetaData(create.Test,create.Locale);

            //Run CreateVoucherAsync Service and returns response with ServiceResponse class
            ServiceResponse response = await CreateVoucherRequest.CreateVoucherAsync(voucher,discount,gift,redemption,code_Config,metadata);


            //Checks if response status code is 200, if true returns voucher params and values as Json data, else returns response(Not successful)
            switch (Response.StatusCode == 200) {
                case true:
                    return Ok(create);
                default:
                    return Ok(response);
            }
        
        }

        //GET request action method for Querying Database for Voucher details specific to a code
        [HttpGet("{code}")]
        public async Task<ActionResult> GetVoucher(string code)
        {
            VoucherModel result;
            result = await GetVoucherRequest.GetVoucherAsync(code);
            return Ok(result);

        }

        [HttpGet]
        public async Task<ActionResult> CreateCode([FromBody] Code_Config code_Config)
        {

            string result = await VoucherDependencies.Api.CreateCodeRequest.CreateCode(code_Config);

            return Ok(result);

        }

        [HttpPut("{code}")]
        public async Task<ActionResult> UpdateVoucher(string code, [FromBody] VoucherModel update)
        {
            //Passing in values using "VoucherModel" into the Different Model to use params
            Voucher voucher = new Voucher(update.Code, update.Voucher_Type, update.Category, update.AdditionalInfo, update.StartDate, update.ExpirationDate, update.Active);
            Discount discount = new Discount(update.Discount_Type, update.Percent_Off, update.Amount_Off, update.AmountLimit, update.Unit_Off, update.UnitType);
            Gift gift = new Gift(update.Amount);
            Redemption redemption = new Redemption(update.Quantity);
            Code_Config code_Config = new Code_Config(update.Prefix, update.Suffix, update.CodeLength, update.CharSet);
            MetaData metadata = new MetaData(update.Test, update.Locale);

            //Run CreateVoucherAsync Service and returns response with ServiceResponse class
            ServiceResponse response = await CreateVoucherRequest.CreateVoucherAsync(voucher, discount, gift, redemption, code_Config, metadata);

            //Checks if response status code is 200, if true returns voucher params and values as Json data, else returns response(Not successful)
            switch (Response.StatusCode == 200)
            {
                case true:
                    return Ok(update);
                default:
                    return Ok(response);
            }
        }

        [HttpDelete("{code}")]
        public async Task<ActionResult> DeleteVoucher(string code)
        {
            return new JsonResult(Response);
        }

        [HttpGet]
        public async Task<ActionResult> GetVoucherList()
        {
            return new JsonResult(Response);
        }

        [HttpPost("{code}")]
        public async Task<ActionResult> EnableVoucher(string code)
        {
            return new JsonResult(Response);
        }

        [HttpPost("{code}")]
        public async Task<ActionResult> DisableVoucher(string code)
        {
            return new JsonResult(Response);
        }

        [HttpPost("{code}")]
        public async Task<ActionResult> AddGiftVoucherBalance(string code)
        {
            return new JsonResult(Response);
        }

        [HttpPost]
        public async Task<ActionResult> ImportVouchers()
        {
            return new JsonResult(Response);
        }

        [HttpPost]
        public async Task<ActionResult> ImportVouchersByCSV()
        {
            return new JsonResult(Response);        }
        
    }
}
