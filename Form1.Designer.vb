<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtInputBinary = New System.Windows.Forms.TextBox()
        Me.txtOutpuBinary = New System.Windows.Forms.TextBox()
        Me.txtInputHex = New System.Windows.Forms.TextBox()
        Me.txtOutputHex = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(206, 362)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Change"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtInput.Location = New System.Drawing.Point(206, 64)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(148, 35)
        Me.txtInput.TabIndex = 1
        '
        'txtInputBinary
        '
        Me.txtInputBinary.Enabled = False
        Me.txtInputBinary.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtInputBinary.Location = New System.Drawing.Point(305, 187)
        Me.txtInputBinary.Name = "txtInputBinary"
        Me.txtInputBinary.Size = New System.Drawing.Size(148, 39)
        Me.txtInputBinary.TabIndex = 1
        '
        'txtOutpuBinary
        '
        Me.txtOutpuBinary.Enabled = False
        Me.txtOutpuBinary.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtOutpuBinary.Location = New System.Drawing.Point(305, 238)
        Me.txtOutpuBinary.Name = "txtOutpuBinary"
        Me.txtOutpuBinary.Size = New System.Drawing.Size(148, 39)
        Me.txtOutpuBinary.TabIndex = 1
        '
        'txtInputHex
        '
        Me.txtInputHex.Enabled = False
        Me.txtInputHex.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtInputHex.Location = New System.Drawing.Point(110, 187)
        Me.txtInputHex.Name = "txtInputHex"
        Me.txtInputHex.Size = New System.Drawing.Size(148, 39)
        Me.txtInputHex.TabIndex = 1
        '
        'txtOutputHex
        '
        Me.txtOutputHex.Enabled = False
        Me.txtOutputHex.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtOutputHex.Location = New System.Drawing.Point(110, 238)
        Me.txtOutputHex.Name = "txtOutputHex"
        Me.txtOutputHex.Size = New System.Drawing.Size(148, 39)
        Me.txtOutputHex.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Input"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Output"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(155, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hex"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(339, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Bin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(70, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 24)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Input Dec"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 442)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOutputHex)
        Me.Controls.Add(Me.txtOutpuBinary)
        Me.Controls.Add(Me.txtInputHex)
        Me.Controls.Add(Me.txtInputBinary)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents txtInputBinary As System.Windows.Forms.TextBox
    Friend WithEvents txtOutpuBinary As System.Windows.Forms.TextBox
    Friend WithEvents txtInputHex As System.Windows.Forms.TextBox
    Friend WithEvents txtOutputHex As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
