using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o preço do quilo:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de quilos:");
            int q = int.Parse(Console.ReadLine());
            int v = p * q;
            Console.WriteLine("A quantidade a ser paga é: "+ v);
        }
    }
}
