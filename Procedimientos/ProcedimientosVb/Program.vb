Imports System

Module Program
    Sub Main(args As String())
        Sumar(10, 30)
        Console.WriteLine(Concatenar("Hola ", "mundo"))
    End Sub

    Sub Sumar(valor1 As Integer, valor2 As Integer)
        Console.WriteLine(valor1 + valor2)
    End Sub

    Function Concatenar(valor1 As String, valor2 As String) As String
        Return valor1 & valor2
    End Function
End Module
