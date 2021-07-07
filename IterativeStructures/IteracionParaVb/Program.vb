Imports System

Module Program
    Sub Main(args As String())
        ' de 0 a 3 en paso 1 
        For x = 0 To 3
            Console.WriteLine("x: {0}", x)
        Next
        ' de 0 a 10 en paso 3 
        For x = 0 To 10 Step 3
            Console.WriteLine("x: {0}", x)
        Next
        ' de 0 a 10 en paso -3 
        For x = 0 To 10 Step -3
            Console.WriteLine("x: {0}", x)
        Next
        ' de 10 a 0 en paso -3 
        For x = 10 To 0 Step -3
            Console.WriteLine("x: {0}", x)
        Next
        For x = 0 To -10 Step -3
            Console.WriteLine("x= {0}", x)
        Next
    End Sub
End Module
