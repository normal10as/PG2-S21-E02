Imports System

Module Program
    Sub Main(args As String())
        ' contador o incrementador
        Dim contador As UShort
        contador += 1
        Console.WriteLine(contador)
        contador += 1
        Console.WriteLine(contador)
        contador += 1
        Console.WriteLine(contador)
        ' acumulador
        Dim acumulador As UInteger
        acumulador += 20
        Console.WriteLine(acumulador)
        acumulador += 10
        Console.WriteLine(acumulador)
        acumulador += 25
        Console.WriteLine(acumulador)
        ' división
        Console.WriteLine(25 / 10)
        Console.WriteLine(25 \ 10)
        Console.WriteLine(25 Mod 10)
        ' exponenciacion
        Console.WriteLine(5 ^ 2)
        Console.WriteLine(5 ^ 5)
        ' conversion
        Dim a As Byte = 200
        Dim b As Single
        b = a / 3
        Console.WriteLine(b)
        a = b
        Console.WriteLine(a)
        ' casting
        a = CByte(b)
        Console.WriteLine(a)
        ' Precedencia
        a = 4
        b = 10
        Console.WriteLine(-b ^ a)
        Console.WriteLine((-b) ^ a)
        Console.WriteLine(b + a / b)
        Console.WriteLine((b + a) / b)
    End Sub
End Module
