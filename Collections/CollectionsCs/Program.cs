using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsCs
{
    class Program
    {
        static void Main(string[] args)
        {
            EjemploArrayList();
            EjemploList();
        }

        private static void EjemploList()
        {
            List<String> paises = new List<String>();
            paises.Add("Brasil");
            paises.Add("China");
            paises.Add("China");
            paises.Add("India");
            paises.Add("Rusia");
            paises.Add(1);

            Iterar(paises);
            Console.WriteLine(paises[3]);

            paises.Insert(3, "Australia");
            paises.RemoveAt(6);
            paises.Remove("China");

            for (int x = 0; x < paises.Count; x++)
            {
                Console.WriteLine($"{x}: {paises[x]}"); // idem a paises.Item(x)
            }

            paises.Sort();
            Iterar(paises);
            paises.Reverse();
            Iterar(paises);

            Console.WriteLine("Existe India: " + paises.Contains("India"));
            Console.WriteLine("Existe india: " + paises.Contains("india"));

            Console.WriteLine("Posición India: " + paises.IndexOf("India"));
            Console.WriteLine("Posición india: " + paises.IndexOf("india"));
        }
        private static void EjemploArrayList()
        {
            ArrayList paises = new ArrayList();
            paises.Add("Brasil");
            paises.Add("China");
            paises.Add("China");
            paises.Add("India");
            paises.Add("Rusia");
            paises.Add(1);

            Iterar(paises);
            Console.WriteLine(paises[3]);

            paises.Insert(3, "Australia");
            paises.RemoveAt(6);
            paises.Remove("China");

            for (int x = 0; x < paises.Count; x++)
            {
                Console.WriteLine($"{x}: {paises[x]}"); // idem a paises.Item(x)
            }

            paises.Sort();
            Iterar(paises);
            paises.Reverse();
            Iterar(paises);

            Console.WriteLine("Existe India: " + paises.Contains("India"));
            Console.WriteLine("Existe india: " + paises.Contains("india"));

            Console.WriteLine("Posición India: " + paises.IndexOf("India"));
            Console.WriteLine("Posición india: " + paises.IndexOf("india"));
        }

        private static void Iterar(ArrayList paises)
        {
            foreach (var item in paises)
            {
                Console.WriteLine(item);
            }
        }
    }
}