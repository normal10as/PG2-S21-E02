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
            If lecturaActual = 0 Then
                Continue Do
            End If
            If lecturaActual < 0 Then
                Exit Do
            End If
            cargado += lecturaActual
        Loop While cargado < maximo
        Console.WriteLine("Se ha llenado, sobro: " & cargado - maximo)
    End Sub
End Module
