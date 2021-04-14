Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblOutput.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        'read input
        'declare variable first
        Dim num1 As Integer
        Dim result As Integer
        'error check your read
        Try
            'read the input and assign
            num1 = CInt(txtInput.Text)
            'call your fn
            result = getSquare(num1)
            lblOutput.Text = "The square value is " & result.ToString & "."
        Catch ex As Exception
            MessageBox.Show("Please enter numerical values.")
        End Try
    End Sub 'end of click event
    'write a fn that computes the square value
    Public Function getSquare(ByVal numGiven As Integer) As Integer
        'Dim myresult As Integer
        ' myresult = CInt(numGiven ^ 2)
        'Return myresult
        Return CInt(numGiven ^ 2)
    End Function
End Class
