Module VBModule
 
 Sub Main()
    Console.ForegroundColor=ConsoleColor.Red ' set text color to red
    Console.writeLine("Please only input numbers.")
    Console.ResetColor() ' reset text color
    Console.write("What did you score on hole #1? ")
    Dim h1 As Integer=console.readline()
    Console.write("What did you score on hole #2? ")
    Dim h2 As Integer=console.readline()
    Console.write("What did you score on hole #3? ")
    Dim h3 As Integer=console.readline()
    Console.write("What did you score on hole #4? ")
    Dim h4 As Integer=console.readline()
    Console.write("What did you score on hole #5? ")
    Dim h5 As Integer=console.readline()
    Console.write("What did you score on hole #6? ")
    Dim h6 As Integer=console.readline()
    Console.write("What did you score on hole #7? ")
    Dim h7 As Integer=console.readline()
    Console.write("What did you score on hole #8? ")
    Dim h8 As Integer=console.readline()
    Console.write("What did you score on hole #9? ")
    Dim h9 As Integer = console.readline()
    Dim compScore As Integer = h1+h2+h3+h4+h5+h6+h7+h8+h9
    Console.writeLine("Your score is " & compScore & ".")
    If compScore > 36 Then
        Console.writeLine("Better Luck next time!")
    Else
        Console.writeLine("Congrats!")
    End If
 End Sub
End Module
