using System;

namespace Convercion_de_Grados_a_Radianes
{
    class Program
    {
        static void Main(string[] args)
        {
            String dato = " ";
            float radian;
            float grados;

            Console.WriteLine("Convercion de Grados a Radianes");
            Console.WriteLine("Dijite los Grados a convertir: ");
            dato = Console.ReadLine();
            grados = Convert.ToSingle(dato);

            radian = grados / 180.0f;

            Console.Write("Son {0} Radianes",radian);
        }
    }
}
