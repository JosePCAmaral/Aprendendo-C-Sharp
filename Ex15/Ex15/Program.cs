using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do carro:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o preço de fabrica do carro:");
            int p = int.Parse(Console.ReadLine());
            int i = (p / 100) * 45;
            int f = (p / 100) * 28;
            p += i;
            p += f;
            Console.WriteLine("O carro "+nome +" tem o valor final de: " +p);
        }
    }
}
