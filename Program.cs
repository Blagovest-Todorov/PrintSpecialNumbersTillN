using System;

namespace SpecialNumbersSumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());           

            for (int i = 1; i <= num; i++)
            {
                int sumDigits = 0;
                int iNum = i;

                while(iNum > 0)
                {
                    int digit = iNum % 10;
                    sumDigits += digit;
                    iNum = iNum / 10;                   
                }

                if (sumDigits == 5 || sumDigits == 7 || sumDigits == 11)
                {
                    Console.WriteLine($"{i} -> True");                    
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }                
            }
        }
    }
}
