using System;

namespace Tarea3_1_Meses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numeroMes;

            Console.Write("Dame un número del 1 al 12: ");
            numeroMes = Convert.ToByte(Console.ReadLine());

            switch (numeroMes)
            {
                case 1:
                    Console.WriteLine("El mes correspondiente al número {0} es Enero.", numeroMes);
                    break;
                case 2:
                    Console.WriteLine("El mes correspondiente al número {0} es Febrero.", numeroMes);
                    break;
                case 3:
                    Console.WriteLine("El mes correspondiente al número {0} es Marzo.", numeroMes);
                    break;
                case 4:
                    Console.WriteLine("El mes correspondiente al número {0} es Abril.", numeroMes);
                    break;
                case 5:
                    Console.WriteLine("El mes correspondiente al número {0} es Mayo.", numeroMes);
                    break;
                case 6:
                    Console.WriteLine("El mes correspondiente al número {0} es Junio.", numeroMes);
                    break;
                case 7:
                    Console.WriteLine("El mes correspondiente al número {0} es Julio.", numeroMes);
                    break;
                case 8:
                    Console.WriteLine("El mes correspondiente al número {0} es Agosto.", numeroMes);
                    break;
                case 9:
                    Console.WriteLine("El mes correspondiente al número {0} es Septiembre.", numeroMes);
                    break;
                case 10:
                    Console.WriteLine("El mes correspondiente al número {0} es Octubre.", numeroMes);
                    break;
                case 11:
                    Console.WriteLine("El mes correspondiente al número {0} es Noviembre.", numeroMes);
                    break;
                case 12:
                    Console.WriteLine("El mes correspondiente al número {0} es Diciembre.", numeroMes);
                    break;
                default:
                    Console.WriteLine("No existe un mes que corresponda al número {0}.", numeroMes);
                    break;
            }
        }
    }
}
