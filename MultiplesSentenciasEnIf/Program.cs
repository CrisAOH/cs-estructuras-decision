using System;

namespace MultiplesSentenciasEnIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROGRAMA QUE HACE LA DIVISIÓN DE DOS NÚMEROS
            double divisor, dividendo, resultado;

            Console.Write("Dame el dividendo: ");
            dividendo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dame el divisor: ");
            divisor = Convert.ToDouble(Console.ReadLine());

            if (divisor != 0)
            {
                resultado = dividendo / divisor;
                Console.WriteLine("{0} / {1} = {2}", dividendo, divisor, resultado);
            }

        }
    }
}
