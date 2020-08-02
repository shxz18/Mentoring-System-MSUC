<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SubjectRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubjectRegistration))
        Dim IDLabel As System.Windows.Forms.Label
        Dim NoMatrikLabel As System.Windows.Forms.Label
        Dim Student_NameLabel As System.Windows.Forms.Label
        Dim SemesterLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim CourseLabel As System.Windows.Forms.Label
        Dim Subject_1Label As System.Windows.Forms.Label
        Dim Subject_2Label As System.Windows.Forms.Label
        Dim Subject_3Label As System.Windows.Forms.Label
        Dim Subject_4Label As System.Windows.Forms.Label
        Dim Subject_5Label As System.Windows.Forms.Label
        Dim Subject_6Label As System.Windows.Forms.Label
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.BtnRegistraton = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaAdvenceButton4 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceTileButton1 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.Database1DataSet = New Staff_Mentoring_System.Database1DataSet()
        Me.MentorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MentorTableAdapter = New Staff_Mentoring_System.Database1DataSetTableAdapters.MentorTableAdapter()
        Me.TableAdapterManager = New Staff_Mentoring_System.Database1DataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NoMatrikTextBox = New System.Windows.Forms.TextBox()
        Me.Student_NameTextBox = New System.Windows.Forms.TextBox()
        Me.SemesterTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.CourseTextBox = New System.Windows.Forms.TextBox()
        Me.Subject_3TextBox = New System.Windows.Forms.TextBox()
        Me.Subject_4TextBox = New System.Windows.Forms.TextBox()
        Me.Subject_5TextBox = New System.Windows.Forms.TextBox()
        Me.Subject_6TextBox = New System.Windows.Forms.TextBox()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoMatrikDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemesterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subject1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subject2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subject3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subject4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subject5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subject6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaComboBox1 = New Guna.UI.WinForms.GunaComboBox()
        IDLabel = New System.Windows.Forms.Label()
        NoMatrikLabel = New System.Windows.Forms.Label()
        Student_NameLabel = New System.Windows.Forms.Label()
        SemesterLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        CourseLabel = New System.Windows.Forms.Label()
        Subject_1Label = New System.Windows.Forms.Label()
        Subject_2Label = New System.Windows.Forms.Label()
        Subject_3Label = New System.Windows.Forms.Label()
        Subject_4Label = New System.Windows.Forms.Label()
        Subject_5Label = New System.Windows.Forms.Label()
        Subject_6Label = New System.Windows.Forms.Label()
        Me.GunaGroupBox1.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MentorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(652, 21)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(366, 41)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "SUBJECT REGISTRATION"
        '
        'BtnRegistraton
        '
        Me.BtnRegistraton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnRegistraton.Image = CType(resources.GetObject("BtnRegistraton.Image"), System.Drawing.Image)
        Me.BtnRegistraton.ImageSize = New System.Drawing.Size(50, 50)
        Me.BtnRegistraton.Location = New System.Drawing.Point(1055, 12)
        Me.BtnRegistraton.Name = "BtnRegistraton"
        Me.BtnRegistraton.OnHoverImage = Nothing
        Me.BtnRegistraton.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.BtnRegistraton.Size = New System.Drawing.Size(66, 64)
        Me.BtnRegistraton.TabIndex = 4
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.GunaGroupBox1.Controls.Add(Me.GunaDataGridView1)
        Me.GunaGroupBox1.Controls.Add(Me.GunaGroupBox2)
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.GunaGroupBox1.Location = New System.Drawing.Point(3, 73)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(1904, 651)
        Me.GunaGroupBox1.TabIndex = 5
        Me.GunaGroupBox1.Text = "Registration"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaAdvenceButton4
        '
        Me.GunaAdvenceButton4.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton4.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.CheckedImage = CType(resources.GetObject("GunaAdvenceButton4.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton4.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.Image = Nothing
        Me.GunaAdvenceButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton4.Location = New System.Drawing.Point(337, 467)
        Me.GunaAdvenceButton4.Name = "GunaAdvenceButton4"
        Me.GunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.OnHoverImage = Nothing
        Me.GunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.Size = New System.Drawing.Size(113, 42)
        Me.GunaAdvenceButton4.TabIndex = 53
        Me.GunaAdvenceButton4.Text = "PREVIEW"
        Me.GunaAdvenceButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.Controls.Add(Me.GunaComboBox1)
        Me.GunaGroupBox2.Controls.Add(Me.GunaAdvenceButton4)
        Me.GunaGroupBox2.Controls.Add(IDLabel)
        Me.GunaGroupBox2.Controls.Add(Me.IDTextBox)
        Me.GunaGroupBox2.Controls.Add(Me.GunaAdvenceButton3)
        Me.GunaGroupBox2.Controls.Add(NoMatrikLabel)
        Me.GunaGroupBox2.Controls.Add(Me.GunaAdvenceButton2)
        Me.GunaGroupBox2.Controls.Add(Me.NoMatrikTextBox)
        Me.GunaGroupBox2.Controls.Add(Me.GunaAdvenceButton1)
        Me.GunaGroupBox2.Controls.Add(Student_NameLabel)
        Me.GunaGroupBox2.Controls.Add(Me.Student_NameTextBox)
        Me.GunaGroupBox2.Controls.Add(SemesterLabel)
        Me.GunaGroupBox2.Controls.Add(Me.SemesterTextBox)
        Me.GunaGroupBox2.Controls.Add(DepartmentLabel)
        Me.GunaGroupBox2.Controls.Add(Me.DepartmentTextBox)
        Me.GunaGroupBox2.Controls.Add(CourseLabel)
        Me.GunaGroupBox2.Controls.Add(Me.CourseTextBox)
        Me.GunaGroupBox2.Controls.Add(Subject_1Label)
        Me.GunaGroupBox2.Controls.Add(Subject_2Label)
        Me.GunaGroupBox2.Controls.Add(Subject_3Label)
        Me.GunaGroupBox2.Controls.Add(Me.Subject_3TextBox)
        Me.GunaGroupBox2.Controls.Add(Subject_4Label)
        Me.GunaGroupBox2.Controls.Add(Me.Subject_4TextBox)
        Me.GunaGroupBox2.Controls.Add(Subject_5Label)
        Me.GunaGroupBox2.Controls.Add(Me.Subject_5TextBox)
        Me.GunaGroupBox2.Controls.Add(Subject_6Label)
        Me.GunaGroupBox2.Controls.Add(Me.Subject_6TextBox)
        Me.GunaGroupBox2.Controls.Add(Me.GunaLabel2)
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.Location = New System.Drawing.Point(9, 42)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(452, 537)
        Me.GunaGroupBox2.TabIndex = 25
        Me.GunaGroupBox2.Text = "GunaGroupBox2"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(17, 402)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(368, 38)
        Me.GunaLabel2.TabIndex = 0
        Me.GunaLabel2.Text = "*Note the maximum subject registration is 7 (Long Semester)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*Note the maximum su" &
    "bject registration is 3 (Short Semester)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GunaAdvenceButton3
        '
        Me.GunaAdvenceButton3.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton3.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton3.BaseColor = System.Drawing.Color.Green
        Me.GunaAdvenceButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.CheckedImage = CType(resources.GetObject("GunaAdvenceButton3.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton3.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.Image = CType(resources.GetObject("GunaAdvenceButton3.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(110, 467)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.Green
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(104, 42)
        Me.GunaAdvenceButton3.TabIndex = 28
        Me.GunaAdvenceButton3.Text = "SAVE"
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.Red
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.CheckedImage = CType(resources.GetObject("GunaAdvenceButton2.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.Image = CType(resources.GetObject("GunaAdvenceButton2.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(220, 467)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(113, 42)
        Me.GunaAdvenceButton2.TabIndex = 27
        Me.GunaAdvenceButton2.Text = "DELETE"
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.Blue
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
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(3, 467)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(101, 42)
        Me.GunaAdvenceButton1.TabIndex = 26
        Me.GunaAdvenceButton1.Text = "ADD"
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
        Me.GunaAdvenceTileButton1.Location = New System.Drawing.Point(1848, 3)
        Me.GunaAdvenceTileButton1.Name = "GunaAdvenceTileButton1"
        Me.GunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.Size = New System.Drawing.Size(47, 44)
        Me.GunaAdvenceTileButton1.TabIndex = 12
        Me.GunaAdvenceTileButton1.Text = "X"
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MentorBindingSource
        '
        Me.MentorBindingSource.DataMember = "Mentor"
        Me.MentorBindingSource.DataSource = Me.Database1DataSet
        '
        'MentorTableAdapter
        '
        Me.MentorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MentorTableAdapter = Me.MentorTableAdapter
        Me.TableAdapterManager.ParentsTableAdapter = Nothing
        Me.TableAdapterManager.StudentInfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Staff_Mentoring_System.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(18, 57)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(25, 17)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MentorBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(126, 54)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(284, 22)
        Me.IDTextBox.TabIndex = 2
        '
        'NoMatrikLabel
        '
        NoMatrikLabel.AutoSize = True
        NoMatrikLabel.Location = New System.Drawing.Point(18, 85)
        NoMatrikLabel.Name = "NoMatrikLabel"
        NoMatrikLabel.Size = New System.Drawing.Size(72, 17)
        NoMatrikLabel.TabIndex = 3
        NoMatrikLabel.Text = "No Matrik:"
        '
        'NoMatrikTextBox
        '
        Me.NoMatrikTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MentorBindingSource, "NoMatrik", True))
        Me.NoMatrikTextBox.Location = New System.Drawing.Point(126, 82)
        Me.NoMatrikTextBox.Name = "NoMatrikTextBox"
        Me.NoMatrikTextBox.Size = New System.Drawing.Size(284, 22)
        Me.NoMatrikTextBox.TabIndex = 4
        '
        'Student_NameLabel
        '
        Student_NameLabel.AutoSize = True
        Student_NameLabel.Location = New System.Drawing.Point(18, 113)
        Student_NameLabel.Name = "Student_NameLabel"
        Student_NameLabel.Size = New System.Drawing.Size(102, 17)
        Student_NameLabel.TabIndex = 5
        Student_NameLabel.Text = "Student Name:"
        '
        'Student_NameTextBox
        '
        Me.Student_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MentorBindingSource, "Student Name", True))
        Me.Student_NameTextBox.Location = New System.Drawing.Point(126, 110)
        Me.Student_NameTextBox.Name = "Student_NameTextBox"
        Me.Student_NameTextBox.Size = New System.Drawing.Size(284, 22)
        Me.Student_NameTextBox.TabIndex = 6
        '
        'SemesterLabel
        '
        SemesterLabel.AutoSize = True
        SemesterLabel.Location = New System.Drawing.Point(18, 141)
        SemesterLabel.Name = "SemesterLabel"
        SemesterLabel.Size = New System.Drawing.Size(72, 17)
        SemesterLabel.TabIndex = 7
        SemesterLabel.Text = "Semester:"
        '
        'SemesterTextBox
        '
        Me.SemesterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MentorBindingSource, "Semester", True))
        Me.SemesterTextBox.Location = New System.Drawing.Point(126, 138)
        Me.SemesterTextBox.Name = "SemesterTextBox"
        Me.SemesterTextBox.Size = New System.Drawing.Size(284, 22)
        Me.SemesterTextBox.TabIndex = 8
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(18, 169)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(86, 17)
        DepartmentLabel.TabIndex = 9
        DepartmentLabel.Text = "Department:"
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MentorBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(126, 166)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(284, 22)
        Me.DepartmentTextBox.TabIndex = 10
        '
        'CourseLabel
        '
        CourseLabel.AutoSize = True
        CourseLabel.Location = New System.Drawing.Point(18, 197)
        CourseLabel.Name = "CourseLabel"
        CourseLabel.Size = New System.Drawing.Size(57, 17)
        CourseLabel.TabIndex = 11
        CourseLabel.Text = "Course:"
        '
        'CourseTextBox
        '
        Me.CourseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MentorBindingSource, "Course", True))
        Me.CourseTextBox.Location = New System.Drawing.Point(126, 194)
        Me.CourseTextBox.Name = "CourseTextBox"
        Me.CourseTextBox.Size = New System.Drawing.Size(284, 22)
        Me.CourseTextBox.TabIndex = 12
        '
        'Subject_1Label
        '
        Subject_1Label.AutoSize = True
        Subject_1Label.Location = New System.Drawing.Point(18, 225)
        Subject_1Label.Name = "Subject_1Label"
        Subject_1Label.Size = New System.Drawing.Size(71, 17)
        Subject_1Label.TabIndex = 13
        Subject_1Label.Text = "Subject 1:"
        '
        'Subject_2Label
        '
        Subject_2Label.AutoSize = True
        Subject_2Label.Location = New System.Drawing.Point(18, 253)
        Subject_2Label.Name = "Subject_2Label"
        Subject_2Label.Size = New System.Drawing.Size(71, 17)
        Subject_2Label.TabIndex = 15
        Subject_2Label.Text = "Subject 2:"
        '
        'Subject_3Label
        '
        Subject_3Label.AutoSize = True
        Subject_3Label.Location = New System.Drawing.Point(18, 281)
        Subject_3Label.Name = "Subject_3Label"
        Subject_3Label.Size = New System.Drawing.Size(71, 17)
        Subject_3Label.TabIndex = 17
        Subject_3Label.Text = "Subject 3:"
        '
        'Subject_3TextBox
        '
        Me.Subject_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MentorBindingSource, "Subject 3", True))
        Me.Subject_3TextBox.Location = New System.Drawing.Point(126, 278)
        Me.Subject_3TextBox.Name = "Subject_3TextBox"
        Me.Subject_3TextBox.Size = New System.Drawing.Size(284, 22)
        Me.Subject_3TextBox.TabIndex = 18
        '
        'Subject_4Label
        '
        Subject_4Label.AutoSize = True
        Subject_4Label.Location = New System.Drawing.Point(18, 309)
        Subject_4Label.Name = "Subject_4Label"
        Subject_4Label.Size = New System.Drawing.Size(71, 17)
        Subject_4Label.TabIndex = 19
        Subject_4Label.Text = "Subject 4:"
        '
        'Subject_4TextBox
        '
        Me.Subject_4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MentorBindingSource, "Subject 4", True))
        Me.Subject_4TextBox.Location = New System.Drawing.Point(126, 306)
        Me.Subject_4TextBox.Name = "Subject_4TextBox"
        Me.Subject_4TextBox.Size = New System.Drawing.Size(284, 22)
        Me.Subject_4TextBox.TabIndex = 20
        '
        'Subject_5Label
        '
        Subject_5Label.AutoSize = True
        Subject_5Label.Location = New System.Drawing.Point(18, 337)
        Subject_5Label.Name = "Subject_5Label"
        Subject_5Label.Size = New System.Drawing.Size(71, 17)
        Subject_5Label.TabIndex = 21
        Subject_5Label.Text = "Subject 5:"
        '
        'Subject_5TextBox
        '
        Me.Subject_5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MentorBindingSource, "Subject 5", True))
        Me.Subject_5TextBox.Location = New System.Drawing.Point(126, 334)
        Me.Subject_5TextBox.Name = "Subject_5TextBox"
        Me.Subject_5TextBox.Size = New System.Drawing.Size(284, 22)
        Me.Subject_5TextBox.TabIndex = 22
        '
        'Subject_6Label
        '
        Subject_6Label.AutoSize = True
        Subject_6Label.Location = New System.Drawing.Point(18, 365)
        Subject_6Label.Name = "Subject_6Label"
        Subject_6Label.Size = New System.Drawing.Size(71, 17)
        Subject_6Label.TabIndex = 23
        Subject_6Label.Text = "Subject 6:"
        '
        'Subject_6TextBox
        '
        Me.Subject_6TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MentorBindingSource, "Subject 6", True))
        Me.Subject_6TextBox.Location = New System.Drawing.Point(126, 362)
        Me.Subject_6TextBox.Name = "Subject_6TextBox"
        Me.Subject_6TextBox.Size = New System.Drawing.Size(284, 22)
        Me.Subject_6TextBox.TabIndex = 24
        '
        'GunaDataGridView1
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.GunaDataGridView1.AutoGenerateColumns = False
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.GunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.GunaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GunaDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NoMatrikDataGridViewTextBoxColumn, Me.StudentNameDataGridViewTextBoxColumn, Me.SemesterDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.Subject1DataGridViewTextBoxColumn, Me.Subject2DataGridViewTextBoxColumn, Me.Subject3DataGridViewTextBoxColumn, Me.Subject4DataGridViewTextBoxColumn, Me.Subject5DataGridViewTextBoxColumn, Me.Subject6DataGridViewTextBoxColumn})
        Me.GunaDataGridView1.DataSource = Me.MentorBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GunaDataGridView1.Location = New System.Drawing.Point(467, 42)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.RowHeadersWidth = 51
        Me.GunaDataGridView1.RowTemplate.Height = 24
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(1064, 150)
        Me.GunaDataGridView1.TabIndex = 26
        Me.GunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 52
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = False
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 24
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NoMatrikDataGridViewTextBoxColumn
        '
        Me.NoMatrikDataGridViewTextBoxColumn.DataPropertyName = "NoMatrik"
        Me.NoMatrikDataGridViewTextBoxColumn.HeaderText = "NoMatrik"
        Me.NoMatrikDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NoMatrikDataGridViewTextBoxColumn.Name = "NoMatrikDataGridViewTextBoxColumn"
        '
        'StudentNameDataGridViewTextBoxColumn
        '
        Me.StudentNameDataGridViewTextBoxColumn.DataPropertyName = "Student Name"
        Me.StudentNameDataGridViewTextBoxColumn.HeaderText = "Student Name"
        Me.StudentNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StudentNameDataGridViewTextBoxColumn.Name = "StudentNameDataGridViewTextBoxColumn"
        '
        'SemesterDataGridViewTextBoxColumn
        '
        Me.SemesterDataGridViewTextBoxColumn.DataPropertyName = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.HeaderText = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SemesterDataGridViewTextBoxColumn.Name = "SemesterDataGridViewTextBoxColumn"
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        '
        'Subject1DataGridViewTextBoxColumn
        '
        Me.Subject1DataGridViewTextBoxColumn.DataPropertyName = "Subject 1"
        Me.Subject1DataGridViewTextBoxColumn.HeaderText = "Subject 1"
        Me.Subject1DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.Subject1DataGridViewTextBoxColumn.Name = "Subject1DataGridViewTextBoxColumn"
        '
        'Subject2DataGridViewTextBoxColumn
        '
        Me.Subject2DataGridViewTextBoxColumn.DataPropertyName = "Subject 2"
        Me.Subject2DataGridViewTextBoxColumn.HeaderText = "Subject 2"
        Me.Subject2DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.Subject2DataGridViewTextBoxColumn.Name = "Subject2DataGridViewTextBoxColumn"
        '
        'Subject3DataGridViewTextBoxColumn
        '
        Me.Subject3DataGridViewTextBoxColumn.DataPropertyName = "Subject 3"
        Me.Subject3DataGridViewTextBoxColumn.HeaderText = "Subject 3"
        Me.Subject3DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.Subject3DataGridViewTextBoxColumn.Name = "Subject3DataGridViewTextBoxColumn"
        '
        'Subject4DataGridViewTextBoxColumn
        '
        Me.Subject4DataGridViewTextBoxColumn.DataPropertyName = "Subject 4"
        Me.Subject4DataGridViewTextBoxColumn.HeaderText = "Subject 4"
        Me.Subject4DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.Subject4DataGridViewTextBoxColumn.Name = "Subject4DataGridViewTextBoxColumn"
        '
        'Subject5DataGridViewTextBoxColumn
        '
        Me.Subject5DataGridViewTextBoxColumn.DataPropertyName = "Subject 5"
        Me.Subject5DataGridViewTextBoxColumn.HeaderText = "Subject 5"
        Me.Subject5DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.Subject5DataGridViewTextBoxColumn.Name = "Subject5DataGridViewTextBoxColumn"
        '
        'Subject6DataGridViewTextBoxColumn
        '
        Me.Subject6DataGridViewTextBoxColumn.DataPropertyName = "Subject 6"
        Me.Subject6DataGridViewTextBoxColumn.HeaderText = "Subject 6"
        Me.Subject6DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.Subject6DataGridViewTextBoxColumn.Name = "Subject6DataGridViewTextBoxColumn"
        '
        'GunaComboBox1
        '
        Me.GunaComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaComboBox1.BaseColor = System.Drawing.Color.White
        Me.GunaComboBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GunaComboBox1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaComboBox1.ForeColor = System.Drawing.Color.Black
        Me.GunaComboBox1.FormattingEnabled = True
        Me.GunaComboBox1.Location = New System.Drawing.Point(126, 225)
        Me.GunaComboBox1.Name = "GunaComboBox1"
        Me.GunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White
        Me.GunaComboBox1.Size = New System.Drawing.Size(284, 31)
        Me.GunaComboBox1.TabIndex = 54
        '
        'SubjectRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1907, 736)
        Me.Controls.Add(Me.GunaAdvenceTileButton1)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.BtnRegistraton)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SubjectRegistration"
        Me.Text = "SubjectRegistration"
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MentorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BtnRegistraton As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceTileButton1 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaAdvenceButton4 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents MentorBindingSource As BindingSource
    Friend WithEvents MentorTableAdapter As Database1DataSetTableAdapters.MentorTableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoMatrikDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SemesterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Subject1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Subject2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Subject3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Subject4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Subject5DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Subject6DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NoMatrikTextBox As TextBox
    Friend WithEvents Student_NameTextBox As TextBox
    Friend WithEvents SemesterTextBox As TextBox
    Friend WithEvents DepartmentTextBox As TextBox
    Friend WithEvents CourseTextBox As TextBox
    Friend WithEvents Subject_3TextBox As TextBox
    Friend WithEvents Subject_4TextBox As TextBox
    Friend WithEvents Subject_5TextBox As TextBox
    Friend WithEvents Subject_6TextBox As TextBox
    Friend WithEvents GunaComboBox1 As Guna.UI.WinForms.GunaComboBox
End Class
