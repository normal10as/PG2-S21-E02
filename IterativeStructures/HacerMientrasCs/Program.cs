using System;
namespace HacerMientrasCs
{
    static class Program
    {

        public static void Main(string[] args)
        {
            int disponible, lecturaActual;
            Console.WriteLine("Medidor regresivo");
            Console.Write("Ingrese el disponible: ");
            disponible = Convert.ToInt32(Console.ReadLine());
            while (disponible > 0)
            {
                Console.WriteLine("Disponible: " + disponible);
                Console.Write("Ingrese una cantidad a extraer: ");
                lecturaActual = Convert.ToInt32(Console.ReadLine());
                disponible -= lecturaActual;
            }
            Console.WriteLine("Se ha vaciado, falto: " + Math.Abs(disponible));
        }
    }
}