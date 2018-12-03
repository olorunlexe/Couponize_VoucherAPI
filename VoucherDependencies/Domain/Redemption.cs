using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherDependencies.Domain
{
    public class Redemption
    {
        public int Quantity { get; set; }

        public Redemption(int quantity)
        {
            Quantity = quantity;
        }
    }
}
