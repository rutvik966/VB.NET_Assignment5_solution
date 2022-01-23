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
        Me.empid = New System.Windows.Forms.TextBox()
        Me.empname = New System.Windows.Forms.TextBox()
        Me.empsalary = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.netsalary = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter EMP Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter EMP Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter Basic Salary"
        '
        'empid
        '
        Me.empid.Location = New System.Drawing.Point(246, 49)
        Me.empid.Name = "empid"
        Me.empid.Size = New System.Drawing.Size(173, 31)
        Me.empid.TabIndex = 3
        '
        'empname
        '
        Me.empname.Location = New System.Drawing.Point(246, 112)
        Me.empname.Name = "empname"
        Me.empname.Size = New System.Drawing.Size(173, 31)
        Me.empname.TabIndex = 4
        '
        'empsalary
        '
        Me.empsalary.Location = New System.Drawing.Point(246, 181)
        Me.empsalary.Name = "empsalary"
        Me.empsalary.Size = New System.Drawing.Size(173, 31)
        Me.empsalary.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(155, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Show NET Salary"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 366)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "EMP NET Salary Is "
        '
        'netsalary
        '
        Me.netsalary.Location = New System.Drawing.Point(234, 366)
        Me.netsalary.Name = "netsalary"
        Me.netsalary.ReadOnly = True
        Me.netsalary.Size = New System.Drawing.Size(185, 31)
        Me.netsalary.TabIndex = 8
        Me.netsalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 450)
        Me.Controls.Add(Me.netsalary)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.empsalary)
        Me.Controls.Add(Me.empname)
        Me.Controls.Add(Me.empid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Employee Salary Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents empid As TextBox
    Friend WithEvents empname As TextBox
    Friend WithEvents empsalary As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents netsalary As TextBox
End Class
