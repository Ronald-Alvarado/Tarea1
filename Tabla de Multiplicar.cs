using System;

namespace Tabla_de_Multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            String dato = " ";
            int numero;
            int operacion;

            Console.WriteLine("Tabla de Multiplicar de un Numeron\n");

            Console.Write("Digite un Numero: ");
            dato = Console.ReadLine();
            numero = Convert.ToInt32(dato);

            Console.WriteLine("\nLa tabla de Multiplicar del numero {0} es: ", numero);

            for (int i = 0; i <= 10; i++)
            {
                operacion = numero * i;
                Console.WriteLine("{0} x {1} = {2}", numero, i, operacion);
            }
        }
    }
}
