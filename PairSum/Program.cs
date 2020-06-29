using System.Collections.Generic;

namespace PairSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4 };
            var a = HasPair(numbers, 8);
            int[] numbers2 = new int[] { 1, 2, 4, 4 };
            var b = HasPair(numbers2, 8);
        }

        private static bool HasPair(IEnumerable<int> numbers, int sum)
        {
            var complements = new List<int>();

            foreach (var value in numbers)
            {
                if (complements.Contains(value))
                {
                    return true;
                }
                complements.Add(sum - value);
            }


            return false;
        }
    }
}
