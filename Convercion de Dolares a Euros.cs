using System;

namespace Convercion_de_Dolares_a_Euros
{
    class Program
    {
        static void Main(string[] args)
        {
            String dato = " ";
            float dolar, euro, cambio;

            Console.WriteLine("Conversion de Dolar a Euro\n");
            Console.Write("Dijite el cambio del dia del Euro:   ");
            dato = Console.ReadLine();
            cambio = Convert.ToSingle(dato);

            Console.Write("Dijite los dolares a Cambiar:    ");
            dato = Console.ReadLine();
            dolar = Convert.ToSingle(dato);

            euro = dolar * cambio;

            Console.WriteLine("Su Cambio es de {0} euros", euro);
        }
    }
}
