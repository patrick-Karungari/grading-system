<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordForm
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
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.idlbl = New System.Windows.Forms.Label()
        Me.pwlbl = New System.Windows.Forms.Label()
        Me.idtxt = New System.Windows.Forms.TextBox()
        Me.pwtxt = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'cancelbtn
        '
        Me.cancelbtn.Location = New System.Drawing.Point(12, 146)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelbtn.TabIndex = 0
        Me.cancelbtn.Text = "CANCEL"
        Me.cancelbtn.UseVisualStyleBackColor = True
        '
        'loginbtn
        '
        Me.loginbtn.Location = New System.Drawing.Point(259, 146)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(75, 23)
        Me.loginbtn.TabIndex = 1
        Me.loginbtn.Text = "LOGIN"
        Me.loginbtn.UseVisualStyleBackColor = True
        '
        'idlbl
        '
        Me.idlbl.AutoSize = True
        Me.idlbl.Location = New System.Drawing.Point(30, 24)
        Me.idlbl.Name = "idlbl"
        Me.idlbl.Size = New System.Drawing.Size(51, 13)
        Me.idlbl.TabIndex = 2
        Me.idlbl.Text = "USER ID"
        '
        'pwlbl
        '
        Me.pwlbl.AutoSize = True
        Me.pwlbl.Location = New System.Drawing.Point(12, 90)
        Me.pwlbl.Name = "pwlbl"
        Me.pwlbl.Size = New System.Drawing.Size(70, 13)
        Me.pwlbl.TabIndex = 3
        Me.pwlbl.Text = "PASSWORD"
        '
        'idtxt
        '
        Me.idtxt.Location = New System.Drawing.Point(143, 17)
        Me.idtxt.Name = "idtxt"
        Me.idtxt.Size = New System.Drawing.Size(100, 20)
        Me.idtxt.TabIndex = 4
        '
        'pwtxt
        '
        Me.pwtxt.Location = New System.Drawing.Point(143, 83)
        Me.pwtxt.Name = "pwtxt"
        Me.pwtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwtxt.Size = New System.Drawing.Size(100, 20)
        Me.pwtxt.TabIndex = 5
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.RoyalBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(216, 186)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(172, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot Password? Reset Password"
        '
        'PasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 208)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.pwtxt)
        Me.Controls.Add(Me.idtxt)
        Me.Controls.Add(Me.pwlbl)
        Me.Controls.Add(Me.idlbl)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.cancelbtn)
        Me.Name = "PasswordForm"
        Me.Text = "LOGIN TO SYSTEM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cancelbtn As Button
    Friend WithEvents loginbtn As Button
    Friend WithEvents idlbl As Label
    Friend WithEvents pwlbl As Label
    Friend WithEvents idtxt As TextBox
    Friend WithEvents pwtxt As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
