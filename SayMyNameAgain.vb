'Ian Gunter
'RCET0265
'Spring 2020
'Say My Name Again
'https://github.com/IanGunter/SayMyNameAgain_.git

Option Strict On
Option Explicit On
Option Compare Text




Module SayMyNameAgain

    Sub Main()
        'Dim assigns the next word to whatever As is assigned to. 
        Dim Input As String
        Dim Input2 As String
        Console.WriteLine("What Is your name?")
        Input = Console.ReadLine()

        If Input = "Emily" Then
            Console.WriteLine("Wow " & Input & "! Thats an awesome name!")

        ElseIf Input = "Joe" Then
            Console.WriteLine("Wow " & Input & "! Thats an awesome name!")

        ElseIf Input = "Ian" Then
            Console.WriteLine("Oh, I've heard of you! " & Input & " The G!! What a pleasure to meet you.")

        ElseIf Input = "Tim" Then
            Console.WriteLine("Tim? Rossiter or Leishman?")

            'Input2 asks a second round of questions depending on the users answer to the 1st questions.

            Input2 = Console.ReadLine()

            If Input2 = "Rossiter" Then
                Console.WriteLine("Good Work!")


            ElseIf Input2 = "Leishman" Then
                Console.WriteLine("Wheres your schematic?")


            ElseIf Input2 <> "Leishman" Or Input2 <> "Rossiter" Then
                Console.WriteLine("Fine then. Keep your secrets ;)")

            End If

        End If

        Console.ReadLine()
    End Sub

End Module






