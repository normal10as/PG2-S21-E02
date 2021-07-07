using System;

namespace VectoresCs
{
    static class Program
    {
        public static void Main(string[] args)
        {
            var valores = NuevoArray();
            IterarArrayFor(valores);
            ModificarElementos(valores);
            IterarArrayFor(valores);
            ArrayDeclaracionAsignacionSimultanea();
            var matriz = NuevoArray2Dimensiones();
            IterarArrayForEach(matriz);

            // declara y asigna un vector de 2 x 3
            var grid1 = new ushort[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            IterarArrayForEach(grid1);
            VerInfoArray(grid1);
            IterarArray2Dimensiones(grid1);
            ArryaMultidimensional();
        }

        private static void ArryaMultidimensional()
        {
            // array multidimensional
            var grid2 = new[, ,] { { { 1, 2 }, { 3, 4 }, { 5, 6 } }, { { 7, 8 }, { 9, 10 }, { 11, 12 } }, { { 13, 14 }, { 15, 16 }, { 17, 18 } }, { { 19, 20 }, { 21, 22 }, { 23, 24 } } };
            Console.WriteLine("Longitud: " + grid2.Length);
            Console.WriteLine("Dimensiones: " + grid2.Rank);
            for (int x = 1, loopTo = grid2.Rank; x <= loopTo; x++)
                Console.WriteLine("Longitud dimension {0}: {1}", x, grid2.GetLength(x - 1));
        }

        private static void IterarArray2Dimensiones(ushort[,] grid1)
        {
            for (int x = 0, loopTo = grid1.GetUpperBound(1); x <= loopTo; x++)
            {
                for (int y = 0, loopTo1 = grid1.GetUpperBound(0); y <= loopTo1; y++)
                    Console.Write(grid1[y, x] + " ");
                Console.WriteLine();
            }
        }

        private static void VerInfoArray(ushort[,] grid1)
        {
            Console.WriteLine("Longitud: " + grid1.Length);
            Console.WriteLine("Ultima posición Dimension 0: " + grid1.GetUpperBound(0));
            Console.WriteLine("Ultima posición Dimension 1: " + grid1.GetUpperBound(1));
        }

        private static float[,] NuevoArray2Dimensiones()
        {
            // declara un array de 2 dimensiones 3 x 2
            var matriz = new float[3, 2];
            // asignación de los valores uno por uno
            matriz[0, 0] = 1f;
            matriz[0, 1] = 2f;
            matriz[1, 0] = 3f;
            matriz[1, 1] = 4f;
            matriz[2, 0] = 5f;
            matriz[2, 1] = 6f;
            return matriz;
        }

        private static void ModificarElementos(ushort[] valores)
        {
            // iteración sobre el vector para alterar el valor de todos los elementos
            for (int x = 0, loopTo = valores.Length - 1; x <= loopTo; x++)
                // Console.WriteLine(valores(x))
                valores[x] *= valores[x];
        }

        private static void ArrayDeclaracionAsignacionSimultanea()
        {
            // declaración de un array con 3 elementos y asignación de los valores
            var nombres = new string[] { "Pepe", "Juan", "Maria" };
            // iteración sobre el vector para mostrar el valor de todos los elementos
            foreach (var nombre in nombres)
                Console.WriteLine(nombre);
        }

        private static void IterarArrayFor(ushort[] valores)
        {
            // iteración sobre el vector para mostrar el valor de todos los elementos
            for (int x = 0, loopTo = valores.Length - 1; x <= loopTo; x++)
                Console.WriteLine(valores[x]);
        }

        private static ushort[] NuevoArray()
        {
            // declaración de un array con 3 elementos
            var valores = new ushort[3];
            // asignación de los valores uno por uno
            valores[0] = 5;
            valores[1] = 15;
            valores[2] = 25;
            return valores;
        }

        public static void IterarArrayForEach(float[,] grid)
        {
            foreach (var valor in grid)
                Console.Write(valor + " ");
            Console.WriteLine();
        }

        public static void IterarArrayForEach(ushort[,] grid)
        {
            foreach (var valor in grid)
                Console.Write(valor + " ");
            Console.WriteLine();
        }
    }
}