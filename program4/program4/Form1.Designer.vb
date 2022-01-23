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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fclose = New System.Windows.Forms.Button()
        Me.fnext = New System.Windows.Forms.Button()
        Me.hitme = New System.Windows.Forms.Button()
        Me.mess = New System.Windows.Forms.Label()
        Me.gfemale = New System.Windows.Forms.RadioButton()
        Me.gmale = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.fclose)
        Me.GroupBox1.Controls.Add(Me.fnext)
        Me.GroupBox1.Controls.Add(Me.hitme)
        Me.GroupBox1.Controls.Add(Me.mess)
        Me.GroupBox1.Controls.Add(Me.gfemale)
        Me.GroupBox1.Controls.Add(Me.gmale)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(626, 319)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gender"
        '
        'fclose
        '
        Me.fclose.Location = New System.Drawing.Point(525, 242)
        Me.fclose.Name = "fclose"
        Me.fclose.Size = New System.Drawing.Size(61, 34)
        Me.fclose.TabIndex = 5
        Me.fclose.Text = "×"
        Me.fclose.UseVisualStyleBackColor = True
        '
        'fnext
        '
        Me.fnext.Location = New System.Drawing.Point(385, 242)
        Me.fnext.Name = "fnext"
        Me.fnext.Size = New System.Drawing.Size(112, 34)
        Me.fnext.TabIndex = 4
        Me.fnext.Text = "Next"
        Me.fnext.UseVisualStyleBackColor = True
        '
        'hitme
        '
        Me.hitme.Location = New System.Drawing.Point(244, 242)
        Me.hitme.Name = "hitme"
        Me.hitme.Size = New System.Drawing.Size(112, 34)
        Me.hitme.TabIndex = 3
        Me.hitme.Text = "Hit Me"
        Me.hitme.UseVisualStyleBackColor = True
        '
        'mess
        '
        Me.mess.AutoSize = True
        Me.mess.Location = New System.Drawing.Point(28, 155)
        Me.mess.Name = "mess"
        Me.mess.Size = New System.Drawing.Size(0, 25)
        Me.mess.TabIndex = 2
        '
        'gfemale
        '
        Me.gfemale.AutoSize = True
        Me.gfemale.Location = New System.Drawing.Point(182, 61)
        Me.gfemale.Name = "gfemale"
        Me.gfemale.Size = New System.Drawing.Size(93, 29)
        Me.gfemale.TabIndex = 1
        Me.gfemale.Text = "Female"
        Me.gfemale.UseVisualStyleBackColor = True
        '
        'gmale
        '
        Me.gmale.AutoSize = True
        Me.gmale.Location = New System.Drawing.Point(38, 61)
        Me.gmale.Name = "gmale"
        Me.gmale.Size = New System.Drawing.Size(75, 29)
        Me.gmale.TabIndex = 0
        Me.gmale.Text = "Male"
        Me.gmale.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 346)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Radio Button"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents fclose As Button
    Friend WithEvents fnext As Button
    Friend WithEvents hitme As Button
    Friend WithEvents mess As Label
    Friend WithEvents gfemale As RadioButton
    Friend WithEvents gmale As RadioButton
End Class
