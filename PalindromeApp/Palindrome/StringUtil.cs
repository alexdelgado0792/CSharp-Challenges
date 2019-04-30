using System.Linq;
using System.Text.RegularExpressions;

namespace Palindrome
{
    public static class StringUtil
    {
        private const string Space = " ";
        private const string Dot = ".";
        private const string RegexPattern = @"[^0-9a-zA-Z ]+";


        public static string WithoutSpaces(this string value)
        {
            return value.Replace(Space, string.Empty);
        }

        public static string WithoutDot(this decimal value)
        {
            return value.ToString().Replace(Dot, string.Empty);
        }

        public static string ReverseWord2(this string data)
        {
            return new string(data.Select((value, index) => new { value, index })
                                         .OrderByDescending(x => x.index)
                                         .Select(x => x.value)
                                         .ToArray());
        }

        public static string ReverseWord(this string value)
        {
            return new string(value.Reverse().ToArray());
        }

        public static string RemoveSpecialCharacters(this string value)
        {
            return Regex.Replace(value, RegexPattern, string.Empty);
        }
    }
}