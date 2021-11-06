using System;
using System.Text;

namespace CodeWarsJadenCasingStrings
{
    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {
            StringBuilder sb = new StringBuilder();
            bool isFirst = true;
            bool isAfterSpace = false;

            foreach (char c in phrase)
            {
                if(c == ' ')
                {
                    isAfterSpace = true;
                    sb.Append(c);
                }
                else if(isFirst)
                {
                    sb.Append(c.ToString().ToUpper());
                    isFirst = false;
                }
                else if (isAfterSpace)
                {
                    sb.Append(c.ToString().ToUpper());
                    isAfterSpace = false;
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
