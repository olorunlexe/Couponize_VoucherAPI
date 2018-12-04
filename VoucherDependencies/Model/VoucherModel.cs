using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoucherDependencies.Util;

namespace VoucherDependencies.Model
{
    public class VoucherModel
    {
        public string Code { get; set; }
        public Voucher_Type Voucher_Type { get; set; }
        //Discount
        public Discount_Type Discount_Type { get; set; }
        public float Percent_Off { get; set; }
        public Int64 Amount_Off { get; set; }
        public Int64 AmountLimit { get; set; }
        public float Unit_Off { get; set; }
        public string UnitType { get; set; }
        //Gift
        public Int64 Amount { get; set; }
        public string Category { get; set; }
        public string AdditionalInfo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool Active { get; set; }
        //Redemption
        public Int32 Quantity { get; set; }
        //Code_Config
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public int CodeLength { get; set; }
        public CharSet CharSet { get; set; }
        public bool Test { get; set; }
        public string Locale { get; set; }

        
    }
}
