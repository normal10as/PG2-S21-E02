Imports System

Module Program
    Sub Main(args As String())
        Dim maximo, lecturaActual, cargado As Integer
        Console.WriteLine("Medidor")
        Console.Write("Ingrese el máximo: ")
        maximo = Console.ReadLine()
        Do
            Console.WriteLine("Cargado: " & cargado)
            Console.Write("Ingrese una cantidad a cargar: ")
            lecturaActual = Console.ReadLine()
            cargado += lecturaActual
        Loop Until cargado >= maximo
        Console.WriteLine("Se ha llenado, sobro: " & cargado - maximo)
    End Sub
End Module
