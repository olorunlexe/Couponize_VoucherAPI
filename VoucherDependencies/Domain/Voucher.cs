using System;

namespace VoucherDependencies.Domain
{
    public class Voucher 
    {
        public string Code { get; }
        public string Voucher_type { get; }
        public string Category{ get; }
        public string Additional_Info{ get; }
        public DateTime Start_Date{ get; }
        public DateTime Expiration_Date{ get; }
        public bool Active{ get; }

        public Voucher(string code, string voucher_type, string category, string additional_Info, DateTime start_Date, DateTime expiration_Date, bool active)
        {
            this.Code = code;
            this.Voucher_type = voucher_type;
            this.Category = category;
            this.Additional_Info = additional_Info;
            this.Start_Date = start_Date;
            this.Expiration_Date = expiration_Date;
            this.Active = active;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
