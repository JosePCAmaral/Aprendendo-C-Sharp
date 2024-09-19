using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double t = 0;
            Console.WriteLine("Verificador de troco!!");
            Console.WriteLine("Digite o valor pago:");
            double v = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço do produto:");
            double p = double.Parse(Console.ReadLine());
            if (v > p) {
                t = v - p;
            }
            else
            {
                double f = p - v;
                Console.WriteLine("Falta" + f + "para pagar!!");
            }
            Console.WriteLine("O troco é: " +t);
        }
    }
}
