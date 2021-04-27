using System;

namespace StringsCs
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "";
            Console.WriteLine("Cadena sin inicializar: <" + cadena + ">");
            cadena = "The path is C:\\PublicDocuments\\Report1.doc";
            cadena = @"The path is C:\PublicDocuments\Report1.doc";
            Console.WriteLine("Cadena: " + cadena);
            cadena += "x";
            Console.WriteLine("Cadena concatenada: " + cadena);
            Console.WriteLine("Longitud Cadena: " + cadena.Length);
            Console.WriteLine("Caracter extradido por posición {0}: {1}",
                              cadena.Length, cadena[cadena.Length - 1]);

            byte posicion = 31;
            Console.WriteLine("Cadena extradida desde posición {0}: {1}",
                          posicion, cadena.Substring(posicion));

            posicion = Convert.ToByte(cadena.IndexOf(".") + 1);
            Console.WriteLine("Cadena extradida por búsqueda de '.' desde posición {0}: {1}",
                          posicion, cadena.Substring(posicion));

            DateTime dateAndTime = new DateTime(2011, 7, 6, 7, 32, 0);
            Single temperature = 25.3F;
            String result = String.Format(
               "A las {0:t} del {0:D}, la temperatura fue {1:F1} grados Centigrados.",
                                        dateAndTime, temperature);
            Console.WriteLine(result);

            Char letra = Convert.ToChar(0);
            Console.WriteLine("'{0}': {1}", letra, Char.GetUnicodeCategory(letra));
            letra = 'h';
            Console.WriteLine("'{0}': {1}", letra, Char.GetUnicodeCategory(letra));

            letra = Char.ToUpper(letra);
            Console.WriteLine("'{0}': {1}", letra, Char.GetUnicodeCategory(letra));
            letra = '5';
            Console.WriteLine("'{0}': {1}", letra, Char.GetUnicodeCategory(letra));
            letra = '*';
            Console.WriteLine("'{0}': {1}", letra, Char.GetUnicodeCategory(letra));
            letra = '+';
            Console.WriteLine("'{0}': {1}", letra, Char.GetUnicodeCategory(letra));

            Console.WriteLine("{0} es minúscula: {1}", letra, Char.IsLower(letra));
            Console.WriteLine("{0} es mayúscula: {1}", letra, Char.IsUpper(letra));
            Console.WriteLine("{0} es número: {1}", letra, Char.IsNumber(letra));
            Console.WriteLine("{0} es símbolo: {1}", letra, Char.IsSymbol(letra));
        }
    }
}
