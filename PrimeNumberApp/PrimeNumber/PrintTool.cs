using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumber
{
    public class PrintTool
    {
        public static void Print()
        {
            Console.WriteLine("--------Prime Numbers Challenge--------");

            var tool = new NumberTools();
            for (int i = 0; i <= 18; i++)
            {
                if (tool.IsPrime(i))
                {
                    Console.WriteLine("Prime Number: {0}", i);
                }
                else
                {
                    Console.WriteLine("Number: {0}", i);
                }

                var numberFactors = tool.GetNumberFactors(i);
                var primeFactors = tool.GetPrimeNumberFactors(numberFactors);

                PrintFactors(numberFactors, false);
                PrintFactors(primeFactors, true);
                PrintLargestFactor(tool.GetLargestFactor(primeFactors));
            }

            
        }

        private static void PrintFactors(IList<int> factorList, bool primeList)
        {
            if (primeList)
            {
                Console.WriteLine("Prime Factors: {0}", FortmatList(factorList));
            }
            else
            {
                Console.WriteLine("Number Factors: {0}", FortmatList(factorList));
            }
        }

        private static string FortmatList(IList<int> factorList)
        {
            var builder = string.Empty;
            foreach (var number in factorList)
            {
                builder += string.Format("{0},", number.ToString());
            }

            return builder;
        }

        private static void PrintLargestFactor(int largestFactor)
        {
            Console.WriteLine("Largest number factor is [{0}]", largestFactor);
            Console.WriteLine("------------------------------");
        }
    }
}