using System.Collections.Generic;
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
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> VoucherApi()
        { 
            return await Task.Run(()=> new JsonResult("Welcome to Voucher Api"));
        }

        [HttpPost("{code}")]
        public async Task<ActionResult> Create(string code, [FromBody] VoucherModel create)
        {
            Voucher voucher = new Voucher(create.Code, create.Voucher_Type, create.Category, create.AdditionalInfo, create.StartDate, create.ExpirationDate, create.Active);
            Discount discount = new Discount(create.Discount_Type, create.Percent_Off, create.Amount_Off, create.AmountLimit, create.Unit_Off, create.UnitType);
            Gift gift = new Gift(create.Amount);
            Redemption redemption = new Redemption(create.Quantity);
            Code_Config code_Config = new Code_Config(create.Prefix, create.Suffix, create.CodeLength, create.CharSet);
            MetaData metadata = new MetaData(create.Test,create.Locale);
            ServiceResponse response = await CreateVoucherRequest.CreateVoucherAsync(voucher,discount,gift,redemption,code_Config,metadata);

            switch (Response.StatusCode==200) {
                case true:
                    return Ok(create);
                default:
                    return Ok(response);
            }
        
        }

        [HttpGet("{code}")]
        public async Task<ActionResult> Get(string code)
        {
            CreateVoucherRequest createVoucherRequest = new CreateVoucherRequest();
            

            return Ok("Not yet Implemented");
        }

        [HttpPut("{code}")]
        public async Task<ActionResult> Update(string code)
        {

            return new JsonResult(Response);
        }

        [HttpDelete("{code}")]
        public async Task<ActionResult> Delete(string code)
        {
            return new JsonResult(Response);
        }

        [HttpGet]
        public async Task<ActionResult> GetList()
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
