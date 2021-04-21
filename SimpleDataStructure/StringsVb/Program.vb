Imports System

Module Program
    Sub Main(args As String())
        Dim cadena As String
        Console.WriteLine("Cadena sin inicializar: <" + cadena + ">")

        cadena = "The path is C:\PublicDocuments\Report1.doc"
        Console.WriteLine("Cadena: " + cadena)

        cadena &= "x"
        Console.WriteLine("Cadena concatenada: " + cadena)

        Console.WriteLine("Longitud Cadena: " & cadena.Length)

        Console.WriteLine("Caracter extradido por posici�n {0}: {1}",
                          cadena.Length, cadena.Chars(cadena.Length - 1))

        Dim posicion As Byte = 31
        Console.WriteLine("Cadena extradida desde posici�n {0}: {1}",
                          posicion, cadena.Substring(posicion))

        posicion = cadena.IndexOf(".") + 1
        Console.WriteLine("Cadena extradida por b�squeda de '.' desde posici�n {0}: {1}",
                          posicion, cadena.Substring(posicion))

        Dim dateAndTime As DateTime = #07/06/2019 7:32:00AM#
        Dim temperature As Single = 25.3
        Dim result As String = String.Format(
            "A las {0:t} del {0:D}, la temperatura fue {1:F1} grados Centigrados.",
                                     dateAndTime, temperature)
        Console.WriteLine(result)

        Dim letra As Char
        Console.WriteLine("'{0}': {1}", letra, Char.GetUnicodeCategory(letra))
        letra = "h"
        Console.WriteLine("'{0}': {1}", letra, Char.GetUnicodeCategory(letra))

        letra = Char.ToUpper(letra)
        Console.WriteLine("'{0}': {1}", letra, Char.GetUnicodeCategory(letra))
        letra = "5"
        Console.WriteLine("'{0}': {1}", letra, Char.GetUnicodeCategory(letra))
        letra = "*"
        Console.WriteLine("'{0}': {1}", letra, Char.GetUnicodeCategory(letra))
        letra = "+"
        Console.WriteLine("'{0}': {1}", letra, Char.GetUnicodeCategory(letra))

        Console.WriteLine("{0} es min�scula: {1}", letra, Char.IsLower(letra))
        Console.WriteLine("{0} es may�scula: {1}", letra, Char.IsUpper(letra))
        Console.WriteLine("{0} es n�mero: {1}", letra, Char.IsNumber(letra))
        Console.WriteLine("{0} es s�mbolo: {1}", letra, Char.IsSymbol(letra))
    End Sub

End Module
