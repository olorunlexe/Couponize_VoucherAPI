using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoucherDependencies.Util;

namespace VoucherDependencies.Domain
{
    public class Discount
    {
        public Discount_Type Discount_type { get; }
        public float Percent_Off { get; }
        public Int64 Amount_Off { get; }
        public Int64 AmountLimit { get; }
        public float Unit_Off { get; }
        public string Unit_Type { get; }

        public Discount(Discount_Type discount_type, float percent_Off, Int64 amount_Off, Int64 amount_Limit, float unit_Off, string unit_Type)
        {
            this.Discount_type = discount_type;
            this.Percent_Off = percent_Off;
            this.Amount_Off = amount_Off;
            this.AmountLimit = amount_Limit;
            this.Unit_Off = unit_Off;
            this.Unit_Type = unit_Type;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
