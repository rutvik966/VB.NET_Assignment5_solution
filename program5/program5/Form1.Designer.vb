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
        Me.additem = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.l1 = New System.Windows.Forms.ListBox()
        Me.l2 = New System.Windows.Forms.ListBox()
        Me.b1 = New System.Windows.Forms.Button()
        Me.bb1 = New System.Windows.Forms.Button()
        Me.bb2 = New System.Windows.Forms.Button()
        Me.bb3 = New System.Windows.Forms.Button()
        Me.b2 = New System.Windows.Forms.Button()
        Me.b3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Items"
        '
        'additem
        '
        Me.additem.Location = New System.Drawing.Point(136, 69)
        Me.additem.Name = "additem"
        Me.additem.Size = New System.Drawing.Size(259, 31)
        Me.additem.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(432, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'l1
        '
        Me.l1.FormattingEnabled = True
        Me.l1.ItemHeight = 25
        Me.l1.Location = New System.Drawing.Point(28, 154)
        Me.l1.Name = "l1"
        Me.l1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.l1.Size = New System.Drawing.Size(186, 354)
        Me.l1.TabIndex = 3
        '
        'l2
        '
        Me.l2.FormattingEnabled = True
        Me.l2.ItemHeight = 25
        Me.l2.Location = New System.Drawing.Point(358, 154)
        Me.l2.Name = "l2"
        Me.l2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.l2.Size = New System.Drawing.Size(186, 354)
        Me.l2.TabIndex = 4
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(229, 154)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(112, 34)
        Me.b1.TabIndex = 5
        Me.b1.Text = ">"
        Me.b1.UseVisualStyleBackColor = True
        '
        'bb1
        '
        Me.bb1.Location = New System.Drawing.Point(229, 355)
        Me.bb1.Name = "bb1"
        Me.bb1.Size = New System.Drawing.Size(112, 34)
        Me.bb1.TabIndex = 6
        Me.bb1.Text = "<"
        Me.bb1.UseVisualStyleBackColor = True
        '
        'bb2
        '
        Me.bb2.Location = New System.Drawing.Point(229, 413)
        Me.bb2.Name = "bb2"
        Me.bb2.Size = New System.Drawing.Size(112, 34)
        Me.bb2.TabIndex = 7
        Me.bb2.Text = "<<"
        Me.bb2.UseVisualStyleBackColor = True
        '
        'bb3
        '
        Me.bb3.Location = New System.Drawing.Point(229, 474)
        Me.bb3.Name = "bb3"
        Me.bb3.Size = New System.Drawing.Size(112, 34)
        Me.bb3.TabIndex = 8
        Me.bb3.Text = "<<<"
        Me.bb3.UseVisualStyleBackColor = True
        '
        'b2
        '
        Me.b2.Location = New System.Drawing.Point(229, 212)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(112, 34)
        Me.b2.TabIndex = 9
        Me.b2.Text = ">>"
        Me.b2.UseVisualStyleBackColor = True
        '
        'b3
        '
        Me.b3.Location = New System.Drawing.Point(229, 277)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(112, 34)
        Me.b3.TabIndex = 10
        Me.b3.Text = ">>>"
        Me.b3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 533)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.bb3)
        Me.Controls.Add(Me.bb2)
        Me.Controls.Add(Me.bb1)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.additem)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "ListBox MoveMent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents additem As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents l1 As ListBox
    Friend WithEvents l2 As ListBox
    Friend WithEvents b1 As Button
    Friend WithEvents bb1 As Button
    Friend WithEvents bb2 As Button
    Friend WithEvents bb3 As Button
    Friend WithEvents b2 As Button
    Friend WithEvents b3 As Button
End Class
