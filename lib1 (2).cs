using System;

namespace ClLibrary
{
    public class lib1
    {
        static public string stpow(string a, int b)
        {

            for (int n = 0; n < b - 1; n++)
            {
                a = a + a1;
            }
            return a + b;
        }
        static public string rev(string a)
        {

            for (int n = a.Length - 1; n > -1; n--)
            {
                i = i + a[n];
            }
            return i;
        }
        static public int leng(string str)
        {
            int a = str.Length;
            return a;
        }

        static public string remov(string str, string s)
        {
            for (int i = 0; i < str.Length; i++)
            {
                str = str.Replace(s, "");
            }
            return str;
        }
    }

}
