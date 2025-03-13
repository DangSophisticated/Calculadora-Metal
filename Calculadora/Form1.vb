Public Class Form1

    Dim calc As String

    Dim resultado As Nullable(Of Double) = Nothing

    Dim valor2 As Nullable(Of Double) = Nothing

    Dim operador As Boolean

    Public Sub evaluaycalcula()
        operador = True
        valor2 = Val(txb_panel.Text)
        If resultado IsNot Nothing Then
            Select Case calc
                Case "+"
                    resultado += valor2
                Case "-"
                    resultado -= valor2
                Case "*"
                    resultado *= valor2
                Case "/"
                    resultado /= valor2
            End Select
            txb_panel.Text = resultado
        Else
            resultado = valor2

        End If
    End Sub

    Public Sub restriccion()

        If operador = True Then
            txb_panel.Text = ""
            operador = False

        ElseIf txb_panel.Text = "0" Then
            txb_panel.Text = ""
        End If

    End Sub



    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        restriccion()
        txb_panel.Text &= "0"
        My.Computer.Audio.Play("C:\Users\Hp\Downloads\Sonic Ring - Sound Effect (HD).wav")
    End Sub

    Private Sub btn_dec_Click(sender As Object, e As EventArgs) Handles btn_dec.Click
        If InStr(txb_panel.Text, ".", CompareMethod.Text) = 0 Then
            txb_panel.Text &= "."
        End If
        My.Computer.Audio.Play("C:\Users\Hp\Downloads\Sonic Ring - Sound Effect (HD).wav")
    End Sub

    Private Sub btn_igual_Click(sender As Object, e As EventArgs) Handles btn_igual.Click
        evaluaycalcula()
        calc = ""

        l_memoria.Items.Add(resultado)

        My.Computer.Audio.Play("C:\Users\Hp\Downloads\Sonic cd jump sound.wav")
    End Sub

    Private Sub btn_C_Click(sender As Object, e As EventArgs) Handles btn_C.Click
        txb_panel.Text = "0"
        resultado = Nothing
        valor2 = Nothing

        My.Computer.Audio.Play("C:\Users\Hp\Downloads\Sonic The Hedgehog Sonic Getting Hit sound effect.wav")

    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        restriccion()
        txb_panel.Text &= "1"
        My.Computer.Audio.Play("C:\Users\Hp\Downloads\Sonic Ring - Sound Effect (HD).wav")
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        restriccion()
        txb_panel.Text &= "2"
        My.Computer.Audio.Play("C:\Users\Hp\Downloads\Sonic Ring - Sound Effect (HD).wav")
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        restriccion()
        txb_panel.Text &= "3"
        My.Computer.Audio.Play("C:\Users\Hp\Downloads\Sonic Ring - Sound Effect (HD).wav")
    End Sub

    Private Sub btn_div_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        evaluaycalcula()
        calc = "/"

        My.Computer.Audio.Play("C:\Users\Hp\Downloads\Sonic cd jump sound.wav")
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        restriccion()
        txb_panel.Text &= "4"
        My.Computer.Audio.Play("C:\Users\Hp\Downloads\Sonic Ring - Sound Effect (HD).wav")
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        restriccion()
        txb_panel.Text &= "5"
        My.Computer.Audio.Play("C:\Users\Hp\Downloads\Sonic Ring - Sound Effect (HD).wav")
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        restriccion()
        txb_panel.Text &= "6"
        My.Computer.Audio.Play("C:\Users\Hp\Downloads\Sonic Ring - Sound Effect (HD).wav")
    End Sub

    Private Sub btn_por_Click(sender As Object, e As EventArgs) Handles btn_por.Click
        evaluaycalcula()
        calc = "*"

        My.Computer.Audio.Play("C:\Users\Hp\Downloads\Sonic cd jump sound.wav")
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        restriccion()
        txb_panel.Text &= "7"
        My.Computer.Audio.Play("C:\Users\Hp\Downloads\Sonic Ring - Sound Effect (HD).wav")
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        restriccion()
        txb_panel.Text &= "8"
        My.Computer.Audio.Play("C:\Users\Hp\Downloads\Sonic Ring - Sound Effect (HD).wav")

    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        restriccion()
        txb_panel.Text &= "9"

        My.Computer.Audio.Play("C:\Users\Hp\Downloads\Sonic Ring - Sound Effect (HD).wav", AudioPlayMode.Background)
    End Sub

    Private Sub btn_men_Click(sender As Object, e As EventArgs) Handles btn_men.Click
        evaluaycalcula()
        calc = "-"

        My.Computer.Audio.Play("C:\Users\Hp\Downloads\Sonic cd jump sound.wav", AudioPlayMode.Background)
    End Sub

    Private Sub btn_mas_Click(sender As Object, e As EventArgs) Handles btn_mas.Click
        evaluaycalcula()
        calc = "+"

        My.Computer.Audio.Play("C:\Users\Hp\Downloads\Sonic cd jump sound.wav", AudioPlayMode.Background)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.BackColor = Color.Transparent

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        My.Computer.Audio.Play("C:\Users\Hp\Downloads\HueHueHue  HeyHeyHey  Bad Future Version (Clean Version) - Sonic the Hedgehog CD.wav", AudioPlayMode.Background)
    End Sub
End Class
