using System;
using static System.Convert;
using static System.Console;
using static System.String;


namespace ConsoleApp10
{
    class Program
    {

        static void Main(string[] args)
        {
            WriteLine("1 задание ; \n 3 задание ; \n 2 задание . ");
            int b = ToInt32(ReadLine());
            if (b == 1)
            {
                string v = ReadLine();
                int a = v.IndexOf("f");
                int count = 0;
                
                for (int i = a+1; i < v.Length; i++)
                {
                    string g = (v[i] + "");
                    if (String.Compare("f", g) == 0 )
                    {
                        WriteLine(i);
                        count++;
                        break;
                    }
                   
                }    
                if (count == 0) WriteLine(-1);
               else if (a < 0) WriteLine(-2);
             
            }
            else if (b == 3)
            { 
                int a1 = v.IndexOf("h");
                int a2 = v.LastIndexOf("h");
                string v = ReadLine();
               
                string prom = "";
                for (int i = 0; i < v.Length; i++)
                {
                    string g = (v[i] + "");
                    if (String.Compare("h", g) == 0 && i != a1 && i != a2)
                    {
                        prom = prom + "H";
                    }
                    else prom = prom + v[i];
                }
                WriteLine(prom);
            }
            else if (n == 2)
            {
                string v = ReadLine();

                string rez = "";
                string[] rus = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };
                string[] eng = { "A", "B", "V", "G", "D", "E", "E", "ZH", "Z", "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F", "KH", "TS", "CH", "SH", "SHCH", "", "Y", "", "E", "YU", "YA" };


                for (int j = 0; j < v.Length; j++)
                {
                    int i = 0;
                    while (i < rus.Length)
                    {
                        string a = v[j] + "";
                        if (String.Compare(a, rus[i]) == 0)
                        {
                            rez = rez + eng[i];
                            i++;
                        }
                        else i++;
                    }
                }
                WriteLine(rez);
            }
           
        }
    }
}
