using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoucherDependencies.Util;

namespace VoucherDependencies.Domain
{
    public class Code_Config
    {
        private readonly string prefix;
        private readonly string suffix;
        private readonly int length;
        private readonly CharSet charset;

        public Code_Config(string prefix, string suffix, int length, CharSet charset)
        {
            this.prefix = prefix;
            this.suffix = suffix;
            this.length = length;
            this.charset = charset;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
