Imports System

Module Program
    Sub Main(args As String())
        'Console.WriteLine(GetLegajo());
        'Console.WriteLine(GetNombre());
        'Console.WriteLine(GetNota());
        'Console.WriteLine(Promedio(6,8,9));
        'Console.WriteLine(MejorNota(6, 8, 9));
        Dim legajo As UShort = 0
        Dim nombre = ""
        Dim nota1 As Byte = 0, nota2 As Byte = 0, nota3 As Byte = 0, mejorNota As Byte = 0
        Dim promedio As Decimal = 0
        IngresarDatos(legajo, nombre, nota1, nota2, nota3)
        Operaciones(nota1, nota2, nota3, promedio, mejorNota)
        Salidas(legajo, nombre, promedio, mejorNota)
    End Sub

    Private Sub Salidas(ByVal legajo As UShort, ByVal nombre As String, ByVal promedio As Decimal, ByVal mejorNota As Byte)
        Console.WriteLine("Legajo: " & legajo)
        Console.WriteLine("Nombre: " & nombre)
        Console.WriteLine("Promedio: " & promedio)
        Console.WriteLine("Mejor Nota: " & mejorNota)
    End Sub

    Public Sub IngresarDatos(ByRef legajo As UShort, ByRef nombre As String, ByRef nota1 As Byte, ByRef nota2 As Byte, ByRef nota3 As Byte)
        legajo = GetLegajo()
        nombre = GetNombre()
        nota1 = GetNota()
        nota2 = GetNota()
        nota3 = GetNota()
    End Sub

    Public Sub Operaciones(ByVal nota1 As Byte, ByVal nota2 As Byte, ByVal nota3 As Byte, ByRef promedio As Decimal, ByRef mejorNota As Byte)
        promedio = Program.Promedio(nota1, nota2, nota3)
        mejorNota = Program.MejorNota(nota1, nota2, nota3)
    End Sub

    Public Function GetLegajo() As UShort
        Console.Write("Ingrese legajo: ")
        Dim legajo = Convert.ToUInt16(Console.ReadLine())
        Return legajo
    End Function

    Public Function GetNombre() As String
        Console.Write("Ingrese Nombre: ")
        Dim nombre = Console.ReadLine()
        Return nombre.ToUpper()
    End Function

    Public Function GetNota() As Byte
        Console.Write("Ingrese nota: ")
        Dim nota = Convert.ToByte(Console.ReadLine())
        Return nota
    End Function

    Public Function Promedio(ByVal nota1 As Byte, ByVal nota2 As Byte, ByVal nota3 As Byte) As Decimal
        Dim lPromedio As Decimal = (nota1 + nota2 + nota3) / 3.0R
        Return lPromedio
    End Function

    Public Function MejorNota(ByVal nota1 As Byte, ByVal nota2 As Byte, ByVal nota3 As Byte) As Byte
        'var maximo = Math.Max(nota1, nota2);
        'maximo = Math.Max(maximo, nota3);
        'return maximo;
        Return Math.Max(Math.Max(nota1, nota2), nota3)
    End Function
End Module
