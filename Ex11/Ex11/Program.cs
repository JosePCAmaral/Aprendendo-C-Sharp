using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o codigo do produto:");
            int cod = int.Parse(Console.ReadLine());
            if(cod == 001)
            {
                Console.WriteLine("Código 001 - parafuso");
            }
            else if(cod == 002)
            {
                Console.WriteLine("Código 002 - porca");
            }
            else if (cod == 003)
            {
                Console.WriteLine("Código 003 - prego");
            }
            else
            {
                Console.WriteLine("Código não definido");
            }
        }
    }
}
