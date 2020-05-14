using System;

namespace ViLibrary
{
    public class lib1
    {
        static public string stpow(string k, int b)
        {
            string k1 = k;
            for (int s = 0; s < b - 1; s++)
            {
                k = k + k1;
            }
            return (k);
        }
        static public string rev(string a)
        {
            string l = "";
            for (int s = a.Length - 1; s > -1; s--)
            {
                l = l + a[s] + "";
            }
            return (l);
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

