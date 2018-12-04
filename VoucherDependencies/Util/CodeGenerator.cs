using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherDependencies.Util
{
    class CodeGenerator
    {
        static void Main(string[] args)
        {
            RandomGenerator generator = new RandomGenerator();

            Console.WriteLine($"Do you want to customize the Number? yes or no");
            String confirm = Console.ReadLine();
            if (confirm == "no")
            {
                Console.WriteLine($"Select the character set|1= Numeric");
                Console.WriteLine($"1= Numeric ");
                Console.WriteLine($"2= Alphabet ");
                Console.WriteLine($"3= Alphanumeric ");
                String tp = Console.ReadLine();
                int inttp = Convert.ToInt32(tp);
                if (inttp == 1)
                {
                    Console.WriteLine($"Specify the lenght of the Codes");
                    String leng = Console.ReadLine();
                    int intLeng = Convert.ToInt32(leng);
                    Console.WriteLine($"How many Code do want to generate?");
                    String repi = Console.ReadLine();
                    int intRepi = Convert.ToInt32(repi);
                    if (intLeng == 0 || intRepi == 0)
                    {
                        Console.WriteLine($"The Legnth or the number of generation can not be Zero");
                    }
                    else
                    {
                        Random rnd = new Random();
                        string[] coupon = new string[intRepi];
                        for (int i = 0; i < coupon.Length; i++)
                        {
                            coupon[i] = generator.GenerateNumber(intLeng, rnd);
                        }
                        Console.WriteLine(String.Join(Environment.NewLine, coupon));
                    }
                }
                else if (inttp == 2)
                {
                    Console.WriteLine($"Specify the lenght of the Codes");
                    String leng = Console.ReadLine();
                    int intLeng = Convert.ToInt32(leng);
                    Console.WriteLine($"How many Code do want to generate?");
                    String repi = Console.ReadLine();
                    int intRepi = Convert.ToInt32(repi);
                    if (intLeng == 0 || intRepi == 0)
                    {
                        Console.WriteLine($"The Legnth or the number of generation can not be Zero");
                    }
                    else
                    {
                        Random rnd = new Random();
                        string[] coupon = new string[intRepi];
                        for (int i = 0; i < coupon.Length; i++)
                        {
                            coupon[i] = generator.GenerateAlpha(intLeng, rnd);
                        }
                        Console.WriteLine(String.Join(Environment.NewLine, coupon));
                    }
                }
                else if (inttp == 3)
                {
                    Console.WriteLine($"Specify the lenght of the Codes");
                    String leng = Console.ReadLine();
                    int intLeng = Convert.ToInt32(leng);
                    Console.WriteLine($"How many Code do want to generate?");
                    String repi = Console.ReadLine();
                    int intRepi = Convert.ToInt32(repi);
                    if (intLeng == 0 || intRepi == 0)
                    {
                        Console.WriteLine($"The Legnth or the number of generation can not be Zero");
                    }
                    else
                    {
                        Random rnd = new Random();
                        string[] coupon = new string[intRepi];
                        for (int i = 0; i < coupon.Length; i++)
                        {
                            coupon[i] = generator.GenerateCoupon(intLeng, rnd);
                        }
                        Console.WriteLine(String.Join(Environment.NewLine, coupon));

                    }
                }
                else
                {
                    Console.WriteLine($"Response must be 1 or 2 or 3");
                }


            }
            if (confirm == "yes")
            {
                Console.WriteLine($"Select the character set|1= Numeric");
                Console.WriteLine($"1= Numeric ");
                Console.WriteLine($"2= Alphabet ");
                Console.WriteLine($"3= Alphanumeric ");
                String tp = Console.ReadLine();
                int inttp = Convert.ToInt32(tp);
                if (inttp == 1)
                {
                    Console.WriteLine($"Specify the lenght of the Codes");
                    String leng = Console.ReadLine();
                    int intLeng = Convert.ToInt32(leng);
                    Console.WriteLine($"How many Code do want to generate?");
                    String repi = Console.ReadLine();
                    int intRepi = Convert.ToInt32(repi);
                    if (intLeng == 0 || intRepi == 0)
                    {
                        Console.WriteLine($"The Legnth or the number of generation can not be Zero");
                    }
                    else
                    {
                        Console.WriteLine($"Specify your Prefix. Enter -1 if u want to bypass");
                        String pri = Console.ReadLine();
                        Console.WriteLine($"Specify your Suffix. Enter -1 if u want to bypass");
                        String suf = Console.ReadLine();
                        int lpri = pri.Length;// Lenght of the preffix string
                        int lsuf = suf.Length;// Lenght of the suffix string
                        int aps = lpri + lsuf;// addition of the Lenght of the preffix and suffix
                        int diff = intLeng - aps;// differences between the original lenght of string and that of the addtion of the suffix and preffix lenght
                                                 //Check if the lenght make sense
                        if (intLeng <= aps)
                        {
                            Console.WriteLine($"ERROR:  The Length must be greater than the combination of the prefix and suffix");
                        }
                        else
                        {
                            Random rnd = new Random();
                            string[] coupon = new string[intRepi];
                            for (int i = 0; i < coupon.Length; i++)
                            {
                                coupon[i] = pri + generator.GenerateNumber(diff, rnd) + suf;
                            }
                            String gv = String.Join(Environment.NewLine, coupon);
                            Console.WriteLine(gv);
                        }
                    }
                }
                else if (inttp == 2)
                {
                    Console.WriteLine($"Specify the lenght of the Codes");
                    String leng = Console.ReadLine();
                    int intLeng = Convert.ToInt32(leng);
                    Console.WriteLine($"How many Code do want to generate?");
                    String repi = Console.ReadLine();
                    int intRepi = Convert.ToInt32(repi);
                    if (intLeng == 0 || intRepi == 0)
                    {
                        Console.WriteLine($"The Legnth or the number of generation can not be Zero");
                    }
                    else
                    {
                        Console.WriteLine($"Specify your Prefix. Enter -1 if u want to bypass");
                        String pri = Console.ReadLine();
                        Console.WriteLine($"Specify your Suffix. Enter -1 if u want to bypass");
                        String suf = Console.ReadLine();
                        int lpri = pri.Length;// Lenght of the preffix string
                        int lsuf = suf.Length;// Lenght of the suffix string
                        int aps = lpri + lsuf;// addition of the Lenght of the preffix and suffix
                        int diff = intLeng - aps;// differences between the original lenght of string and that of the addtion of the suffix and preffix lenght
                                                 //Check if the lenght make sense
                        if (intLeng <= aps)
                        {
                            Console.WriteLine($"ERROR: The Length must be greater than the combination of the prefix and suffix");
                        }
                        else
                        {
                            Random rnd = new Random();
                            string[] coupon = new string[intRepi];
                            for (int i = 0; i < coupon.Length; i++)
                            {
                                coupon[i] = pri + generator.GenerateAlpha(diff, rnd) + suf;
                            }
                            String gv = String.Join(Environment.NewLine, coupon);
                            Console.WriteLine(gv);
                        }
                    }
                }
                else if (inttp == 3)
                {
                    Console.WriteLine($"Specify the lenght of the Codes");
                    String leng = Console.ReadLine();
                    int intLeng = Convert.ToInt32(leng);
                    Console.WriteLine($"How many Code do want to generate?");
                    String repi = Console.ReadLine();
                    int intRepi = Convert.ToInt32(repi);
                    if (intLeng == 0 || intRepi == 0)
                    {
                        Console.WriteLine($"The Legnth or the number of generation can not be Zero");
                    }
                    else
                    {
                        Console.WriteLine($"Specify your Prefix. Enter -1 if u want to bypass");
                        String pri = Console.ReadLine();
                        Console.WriteLine($"Specify your Suffix. Enter -1 if u want to bypass");
                        String suf = Console.ReadLine();
                        int lpri = pri.Length;// Lenght of the preffix string
                        int lsuf = suf.Length;// Lenght of the suffix string
                        int aps = lpri + lsuf;// addition of the Lenght of the preffix and suffix
                        int diff = intLeng - aps;// differences between the original lenght of string and that of the addtion of the suffix and preffix lenght
                                                 //Check if the lenght make sense
                        if (intLeng <= aps)
                        {
                            Console.WriteLine($"ERROR:  The Length must be greater than the combination of the prefix and suffix");
                        }
                        else
                        {
                            Random rnd = new Random();
                            string[] coupon = new string[intRepi];
                            for (int i = 0; i < coupon.Length; i++)
                            {
                                coupon[i] = pri + generator.GenerateCoupon(diff, rnd) + suf;
                            }
                            String gv = String.Join(Environment.NewLine, coupon);
                            Console.WriteLine(gv);
                        }
                    }

                }
                else
                {
                    Console.WriteLine($"Response must be 1 or 2 or 3");
                }


            }
            else
            {
                Console.WriteLine($"The answer must be Yes or No");
            }

            Console.ReadKey();
        }
    }

    public class RandomGenerator
    {
        public string GenerateCoupon(int length, Random random)
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
        public string GenerateNumber(int length, Random random)
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
        public string GenerateAlpha(int length, Random random)
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

    }
}

