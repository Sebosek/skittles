using System.Linq;

namespace Skittles.Extensions
{
    public static class StringExtensions
    {
        public static string SanityFilename(this string file) => file.Replace(" ", "-").ToLowerInvariant();

        public static string JustFilename(this string file) => string.Join(" ", file.Split('.').Reverse().Skip(1).Reverse());

        public static string ToUpperFirst(this string s) => char.ToUpper(s[0]) + s.Substring(1);
    }
}