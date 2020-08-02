<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.UserNameTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.PasswordTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPictureBox3 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox4 = New Guna.UI.WinForms.GunaPictureBox()
        Me.RegisterTxt = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaAdvenceTileButton1 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.LoginBtn = New Guna.UI.WinForms.GunaButton()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER
        Me.GunaAnimateWindow1.Interval = 100
        Me.GunaAnimateWindow1.TargetControl = Nothing
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(133, 57)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(190, 45)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Staff Login"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(103, 103)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(253, 23)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "make sure your account is secure"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(27, 129)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(412, 344)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 2
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(633, 154)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(164, 157)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 3
        Me.GunaPictureBox2.TabStop = False
        '
        'UserNameTxt
        '
        Me.UserNameTxt.BaseColor = System.Drawing.Color.White
        Me.UserNameTxt.BorderColor = System.Drawing.Color.Silver
        Me.UserNameTxt.BorderSize = 3
        Me.UserNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserNameTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.UserNameTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserNameTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.UserNameTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UserNameTxt.Location = New System.Drawing.Point(516, 268)
        Me.UserNameTxt.Name = "UserNameTxt"
        Me.UserNameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserNameTxt.Size = New System.Drawing.Size(394, 32)
        Me.UserNameTxt.TabIndex = 4
        '
        'PasswordTxt
        '
        Me.PasswordTxt.BaseColor = System.Drawing.Color.White
        Me.PasswordTxt.BorderColor = System.Drawing.Color.Silver
        Me.PasswordTxt.BorderSize = 3
        Me.PasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.PasswordTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.PasswordTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PasswordTxt.Location = New System.Drawing.Point(516, 317)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTxt.Size = New System.Drawing.Size(394, 32)
        Me.PasswordTxt.TabIndex = 5
        '
        'GunaPictureBox3
        '
        Me.GunaPictureBox3.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox3.Image = CType(resources.GetObject("GunaPictureBox3.Image"), System.Drawing.Image)
        Me.GunaPictureBox3.Location = New System.Drawing.Point(916, 268)
        Me.GunaPictureBox3.Name = "GunaPictureBox3"
        Me.GunaPictureBox3.Size = New System.Drawing.Size(34, 32)
        Me.GunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox3.TabIndex = 7
        Me.GunaPictureBox3.TabStop = False
        '
        'GunaPictureBox4
        '
        Me.GunaPictureBox4.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox4.Image = CType(resources.GetObject("GunaPictureBox4.Image"), System.Drawing.Image)
        Me.GunaPictureBox4.Location = New System.Drawing.Point(916, 317)
        Me.GunaPictureBox4.Name = "GunaPictureBox4"
        Me.GunaPictureBox4.Size = New System.Drawing.Size(34, 32)
        Me.GunaPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox4.TabIndex = 8
        Me.GunaPictureBox4.TabStop = False
        '
        'RegisterTxt
        '
        Me.RegisterTxt.AutoSize = True
        Me.RegisterTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RegisterTxt.Location = New System.Drawing.Point(812, 361)
        Me.RegisterTxt.Name = "RegisterTxt"
        Me.RegisterTxt.Size = New System.Drawing.Size(98, 20)
        Me.RegisterTxt.TabIndex = 9
        Me.RegisterTxt.TabStop = True
        Me.RegisterTxt.Text = "Register Now"
        '
        'GunaAdvenceTileButton1
        '
        Me.GunaAdvenceTileButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceTileButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceTileButton1.BaseColor = System.Drawing.Color.Red
        Me.GunaAdvenceTileButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceTileButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.CheckedImage = Nothing
        Me.GunaAdvenceTileButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceTileButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceTileButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceTileButton1.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.GunaAdvenceTileButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.Image = Nothing
        Me.GunaAdvenceTileButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaAdvenceTileButton1.LineColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.Location = New System.Drawing.Point(974, 0)
        Me.GunaAdvenceTileButton1.Name = "GunaAdvenceTileButton1"
        Me.GunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.Size = New System.Drawing.Size(47, 44)
        Me.GunaAdvenceTileButton1.TabIndex = 11
        Me.GunaAdvenceTileButton1.Text = "X"
        '
        'LoginBtn
        '
        Me.LoginBtn.AnimationHoverSpeed = 0.07!
        Me.LoginBtn.AnimationSpeed = 0.03!
        Me.LoginBtn.BaseColor = System.Drawing.Color.Red
        Me.LoginBtn.BorderColor = System.Drawing.Color.Black
        Me.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LoginBtn.FocusedColor = System.Drawing.Color.Empty
        Me.LoginBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LoginBtn.ForeColor = System.Drawing.Color.White
        Me.LoginBtn.Image = Nothing
        Me.LoginBtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.LoginBtn.Location = New System.Drawing.Point(750, 396)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LoginBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LoginBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.LoginBtn.OnHoverImage = Nothing
        Me.LoginBtn.OnPressedColor = System.Drawing.Color.Black
        Me.LoginBtn.Size = New System.Drawing.Size(160, 42)
        Me.LoginBtn.TabIndex = 12
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1021, 495)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.GunaAdvenceTileButton1)
        Me.Controls.Add(Me.RegisterTxt)
        Me.Controls.Add(Me.GunaPictureBox4)
        Me.Controls.Add(Me.GunaPictureBox3)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.UserNameTxt)
        Me.Controls.Add(Me.GunaPictureBox2)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents UserNameTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PasswordTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPictureBox3 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPictureBox4 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents RegisterTxt As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaAdvenceTileButton1 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents LoginBtn As Guna.UI.WinForms.GunaButton
End Class
