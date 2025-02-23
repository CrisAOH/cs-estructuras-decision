using System;

namespace EscaleraIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROGRAMA QUE REALICE LAS 4 OPERACIONES ARITMÉTICAS BÁSICAS A PARTIR DE DOS NÚMEROS. LA OPERACIÓN DESEADA SERÁ ELEGIDA POR EL USUARIO
            decimal num1, num2, resultado = 0M;
            byte opcion;

            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            Console.Write("Escoge una opción: ");
            opcion = Convert.ToByte(Console.ReadLine());

            Console.Write("Dame el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Dame el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            if (opcion == 1)
            {
                resultado = num1 + num2;
            }
            else
            {
                if (opcion == 2)
                {
                    resultado = num1 - num2;
                }
                else
                {
                    if (opcion == 3)
                    {
                        resultado = num1 * num2;
                    }
                    else
                    {
                        if (opcion == 4)
                        {
                            if (num2 != 0)
                            {
                                resultado = num1 / num2;
                            }
                            else
                            {
                                Console.WriteLine("No es posible dividir entre cero.");
                            }
                        }
                    }
                }
            }

            Console.WriteLine("El resultado es: {0}", resultado);
        }
    }
}
