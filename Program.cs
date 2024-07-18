using System;
using Microsoft.VisualBasic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Olá, Digite uma operação: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-----------------------------------");

            short res = short.Parse(Console.ReadLine());

            switch(res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Soma() 
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            var sum = v1 + v2;
            Console.WriteLine("O resultado da sua soma é: " + sum);
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
           Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            var sub = v1 - v2;
            Console.WriteLine("O resultado da sua subtração é: " + sub);
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            var mul = v1 * v2;
            Console.WriteLine("O resultado da sua multiplicação é: " + mul);
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            var div = v1 / v2;
            Console.WriteLine("O resultado da sua divisão é: " + div);
            Console.ReadKey();
            Menu();
        }
    }
}