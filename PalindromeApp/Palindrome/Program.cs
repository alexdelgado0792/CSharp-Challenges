using System;

namespace Palindrome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var palindrome = new PalindromeUtil();

            string str = "racecar";
            string str2 = "stack catS";
            string str3 = "Anita_lava$ la ()tina";
            string str4 = "race car_*#@-!|°?¡¿'´+-/%";
            decimal num = 12.321m;
            decimal num2 = 10.392m;
            int number = 1012;


            Console.WriteLine($"{str}  ->  {palindrome.IsPalindrome(str)}");
            Console.WriteLine($"{str2}  ->  {palindrome.IsPalindrome(str2)}");
            Console.WriteLine($"{str3}  ->  {palindrome.IsPalindrome(str3)}");
            Console.WriteLine($"{str4}  ->  {palindrome.IsPalindrome(str4)}");
            Console.WriteLine($"{num}   ->  {palindrome.IsPalindrome(num)}");
            Console.WriteLine($"{num2}   ->  {palindrome.IsPalindrome(num2)}");
            Console.WriteLine($"{number}   ->  {palindrome.IsPalindrome(number)}");


            Console.ReadKey();
        }
    }
}
