using System;

namespace Calcular_Perimetro_de_Poligonos
{
    class Program
    {
        static void Main(string[] args)
        {
            String dato = " ";
            float base1;
            float altura;
            float Area;
            float Perimetro;

            Console.WriteLine("Area y Parimetro de un rectangulo");
            Console.WriteLine("Dijite la Base: ");
            dato = Console.ReadLine();
            base1 = Convert.ToSingle(dato);
            Console.WriteLine("Ddijite la altura: ");
            dato = Console.ReadLine();
            altura = Convert.ToSingle(dato);

            Area = (base1 * altura);
            Perimetro = (base1 + altura) * 2;

            Console.WriteLine("El Area es de {0} y el Perimetro es de {1}",Area,Perimetro);
        }
    }
}
