using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Arrays1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[3];
            double soma = 0;
            double media = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Digite a "+(i+1)+"° nota:");
                notas[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0;i < notas.Length; i++)
            {
                soma += notas[i];
                Console.WriteLine((i+1)+"° nota: " + notas[i]);
            }
            Console.WriteLine("Soma das notas: "+ soma);
            media = soma / notas.Length;
            Console.WriteLine("Media final: "+ media);
        }
    }
}
