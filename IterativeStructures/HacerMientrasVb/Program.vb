Imports System

Module Program
    Sub Main(args As String())
        Dim disponible, lecturaActual As Integer
        Console.WriteLine("Medidor regresivo")
        Console.Write("Ingrese el disponible: ")
        disponible = Console.ReadLine()
        Do While disponible > 0
            Console.WriteLine("Disponible: " & disponible)
            Console.Write("Ingrese una cantidad a extraer: ")
            lecturaActual = Console.ReadLine()
            disponible -= lecturaActual
        Loop
        Console.WriteLine("Se ha vaciado, falto: " & Math.Abs(disponible))
    End Sub
End Module
