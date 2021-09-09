Imports System
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Module Program
    Private Const kilometrosXmillas As Double = 1.609
    Private Const nudosXmillas As Double = 0.869
    Enum SpeedUnit
        KilometrosHora = 1
        Millas
        Nudos
    End Enum
    Sub Main(args As String())
        'test()
        Dim tecla As Char
        Do
            Dim originalSpeedUnit As SpeedUnit
            originalSpeedUnit = GetSpeedUnit("original")
            Dim speedValue As Decimal
            speedValue = GetSpeedValue()
            Dim equivalentSpeedUnit As SpeedUnit
            equivalentSpeedUnit = GetSpeedUnit("equivalente")
            Dim result = ConvertSpeedUnit(originalSpeedUnit, speedValue, equivalentSpeedUnit)
            Console.WriteLine($"{originalSpeedUnit}: {speedValue} => {equivalentSpeedUnit}: {result}")
            Console.WriteLine("¿Desea hacer otro calculo? (<S> afirmativo, cualquier otra tecla para salir)")
            tecla = Console.ReadKey().KeyChar()
        Loop While tecla = "S"
    End Sub
    Sub test()
        Assert.AreEqual(160.9D, ConvertSpeedUnit(SpeedUnit.Millas, 100, SpeedUnit.KilometrosHora))
        Assert.AreEqual(86.9D, ConvertSpeedUnit(SpeedUnit.Millas, 100, SpeedUnit.Nudos))
        Assert.AreEqual(62.1504039776259D, ConvertSpeedUnit(SpeedUnit.KilometrosHora, 100, SpeedUnit.Millas))
        Assert.AreEqual(54.0087010565569D, ConvertSpeedUnit(SpeedUnit.KilometrosHora, 100, SpeedUnit.Nudos))
        Assert.AreEqual(185.155350978135D, ConvertSpeedUnit(SpeedUnit.Nudos, 100, SpeedUnit.KilometrosHora))
        Assert.AreEqual(115.074798619102D, ConvertSpeedUnit(SpeedUnit.Nudos, 100, SpeedUnit.Millas))
    End Sub
    Public Function ConvertSpeedUnit(original As SpeedUnit, value As Decimal, equivalent As SpeedUnit) As Decimal
        If original = equivalent Then
            Return value
        End If
        Dim result As Decimal
        Select Case original
            Case SpeedUnit.KilometrosHora
                result = value / kilometrosXmillas
                If equivalent = SpeedUnit.Nudos Then
                    result = ConvertSpeedUnit(SpeedUnit.Millas, result, SpeedUnit.Nudos)
                End If
            Case SpeedUnit.Millas
                If equivalent = SpeedUnit.KilometrosHora Then
                    result = value * kilometrosXmillas
                Else
                    result = value * nudosXmillas
                End If
            Case SpeedUnit.Nudos
                result = value / nudosXmillas
                If equivalent = SpeedUnit.KilometrosHora Then
                    result = ConvertSpeedUnit(SpeedUnit.Millas, result, SpeedUnit.KilometrosHora)
                End If
        End Select
        Return result
    End Function
    Function GetSpeedUnit(mensaje As String) As SpeedUnit
        Dim value As SpeedUnit
        Do
            Console.WriteLine("Unidades de medida")
            For Each item In [Enum].GetValues(GetType(SpeedUnit))
                Console.WriteLine($"{item:D}) {item}")
            Next
            Console.WriteLine($"Ingrese unidad de medida de {mensaje}: ")
            value = Console.ReadLine()
            If Not isValidSpeedUnit(value) Then
                Console.WriteLine("Selección inválidad")
            End If
        Loop Until isValidSpeedUnit(value)
        Return value
    End Function
    Private Function isValidSpeedUnit(value As SpeedUnit) As Boolean
        Return [Enum].IsDefined(GetType(SpeedUnit), value)
    End Function
    Function GetSpeedValue() As Decimal
        Dim value As Decimal
        Do
            Console.Write("Ingrese velocidad: ")
            value = Console.ReadLine()
            If Not isValidSpeedValue(value) Then
                Console.WriteLine("Velocidad inválida")
            End If
        Loop Until isValidSpeedValue(value)
        Return value
    End Function
    Private Function isValidSpeedValue(value As Decimal) As Boolean
        Return value > 0
    End Function
End Module