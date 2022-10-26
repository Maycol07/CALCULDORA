Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim num1, num2 As Double

        num1 = txt1.Text
        num2 = txt2.Text
        txt3.Text = num1 + num2

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1, num2 As Double

        num1 = txt1.Text
        num2 = txt2.Text
        txt3.Text = num1 - num2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim num1, num2 As Double

        num1 = txt1.Text
        num2 = txt2.Text
        txt3.Text = num1 * num2
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim num1, num2, num3 As Double

        num1 = txt1.Text
        num2 = txt2.Text
        txt3.Text = num1 / num2

        txt3.Text = Format(num3, "0.000")

    End Sub

    Sub LIMPIAR()
        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LIMPIAR()
    End Sub


End Class
