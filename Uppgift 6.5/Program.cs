using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Längsta meddelande mellan \"hdwahdjsanndbwa\" och \"heheheha\" är " + Längst("hdwahdjsanndbwa", "heheheha"));
            Console.WriteLine("Längsta talet mellan \"123456789\" och \"4892147218\" är " + Längst(12345678, 489214721));
        }

        static int Längst(int tal1, int tal2)
        {
            if (tal1.ToString().Length > tal2.ToString().Length)
            {
                return tal1;
            }

            else if (tal1.ToString().Length < tal2.ToString().Length)
            {
                return tal2;
            }

            else
            {
                return tal1;
            }
        }

        static string Längst(string text1, string text2)
        {
            if (text1.Length > text2.Length)
            {
                return text1;
            }

            else if (text1.Length < text2.Length)
            {
                return text2;
            }

            else
            {
                return text1;
            }
        }
    }
}