using System;

namespace Verificar_que_dia_es
{
    class Program
    {
        static void Main(string[] args)
        {
            String dato = " ";
            int numero;

            Console.WriteLine("Que dia es?\n");

            Console.Write("Digite un numero del 1 al 7: ");
            dato = Console.ReadLine();
            numero = Convert.ToInt32(dato);

            switch (numero) {
                case 1:
                    Console.WriteLine("\nEs Domingo!");
                    break;
                case 2:
                    Console.WriteLine("\nEs Lunes!");
                    break;
                case 3:
                    Console.WriteLine("\nEs Martes!");
                    break;
                case 4:
                    Console.WriteLine("\nEs Miercoles!");
                    break;
                case 5:
                    Console.WriteLine("\nEs Jueves!");
                    break;
                case 6:
                    Console.WriteLine("\nEs Viernes!");
                    break;
                case 7:
                    Console.WriteLine("\nEs Sabado!");
                    break;
            }

        }
    }
}
