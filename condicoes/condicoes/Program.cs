using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insera a sua Idade:");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 18)
            {
                Console.WriteLine("Você é menor de idade");
            }
            else
            {
                Console.WriteLine("Você é maior de idade");
            }

        }
    }
}
