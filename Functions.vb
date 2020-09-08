Module Functions

    Sub Main()
        Dim aLetter As String
        aLetter = "Q"
        Console.WriteLine(aLetter)
        Console.ReadLine()
    End Sub

    Function Letter()
        Dim someOtherLetter As String
        someOtherLetter = "Y"
        Return someOtherLetter
    End Function

    Sub DoesNotReturn()
        Dim someOtherLetter As String
        someOtherLetter = "X"
    End Sub

    Function AddNumber() As Integer
End Module
