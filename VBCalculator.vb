Public Class VBCalculator
    Public Shared Sub Main(args As String())
        Console.Write("Enter the first number: ")
        Dim num1 = Double.Parse(Console.ReadLine())

        Console.WriteLine("Choose between:" + vbCrLf + "1) Addition" + vbCrLf + "2) Subtraction" + vbCrLf + "3) Multiplication" + vbCrLf + "4) Division")
        Dim calculationType = Console.ReadLine()

        Console.Write("Enter the second number: ")
        Dim num2 = Double.Parse(Console.ReadLine())
        
        Select Case calculationType     
            Case "1"                
                Console.Write(num1 + num2)    
            Case "2"                
                Console.Write(num1 - num2)
            Case "3"  
                Console.Write(num1 * num2)
            Case "4"   
                Console.Write(num1 / num2)
            Case Else 
                Console.Write(calculationType + " is not a valid function")
        End Select
    End Sub
End Class
