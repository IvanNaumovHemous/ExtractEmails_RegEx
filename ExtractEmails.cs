using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var RegexMatches = GetRegexMatches();
            PrintRegexMatches(RegexMatches);
        }

        private static void PrintRegexMatches(MatchCollection regexMatches)
        {
            foreach (Match item in regexMatches)
            {
                Console.WriteLine(item);
            }
        }

        private static MatchCollection GetRegexMatches()
        {
            string text = Console.ReadLine();
            string pattern = @"\w+.\w+@\w+.\w+\.?\w+";

            var matches = Regex.Matches(text, pattern);
            return matches;
        }
    }
}
