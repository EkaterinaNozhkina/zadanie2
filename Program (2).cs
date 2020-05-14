using System;
using ClassLibrary;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(lib1.stpow("ha", 4));
            Console.WriteLine(lib1.rev("hello"));
            Console.WriteLine(lib1.remov("aHeallao", "a"));
            Console.WriteLine(lib1.leng("Hello, friends!"));
        }
    }
}
