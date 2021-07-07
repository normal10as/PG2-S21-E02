using System;

namespace IteracionParaCs
{
    static class Program
    {
        public static void Main(string[] args)
        {
            // de 0 a 3 en paso 1 
            for (int x = 0; x <= 3; x++)
                Console.WriteLine("x: {0}", x);
            // de 0 a 10 en paso 3 
            for (int x = 0; x <= 10; x += 3)
                Console.WriteLine("x: {0}", x);
            // de 0 a 10 en paso -3 
            for (int x = 0; x >= 10; x -= 3)
                Console.WriteLine("x: {0}", x);
            // de 10 a 0 en paso -3 
            for (int x = 10; x >= 0; x -= 3)
                Console.WriteLine("x: {0}", x);
            for (int x = 0; x >= -10; x -= 3)
                Console.WriteLine("x: {0}", x);
        }
    }
}