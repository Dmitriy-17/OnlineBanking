
using System.Text.RegularExpressions;

namespace System
{
    public static class StringValidEx
    {
        public static bool IsEmail(this string str)
        {
            return new Regex(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}").IsMatch(str);
        }

        public static bool IsPhone(this string str)
        {
            return new Regex(@"(\+?\d[- .]*){7,13}").IsMatch(str);
        }
        public static bool LessThen(this string str, int max)
        {
            return (str ?? "").Length <= max;
        }

        public static bool MoreThen(this string str, int min)
        {
            return (str ?? "").Length >= min;
        }

        public static bool InRange(this string str, int min, int max)
        {
            var len = (str ?? "").Length;
            return min <= len && len <= max;
        }
    }
}