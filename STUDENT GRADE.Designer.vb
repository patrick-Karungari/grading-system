<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class STUDENT_GRADE
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
        Me.cat1lbl = New System.Windows.Forms.Label()
        Me.cat2lbl = New System.Windows.Forms.Label()
        Me.mainlbl = New System.Windows.Forms.Label()
        Me.averagelbl = New System.Windows.Forms.Label()
        Me.gradelbl = New System.Windows.Forms.Label()
        Me.cat1txt = New System.Windows.Forms.TextBox()
        Me.cat2txt = New System.Windows.Forms.TextBox()
        Me.maintxt = New System.Windows.Forms.TextBox()
        Me.averagetxt = New System.Windows.Forms.TextBox()
        Me.gradetxt = New System.Windows.Forms.TextBox()
        Me.calcbtn = New System.Windows.Forms.Button()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cat1lbl
        '
        Me.cat1lbl.AutoSize = True
        Me.cat1lbl.Location = New System.Drawing.Point(89, 9)
        Me.cat1lbl.Name = "cat1lbl"
        Me.cat1lbl.Size = New System.Drawing.Size(149, 13)
        Me.cat1lbl.TabIndex = 0
        Me.cat1lbl.Text = "ENTER MARKS FOR CAT 1 :"
        '
        'cat2lbl
        '
        Me.cat2lbl.AutoSize = True
        Me.cat2lbl.Location = New System.Drawing.Point(89, 97)
        Me.cat2lbl.Name = "cat2lbl"
        Me.cat2lbl.Size = New System.Drawing.Size(149, 13)
        Me.cat2lbl.TabIndex = 1
        Me.cat2lbl.Text = "ENTER MARKS FOR CAT 2 :"
        '
        'mainlbl
        '
        Me.mainlbl.AutoSize = True
        Me.mainlbl.Location = New System.Drawing.Point(59, 181)
        Me.mainlbl.Name = "mainlbl"
        Me.mainlbl.Size = New System.Drawing.Size(179, 13)
        Me.mainlbl.TabIndex = 2
        Me.mainlbl.Text = "ENTER MARKS FOR MAIN EXAM :"
        '
        'averagelbl
        '
        Me.averagelbl.AutoSize = True
        Me.averagelbl.Location = New System.Drawing.Point(535, 97)
        Me.averagelbl.Name = "averagelbl"
        Me.averagelbl.Size = New System.Drawing.Size(64, 13)
        Me.averagelbl.TabIndex = 3
        Me.averagelbl.Text = "AVERAGE :"
        '
        'gradelbl
        '
        Me.gradelbl.AutoSize = True
        Me.gradelbl.Location = New System.Drawing.Point(548, 276)
        Me.gradelbl.Name = "gradelbl"
        Me.gradelbl.Size = New System.Drawing.Size(51, 13)
        Me.gradelbl.TabIndex = 4
        Me.gradelbl.Text = "GRADE :"
        '
        'cat1txt
        '
        Me.cat1txt.Location = New System.Drawing.Point(291, 2)
        Me.cat1txt.Multiline = True
        Me.cat1txt.Name = "cat1txt"
        Me.cat1txt.Size = New System.Drawing.Size(100, 53)
        Me.cat1txt.TabIndex = 5
        Me.cat1txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cat2txt
        '
        Me.cat2txt.Location = New System.Drawing.Point(291, 90)
        Me.cat2txt.Multiline = True
        Me.cat2txt.Name = "cat2txt"
        Me.cat2txt.Size = New System.Drawing.Size(100, 56)
        Me.cat2txt.TabIndex = 6
        Me.cat2txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'maintxt
        '
        Me.maintxt.Location = New System.Drawing.Point(291, 174)
        Me.maintxt.Multiline = True
        Me.maintxt.Name = "maintxt"
        Me.maintxt.Size = New System.Drawing.Size(100, 52)
        Me.maintxt.TabIndex = 7
        Me.maintxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'averagetxt
        '
        Me.averagetxt.Location = New System.Drawing.Point(655, 55)
        Me.averagetxt.Multiline = True
        Me.averagetxt.Name = "averagetxt"
        Me.averagetxt.Size = New System.Drawing.Size(100, 79)
        Me.averagetxt.TabIndex = 8
        Me.averagetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gradetxt
        '
        Me.gradetxt.Location = New System.Drawing.Point(655, 243)
        Me.gradetxt.Multiline = True
        Me.gradetxt.Name = "gradetxt"
        Me.gradetxt.Size = New System.Drawing.Size(101, 65)
        Me.gradetxt.TabIndex = 9
        Me.gradetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'calcbtn
        '
        Me.calcbtn.Location = New System.Drawing.Point(291, 276)
        Me.calcbtn.Name = "calcbtn"
        Me.calcbtn.Size = New System.Drawing.Size(149, 68)
        Me.calcbtn.TabIndex = 10
        Me.calcbtn.Text = "GRADE STUDENT"
        Me.calcbtn.UseVisualStyleBackColor = True
        '
        'cancelbtn
        '
        Me.cancelbtn.Location = New System.Drawing.Point(482, 373)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(306, 51)
        Me.cancelbtn.TabIndex = 11
        Me.cancelbtn.Text = "CANCEL"
        Me.cancelbtn.UseVisualStyleBackColor = True
        '
        'STUDENT_GRADE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.calcbtn)
        Me.Controls.Add(Me.gradetxt)
        Me.Controls.Add(Me.averagetxt)
        Me.Controls.Add(Me.maintxt)
        Me.Controls.Add(Me.cat2txt)
        Me.Controls.Add(Me.cat1txt)
        Me.Controls.Add(Me.gradelbl)
        Me.Controls.Add(Me.averagelbl)
        Me.Controls.Add(Me.mainlbl)
        Me.Controls.Add(Me.cat2lbl)
        Me.Controls.Add(Me.cat1lbl)
        Me.Name = "STUDENT_GRADE"
        Me.Text = "STUDENT GRADE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cat1lbl As Label
    Friend WithEvents cat2lbl As Label
    Friend WithEvents mainlbl As Label
    Friend WithEvents averagelbl As Label
    Friend WithEvents gradelbl As Label
    Friend WithEvents cat1txt As TextBox
    Friend WithEvents cat2txt As TextBox
    Friend WithEvents maintxt As TextBox
    Friend WithEvents averagetxt As TextBox
    Friend WithEvents gradetxt As TextBox
    Friend WithEvents calcbtn As Button
    Friend WithEvents cancelbtn As Button
End Class
