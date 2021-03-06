using System;

namespace ProcedimientosCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumar(10, 30);
            Sumar((decimal)10.8, 30);
            Sumar(10, 30, 50);
            //TODO implementar la llamada a concatenar
            Console.WriteLine(Concatenar("Hola","Mundo"));
            Console.WriteLine(Concatenar("Hola", "Mundo", "Cruel"));
            Console.WriteLine();

            int a, b;
            a = 10;
            //b = 20;
            Console.WriteLine(a);
            //Console.WriteLine(b);
            ParametroValor(a);
            Console.WriteLine(a);
            ParametroReferencia(ref a);
            Console.WriteLine(a);
        }

        private static void ParametroValor(int a)
        {
            a += a;
        }        
        private static void ParametroReferencia(ref int b)
        {
            b += b;
        }

        static void Sumar(int valor1, int valor2)
        {
            Console.WriteLine(valor1 + valor2);
        }
        static void Sumar(decimal valor1, decimal valor2)
        {
            Console.WriteLine(valor1 + valor2);
        }
        static void Sumar(int valor1, int valor2, int valor3)
        {
            Console.WriteLine(valor1 + valor2 + valor3);
        }
        static string Concatenar(
            string valor1, string valor2) 
        {
            return valor1 +" "+ valor2;
        }
        static string Concatenar(string valor1, string valor2, string valor3)
        {
            return Concatenar(valor1, Concatenar(valor2,valor3));
        }

    }
}
