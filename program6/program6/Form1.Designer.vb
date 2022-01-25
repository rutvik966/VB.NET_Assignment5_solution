<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.l2 = New System.Windows.Forms.ListBox()
        Me.l1 = New System.Windows.Forms.ListBox()
        Me.mess = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'l2
        '
        Me.l2.FormattingEnabled = True
        Me.l2.ItemHeight = 25
        Me.l2.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "L", "J", "K", "M", "N", "O", "P", "Q", "R", "U", "T", "V", "S", "W", "X", "Y", "Z"})
        Me.l2.Location = New System.Drawing.Point(13, 13)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(53, 654)
        Me.l2.TabIndex = 0
        '
        'l1
        '
        Me.l1.FormattingEnabled = True
        Me.l1.ItemHeight = 25
        Me.l1.Items.AddRange(New Object() {"Amit", "Aakash", "Akshay", "bjgjg", "cjkkjd", "Rutvik", "utsav", "yagnik"})
        Me.l1.Location = New System.Drawing.Point(99, 13)
        Me.l1.Name = "l1"
        Me.l1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.l1.Size = New System.Drawing.Size(180, 654)
        Me.l1.TabIndex = 1
        '
        'mess
        '
        Me.mess.AutoSize = True
        Me.mess.Location = New System.Drawing.Point(13, 697)
        Me.mess.Name = "mess"
        Me.mess.Size = New System.Drawing.Size(0, 25)
        Me.mess.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 742)
        Me.Controls.Add(Me.mess)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.l2)
        Me.Name = "Form1"
        Me.Text = " Form List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents l2 As ListBox
    Friend WithEvents l1 As ListBox
    Friend WithEvents mess As Label
End Class
