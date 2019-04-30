using System.Collections.Generic;
using System.Linq;

namespace PrimeNumber
{
    public class NumberTools
    {
        public bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            bool isPrime = true;
            for (int i = 2; i < number; i++)
            {
                if (number != i && number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }

        public IList<int> GetNumberFactors(int number)
        {
            var factorList = new List<int>();


            //removed number 1 and itself.
            //for (int i = 1; i <= number; i++)
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    factorList.Add(i);
                }
            }

            return factorList;
        }

        public IList<int> GetPrimeNumberFactors(IList<int> numbers)
        {
            var primeFactorNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if (IsPrime(number))
                {
                    primeFactorNumbers.Add(number);
                }
            }

            return primeFactorNumbers;
        }

        public int GetLargestFactor(IList<int> numbers)
        {
            if (numbers.Any())
            {
                return numbers.Last();
            }

            return 0;
        }
    }
}