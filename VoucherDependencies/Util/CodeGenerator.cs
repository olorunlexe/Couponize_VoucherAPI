using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherDependencies.Util
{
    public class CodeGenerator
    {
        Random random = new Random();
        StringBuilder result;
        string code;
        private string GenerateAlphaNumeric(int length)
        {
            // Generate a random number
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            result = new StringBuilder(length);
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
            result = new StringBuilder(length);
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
            result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            return result.ToString();
        }

        public async Task<string> GetGeneratedCode(string prefix, string suffix, int length, CharSet charset)
        {
            int prefixLen = prefix.Length;
            int suffixLen = suffix.Length;
            int codeLength = length - (prefixLen + suffixLen);

            CodeGenerator randgen = new CodeGenerator();

            switch (charset)
            {
                case CharSet.Numeric:
                    return code = prefix + randgen.GenerateNumeric(codeLength) + suffix;
                case CharSet.Alphabetic:
                    return code = prefix + randgen.GenerateAlphabetic(codeLength) + suffix;
                case CharSet.Alphanumeric:
                    return code = prefix + randgen.GenerateAlphaNumeric(codeLength) + suffix;
            }

            //if (charset.Equals(CharSet.Numeric))
            //{
            //    code = prefix + randgen.GenerateNumeric(codeLength) + suffix;
            //}
            //else if (charset.Equals(CharSet.Alphabetic))
            //{
            //    code = prefix + randgen.GenerateAlphabetic(codeLength) + suffix;
            //}
            //else if (charset.Equals(CharSet.Alphanumeric))
            //{
            //    code = prefix + randgen.GenerateAlphaNumeric(codeLength) + suffix;
            //}

            return code;
        }
        
    }

}

