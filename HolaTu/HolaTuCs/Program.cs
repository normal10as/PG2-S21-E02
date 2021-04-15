using System;

namespace HolaTuCs
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " " + apellido);
            // String.Format()
            Console.WriteLine("Hola {0} {1}", nombre, apellido);
        }
    }
}
