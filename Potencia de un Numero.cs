using System;

namespace Potencia_de_un_Numero
{
    class Program
    {
        static void Main(string[] args)
        {
            String dato = " ";
            int i = 0;
            int base1, potencia, resultado;

            Console.WriteLine("Potencia de un Numero\n");

            Console.Write("Digite un Numero: ");
            dato = Console.ReadLine();
            base1 = Convert.ToInt32(dato);

            Console.Write("Digite una Potencia: ");
            dato = Console.ReadLine();
            potencia = Convert.ToInt32(dato);

            resultado = base1;
            do {
                resultado *= base1;

                i++;
            } while (i < potencia-1);

            Console.WriteLine("El numero {0} Elevado a la {1} potencia es: {2}", base1, potencia, resultado);
        }
    }
}
