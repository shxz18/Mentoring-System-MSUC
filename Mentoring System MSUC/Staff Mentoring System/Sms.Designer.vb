<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sms))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtApi = New Guna.UI.WinForms.GunaTextBox()
        Me.SenderTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.PhoneTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.SmsTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(338, 34)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(75, 20)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Send SMS"
        '
        'txtApi
        '
        Me.txtApi.BaseColor = System.Drawing.Color.White
        Me.txtApi.BorderColor = System.Drawing.Color.Silver
        Me.txtApi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApi.FocusedBaseColor = System.Drawing.Color.White
        Me.txtApi.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtApi.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtApi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtApi.Location = New System.Drawing.Point(176, 90)
        Me.txtApi.Name = "txtApi"
        Me.txtApi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApi.Size = New System.Drawing.Size(237, 35)
        Me.txtApi.TabIndex = 1
        '
        'SenderTxt
        '
        Me.SenderTxt.BaseColor = System.Drawing.Color.White
        Me.SenderTxt.BorderColor = System.Drawing.Color.Silver
        Me.SenderTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SenderTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.SenderTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SenderTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.SenderTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SenderTxt.Location = New System.Drawing.Point(176, 167)
        Me.SenderTxt.Name = "SenderTxt"
        Me.SenderTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SenderTxt.Size = New System.Drawing.Size(237, 35)
        Me.SenderTxt.TabIndex = 2
        '
        'PhoneTxt
        '
        Me.PhoneTxt.BaseColor = System.Drawing.Color.White
        Me.PhoneTxt.BorderColor = System.Drawing.Color.Silver
        Me.PhoneTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PhoneTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.PhoneTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PhoneTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.PhoneTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PhoneTxt.Location = New System.Drawing.Point(176, 223)
        Me.PhoneTxt.Name = "PhoneTxt"
        Me.PhoneTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PhoneTxt.Size = New System.Drawing.Size(237, 35)
        Me.PhoneTxt.TabIndex = 3
        '
        'SmsTxt
        '
        Me.SmsTxt.BaseColor = System.Drawing.Color.White
        Me.SmsTxt.BorderColor = System.Drawing.Color.Silver
        Me.SmsTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SmsTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.SmsTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SmsTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.SmsTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SmsTxt.Location = New System.Drawing.Point(176, 273)
        Me.SmsTxt.MultiLine = True
        Me.SmsTxt.Name = "SmsTxt"
        Me.SmsTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SmsTxt.Size = New System.Drawing.Size(237, 152)
        Me.SmsTxt.TabIndex = 4
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(58, 105)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(60, 20)
        Me.GunaLabel2.TabIndex = 5
        Me.GunaLabel2.Text = "API KEY"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(58, 288)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(75, 20)
        Me.GunaLabel3.TabIndex = 6
        Me.GunaLabel3.Text = "Send SMS"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(58, 167)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(99, 20)
        Me.GunaLabel4.TabIndex = 7
        Me.GunaLabel4.Text = "Sender Name"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.Location = New System.Drawing.Point(58, 223)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(50, 20)
        Me.GunaLabel5.TabIndex = 8
        Me.GunaLabel5.Text = "Phone"
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(534, 201)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(160, 42)
        Me.GunaButton1.TabIndex = 9
        Me.GunaButton1.Text = "SEND"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(434, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "uK/LSxR4bFg-4fNIWKmo1ivrvk09Mwr1nQlmAcqHBp"
        '
        'Sms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 553)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.SmsTxt)
        Me.Controls.Add(Me.PhoneTxt)
        Me.Controls.Add(Me.SenderTxt)
        Me.Controls.Add(Me.txtApi)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sms"
        Me.Text = "Sms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtApi As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents SenderTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PhoneTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents SmsTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As Label
End Class
