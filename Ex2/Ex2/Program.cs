using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0, num = 0;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Digite o " + (i+1) + "° numero:");
                num = int.Parse(Console.ReadLine());
                soma += num;
            }
            Console.WriteLine("A soma dos nuemros é:" +soma);
        }
            
    }
}
