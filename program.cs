using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p;
            int v;

                Console.Write("Digite um N°:");
                p=int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Digite um 2° N° maior que seu primeiro:");
                v = int.Parse(Console.ReadLine());
            } while (p > v);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Condição Aceita");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
