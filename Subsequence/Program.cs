using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsequence
{
    internal class Program
    {

        static public bool IsSubsequence(string s, string t)
        {
            bool check = false;
            int ind = 0;
            for(int i = 0; i < s.Length; i++)
            {
                check = false;

                for (int j = i; j < t.Length; j++)
                {
                    if (s[i] == t[j])
                    {
                        if (ind > j)
                        {
                            return false;
                        }

                        ind = j;
                        check = true;
                    }
                }

                if(!check)
                {
                    break;
                }
            }

            return check;
        }

        static void Main(string[] args)
        {
            //string s = "ace", t = "abcde";
            string s = "abc", t = "ahbgdc";
            bool res = IsSubsequence(s, t);
            Console.WriteLine($"Input: s = {s}, t = {t}");
            Console.WriteLine($"Output: {res}");
            Console.ReadKey();
        }
    }
}
