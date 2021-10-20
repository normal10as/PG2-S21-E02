using System;

namespace LittleTestCs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(GetLegajo());
            //Console.WriteLine(GetNombre());
            //Console.WriteLine(GetNota());
            //Console.WriteLine(Promedio(6,8,9));
            //Console.WriteLine(MejorNota(6, 8, 9));
            ushort legajo = 0;
            string nombre = "";
            byte nota1 = 0, nota2 = 0, nota3 = 0, mejorNota = 0;
            decimal promedio = 0;
            IngresarDatos(ref legajo, ref nombre, ref nota1, ref nota2, ref nota3);
            Operaciones(nota1,nota2,nota3, ref promedio, ref mejorNota);
            Salidas(legajo, nombre, promedio, mejorNota);
        }
        private static void Salidas(ushort legajo, string nombre, decimal promedio, byte mejorNota)
        {
            Console.WriteLine("Legajo: " + legajo);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Mejor Nota: " +mejorNota);
        }
        public static void IngresarDatos(ref ushort legajo, ref string nombre, ref byte nota1,ref byte nota2,ref byte nota3)
        {
            legajo = GetLegajo();
            nombre = GetNombre();
            nota1 = GetNota();
            nota2 = GetNota();
            nota3 = GetNota();
        }
        public static void Operaciones(byte nota1, byte nota2, byte nota3, ref decimal promedio, ref byte mejorNota)
        {
            promedio = Promedio(nota1, nota2, nota3);
            mejorNota = MejorNota(nota1, nota2, nota3);
        }
        public static ushort GetLegajo()
        {
            Console.Write("Ingrese legajo: ");
            var legajo = Convert.ToUInt16( Console.ReadLine());
            return legajo;
        }
        public static string GetNombre()
        {
            Console.Write("Ingrese Nombre: ");
            var nombre = Console.ReadLine();
            return nombre.ToUpper();
        }
        public static byte GetNota()
        {
            Console.Write("Ingrese nota: ");
            var nota = Convert.ToByte(Console.ReadLine());
            return nota;
        }
        public static decimal Promedio(byte nota1, byte nota2, byte nota3)
        {
            decimal promedio = (decimal)((nota1 + nota2 + nota3) / 3D);
            return promedio;
        }
        public static byte MejorNota(byte nota1, byte nota2, byte nota3)
        {
            //var maximo = Math.Max(nota1, nota2);
            //maximo = Math.Max(maximo, nota3);
            //return maximo;
            return Math.Max(Math.Max(nota1, nota2), nota3);
        }
    }
}
