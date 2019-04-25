using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public void Validate(int startNumber = 0, int maxNumber = 100)
        {
            for (int i = startNumber; i <= maxNumber; i++)
            {
                // Solution1(i);
                // Solution2(i);

                var rules = new Dictionary<int, string>
                {
                    { 3, "Fizz" },
                    { 7, "Jazz" },
                    { 5, "Buzz" }
                };
                Console.WriteLine("{0} ({1})", Rules(rules, i), i);
            }
        }

        public void Solution1(int number)
        {
            if (number % 3 == 0 && number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("FizzBuzzJazz ({0})", number);
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz ({0})", number);
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz ({0})", number);
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("Jazz ({0})", number);
            }
            else
            {
                Console.WriteLine(number);
            }
        }

        public void Solution2(int number)
        {
            string result = string.Empty;

            if (number % 3 == 0)
            {
                result += "Fizz";
            }

            if (number % 5 == 0)
            {
                result += "Buzz";
            }

            if (number % 7 == 0)
            {
                result += "Jazz";
            }

            if (result.Length == 0)
            {
                result = number.ToString();
            }
            else
            {
                result += string.Format("({0})", number.ToString());
            }

            Console.WriteLine(result);
        }

        private string Rules(IDictionary<int, string> rules, int number)
        {
            var applyRules = rules.OrderBy(x => x.Key);
            var result = string.Empty;

            foreach (var rule in applyRules)
            {
                if (number % rule.Key == 0)
                {
                    result += rule.Value;
                }
            }

            return result;
        }
    }
}