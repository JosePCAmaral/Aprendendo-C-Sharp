using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um Código:");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 001:
                    Console.WriteLine("001 - parafuso");
                    break;
                case 002:
                    Console.WriteLine("002 - porca");
                    break;
                case 003:
                    Console.WriteLine("003 prego");
                    break;
                default:
                    Console.WriteLine("Código não definido");
                    break;
            }
        }
    }
}
