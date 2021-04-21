using System;

namespace ConstsCs
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal impuesto = 0.21M;
            const string msgEntrada = "Ingrese monto del producto: ";
            const string msgSalida = "El total con impuesto es: ";
            decimal monto;
            Console.Write(msgEntrada);
            monto = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("{0}{1}", msgSalida, monto + impuesto * monto);
        }
    }
}
