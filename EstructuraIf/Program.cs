using System;

namespace EstructuraIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SOLICITAR UN NUMERO AL USUARIO Y DETERMINAR SI ES POSITIVO O NEGATIVO
            double numero;

            Console.Write("Dame el número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }

            if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
        }
    }
}
