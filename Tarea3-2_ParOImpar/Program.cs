using System;

namespace Tarea3_2_ParOImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroCadena;
            int numero;


            Console.Write("Ingrese un número: ");
            numeroCadena = Console.ReadLine();

            if (int.TryParse(numeroCadena, out numero))
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("{0} es un número par.", numero);
                }
                else
                {
                    Console.WriteLine("{0} es un número impar.", numero);
                }
            }
            else
            {
                Console.WriteLine("Por favor, proporciona un número entero.");
            }
        }
    }
}
