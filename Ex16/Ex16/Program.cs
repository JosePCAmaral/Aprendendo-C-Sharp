using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = 0, soma = 0;
            for (int i = 0; i < 20; i++) {
                Console.WriteLine("Digite um valor");
                num = double.Parse(Console.ReadLine());
                soma += num;
            }
            double media = soma / 20;
            Console.WriteLine("A media é: "+media);
        }
    }
}
