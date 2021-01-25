using System;

namespace frame
{
    class Program
    {
        static void Main()
        {
            static void Main(string[] args)
            {
                WriteTextWithBorder("Menu:");
                WriteTextWithBorder("");
                WriteTextWithBorder(" ");
                WriteTextWithBorder("Game Over!");
                WriteTextWithBorder("Select level:");
            }
            static void WriteTextWithBorder(string text)
            {
                ToSymbols(text);

                Console.Write("| ");
                Console.Write(text);
                Console.WriteLine(" |");

                ToSymbols(text);
            }

            static void ToSymbols(string text)
            {
                Console.Write('+');
                for (int i = 1; i < text.Length + 3; i++)
                    Console.Write('-');
                Console.WriteLine('+');
            }
        }
    }
}
