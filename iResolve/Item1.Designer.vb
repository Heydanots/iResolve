﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Item1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LABEL_A = New System.Windows.Forms.Label()
        Me.LABEL_B = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelAff = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LABEL_A
        '
        Me.LABEL_A.AutoSize = True
        Me.LABEL_A.Location = New System.Drawing.Point(154, 73)
        Me.LABEL_A.Name = "LABEL_A"
        Me.LABEL_A.Size = New System.Drawing.Size(47, 13)
        Me.LABEL_A.TabIndex = 0
        Me.LABEL_A.Text = "Entrez A"
        '
        'LABEL_B
        '
        Me.LABEL_B.AutoSize = True
        Me.LABEL_B.Location = New System.Drawing.Point(154, 99)
        Me.LABEL_B.Name = "LABEL_B"
        Me.LABEL_B.Size = New System.Drawing.Size(47, 13)
        Me.LABEL_B.TabIndex = 1
        Me.LABEL_B.Text = "Entrez B"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(214, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(214, 96)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(56, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(175, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Resoudre"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelAff
        '
        Me.LabelAff.AutoSize = True
        Me.LabelAff.Location = New System.Drawing.Point(146, 224)
        Me.LabelAff.Name = "LabelAff"
        Me.LabelAff.Size = New System.Drawing.Size(104, 13)
        Me.LabelAff.TabIndex = 5
        Me.LabelAff.Text = "Le resultat final est : "
        Me.LabelAff.Visible = False
        '
        'Item1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 292)
        Me.Controls.Add(Me.LabelAff)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LABEL_B)
        Me.Controls.Add(Me.LABEL_A)
        Me.Name = "Item1"
        Me.ShowIcon = False
        Me.Text = "Premier degré"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LABEL_A As Label
    Friend WithEvents LABEL_B As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelAff As Label
End Class
