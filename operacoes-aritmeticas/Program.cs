using operacoes_aritmeticas;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string logo = ($"-----------------------------------------{Environment.NewLine}------------- Calculadora ---------------{Environment.NewLine}-----------------------------------------");
        Console.WriteLine(logo);
        string continua = ("Digite qualquer tecla para continuar...");


        Calculadora calculadora = new();

        

        while (true)
        {   Console.Clear();
            Console.WriteLine(logo);
            Console.WriteLine("Digite qual operação aritmética você gostaria de realizar:");
            Console.WriteLine($"{Environment.NewLine}Opções:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine($"5 - Sair{Environment.NewLine}");
            Console.Write($"{Environment.NewLine}Escolha uma opção: ");
            int operacaoAritmetica = int.Parse(Console.ReadLine());

            if (operacaoAritmetica == 5)
            {   
                Console.Clear();
                Console.WriteLine(logo);
                Console.WriteLine("Calculadora finalizada");
                break;
            }
            else if(operacaoAritmetica == 1)
            {
                Console.Clear();
                Console.WriteLine(logo);
                Console.WriteLine("Digite dois números para somar:");
                calculadora.num1 = double.Parse(Console.ReadLine());
                calculadora.num2 = double.Parse(Console.ReadLine());
                double resultado = calculadora.Somar();
                calculadora.ImprimirResultado(resultado);
                Console.WriteLine(continua);
                Console.ReadKey();

            }
            else if (operacaoAritmetica == 2)
            {
                Console.Clear();
                Console.WriteLine(logo);
                Console.WriteLine("Digite dois números para subtrair:");
                calculadora.num1 = double.Parse(Console.ReadLine());
                calculadora.num2 = double.Parse(Console.ReadLine());
                double resultado = calculadora.Subtrair();
                calculadora.ImprimirResultado(resultado);
                Console.WriteLine(continua);
                Console.ReadKey();

            }
            else if (operacaoAritmetica == 3)
            {
                Console.Clear();
                Console.WriteLine(logo);
                Console.WriteLine("Digite dois números para multiplicar:");
                calculadora.num1 = double.Parse(Console.ReadLine());
                calculadora.num2 = double.Parse(Console.ReadLine());
                double resultado = calculadora.Multiplicar();
                calculadora.ImprimirResultado(resultado);
                Console.WriteLine(continua);
                Console.ReadKey();
            }
            else if (operacaoAritmetica == 4)
            {
                Console.Clear();
                Console.WriteLine(logo);
                Console.WriteLine("Digite dois números para dividir:");
                calculadora.num1 = double.Parse(Console.ReadLine());
                calculadora.num2 = double.Parse(Console.ReadLine());
                while (calculadora.num2 == 0)
                {
                    Console.WriteLine("Digite um número diferente de 0 para o Divisor:");
                    calculadora.num2 = double.Parse(Console.ReadLine());
                }

                double resultado = calculadora.Divide();
                calculadora.ImprimirResultado(resultado);
                Console.WriteLine(continua);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Opção inválida. Escolha novamente.");
            }

        
        }
    }
}