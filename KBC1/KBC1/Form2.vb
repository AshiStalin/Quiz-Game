Public Class Form2
    Dim form1 As New Form
    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    End Sub
End Class