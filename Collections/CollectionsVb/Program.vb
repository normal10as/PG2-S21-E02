Imports System

Module Program
    Sub Main(args As String())
        'EjemploArrayList()
        'EjemploList()
        'EjemploQueue()
        EjemploDictionary()
    End Sub

    Private Sub EjemploDictionary()
        Dim Clientes As Dictionary(Of Int16, String)
        Clientes = New Dictionary(Of Short, String)
        Clientes.Add(1, "Pepe")
        Clientes.Add(2, "Juana")
        Clientes.Add(3, "Ruben")
        Iterar(Clientes)
        Console.WriteLine("Existe 2: " & Clientes.ContainsKey(2))
        Console.WriteLine("Existe 4: " & Clientes.ContainsKey(4))
        Console.WriteLine("Existe 2: " & Clientes.ContainsValue("Juana"))
        Console.WriteLine("Existe 4: " & Clientes.ContainsValue("Luis"))

        Clientes.TryAdd(2, "Juani")
        Clientes.Remove(2)
        Clientes.Add(2, "Juani")
    End Sub

    Private Sub Iterar(clientes As Dictionary(Of Short, String))
        For Each item In clientes
            Console.WriteLine(item.Key & ": " & item.Value)
        Next
    End Sub

    Private Sub EjemploQueue()
        Dim frutas As Queue(Of String)
        frutas = New Queue(Of String)()
        Iterar(frutas)
        frutas.Enqueue("Pomelo")
        frutas.Enqueue("Naranja")
        frutas.Enqueue("Maracuja")
        Iterar(frutas)
        Console.WriteLine(frutas.Dequeue())
        frutas.Enqueue("Limon")
        Iterar(frutas)
        Console.WriteLine(frutas.Dequeue())
        Console.WriteLine(frutas.Peek())
        Console.WriteLine(frutas.Dequeue())
        Console.WriteLine(frutas.Peek())
        CWTryDequeue(frutas)
        'Console.WriteLine(frutas.Dequeue())
        If frutas.Count > 0 Then
            Console.WriteLine(frutas.Dequeue())
        End If
        CWTryDequeue(frutas)
    End Sub

    Private Sub CWTryDequeue(frutas As Queue(Of String))
        Dim item = ""
        frutas.TryDequeue(item)
        Console.WriteLine(item)
    End Sub

    Private Sub Iterar(frutas As Queue(Of String))
        For Each item In frutas
            Console.WriteLine(item)
        Next
    End Sub
    Private Sub EjemploList()
        Dim paises As New List(Of String)
        paises.Add("Brasil")
        paises.Add("China")
        paises.Add("China")
        paises.Add("India")
        paises.Add("Rusia")
        paises.Add(1)

        Iterar(paises)
        Console.WriteLine(paises.Item(3))

        paises.Insert(3, "Australia")
        paises.RemoveAt(6)
        paises.Remove("China")

        For x = 0 To paises.Count - 1
            Console.WriteLine($"{x}: {paises(x)}") ' idem a paises.Item(x)
        Next

        paises.Sort()
        Iterar(paises)
        paises.Reverse()
        Iterar(paises)

        Console.WriteLine("Existe India: " & paises.Contains("India"))
        Console.WriteLine("Existe india: " & paises.Contains("india"))

        Console.WriteLine("Posición India: " & paises.IndexOf("India"))
        Console.WriteLine("Posición india: " & paises.IndexOf("india"))
    End Sub
    Private Sub EjemploArrayList()
        Dim paises As New ArrayList()
        paises.Add("Brasil")
        paises.Add("China")
        paises.Add("China")
        paises.Add("India")
        paises.Add("Rusia")
        paises.Add(1)

        Iterar(paises)
        Console.WriteLine(paises.Item(3))

        paises.Insert(3, "Australia")
        paises.RemoveAt(6)
        paises.Remove("China")

        For x = 0 To paises.Count - 1
            Console.WriteLine($"{x}: {paises(x)}") ' idem a paises.Item(x)
        Next

        paises.Sort()
        Iterar(paises)
        paises.Reverse()
        Iterar(paises)

        Console.WriteLine("Existe India: " & paises.Contains("India"))
        Console.WriteLine("Existe india: " & paises.Contains("india"))

        Console.WriteLine("Posición India: " & paises.IndexOf("India"))
        Console.WriteLine("Posición india: " & paises.IndexOf("india"))
    End Sub

    Private Sub Iterar(paises As ArrayList)
        For Each item In paises
            Console.WriteLine(item)
        Next
    End Sub
    Private Sub Iterar(paises As List(Of String))
        For Each item In paises
            Console.WriteLine(item)
        Next
    End Sub
End Module
