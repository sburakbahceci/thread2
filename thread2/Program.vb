Imports System.Threading
Module Module1
    Private Sub th3(ByVal m As Object)
        For i As Integer = 0 To 1000
            Console.WriteLine("{0} ->> {1}", i, Math.Pow(i, 2))
            Thread.Sleep(80)
        Next
    End Sub

    Private Sub th4(ByVal l As Object)
        For i As Integer = 1000 To 0 Step -1
            Console.WriteLine("{0} ->> {1}", i, Math.Pow(i, 2))
            Thread.Sleep(100)
        Next
    End Sub
    Sub Main()
        Dim thread3 As Thread
        Dim thread4 As Thread

        thread3 = New Thread(AddressOf th3)
        thread3.Start()
        thread4 = New Thread(AddressOf th4)
        thread4.Start()
    End Sub
End Module
