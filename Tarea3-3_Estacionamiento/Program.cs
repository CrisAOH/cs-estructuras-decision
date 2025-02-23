using System;

namespace Tarea3_3_Estacionamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float minutos;

            Console.Write("Ingresa el tiempo que estuviste en el estacionamiento (en minutos).");
            minutos = Convert.ToSingle(Console.ReadLine());

            if (minutos >= 0 && minutos <= 60)
            {
                Console.WriteLine("Paga $5.00, por favor.");
            } else
            {
                if (minutos > 60 && minutos <= 120 )
                {
                    Console.WriteLine("Paga $15.00, por favor.");
                }
                else
                {
                    if (minutos > 120)
                    {
                        Console.WriteLine("Paga $40.00, por favor.");
                    }
                }
            }
        }
    }
}
