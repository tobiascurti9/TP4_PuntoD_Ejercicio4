<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lstSalida = New ListBox()
        cmdEjecutar = New Button()
        lstSalida1 = New ListBox()
        SuspendLayout()
        ' 
        ' lstSalida
        ' 
        lstSalida.FormattingEnabled = True
        lstSalida.Location = New Point(43, 35)
        lstSalida.Name = "lstSalida"
        lstSalida.Size = New Size(288, 354)
        lstSalida.TabIndex = 0
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.Location = New Point(337, 1)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(112, 34)
        cmdEjecutar.TabIndex = 2
        cmdEjecutar.Text = "Ejecutar"
        cmdEjecutar.UseVisualStyleBackColor = True
        ' 
        ' lstSalida1
        ' 
        lstSalida1.FormattingEnabled = True
        lstSalida1.Location = New Point(473, 10)
        lstSalida1.Name = "lstSalida1"
        lstSalida1.Size = New Size(292, 404)
        lstSalida1.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstSalida1)
        Controls.Add(cmdEjecutar)
        Controls.Add(lstSalida)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstSalida As ListBox
    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents lstSalida1 As ListBox

End Class
