namespace operacoes_aritmeticas
{
    internal class Calculadora
    {
        public double num1;
        public double num2;
        public double Somar()
        {
            return num1 + num2;
        }

        public double Subtrair()
        {
            return num1 - num2;
        }

        public double Multiplicar()
        {
            return (num1 * num2);
        }

        public double Divide()
        {
            return (num1 / num2);
        }

        public void ImprimirResultado(double resultado)
        {
            Console.WriteLine($"O valor da operação é {resultado}");
        }
    }
}
