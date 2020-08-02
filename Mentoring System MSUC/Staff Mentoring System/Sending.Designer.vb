<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sending
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sending))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.MessageTxt = New System.Windows.Forms.RichTextBox()
        Me.MailIdTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.SubjectTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.ToTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(422, 9)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(204, 46)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Send Email "
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(100, 122)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(49, 20)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "FROM"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(100, 285)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(73, 20)
        Me.GunaLabel3.TabIndex = 2
        Me.GunaLabel3.Text = "Messages"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(100, 169)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(58, 20)
        Me.GunaLabel4.TabIndex = 3
        Me.GunaLabel4.Text = "Subject"
        '
        'MessageTxt
        '
        Me.MessageTxt.Location = New System.Drawing.Point(211, 297)
        Me.MessageTxt.Name = "MessageTxt"
        Me.MessageTxt.Size = New System.Drawing.Size(293, 174)
        Me.MessageTxt.TabIndex = 5
        Me.MessageTxt.Text = ""
        '
        'MailIdTxt
        '
        Me.MailIdTxt.BaseColor = System.Drawing.Color.White
        Me.MailIdTxt.BorderColor = System.Drawing.Color.Silver
        Me.MailIdTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MailIdTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.MailIdTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MailIdTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.MailIdTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MailIdTxt.Location = New System.Drawing.Point(211, 110)
        Me.MailIdTxt.Name = "MailIdTxt"
        Me.MailIdTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MailIdTxt.Size = New System.Drawing.Size(293, 32)
        Me.MailIdTxt.TabIndex = 6
        '
        'SubjectTxt
        '
        Me.SubjectTxt.BaseColor = System.Drawing.Color.White
        Me.SubjectTxt.BorderColor = System.Drawing.Color.Silver
        Me.SubjectTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SubjectTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.SubjectTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubjectTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.SubjectTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SubjectTxt.Location = New System.Drawing.Point(211, 169)
        Me.SubjectTxt.Name = "SubjectTxt"
        Me.SubjectTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SubjectTxt.Size = New System.Drawing.Size(293, 32)
        Me.SubjectTxt.TabIndex = 7
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(573, 169)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(180, 42)
        Me.GunaAdvenceButton1.TabIndex = 8
        Me.GunaAdvenceButton1.Text = "SEND"
        '
        'ToTxt
        '
        Me.ToTxt.BaseColor = System.Drawing.Color.White
        Me.ToTxt.BorderColor = System.Drawing.Color.Silver
        Me.ToTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ToTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.ToTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.ToTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToTxt.Location = New System.Drawing.Point(211, 226)
        Me.ToTxt.Name = "ToTxt"
        Me.ToTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ToTxt.Size = New System.Drawing.Size(293, 32)
        Me.ToTxt.TabIndex = 9
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.Location = New System.Drawing.Point(100, 226)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(27, 20)
        Me.GunaLabel5.TabIndex = 10
        Me.GunaLabel5.Text = "TO"
        '
        'Sending
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1054, 582)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.ToTxt)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.SubjectTxt)
        Me.Controls.Add(Me.MailIdTxt)
        Me.Controls.Add(Me.MessageTxt)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sending"
        Me.Text = "Sending"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents MessageTxt As RichTextBox
    Friend WithEvents MailIdTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents SubjectTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents ToTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
End Class
