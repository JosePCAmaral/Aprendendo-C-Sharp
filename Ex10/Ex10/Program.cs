using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l1 = 0, l2 = 0, l3 = 0;
            Console.WriteLine("Digite o tamanho do lado 1:");
            l1 = int.Parse(Console.ReadLine());
            if (l1 != 0) {
                Console.WriteLine("Digite o tamanho do lado 2:");
                l2 = int.Parse(Console.ReadLine());
                if (l2 != 0)
                {
                    Console.WriteLine("Difite o valor do lado 3:");
                    l3 = int.Parse(Console.ReadLine());
                    if(l3 != 0)
                    {
                        int soma1 = l1 + l2;
                        if(l3 < soma1)
                        {
                            int soma2 = l2 + l3;
                            if(l1 < soma2)
                            {
                                int soma3 = l3 + l1;
                                if(l2 < soma3)
                                {
                                    int c = 0;
                                    if(l1 == l2)
                                    {
                                        c++;
                                    }
                                    if(l1 == l3)
                                    {
                                        c++;
                                    }
                                    if(l1 == l2)
                                    {
                                        c++;
                                    }
                                    if (c == 0)
                                    {
                                        Console.WriteLine("Triangulo Escaleno(3 lados diferentes)");
                                    }
                                    else if(c == 2)
                                    {
                                        Console.WriteLine("Triangulo Isósceles (2 lados iguais)");
                                    }
                                    else if (c == 3)
                                    {
                                        Console.WriteLine("Triangulo equilátero (3 lados iguais)");
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
