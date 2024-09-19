using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogosdeAzar
{
    internal class Program
    {
        static Random rnd = new Random();
        static string nome = "";
        static int saldo = 0;
        static void Main(string[] args)
        {
            int op = 0;
            Console.WriteLine("Informe seu nome:");
            nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());
            if(idade < 18)
            {
                Console.Clear();
                Console.WriteLine("Você não pode acessar por ser menor de idade");
                Console.WriteLine("Saindo...");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Qual o valor do depósito inicial?");
                saldo = int.Parse(Console.ReadLine());
                do
                {
                    Console.Clear();
                    Console.WriteLine("Usuário: "+ nome+ "         Saldo: "+saldo);
                    Console.WriteLine("Bem vindo aos Jogos de Azar");
                    Console.WriteLine("\n");
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1 - Loteria");
                    Console.WriteLine("2 - Raspadinha");
                    Console.WriteLine("3 - Depositos/saques");
                    Console.WriteLine("0 - Sair");
                    Console.WriteLine("Escolha uma das opções do menu:");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Loteria();
                        break;

                        case 2:
                            Raspadinha();
                        break;

                        case 3:
                            Saldo();
                        break;

                        case 0:
                            Console.Clear();
                            Console.WriteLine("Saindo....");
                            Console.ReadKey();
                        break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Opção inválida");
                            Console.ReadKey();
                        break;
                    }

                }while (op != 0);
            }

            
        }

        private static void Saldo()
        {
            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Usuário: " + nome + "         Saldo: " + saldo);
                Console.WriteLine("\n");
                Console.WriteLine("Menu de Saldo");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("0 - Voltar");
                Console.WriteLine("Escolha uma opção:");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Depositar();
                    break;
                    case 2:
                        Sacar();
                    break;
                    case 0:
                        Console.Clear();
                    break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida");
                        Console.ReadKey();
                    break;
                }
            } while (op != 0);
        }

        private static void Sacar()
        {
            Console.Clear();
            Console.WriteLine("Usuário: " + nome + "         Saldo: " + saldo);
            Console.WriteLine("\n");
            Console.WriteLine("Opção de Saque:");
            Console.WriteLine("Quanto deseja sacar?");
            int num = int.Parse(Console.ReadLine());
            saldo -= num;
            Console.WriteLine("Novo saldo: " +saldo);
            Console.ReadKey();
        }

        private static void Depositar()
        {
            Console.Clear();
            Console.WriteLine("Usuário: " + nome + "         Saldo: " + saldo);
            Console.WriteLine("\n");
            Console.WriteLine("Opções de depósito:");
            Console.WriteLine("Quanto deseja depositar?");
            int num = int.Parse(Console.ReadLine());
            saldo += num;
            Console.WriteLine("Novo saldo: " +saldo);
            Console.ReadKey();
        }

        private static void Raspadinha()
        {
            int op = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("Usuário: " + nome + "         Saldo: " + saldo);
                Console.WriteLine("\n");
                Console.WriteLine("Opções de Raspinha:");
                Console.WriteLine("1 - RaspadinhaA");
                Console.WriteLine("2 - RaspadinhaB");
                Console.WriteLine("0 - Voltar");
                Console.WriteLine("Escolha uma Opção:");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        RaspadinhaA();
                    break;

                    case 2:
                        RaspadinhaB();
                    break;

                    case 0:
                        Console.Clear();
                    break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida.");
                        Console.ReadKey();
                    break;
                }
            } while (op != 0);
        }

        private static void RaspadinhaB()
        {
            if (saldo < 2)
            {
                Console.Clear();
                Console.WriteLine("Saldo insuficiente!");
                Console.WriteLine("Quer realizar um depósito?(s/n)");
                char e = char.Parse(Console.ReadLine());
                if (e == 's')
                {
                    Depositar();
                }
            }
            else
            {
                Console.Clear();
                saldo -= 2;
                int numP = rnd.Next(1, 10);
                int premio = rnd.Next(1, 100);

                int n1 = rnd.Next(1, 10);
                int n2 = rnd.Next(1, 10);
                int n3 = rnd.Next(1, 10);
                int n4 = rnd.Next(1, 10);
                int n5 = rnd.Next(1, 10);
                int n6 = rnd.Next(1, 10);
                int n7 = rnd.Next(1, 10);
                int n8 = rnd.Next(1, 10);
                int n9 = rnd.Next(1, 10);

                int cont = 0;

                if (n1 == numP) cont++;
                if (n2 == numP) cont++;
                if (n3 == numP) cont++;
                if (n4 == numP) cont++;
                if (n5 == numP) cont++;
                if (n6 == numP) cont++;
                if (n7 == numP) cont++;
                if (n8 == numP) cont++;
                if (n9 == numP) cont++;

                Console.WriteLine("Numero Premiado: "+numP +"   Valor do premio: "+ premio);
                Console.WriteLine("Numeros gerados:");
                Console.WriteLine(n1+ " " + n2 + " " + n3);
                Console.WriteLine(n4 + " " + n5 + " " + n6);
                Console.WriteLine(n7 + " " + n8 + " " + n9);


                if (cont >= 3)
                {
                    Console.WriteLine("PARABENS VOCE GANHOU O PREMIO DE: "+premio);
                    saldo += premio;
                    Console.WriteLine("Novo Saldo: "+saldo);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Voce não ganhou :(");
                    Console.WriteLine("Novo Saldo: "+saldo);
                    Console.ReadKey();
                }


            }
        }

        private static void RaspadinhaA()
        {
            if (saldo < 2)
            {
                Console.Clear();
                Console.WriteLine("Saldo insuficiente!");
                Console.WriteLine("Quer realizar um depósito?(s/n)");
                char e = char.Parse(Console.ReadLine());
                if (e == 's')
                {
                    Depositar();
                }
            }
            else
            {
                Console.Clear();
                saldo -= 2;
                int numP = rnd.Next(1, 10);
                int g = 0;

                int n1 = rnd.Next(1, 10); int p1 = rnd.Next(1, 100);
                int n2 = rnd.Next(1, 10); int p2 = rnd.Next(1, 100);
                int n3 = rnd.Next(1, 10); int p3 = rnd.Next(1, 100);
                int n4 = rnd.Next(1, 10); int p4 = rnd.Next(1, 100);
                int n5 = rnd.Next(1, 10); int p5 = rnd.Next(1, 100);

                Console.WriteLine("RASPADINHA A");
                Console.WriteLine("\n");
                Console.WriteLine("Numero Premiado: " + numP);
                Console.WriteLine("1° numero: " + n1 + "(" + p1 + ")");
                Console.WriteLine("1° numero: " + n2 + "(" + p2 + ")");
                Console.WriteLine("1° numero: " + n3 + "(" + p3 + ")");
                Console.WriteLine("1° numero: " + n4 + "(" + p4 + ")");
                Console.WriteLine("1° numero: " + n5 + "(" + p5 + ")");

                if (numP == n1)
                {
                    g += p1;
                    saldo += p1;
                }
                if (numP == n2)
                {
                    g += p2;
                    saldo += p2;
                }
                if (numP == n3)
                {
                    g += p3;
                    saldo += p3;
                }
                if (numP == n4)
                {
                    g += p4;
                    saldo += p4;
                }
                if (numP == n5)
                {
                    g += p5;
                    saldo += p5;
                }
                Console.WriteLine("Você ganhou um premio de: " + g);
                Console.WriteLine("Novo saldo = " + saldo);
                Console.ReadKey();
            }
        }

        private static void Loteria()
        {
            if(saldo < 5)
            {
                Console.Clear();
                Console.WriteLine("Saldo insuficiente!");
                Console.WriteLine("Quer realizar um depósito?(s/n)");
                char e = char.Parse(Console.ReadLine());
                if(e == 's')
                {
                    Depositar();
                }
            }
            else
            {
                saldo -= 5;
                int numP = rnd.Next(1000, 10000);
                int numJ = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("LOTERIA!!");
                    Console.WriteLine("\n");
                    Console.WriteLine("Escolha um numero entre 1000 e 10000:");
                    numJ = int.Parse(Console.ReadLine());
                    if(numJ < 1000 || numJ > 9999)
                    {
                        Console.Clear();
                        Console.WriteLine("Numero inválido!");
                        Console.ReadKey();
                    }

                }while (numJ < 1000 || numJ > 9999);

                if(numJ == numP)
                {
                    Console.Clear();
                    Console.WriteLine("Numero premiado: " + numP);
                    Console.WriteLine("PARABENS, VOCE GANHOU O PRIMEIRO PREMIO DA LOTERIA!!!");
                    saldo += 10000;
                    Console.WriteLine("Novo Saldo: " +saldo);
                    Console.ReadKey();
                }
                else if(numJ % 1000 == numP % 1000)
                {
                    Console.Clear();
                    Console.WriteLine("Numero premiado: " + numP);
                    Console.WriteLine("PARABENS, VOCE GANHOU O SEGUNDO PREMIO DA LOTERIA!!!");
                    saldo += 1000;
                    Console.WriteLine("Novo Saldo: " + saldo);
                    Console.ReadKey();
                }
                else if(numJ % 100 == numP % 100)
                {
                    Console.Clear();
                    Console.WriteLine("Numero premiado: " + numP);
                    Console.WriteLine("PARABENS, VOCE GANHOU O SEGUNDO PREMIO DA LOTERIA!!!");
                    saldo += 100;
                    Console.WriteLine("Novo Saldo: " + saldo);
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Voce não ganhou:(");
                    Console.WriteLine("O numero era: " +numP);
                    Console.ReadKey();
                }
            }
        }
    }
}
