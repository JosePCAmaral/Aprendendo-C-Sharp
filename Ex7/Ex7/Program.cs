using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um vlaor:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite  outro valor:");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("O mair numero é: " + num1);
            }
            else
            {
                Console.WriteLine("O maior numero é: " +num2);
            }
        }
    }
}
