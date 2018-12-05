using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherDependencies.Util
{
    class CodeGenerator
    {
            Random random;
            string code;
            private string GenerateAlphaNumeric(int length)
            {
            // Generate a random number
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                StringBuilder result = new StringBuilder(length);
                for (int i = 0; i < length; i++)
                {
                    result.Append(characters[random.Next(characters.Length)]);
                }
                return result.ToString();
            }
            private string GenerateNumeric(int length)
            {
            // Generate a random number
             Random random = new Random();
            string characters = "0123456789";
                StringBuilder result = new StringBuilder(length);
                for (int i = 0; i < length; i++)
                {
                    result.Append(characters[random.Next(characters.Length)]);
                }
                return result.ToString();
            }
            private string GenerateAlphabetic(int length)
            {
            // Generate a random number
            Random random = new Random();
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                StringBuilder result = new StringBuilder(length);
                for (int i = 0; i < length; i++)
                {
                    result.Append(characters[random.Next(characters.Length)]);
                }
                return result.ToString();
            }

            public async Task<string> getGeneratedCode(string prefix, string suffix, int length, CharSet charset)
            {
                int prefixLen = prefix.Length;
                int suffixLen = suffix.Length;
                int codeLength = length - (prefixLen + suffixLen);
                
                CodeGenerator randgen = new CodeGenerator();

                if (charset.Equals(CharSet.Numeric))
                {
                    code = prefix + randgen.GenerateNumeric(codeLength) +suffix;
                }
                else if (charset.Equals(CharSet.Alphabetic))
                {
                    code = prefix + randgen.GenerateAlphabetic(codeLength) + suffix;
                }
                else if (charset.Equals(CharSet.Alphanumeric))
                {
                    code = prefix + randgen.GenerateAlphaNumeric(codeLength) + suffix;
                }

                return code;
            }

        }
  
}

