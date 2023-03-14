using Projetos09.App;
using System;

namespace Projetos09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite o número 1 para realizar uma operação ou número 0 para sair:");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    novoMenu();
                }

                else if (opcao != 0)
                {
                    Console.WriteLine("\nNúmero digitado inválido.");
                }

                else
                {
                    opcao = 0;
                    Console.WriteLine("\nFim!");
                }
            }
            while (opcao == 1);
        }

        private static void novoMenu()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Digite o número para a operação que deseja realizar:");
            Console.WriteLine("1: Soma;");
            Console.WriteLine("2: Subtração;");
            Console.WriteLine("3: Multiplicação;");
            Console.WriteLine("4: Divisão;");
            Console.WriteLine("---------------------------------------------------------\n");

            int novoMenu;
            novoMenu = int.Parse(Console.ReadLine());
            if (novoMenu >= 1 && novoMenu <= 4)
            {
                operacaoEscolhida(novoMenu);
            }
            else
            {
                Console.WriteLine("\nOpção inválida.");
            }
        }

        private static void operacaoEscolhida(int escolha)
        {
            double numero1 = 0, numero2 = 0;
            switch(escolha)
            {
                case 1:
                    Console.Write("\nDigite o primeiro valor: ");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.Write("\nDigite o segundo valor: ");
                    numero2 = double.Parse(Console.ReadLine());
                    Calculadora calculadora1;
                    calculadora1 = new Calculadora(numero1, numero2);
                    double resultado1 = calculadora1.Soma();
                    Console.WriteLine("\nO resultado da soma será: " + resultado1 + "\n");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("\nDigite o primeiro valor:");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("\nDigite o segundo valor:");
                    numero2 = double.Parse(Console.ReadLine());
                    Calculadora calculadora2;
                    calculadora2 = new Calculadora(numero1, numero2);
                    double resultado2 = calculadora2.Subtracao();
                    Console.WriteLine("\nO resultado da subtração será: " + resultado2 + "\n");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("\nDigite o primeiro valor:");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("\nDigite o segundo valor");
                    numero2 = double.Parse(Console.ReadLine());
                    Calculadora calculadora3;
                    calculadora3 = new Calculadora(numero1, numero2);
                    double resultado3 = calculadora3.Multiplicacao();
                    Console.WriteLine("\nO resultado da multiplicação será: " + resultado3 + "\n");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("\nDigite o primeiro valor:");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("\nDigite o segundo valor");
                    numero2 = double.Parse(Console.ReadLine());
                    Calculadora calculadora4;
                    calculadora4 = new Calculadora(numero1, numero2);
                    double resultado4 = calculadora4.Divisao();
                    Console.WriteLine("\nO resultado da divisão será: " + resultado4 + "\n");
                    Console.ReadKey();
                    break;
            }

        }
    }
}
