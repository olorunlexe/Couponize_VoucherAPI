using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherDependencies.Domain
{
    public class MetaData
    {
        public Dictionary<bool,string> Meta_Data { get; set; }

        public MetaData(bool test, string locale)
        {
            Meta_Data = new Dictionary<bool, string>();
            Meta_Data.Add(test, locale);
        }
    }
}
