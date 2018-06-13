<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.connectbtn = New System.Windows.Forms.Button()
        Me.logoutbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'connectbtn
        '
        Me.connectbtn.BackColor = System.Drawing.Color.Teal
        Me.connectbtn.Location = New System.Drawing.Point(303, 34)
        Me.connectbtn.Name = "connectbtn"
        Me.connectbtn.Size = New System.Drawing.Size(223, 290)
        Me.connectbtn.TabIndex = 0
        Me.connectbtn.Text = "LOGIN TO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "THE TECHNICAL UNIVERSITY OF KENYA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GRADING SYSTEM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.connectbtn.UseVisualStyleBackColor = False
        '
        'logoutbtn
        '
        Me.logoutbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.logoutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logoutbtn.Location = New System.Drawing.Point(12, 34)
        Me.logoutbtn.Name = "logoutbtn"
        Me.logoutbtn.Size = New System.Drawing.Size(239, 290)
        Me.logoutbtn.TabIndex = 1
        Me.logoutbtn.Text = "LOGOUT FROM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "THE TECHNICAL UNIVERSITY OF KENYA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GRADING SYSTEM"
        Me.logoutbtn.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 367)
        Me.Controls.Add(Me.logoutbtn)
        Me.Controls.Add(Me.connectbtn)
        Me.Name = "MainForm"
        Me.Text = "TECHNICAL UNIVERSITY OF KENYA GRADE SYSTEM"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents connectbtn As Button
    Friend WithEvents logoutbtn As Button
End Class
