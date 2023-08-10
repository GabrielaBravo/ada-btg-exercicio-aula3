using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacoes_aritmeticas
{
    internal class Calculadora
    {
        public double num1;
        public double num2;
        public double Somar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtrair(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicar(double num1, double num2)
        {
            return (num1 * num2);
        }

        public double Divide(double num1, double num2)
        {
            return (num1 / num2);
        }

        public void ImprimirResultado(double resultado)
        {
            Console.WriteLine($"O valor da operação é {resultado}");
        }
    }
}
