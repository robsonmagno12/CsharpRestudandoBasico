using System;

namespace Calculator
{
    class program
    {
        static void Main(string[] args)
        {

            Menu();
        }
        
        static void Menu()
        {
            Console.WriteLine("Bem-vindo a calculadora escolha a opção: ");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - DIVISÃO");
            Console.WriteLine("4 - MULTIPLICAÇÃO");
            Console.WriteLine("5 - SAIR");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Selecione uma das opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res) 
            {
                case 1:
                    Soma(); 
                    break;

                case 2:
                    Subtracao();
                    break;

                case 3:
                    Divisao();
                    break;

                case 4:
                    Multiplicao();
                    break;

                case 5: System.Environment.Exit(0); break;

                default: Menu(); break;

            }
        }

        static void Soma() 
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 + v2;
            Console.WriteLine("");
            Console.WriteLine($"O resultado da soma é  {result}");
            Menu();
        }
        static void Subtracao()
        {
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Primeiro valor");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 - v2;

            Console.WriteLine("");
            Console.WriteLine($" O resultado da subtração é: {result}");
            Menu();

        }
        static void Divisao()
        {
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Primeiro valor");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 / v2;

            Console.WriteLine("");
            Console.WriteLine($" O resultado da divisão é: {result}");
            Menu();

        }
        static void Multiplicao()
        {
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Primeiro valor");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 * v2;

            Console.WriteLine("");
            Console.WriteLine($" O resultado da multiplicação é: {result}");
            Menu();

        }
    }
}
