'Carson Bogart
'RCET 0265
'Spring 2022
'Simple calculator
'https://github.com/bogacars/SimpleCalculator_VB_CB.git

Option Explicit On
Option Strict On
Module SimpleCalculator

    Sub Main()
        'assign the variables below a type
        Dim userInput As String
        Dim number1 As Integer
        Dim number2 As Integer

        Console.WriteLine("Please enter a number")
        'convert number1 to an integer
        number1 = CInt(Console.ReadLine)

        Console.WriteLine("Enter a second number")
        'convert number2 to an integer
        number2 = CInt(Console.ReadLine)

        Console.WriteLine("Enter + or * to add or multiply")
        'gives the user an option between operations
        userInput = Console.ReadLine()

        If userInput = "+" Then
            'if "+" is entered then the line below will execute
            Console.WriteLine(number1 & " + " & number2 & " = " & number1 + number2)
        ElseIf userInput = "*" Then
            'if "*" is entered then the line below will execute
            Console.WriteLine(number1 & " * " & number2 & " = " & number1 * number2)
        Else
            'if "+" or "*" is not selected the line below will run
            Console.WriteLine("You can't do that try again")

        End If

        Console.WriteLine("Press enter to exit this program")


        'wait for user input
        Console.ReadLine()

    End Sub

End Module
