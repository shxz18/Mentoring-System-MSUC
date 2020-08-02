<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.UsernameSignTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPictureBox3 = New Guna.UI.WinForms.GunaPictureBox()
        Me.PasswordSignTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPictureBox4 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.ConfirmPasswordTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.SignUpBtn = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceTileButton2 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(21, 42)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(170, 54)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Sign Up"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(26, 96)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(358, 24)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Create your account easily with less information"
        '
        'UsernameSignTxt
        '
        Me.UsernameSignTxt.BaseColor = System.Drawing.Color.White
        Me.UsernameSignTxt.BorderColor = System.Drawing.Color.Silver
        Me.UsernameSignTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameSignTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.UsernameSignTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameSignTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.UsernameSignTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UsernameSignTxt.Location = New System.Drawing.Point(30, 218)
        Me.UsernameSignTxt.Name = "UsernameSignTxt"
        Me.UsernameSignTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.UsernameSignTxt.Size = New System.Drawing.Size(299, 32)
        Me.UsernameSignTxt.TabIndex = 2
        Me.UsernameSignTxt.UseSystemPasswordChar = True
        '
        'GunaPictureBox3
        '
        Me.GunaPictureBox3.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox3.Image = CType(resources.GetObject("GunaPictureBox3.Image"), System.Drawing.Image)
        Me.GunaPictureBox3.Location = New System.Drawing.Point(335, 218)
        Me.GunaPictureBox3.Name = "GunaPictureBox3"
        Me.GunaPictureBox3.Size = New System.Drawing.Size(34, 32)
        Me.GunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox3.TabIndex = 8
        Me.GunaPictureBox3.TabStop = False
        '
        'PasswordSignTxt
        '
        Me.PasswordSignTxt.BaseColor = System.Drawing.Color.White
        Me.PasswordSignTxt.BorderColor = System.Drawing.Color.Silver
        Me.PasswordSignTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordSignTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.PasswordSignTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordSignTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.PasswordSignTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PasswordSignTxt.Location = New System.Drawing.Point(30, 311)
        Me.PasswordSignTxt.Name = "PasswordSignTxt"
        Me.PasswordSignTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PasswordSignTxt.Size = New System.Drawing.Size(299, 32)
        Me.PasswordSignTxt.TabIndex = 9
        Me.PasswordSignTxt.UseSystemPasswordChar = True
        '
        'GunaPictureBox4
        '
        Me.GunaPictureBox4.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox4.Image = CType(resources.GetObject("GunaPictureBox4.Image"), System.Drawing.Image)
        Me.GunaPictureBox4.Location = New System.Drawing.Point(335, 311)
        Me.GunaPictureBox4.Name = "GunaPictureBox4"
        Me.GunaPictureBox4.Size = New System.Drawing.Size(34, 32)
        Me.GunaPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox4.TabIndex = 10
        Me.GunaPictureBox4.TabStop = False
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(26, 180)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(86, 24)
        Me.GunaLabel3.TabIndex = 11
        Me.GunaLabel3.Text = "Username"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(26, 272)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(82, 24)
        Me.GunaLabel4.TabIndex = 12
        Me.GunaLabel4.Text = "Password"
        '
        'ConfirmPasswordTxt
        '
        Me.ConfirmPasswordTxt.BaseColor = System.Drawing.Color.White
        Me.ConfirmPasswordTxt.BorderColor = System.Drawing.Color.Silver
        Me.ConfirmPasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ConfirmPasswordTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.ConfirmPasswordTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConfirmPasswordTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.ConfirmPasswordTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ConfirmPasswordTxt.Location = New System.Drawing.Point(30, 392)
        Me.ConfirmPasswordTxt.Name = "ConfirmPasswordTxt"
        Me.ConfirmPasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPasswordTxt.Size = New System.Drawing.Size(299, 32)
        Me.ConfirmPasswordTxt.TabIndex = 13
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(335, 392)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(34, 32)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 14
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(26, 355)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(145, 24)
        Me.GunaLabel5.TabIndex = 15
        Me.GunaLabel5.Text = "Confirm Password"
        '
        'SignUpBtn
        '
        Me.SignUpBtn.AnimationHoverSpeed = 0.07!
        Me.SignUpBtn.AnimationSpeed = 0.03!
        Me.SignUpBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SignUpBtn.BorderColor = System.Drawing.Color.Black
        Me.SignUpBtn.CheckedBaseColor = System.Drawing.Color.Gray
        Me.SignUpBtn.CheckedBorderColor = System.Drawing.Color.Black
        Me.SignUpBtn.CheckedForeColor = System.Drawing.Color.White
        Me.SignUpBtn.CheckedImage = CType(resources.GetObject("SignUpBtn.CheckedImage"), System.Drawing.Image)
        Me.SignUpBtn.CheckedLineColor = System.Drawing.Color.DimGray
        Me.SignUpBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SignUpBtn.FocusedColor = System.Drawing.Color.Empty
        Me.SignUpBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SignUpBtn.ForeColor = System.Drawing.Color.White
        Me.SignUpBtn.Image = Nothing
        Me.SignUpBtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.SignUpBtn.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.SignUpBtn.Location = New System.Drawing.Point(145, 453)
        Me.SignUpBtn.Name = "SignUpBtn"
        Me.SignUpBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SignUpBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.SignUpBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.SignUpBtn.OnHoverImage = Nothing
        Me.SignUpBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.SignUpBtn.OnPressedColor = System.Drawing.Color.Black
        Me.SignUpBtn.Size = New System.Drawing.Size(224, 42)
        Me.SignUpBtn.TabIndex = 16
        Me.SignUpBtn.Text = "Sign Up"
        Me.SignUpBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceTileButton2
        '
        Me.GunaAdvenceTileButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceTileButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceTileButton2.BaseColor = System.Drawing.Color.Red
        Me.GunaAdvenceTileButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton2.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceTileButton2.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton2.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton2.CheckedImage = Nothing
        Me.GunaAdvenceTileButton2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceTileButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceTileButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceTileButton2.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.GunaAdvenceTileButton2.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton2.Image = Nothing
        Me.GunaAdvenceTileButton2.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaAdvenceTileButton2.LineColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton2.Location = New System.Drawing.Point(430, -1)
        Me.GunaAdvenceTileButton2.Name = "GunaAdvenceTileButton2"
        Me.GunaAdvenceTileButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceTileButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton2.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceTileButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton2.Size = New System.Drawing.Size(47, 44)
        Me.GunaAdvenceTileButton2.TabIndex = 19
        Me.GunaAdvenceTileButton2.Text = "X"
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(475, 630)
        Me.Controls.Add(Me.GunaAdvenceTileButton2)
        Me.Controls.Add(Me.SignUpBtn)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.ConfirmPasswordTxt)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaPictureBox4)
        Me.Controls.Add(Me.PasswordSignTxt)
        Me.Controls.Add(Me.GunaPictureBox3)
        Me.Controls.Add(Me.UsernameSignTxt)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignUp"
        Me.Text = "SignUp"
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents UsernameSignTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPictureBox3 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents PasswordSignTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPictureBox4 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ConfirmPasswordTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents SignUpBtn As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceTileButton2 As Guna.UI.WinForms.GunaAdvenceTileButton
End Class
