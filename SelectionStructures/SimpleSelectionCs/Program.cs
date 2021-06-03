using System;

namespace SimpleSelectionCs
{
    class Program
    {
        static void Main(string[] args)
        {
            short a;
            Console.Write("Ingrese un valor: ");
            a = Convert.ToInt16(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("Es positivo");

            if (a > 0)
            {
                Console.WriteLine("Es positivo");
            }
            else
            {
                Console.WriteLine("No Es positivo");
                Console.WriteLine("");
            }

            if (a > 0)
                Console.WriteLine("Es positivo");
            else if (a < 0)
                Console.WriteLine("Es negativo");
            else
                Console.WriteLine("Es cero");

            short b;
            Console.Write("Ingrese otro valor: ");
            b = Convert.ToInt16(Console.ReadLine());
            if (a > 0 && b > 0)
                Console.WriteLine("Ambos son positivos");

            if (a > 0 || b > 0)
                Console.WriteLine("Al menos uno de ambos es positivo");

            if (!(a > 0 && b > 0))
                Console.WriteLine("Ambos no son positivos");
        }
    }
}
