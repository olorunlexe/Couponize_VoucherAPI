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
        private int Quantity;

        public Redemption(int quantity)
        {
            this.Quantity = quantity;
        }

        public int GetQuantity()
        {
            return Quantity;
        }
     
    }
}
