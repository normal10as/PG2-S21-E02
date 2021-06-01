Imports System

Module Program
    Sub Main(args As String())
        Dim a As Short
        Console.Write("Ingrese un valor: ")
        a = Console.ReadLine
        If a > 0 Then
            Console.WriteLine("Es positivo")
        End If

        If a > 0 Then
            Console.WriteLine("Es positivo")
        Else
            Console.WriteLine("No Es positivo")
        End If

        If a > 0 Then
            Console.WriteLine("Es positivo")
        ElseIf a < 0 Then
            Console.WriteLine("Es negativo")
        Else
            Console.WriteLine("Es cero")
        End If

        Dim b As Short
        Console.Write("Ingrese un valor: ")
        b = Console.ReadLine
        If a > 0 And b > 0 Then
            Console.WriteLine("Ambos son positivos")
        End If

        If a > 0 Or b > 0 Then
            Console.WriteLine("Al menos uno de ambos es positivo")
        End If

        If Not (a > 0 And b > 0) Then
            Console.WriteLine("Ambos no son positivos")
        End If

        If Not (a > 0 Xor b > 0) Then
            Console.WriteLine("Ambos son del mismo signo")
        Else
            Console.WriteLine("Ambos son de distinto signo")
        End If

        Dim c As Short
        Console.Write("Ingrese un valor: ")
        c = Console.ReadLine
        If a > 0 And b > 0 Or c > 0 Then
            Console.WriteLine("¿que es?")
        End If
        If a > 0 And (b > 0 Or c > 0) Then
            Console.WriteLine("Primer valor positivo y uno mas es positivo")
        End If
        If a > 0 Then
            If b > 0 Or c > 0 Then
                Console.WriteLine("Primer valor positivo y uno mas es positivo")
            End If
        End If
    End Sub
End Module
