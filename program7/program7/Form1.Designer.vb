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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.enterrs = New System.Windows.Forms.TextBox()
        Me.ans = New System.Windows.Forms.TextBox()
        Me.convertinto = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter RS."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Convert Into."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Answer"
        '
        'enterrs
        '
        Me.enterrs.Location = New System.Drawing.Point(218, 61)
        Me.enterrs.Name = "enterrs"
        Me.enterrs.Size = New System.Drawing.Size(216, 31)
        Me.enterrs.TabIndex = 3
        '
        'ans
        '
        Me.ans.Location = New System.Drawing.Point(218, 205)
        Me.ans.Name = "ans"
        Me.ans.Size = New System.Drawing.Size(216, 31)
        Me.ans.TabIndex = 4
        '
        'convertinto
        '
        Me.convertinto.FormattingEnabled = True
        Me.convertinto.Items.AddRange(New Object() {"Dollar", "Yen", "Euro"})
        Me.convertinto.Location = New System.Drawing.Point(218, 132)
        Me.convertinto.Name = "convertinto"
        Me.convertinto.Size = New System.Drawing.Size(216, 33)
        Me.convertinto.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 287)
        Me.Controls.Add(Me.convertinto)
        Me.Controls.Add(Me.ans)
        Me.Controls.Add(Me.enterrs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "currency converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents enterrs As TextBox
    Friend WithEvents ans As TextBox
    Friend WithEvents convertinto As ComboBox
End Class
