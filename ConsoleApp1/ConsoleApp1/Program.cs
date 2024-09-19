using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menor = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite um nuemro:");
                int v = int.Parse(Console.ReadLine());
                if (i == 0) {
                    menor = v;
                }
                if (v < menor)
                {
                    menor = v;
                }
            }
            Console.WriteLine("O menor numero é: " +menor);
        }
    }
}
