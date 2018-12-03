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
        public Int64 Amount { get; }

        public Gift(Int64 amount)
        {
            this.Amount = amount;
        }

    }
}
