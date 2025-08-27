Public Class frmLoadingScreen
    Dim r = 0
    Dim g = 140
    Dim b = 140
    Dim x = 0
    Dim y = 0

    Private Sub frmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrLoading.Start()
    End Sub

    Private Sub tmrLoading_Tick(sender As Object, e As EventArgs) Handles tmrLoading.Tick
        Me.BackColor = Color.FromArgb(r, g, b)
        If x = 0 Then
            If g >= 40 Then
                g -= 1
                b -= 1
            Else
                x = 1
            End If
        Else
            g += 1
            b += 1
            If g = 140 Then
                x = 0
            End If
        End If

        y += 1

        If y = 400 Then
            Me.Hide()
            frmHome.Show()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        End
    End Sub
End Class
