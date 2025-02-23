using System;

namespace InstruccionSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string color;

            Console.Write("Ingresa el color RGB para darte su código: ");
            color = Console.ReadLine();

            switch(color)
            {
                case "Red":
                    Console.WriteLine("El código RGB para {0} es: 255, 0, 0", color);
                    break;
                case "Green":
                    Console.WriteLine("El código RGB para {0} es: 0, 255, 0", color);
                    break;
                case "Blue":
                    Console.WriteLine("El código RGB para {0} es: 0, 0,255", color);
                    break;
                default:
                    Console.WriteLine("No se ha encontrado el código RGB para el color solicitado.");
                    break;
            }
        }
    }
}
