using System;

namespace ProcedimientosCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumar(10, 30);
            Console.WriteLine();
        }

        static void Sumar(int valor1, int valor2)
        {
            Console.WriteLine(valor1 + valor2);
        }

        static string Concatenar(string valor1, string valor2) 
        {
            return valor1 + valor2;
        }
    }
}
