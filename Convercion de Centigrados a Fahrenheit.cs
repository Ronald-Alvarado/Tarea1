using System;

namespace Convercion_de_Centigrados_a_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            String dato = " ";
            float celsius, fahrenheit;

            Console.WriteLine("Convercion de Celsius a Fahrenheit\n");
            Console.WriteLine("Dijite los Grados Celsius");
            dato = Console.ReadLine();
            celsius = Convert.ToSingle(dato);

            fahrenheit = (celsius* (9f / 5f))+32;

            Console.WriteLine("Son {0} Grados Fahrenheit",fahrenheit);

        }
    }
}
