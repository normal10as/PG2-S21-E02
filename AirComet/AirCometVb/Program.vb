Imports System

Module Program
    Sub Main(args As String())
        Dim pesoMaleta1, pesoMaleta2, pesoMaleta3, pesoTotal, excesoPeso As Decimal
        Console.Write("Ingrese Peso Maleta 1: ")
        pesoMaleta1 = Console.ReadLine()
        Console.Write("Ingrese Peso Maleta 2: ")
        pesoMaleta2 = Console.ReadLine()
        Console.Write("Ingrese Peso Maleta 3: ")
        pesoMaleta3 = Console.ReadLine()
        pesoTotal = pesoMaleta1 + pesoMaleta2 + pesoMaleta3
        Console.WriteLine("Peso Total: " & pesoTotal)
        Console.WriteLine("Peso Promedio: " & pesoTotal / 3)
        ' peso toal = 40 -> exceso = 0
        ' peso toal = 60 -> exceso = 10
        excesoPeso = Math.Max(0, pesoTotal - 50)

        Console.WriteLine("Exceso de equipaje: " & excesoPeso)
        Console.WriteLine("Tarifa por Exceso de equipaje: " & excesoPeso * 100)
    End Sub
End Module
