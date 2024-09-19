using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int soma = 0;
            for( int i = 0; i < 50; i++ )
            {
                Console.WriteLine("Digite o " +(i+1) +"° numero:");
                num = int.Parse(Console.ReadLine());
                soma += num;
            }
            double media = soma / 50;
            Console.WriteLine("A media dos 50 numeros é: " +media);
        }
    }
}
