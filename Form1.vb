Public Class Form1

    Dim arrayData() As Integer = {24, 12, 16, 32, 41, 22}

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        printArray()
        SelSort()
        printArray()
    End Sub

    Private Sub SelSort()
        Dim endUnsorted As Integer
        Dim max As Integer
        Dim posMax As Integer
        Dim i As Integer

        endUnsorted = arrayData.Length - 1
        While endUnsorted > 0
            i = 0
            max = arrayData(i)
            posMax = i
            While i < endUnsorted
                i += 1
                If arrayData(i) > max Then
                    max = arrayData(i)
                    posMax = i
                End If
            End While
            swap(arrayData, posMax, endUnsorted)
            endUnsorted -= 1

        End While

    End Sub

    Private Sub swap(arr() As Integer, a As Integer, b As Integer)
        Dim temp As Integer
        temp = arr(a)
        arr(a) = arr(b)
        arr(b) = temp
    End Sub

    Private Sub printArray()
        Dim temp As String
        temp = " "
        For i = 0 To 5
            temp = temp + " " & CStr(arrayData(i))
        Next i
        ListBox1.Items.Add(temp)
    End Sub

End Class
