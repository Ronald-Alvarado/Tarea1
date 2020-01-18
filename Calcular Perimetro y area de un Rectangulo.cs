using System;

namespace Calcular_Perimetro_y_area_de_un_Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            String dato = " ";
            float base1, altura;
            int opcion;
            float area, perimetro;

            Console.WriteLine("Calcular Area y Perimetro de un Rectangulo\n");

            Console.WriteLine("Que desea Calcular: [1- Area / 2- Perimetro]");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);

            Console.Write("\nDigite la Altura: ");
            dato = Console.ReadLine();
            altura = Convert.ToSingle(dato);
            Console.Write("\nDigite la Base:   ");
            dato = Console.ReadLine();
            base1 = Convert.ToSingle(dato);

            area = base1 * altura;
            perimetro = (base1 + altura) * 2;

            switch (opcion) {
                case 1:
                    Console.WriteLine("\nEl Area es {0}", area);
                    break;
                case 2:
                    Console.WriteLine("\nEl Perimetro es {0}", perimetro);
                    break;
            }

        }
    }
}
