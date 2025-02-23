using System;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROGRAMA QUE DETERMINA SI UNA PERSONA ES MAYOR DE EDAD O NO
            byte edad;

            Console.Write("Dame tu edad: ");
            edad = Convert.ToByte(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad.");
            }
            else
            {
                Console.WriteLine("Eres menor de edad.");
            }
        }
    }
}
