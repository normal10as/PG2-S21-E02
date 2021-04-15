Imports System

Module Program
    Sub Main(args As String())
        Dim nombre As String
        Dim apellido As String
        Console.Write("Ingrese su nombre: ")
        nombre = Console.ReadLine()
        Console.Write("Ingrese su apellido: ")
        apellido = Console.ReadLine()
        Console.WriteLine("Hola " & nombre & " " & apellido)
        ' String.Format()
        Console.WriteLine("Hola {0} {1}", nombre, apellido)
    End Sub
End Module
