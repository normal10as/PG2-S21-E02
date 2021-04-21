Imports System

Module Program
    Sub Main(args As String())
        Const impuesto As Decimal = 0.21
        Const msgEntrada As String = "Ingrese monto del producto: "
        Const msgSalida = "El total con impuesto es: "
        Dim monto As Decimal
        Console.Write(msgEntrada)
        monto = Console.ReadLine()
        Console.WriteLine("{0}{1}", msgSalida, monto + impuesto * monto)
    End Sub
End Module
