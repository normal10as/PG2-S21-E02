using System;

namespace RepetirMientrasCs
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximo, lecturaActual, cargado = default;
            Console.WriteLine("Medidor");
            Console.Write("Ingrese el máximo: ");
            maximo = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Cargado: " + cargado);
                Console.Write("Ingrese una cantidad a cargar: ");
                lecturaActual = Convert.ToInt32(Console.ReadLine());
                if (lecturaActual == 0)
                    continue;
                if (lecturaActual < 0)
                    break;
                cargado += lecturaActual;
            }
            while (cargado < maximo);
            if (lecturaActual < 0)
                Console.WriteLine("Valor invalido kaboom");
            else
                Console.WriteLine("Se ha llenado, sobro: " + (cargado - maximo));
        }
    }
}
