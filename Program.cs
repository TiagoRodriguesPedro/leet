using System;

namespace leet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("texto a ser traduzido: ");
            Console.WriteLine(
                Console.ReadLine()

                .Replace("A", "4")
                .Replace("E", "3")
                .Replace("e", "3")
                .Replace("I", "1")
                .Replace("i", "1")
                .Replace("O", "0")
                .Replace("o", "0")
                .Replace("t", "7")
                .Replace("T", "7")
                .Replace("S", "5")

                .Replace("s", "5")
                .Replace("j", "6")
            );
         }

     }
}

