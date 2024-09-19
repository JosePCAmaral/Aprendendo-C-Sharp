using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculador de Area triangular!!");
            Console.WriteLine("Digite a altura do triangulo:");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a base do triangulo:");
            int b = int.Parse(Console.ReadLine());
            double a = (b * h) / 2;
            Console.WriteLine("A area do triangolo é: " +a);
        }
    }
}
