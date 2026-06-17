Imports System.Numerics

Public Class Form1
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim Vector1(10), Vector2(15), I As Integer
        For I = 0 To 9 Step 1
            Vector1(I) = InputBox("Ingresar Valores", "Carga", 0)
        Next I
        Vector2(1) = Vector1(1)
        Vector2(2) = Vector1(2)
        For I = 2 To 14 Step 1
            Vector2(I) = Vector2(I - 1) + Vector2(I - 2)

        Next I
        lstSalida.Items.Add("Vector 1:")
        For I = 0 To 9 Step 1
            lstSalida.Items.Add(Vector1(I))
        Next I
        lstSalida1.Items.Add("Vector 2:")
        For I = 0 To 14 Step 1
            lstSalida1.Items.Add(Vector2(I))
        Next I
    End Sub
End Class
