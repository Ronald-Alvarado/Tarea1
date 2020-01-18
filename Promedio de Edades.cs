using System;

namespace Promedio_de_Edades
{
    class Program
    {
        static void Main(string[] args)
        {
            String dato = " ";
            int cantidad, edad, suma, mayor, menor;
            int i = 0;
            float promedio;

            Console.WriteLine("Promedio de Edades\n");

            Console.Write("Cuantas edades Desea digitar: ");
            dato = Console.ReadLine();
            cantidad = Convert.ToInt32(dato);

            Console.Write("\nDigite una Edad: ");
            dato = Console.ReadLine();
            edad = Convert.ToInt32(dato);

            mayor = edad;
            menor = edad;
            suma = edad;

            do {

                Console.Write("\nDigite una Edad: ");
                dato = Console.ReadLine();
                edad = Convert.ToInt32(dato);

                suma += edad;

                if(edad > mayor)
                {
                    mayor = edad;
                }
                else if (edad < menor)
                {
                    menor = edad;
                }

                i++;
            } while (i < cantidad-1);

            promedio = suma / cantidad;

            Console.WriteLine("\nEl promedio es {0}", promedio);
            Console.WriteLine("La edad Mayor es {0}", mayor);
            Console.WriteLine("La edad Menor es {0}", menor);
        }
    }
}
