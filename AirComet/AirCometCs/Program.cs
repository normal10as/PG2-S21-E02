﻿using System;

namespace AirCometCs
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pesoMaleta1, pesoMaleta2, pesoMaleta3, pesoTotal, excesoPeso;
            Console.Write("Ingrese Peso Maleta 1: ");
            pesoMaleta1 = Convert.ToDecimal( Console.ReadLine());
            Console.Write("Ingrese Peso Maleta 2: ");
            pesoMaleta2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese Peso Maleta 3: ");
            pesoMaleta3 = Convert.ToDecimal(Console.ReadLine());
            pesoTotal = pesoMaleta1 + pesoMaleta2 + pesoMaleta3;
            Console.WriteLine("Peso Total: " + pesoTotal);
            Console.WriteLine("Peso Promedio: " + pesoTotal / 3);
            // peso toal = 40 -> exceso = 0
            // peso toal = 60 -> exceso = 10
            excesoPeso = Math.Max(0, (pesoTotal - 50));

            Console.WriteLine("Exceso de equipaje: " + excesoPeso);
            Console.WriteLine("Tarifa por Exceso de equipaje: " + excesoPeso * 100);
        }
    }
}
