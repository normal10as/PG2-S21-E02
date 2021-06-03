Imports System

Module Program
    Const minimo As Short = -10
    Const maximo As UShort = 10
    Sub Main(args As String())
        Dim valor As Short
        Console.Write("Ingrese un valor entre {0} y {1}: ", minimo, maximo)
        valor = Console.ReadLine()
        Select Case valor
            Case 1  'equivale a if valor = 1 then
                Console.WriteLine("Es uno")

            Case 2
                Console.WriteLine("Es dos")

            Case 3, 5, -1 ' valor = 3 or valor = 5
                Console.WriteLine("Es tres, cinco o uno negativo")

            Case 6 To 8 ' valor >= 6 and valor <= 8
                Console.WriteLine("Es de seis a ocho")

            Case Is < 0 'valor < 0
                Console.WriteLine("Es negativo")

            Case Else
                Console.WriteLine("Es otro numero: " & valor)

        End Select
    End Sub
End Module
