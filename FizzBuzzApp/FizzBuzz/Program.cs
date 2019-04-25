using System;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var extension = new FizzBuzz();
            extension.Validate(-10,10);

            Console.ReadKey();
        }
    }
}
