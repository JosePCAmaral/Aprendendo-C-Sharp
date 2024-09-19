using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero:");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 1)
            {
                Console.WriteLine("Esse nuemro é impar!");
            }
            else {
                Console.WriteLine("Esse nuemro é par!");
            }


        }
    }
}
