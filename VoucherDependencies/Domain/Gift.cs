using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherDependencies.Domain
{
    public class Gift
    {
        private Int64 Amount { get; set; }

        public Gift(Int64 amount)
        {
            this.Amount = amount;
        }

    }
}
