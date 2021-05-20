Imports System
Imports System.Drawing

Module Program
    Friend vari As String
    Sub Main(args As String())
        Sumar(10, 30)
        Sumar(10, 30, 50)
        Console.WriteLine(Concatenar("Hola", "mundo"))
        Console.WriteLine(Concatenar("Hola", "mundo", "cruel"))

        Dim a, b As Integer
        a = 10
        'b = 20
        Console.WriteLine(a)
        'Console.WriteLine(b)
        ParametroValor(a)
        Console.WriteLine(a)
        ParametroReferencia(a)
        Console.WriteLine(a)
        'Dim a As Int16 = 10
        'Dim b As Int16 = a
        'a = 20
        'Console.WriteLine("{0}, {1}", a, b)

        'Dim c, d As String
        'c = "hola"
        'd = c
        'c = "mundo"
        'Console.WriteLine("{0}, {1}", c, d)

        'Dim e, f As New DateTime()
        'e = DateTime.Now
        'f = e
        'f = f.AddDays(100)
        'Console.WriteLine("{0}, {1}", e, f)

    End Sub
    Sub ParametroValor(ByVal a As Integer)
        a += a
    End Sub

    Sub ParametroReferencia(ByRef b As Integer)
        b += b
    End Sub
    Sub Sumar(valor1 As Integer, valor2 As Integer)
        Console.WriteLine(valor1 + valor2)
    End Sub
    Sub Sumar(valor1 As Integer, valor2 As Integer, valor3 As Integer)
        Console.WriteLine(valor1 + valor2 + valor3)
    End Sub
    Function Concatenar(valor1 As String, valor2 As String) As String
        Return valor1 & " " & valor2
    End Function
    Function Concatenar(valor1 As String, valor2 As String, valor3 As String) As String
        Return Concatenar(Concatenar(valor1, valor2), valor3)
    End Function
End Module
