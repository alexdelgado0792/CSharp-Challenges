using System.Collections.Generic;
using System.Linq;

namespace Palindrome
{
    public class PalindromeUtil
    {
        public bool IsPalindrome(string originalData)
        {
            var data = originalData.RemoveSpecialCharacters().ToLower().WithoutSpaces();

            var reverseValue = data.ReverseWord();

            return data == reverseValue;
        }

        public bool IsPalindrome(decimal originalNumber)
        {
            var number = originalNumber.WithoutDot();

            var reverseValue = number.ReverseWord();

            return number == reverseValue;
        }

        public bool IsPalindrome(int originalNumber)
        {
            var number = originalNumber.ToString();

            var reverseValue = number.ReverseWord();

            return number == reverseValue;
        }

        public dynamic IsPalindrome(IList<string> originalData)
        {
            return originalData.Select(x => x.RemoveSpecialCharacters().ToLower().WithoutSpaces())
                .Select(x => new
                {
                    original = x,
                    reverse = x.ReverseWord(),
                    IsPalidrome = (x == x.ReverseWord())
                });
        }

        public dynamic IsPalindrome(IList<decimal> originalData)
        {
            return originalData.Select(x => x.WithoutDot())
                .Select(x => new
                {
                    original = x,
                    reverse = x.ReverseWord(),
                    IsPalidrome = (x == x.ReverseWord())
                });
        }
    }
}