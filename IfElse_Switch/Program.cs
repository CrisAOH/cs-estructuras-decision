using System;

namespace IfElse_Switch
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

            switch(opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No es posible dividir entre 0.");
                    }
                    break;
                default:
                    Console.WriteLine("Ingresa una opción válida.");
                    break;
            }

            Console.WriteLine("El resultado es: {0}", resultado);
        }
    }
}
