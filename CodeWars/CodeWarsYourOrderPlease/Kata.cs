using System;
using System.Linq;
using System.Text;

namespace CodeWarsYourOrderPlease
{
    public static class Kata
    {
        public static string Order(string words)
        {
            char[] separators = new char[] { ' ', '.' };
            string[] subs = words.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] sortStr = new string[subs.Length];
            foreach (string s in subs)
            {
                char ch = s.Where(x => Char.IsDigit(x)).First();
                int i = ch - '1';
                sortStr[i] = s;
            }
            StringBuilder sb = new StringBuilder(words.Length);
            sb.AppendJoin(' ', sortStr);
            return sb.ToString();
        }

        static void Main(string[] args)
        {

            Console.WriteLine(Kata.Order("is2 Thi1s T4est 3a"));
            Console.WriteLine("expexted: Thi1s is2 3a T4est");
        }
    }
}
