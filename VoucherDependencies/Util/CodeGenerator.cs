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
                string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                StringBuilder result = new StringBuilder(length);
                for (int i = 0; i < length; i++)
                {
                    result.Append(characters[random.Next(characters.Length)]);
                }
                return result.ToString();
            }

            public string getGeneratedCode(string prefix, string suffix, int length, string charset)
            {
                int prefixLen = prefix.Length;
                int suffixLen = suffix.Length;
                int codeLength = length - (prefixLen + suffixLen);
                
                CodeGenerator randgen = new CodeGenerator();

                if (charset=="0")
                {
                    code = prefix + randgen.GenerateNumeric(codeLength) +suffix;
                }
                else if (charset == "1")
                {
                    code = prefix + randgen.GenerateAlphabetic(codeLength) + suffix;
                }
                else if (charset == "2")
                {
                    code = prefix + randgen.GenerateAlphaNumeric(codeLength) + suffix;
                }

                return code;
            }

        }
  
}

