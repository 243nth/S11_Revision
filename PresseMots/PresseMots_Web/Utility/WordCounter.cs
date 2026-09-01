using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PresseMots.Utility
{
    public static class WordCounter
    {
        public static int Count(string input) {

            string pattern = "[^\\w]";
            var wordCount = Regex.Split(input ?? String.Empty, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline).Where(s => !string.IsNullOrWhiteSpace(s)).Count();
            return wordCount;

        }

        public static int Count(IWordCountable wordCountable) {
            return Count(wordCountable.Content);
        }
    }
}
