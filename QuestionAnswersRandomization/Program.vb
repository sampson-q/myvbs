Imports System

Module Program
    Function updateArray(ommitIndex As Integer, array() As String) As String()
        Dim tempArray(array.Length - 2) As String
        Dim counter As Integer = 0

        For i As Integer = 0 To (array.Length - 1)
            If (i <> ommitIndex) Then
                tempArray(counter) = array(i)
                counter += 1
            End If
        Next

        Return tempArray
    End Function

    Function updateArray(ommitIndex As Integer, array()() As String) As String()()
        Dim tempArray(array.Length - 2)() As String
        Dim counter As Integer = 0

        For i As Integer = 0 To (array.Length - 1)
            If (i <> ommitIndex) Then
                tempArray(counter) = array(i)
                counter += 1
            End If
        Next

        Return tempArray
    End Function

    Function randomizeElements(questionsArray() As String, choicesArray()() As String, answersArray() As String) As String()
        Dim random As New Random
        Dim questionsCounter As Integer = 0
        Dim questionSize = questionsArray.Length
        Dim choiceLetters() As String = {"A", "B", "C", "D", "E", "F", "G", "H"}
        Dim studentAnswers(questionsArray.Length - 1) As String
        Dim answersArrayBackup(answersArray.Length - 1) As String

        While questionsCounter < questionSize
            Dim randomQuestion As Integer = random.Next(0, questionsArray.Length)
            Console.WriteLine((questionsCounter + 1) & ". " & questionsArray(randomQuestion))

            Dim choicesCounter As Integer = 0
            Dim choiceSize = choicesArray(randomQuestion).Length

            Dim choicesArrayBackup(choiceSize - 1) As String

            While choicesCounter < choiceSize
                Dim randomChoice As Integer = random.Next(0, choicesArray(randomQuestion).Length)

                Console.WriteLine("   " & choiceLetters(choicesCounter) & ". " & choicesArray(randomQuestion)(randomChoice))

                choicesArrayBackup(choicesCounter) = choicesArray(randomQuestion)(randomChoice)
                choicesArray(randomQuestion) = updateArray(randomChoice, choicesArray(randomQuestion))
                choicesCounter += 1
            End While

            Console.Write("   Enter Choice: ")
            Dim studentChoice As String = Console.ReadLine()

            studentAnswers(questionsCounter) = choicesArrayBackup(Array.IndexOf(choiceLetters, studentChoice))
            answersArrayBackup(questionsCounter) = answersArray(randomQuestion)


            Console.WriteLine(answersArray(randomQuestion))

            questionsArray = updateArray(randomQuestion, questionsArray)
            choicesArray = updateArray(randomQuestion, choicesArray)
            questionsCounter += 1
        End While

        Console.Write("Correct Answers: ")
        For Each randomAnswers As String In answersArrayBackup
            Console.Write(randomAnswers & ", ")
        Next

        Return studentAnswers
    End Function

    Sub Main(args As String())
        Dim questions() As String = {"What is your name?", "How old are you?", "What is your class?", "Have you eaten yet?"}
        Dim choices()() As String = {
            ({"Sampson", "Sylvia", "Hash", "TooSweet"}),
            ({"18", "19", "20", "21"}),
            ({"KG1", "KG5", "Class 2", "JHS 3"}),
            ({"Yes", "Maybe", "No", "I don't know", "Mmai"})
        }
        Dim answers() As String = {"Sampson", "21", "JHS 3", "Mmai"}
        Dim studentAnswers = randomizeElements(questions, choices, answers)


    End Sub
End Module
