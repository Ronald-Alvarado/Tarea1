using System;

namespace Verificar_si_un_Numero_es_Par_o_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            String dato = " ";
            int numero;

            Console.WriteLine("Verificacion de un Numero (Par o Impar)\n");
            Console.Write("Digite un Numero: ");
            dato = Console.ReadLine();
            numero = Convert.ToInt32(dato);

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero {0} es Par", numero);
            }
            else
            {
                Console.WriteLine("El numero {0} es Impar", numero);
            }

        }
    }
}
