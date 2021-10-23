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
            EjemploQueue();
            EjemploDictionary();
        }
        private static void EjemploDictionary()
        {
            Dictionary<short, string> Clientes;
            Clientes = new Dictionary<short, string>();
            Clientes.Add(1, "Pepe");
            Clientes.Add(2, "Juana");
            Clientes.Add(3, "Ruben");
            Iterar(Clientes);
            Console.WriteLine("Existe 2: " + Clientes.ContainsKey(2));
            Console.WriteLine("Existe 4: " + Clientes.ContainsKey(4));
            Console.WriteLine("Existe 2: " + Clientes.ContainsValue("Juana"));
            Console.WriteLine("Existe 4: " + Clientes.ContainsValue("Luis"));
            var isAdded = Clientes.TryAdd(2, "Juani");
            Console.WriteLine("¿Agregado?: " + isAdded);
            Clientes.Remove(2);
            isAdded = Clientes.TryAdd(2, "Juani");
            Console.WriteLine("¿Agregado?: " + isAdded);
            Iterar(Clientes);
        }

        private static void Iterar(Dictionary<short, string> clientes)
        {
            foreach (var item in clientes)
                Console.WriteLine(item.Key + ": " + item.Value);
        }
        private static void EjemploQueue()
        {
            Queue<string> frutas;
            frutas = new Queue<string>();
            Iterar(frutas);
            frutas.Enqueue("Pomelo");
            frutas.Enqueue("Naranja");
            frutas.Enqueue("Maracuja");
            Iterar(frutas);
            Console.WriteLine(frutas.Dequeue());
            frutas.Enqueue("Limon");
            Iterar(frutas);
            Console.WriteLine(frutas.Dequeue());
            Console.WriteLine(frutas.Peek());
            Console.WriteLine(frutas.Dequeue());
            Console.WriteLine(frutas.Peek());
            CWTryDequeue(frutas);
            //Console.WriteLine(frutas.Dequeue());
            if (frutas.Count > 0)
                Console.WriteLine(frutas.Dequeue());
            CWTryDequeue(frutas);
        }

        private static void CWTryDequeue(Queue<string> frutas)
        {
            string item = "";
            frutas.TryDequeue(out item);
            Console.WriteLine(item);
        }

        private static void Iterar(Queue<string> frutas)
        {
            foreach (var item in frutas)
            {
                Console.WriteLine(item);
            }
        }

        private static void EjemploList()
        {
            List<String> paises = new List<String>();
            paises.Add("Brasil");
            paises.Add("China");
            paises.Add("China");
            paises.Add("India");
            paises.Add("Rusia");
            paises.Add("Uno");

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
        private static void Iterar(List<string> paises)
        {
            foreach (var item in paises)
            {
                Console.WriteLine(item);
            }
        }
    }
}