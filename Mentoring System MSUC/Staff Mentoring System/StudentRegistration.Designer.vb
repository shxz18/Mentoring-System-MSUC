<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentRegistration
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim NoMatrikLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim SemesterLabel As System.Windows.Forms.Label
        Dim Birth_DateLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim NationalityLabel As System.Windows.Forms.Label
        Dim AdressLabel As System.Windows.Forms.Label
        Dim Place_Of_BirthLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Dim PicLabel As System.Windows.Forms.Label
        Dim CourseLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim HealthLabel As System.Windows.Forms.Label
        Dim IDLabel1 As System.Windows.Forms.Label
        Dim Father_NameLabel As System.Windows.Forms.Label
        Dim ICLabel As System.Windows.Forms.Label
        Dim AdressLabel1 As System.Windows.Forms.Label
        Dim AgeLabel1 As System.Windows.Forms.Label
        Dim OccupationLabel As System.Windows.Forms.Label
        Dim IncomeLabel As System.Windows.Forms.Label
        Dim Son_NameLabel As System.Windows.Forms.Label
        Dim ContactLabel1 As System.Windows.Forms.Label
        Dim Mother_NameLabel As System.Windows.Forms.Label
        Dim IC_NoLabel As System.Windows.Forms.Label
        Dim Adress_MotherLabel As System.Windows.Forms.Label
        Dim Age_MotherLabel As System.Windows.Forms.Label
        Dim Occupation_MotherLabel As System.Windows.Forms.Label
        Dim Salary_MotherLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentRegistration))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaAdvenceTileButton2 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.BtnInfo = New Guna.UI.WinForms.GunaImageButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoMatrikDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemesterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NationalityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlaceOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PicDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HealthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet2 = New Staff_Mentoring_System.Database1DataSet2()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaAdvenceButton5 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.GunaAdvenceButton4 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.NoMatrikTextBox = New System.Windows.Forms.TextBox()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.PicPictureBox = New System.Windows.Forms.PictureBox()
        Me.SemesterTextBox = New System.Windows.Forms.TextBox()
        Me.HealthTextBox = New System.Windows.Forms.TextBox()
        Me.Birth_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.NationalityTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.AdressTextBox = New System.Windows.Forms.TextBox()
        Me.CourseTextBox = New System.Windows.Forms.TextBox()
        Me.Place_Of_BirthTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaDataGridView2 = New Guna.UI.WinForms.GunaDataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ICDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdressDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OccupationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SonNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ICNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdressMotherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeMotherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OccupationMotherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryMotherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.GunaAdvenceButton6 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton7 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Father_NameTextBox = New System.Windows.Forms.TextBox()
        Me.GunaAdvenceButton8 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton9 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.ICTextBox = New System.Windows.Forms.TextBox()
        Me.Salary_MotherTextBox = New System.Windows.Forms.TextBox()
        Me.AdressTextBox1 = New System.Windows.Forms.TextBox()
        Me.Occupation_MotherTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox1 = New System.Windows.Forms.TextBox()
        Me.Age_MotherTextBox = New System.Windows.Forms.TextBox()
        Me.OccupationTextBox = New System.Windows.Forms.TextBox()
        Me.Adress_MotherTextBox = New System.Windows.Forms.TextBox()
        Me.IncomeTextBox = New System.Windows.Forms.TextBox()
        Me.IC_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Son_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Mother_NameTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTextBox1 = New System.Windows.Forms.TextBox()
        Me.GunaTextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaAdvenceButton10 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.StudentInfoTableAdapter = New Staff_Mentoring_System.Database1DataSet2TableAdapters.StudentInfoTableAdapter()
        Me.TableAdapterManager = New Staff_Mentoring_System.Database1DataSet2TableAdapters.TableAdapterManager()
        Me.ParentsTableAdapter = New Staff_Mentoring_System.Database1DataSet2TableAdapters.ParentsTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        NoMatrikLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        SemesterLabel = New System.Windows.Forms.Label()
        Birth_DateLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        NationalityLabel = New System.Windows.Forms.Label()
        AdressLabel = New System.Windows.Forms.Label()
        Place_Of_BirthLabel = New System.Windows.Forms.Label()
        ContactLabel = New System.Windows.Forms.Label()
        PicLabel = New System.Windows.Forms.Label()
        CourseLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        HealthLabel = New System.Windows.Forms.Label()
        IDLabel1 = New System.Windows.Forms.Label()
        Father_NameLabel = New System.Windows.Forms.Label()
        ICLabel = New System.Windows.Forms.Label()
        AdressLabel1 = New System.Windows.Forms.Label()
        AgeLabel1 = New System.Windows.Forms.Label()
        OccupationLabel = New System.Windows.Forms.Label()
        IncomeLabel = New System.Windows.Forms.Label()
        Son_NameLabel = New System.Windows.Forms.Label()
        ContactLabel1 = New System.Windows.Forms.Label()
        Mother_NameLabel = New System.Windows.Forms.Label()
        IC_NoLabel = New System.Windows.Forms.Label()
        Adress_MotherLabel = New System.Windows.Forms.Label()
        Age_MotherLabel = New System.Windows.Forms.Label()
        Occupation_MotherLabel = New System.Windows.Forms.Label()
        Salary_MotherLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.PicPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.GunaDataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(14, 37)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(25, 17)
        IDLabel.TabIndex = 5
        IDLabel.Text = "ID:"
        '
        'NoMatrikLabel
        '
        NoMatrikLabel.AutoSize = True
        NoMatrikLabel.Location = New System.Drawing.Point(14, 65)
        NoMatrikLabel.Name = "NoMatrikLabel"
        NoMatrikLabel.Size = New System.Drawing.Size(72, 17)
        NoMatrikLabel.TabIndex = 7
        NoMatrikLabel.Text = "No Matrik:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(14, 93)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(49, 17)
        NameLabel.TabIndex = 9
        NameLabel.Text = "Name:"
        '
        'SemesterLabel
        '
        SemesterLabel.AutoSize = True
        SemesterLabel.Location = New System.Drawing.Point(14, 121)
        SemesterLabel.Name = "SemesterLabel"
        SemesterLabel.Size = New System.Drawing.Size(72, 17)
        SemesterLabel.TabIndex = 11
        SemesterLabel.Text = "Semester:"
        '
        'Birth_DateLabel
        '
        Birth_DateLabel.AutoSize = True
        Birth_DateLabel.Location = New System.Drawing.Point(14, 150)
        Birth_DateLabel.Name = "Birth_DateLabel"
        Birth_DateLabel.Size = New System.Drawing.Size(75, 17)
        Birth_DateLabel.TabIndex = 13
        Birth_DateLabel.Text = "Birth Date:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(14, 177)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(37, 17)
        AgeLabel.TabIndex = 15
        AgeLabel.Text = "Age:"
        '
        'NationalityLabel
        '
        NationalityLabel.AutoSize = True
        NationalityLabel.Location = New System.Drawing.Point(14, 205)
        NationalityLabel.Name = "NationalityLabel"
        NationalityLabel.Size = New System.Drawing.Size(78, 17)
        NationalityLabel.TabIndex = 17
        NationalityLabel.Text = "Nationality:"
        '
        'AdressLabel
        '
        AdressLabel.AutoSize = True
        AdressLabel.Location = New System.Drawing.Point(14, 233)
        AdressLabel.Name = "AdressLabel"
        AdressLabel.Size = New System.Drawing.Size(56, 17)
        AdressLabel.TabIndex = 19
        AdressLabel.Text = "Adress:"
        '
        'Place_Of_BirthLabel
        '
        Place_Of_BirthLabel.AutoSize = True
        Place_Of_BirthLabel.Location = New System.Drawing.Point(14, 261)
        Place_Of_BirthLabel.Name = "Place_Of_BirthLabel"
        Place_Of_BirthLabel.Size = New System.Drawing.Size(99, 17)
        Place_Of_BirthLabel.TabIndex = 21
        Place_Of_BirthLabel.Text = "Place Of Birth:"
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Location = New System.Drawing.Point(14, 289)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(60, 17)
        ContactLabel.TabIndex = 23
        ContactLabel.Text = "Contact:"
        '
        'PicLabel
        '
        PicLabel.AutoSize = True
        PicLabel.Location = New System.Drawing.Point(499, 205)
        PicLabel.Name = "PicLabel"
        PicLabel.Size = New System.Drawing.Size(31, 17)
        PicLabel.TabIndex = 25
        PicLabel.Text = "Pic:"
        '
        'CourseLabel
        '
        CourseLabel.AutoSize = True
        CourseLabel.Location = New System.Drawing.Point(499, 55)
        CourseLabel.Name = "CourseLabel"
        CourseLabel.Size = New System.Drawing.Size(57, 17)
        CourseLabel.TabIndex = 27
        CourseLabel.Text = "Course:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(499, 83)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(86, 17)
        DepartmentLabel.TabIndex = 29
        DepartmentLabel.Text = "Department:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(499, 111)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(60, 17)
        GenderLabel.TabIndex = 31
        GenderLabel.Text = "Gender:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(499, 139)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(52, 17)
        StatusLabel.TabIndex = 33
        StatusLabel.Text = "Status:"
        '
        'HealthLabel
        '
        HealthLabel.AutoSize = True
        HealthLabel.Location = New System.Drawing.Point(499, 167)
        HealthLabel.Name = "HealthLabel"
        HealthLabel.Size = New System.Drawing.Size(53, 17)
        HealthLabel.TabIndex = 35
        HealthLabel.Text = "Health:"
        '
        'IDLabel1
        '
        IDLabel1.AutoSize = True
        IDLabel1.Location = New System.Drawing.Point(28, 39)
        IDLabel1.Name = "IDLabel1"
        IDLabel1.Size = New System.Drawing.Size(25, 17)
        IDLabel1.TabIndex = 1
        IDLabel1.Text = "ID:"
        '
        'Father_NameLabel
        '
        Father_NameLabel.AutoSize = True
        Father_NameLabel.Location = New System.Drawing.Point(28, 67)
        Father_NameLabel.Name = "Father_NameLabel"
        Father_NameLabel.Size = New System.Drawing.Size(94, 17)
        Father_NameLabel.TabIndex = 3
        Father_NameLabel.Text = "Father Name:"
        '
        'ICLabel
        '
        ICLabel.AutoSize = True
        ICLabel.Location = New System.Drawing.Point(28, 95)
        ICLabel.Name = "ICLabel"
        ICLabel.Size = New System.Drawing.Size(24, 17)
        ICLabel.TabIndex = 5
        ICLabel.Text = "IC:"
        '
        'AdressLabel1
        '
        AdressLabel1.AutoSize = True
        AdressLabel1.Location = New System.Drawing.Point(28, 123)
        AdressLabel1.Name = "AdressLabel1"
        AdressLabel1.Size = New System.Drawing.Size(56, 17)
        AdressLabel1.TabIndex = 7
        AdressLabel1.Text = "Adress:"
        '
        'AgeLabel1
        '
        AgeLabel1.AutoSize = True
        AgeLabel1.Location = New System.Drawing.Point(28, 151)
        AgeLabel1.Name = "AgeLabel1"
        AgeLabel1.Size = New System.Drawing.Size(37, 17)
        AgeLabel1.TabIndex = 9
        AgeLabel1.Text = "Age:"
        '
        'OccupationLabel
        '
        OccupationLabel.AutoSize = True
        OccupationLabel.Location = New System.Drawing.Point(28, 179)
        OccupationLabel.Name = "OccupationLabel"
        OccupationLabel.Size = New System.Drawing.Size(84, 17)
        OccupationLabel.TabIndex = 11
        OccupationLabel.Text = "Occupation:"
        '
        'IncomeLabel
        '
        IncomeLabel.AutoSize = True
        IncomeLabel.Location = New System.Drawing.Point(28, 207)
        IncomeLabel.Name = "IncomeLabel"
        IncomeLabel.Size = New System.Drawing.Size(57, 17)
        IncomeLabel.TabIndex = 13
        IncomeLabel.Text = "Income:"
        '
        'Son_NameLabel
        '
        Son_NameLabel.AutoSize = True
        Son_NameLabel.Location = New System.Drawing.Point(28, 235)
        Son_NameLabel.Name = "Son_NameLabel"
        Son_NameLabel.Size = New System.Drawing.Size(78, 17)
        Son_NameLabel.TabIndex = 15
        Son_NameLabel.Text = "Son Name:"
        '
        'ContactLabel1
        '
        ContactLabel1.AutoSize = True
        ContactLabel1.Location = New System.Drawing.Point(28, 263)
        ContactLabel1.Name = "ContactLabel1"
        ContactLabel1.Size = New System.Drawing.Size(60, 17)
        ContactLabel1.TabIndex = 17
        ContactLabel1.Text = "Contact:"
        '
        'Mother_NameLabel
        '
        Mother_NameLabel.AutoSize = True
        Mother_NameLabel.Location = New System.Drawing.Point(411, 41)
        Mother_NameLabel.Name = "Mother_NameLabel"
        Mother_NameLabel.Size = New System.Drawing.Size(97, 17)
        Mother_NameLabel.TabIndex = 19
        Mother_NameLabel.Text = "Mother Name:"
        '
        'IC_NoLabel
        '
        IC_NoLabel.AutoSize = True
        IC_NoLabel.Location = New System.Drawing.Point(411, 69)
        IC_NoLabel.Name = "IC_NoLabel"
        IC_NoLabel.Size = New System.Drawing.Size(47, 17)
        IC_NoLabel.TabIndex = 21
        IC_NoLabel.Text = "IC-No:"
        '
        'Adress_MotherLabel
        '
        Adress_MotherLabel.AutoSize = True
        Adress_MotherLabel.Location = New System.Drawing.Point(411, 97)
        Adress_MotherLabel.Name = "Adress_MotherLabel"
        Adress_MotherLabel.Size = New System.Drawing.Size(105, 17)
        Adress_MotherLabel.TabIndex = 23
        Adress_MotherLabel.Text = "Adress-Mother:"
        '
        'Age_MotherLabel
        '
        Age_MotherLabel.AutoSize = True
        Age_MotherLabel.Location = New System.Drawing.Point(411, 125)
        Age_MotherLabel.Name = "Age_MotherLabel"
        Age_MotherLabel.Size = New System.Drawing.Size(86, 17)
        Age_MotherLabel.TabIndex = 25
        Age_MotherLabel.Text = "Age-Mother:"
        '
        'Occupation_MotherLabel
        '
        Occupation_MotherLabel.AutoSize = True
        Occupation_MotherLabel.Location = New System.Drawing.Point(411, 153)
        Occupation_MotherLabel.Name = "Occupation_MotherLabel"
        Occupation_MotherLabel.Size = New System.Drawing.Size(132, 17)
        Occupation_MotherLabel.TabIndex = 27
        Occupation_MotherLabel.Text = "Occupation Mother:"
        '
        'Salary_MotherLabel
        '
        Salary_MotherLabel.AutoSize = True
        Salary_MotherLabel.Location = New System.Drawing.Point(411, 181)
        Salary_MotherLabel.Name = "Salary_MotherLabel"
        Salary_MotherLabel.Size = New System.Drawing.Size(101, 17)
        Salary_MotherLabel.TabIndex = 29
        Salary_MotherLabel.Text = "Salary-Mother:"
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
        Me.GunaAdvenceTileButton2.Location = New System.Drawing.Point(1516, -1)
        Me.GunaAdvenceTileButton2.Name = "GunaAdvenceTileButton2"
        Me.GunaAdvenceTileButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceTileButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton2.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceTileButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton2.Size = New System.Drawing.Size(47, 44)
        Me.GunaAdvenceTileButton2.TabIndex = 21
        Me.GunaAdvenceTileButton2.Text = "X"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(507, 12)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(337, 45)
        Me.GunaLabel1.TabIndex = 22
        Me.GunaLabel1.Text = "Student Information"
        '
        'BtnInfo
        '
        Me.BtnInfo.BackColor = System.Drawing.Color.White
        Me.BtnInfo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnInfo.Image = CType(resources.GetObject("BtnInfo.Image"), System.Drawing.Image)
        Me.BtnInfo.ImageSize = New System.Drawing.Size(40, 40)
        Me.BtnInfo.Location = New System.Drawing.Point(865, 12)
        Me.BtnInfo.Name = "BtnInfo"
        Me.BtnInfo.OnHoverImage = Nothing
        Me.BtnInfo.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.BtnInfo.Size = New System.Drawing.Size(41, 46)
        Me.BtnInfo.TabIndex = 23
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 60)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1551, 647)
        Me.TabControl1.TabIndex = 24
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.GunaDataGridView1)
        Me.TabPage1.Controls.Add(Me.GunaLabel2)
        Me.TabPage1.Controls.Add(Me.GunaAdvenceButton5)
        Me.TabPage1.Controls.Add(Me.GunaTextBox1)
        Me.TabPage1.Controls.Add(Me.GunaGroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1543, 618)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GunaDataGridView1
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.GunaDataGridView1.AutoGenerateColumns = False
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.GunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.GunaDataGridView1.ColumnHeadersHeight = 77
        Me.GunaDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NoMatrikDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.SemesterDataGridViewTextBoxColumn, Me.BirthDateDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.NationalityDataGridViewTextBoxColumn, Me.AdressDataGridViewTextBoxColumn, Me.PlaceOfBirthDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn, Me.PicDataGridViewImageColumn, Me.CourseDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.HealthDataGridViewTextBoxColumn})
        Me.GunaDataGridView1.DataSource = Me.StudentInfoBindingSource
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(226, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(160, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle15
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GunaDataGridView1.Location = New System.Drawing.Point(3, 440)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.RowHeadersWidth = 51
        Me.GunaDataGridView1.RowTemplate.Height = 24
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(1466, 163)
        Me.GunaDataGridView1.TabIndex = 4
        Me.GunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Emerald
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 77
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = False
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 24
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(160, Byte), Integer))
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
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'SemesterDataGridViewTextBoxColumn
        '
        Me.SemesterDataGridViewTextBoxColumn.DataPropertyName = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.HeaderText = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SemesterDataGridViewTextBoxColumn.Name = "SemesterDataGridViewTextBoxColumn"
        '
        'BirthDateDataGridViewTextBoxColumn
        '
        Me.BirthDateDataGridViewTextBoxColumn.DataPropertyName = "Birth Date"
        Me.BirthDateDataGridViewTextBoxColumn.HeaderText = "Birth Date"
        Me.BirthDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BirthDateDataGridViewTextBoxColumn.Name = "BirthDateDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'NationalityDataGridViewTextBoxColumn
        '
        Me.NationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.HeaderText = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NationalityDataGridViewTextBoxColumn.Name = "NationalityDataGridViewTextBoxColumn"
        '
        'AdressDataGridViewTextBoxColumn
        '
        Me.AdressDataGridViewTextBoxColumn.DataPropertyName = "Adress"
        Me.AdressDataGridViewTextBoxColumn.HeaderText = "Adress"
        Me.AdressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AdressDataGridViewTextBoxColumn.Name = "AdressDataGridViewTextBoxColumn"
        '
        'PlaceOfBirthDataGridViewTextBoxColumn
        '
        Me.PlaceOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Place Of Birth"
        Me.PlaceOfBirthDataGridViewTextBoxColumn.HeaderText = "Place Of Birth"
        Me.PlaceOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PlaceOfBirthDataGridViewTextBoxColumn.Name = "PlaceOfBirthDataGridViewTextBoxColumn"
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "Contact"
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "Contact"
        Me.ContactDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        '
        'PicDataGridViewImageColumn
        '
        Me.PicDataGridViewImageColumn.DataPropertyName = "Pic"
        Me.PicDataGridViewImageColumn.HeaderText = "Pic"
        Me.PicDataGridViewImageColumn.MinimumWidth = 6
        Me.PicDataGridViewImageColumn.Name = "PicDataGridViewImageColumn"
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'HealthDataGridViewTextBoxColumn
        '
        Me.HealthDataGridViewTextBoxColumn.DataPropertyName = "Health"
        Me.HealthDataGridViewTextBoxColumn.HeaderText = "Health"
        Me.HealthDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HealthDataGridViewTextBoxColumn.Name = "HealthDataGridViewTextBoxColumn"
        '
        'StudentInfoBindingSource
        '
        Me.StudentInfoBindingSource.DataMember = "StudentInfo"
        Me.StudentInfoBindingSource.DataSource = Me.Database1DataSet2
        '
        'Database1DataSet2
        '
        Me.Database1DataSet2.DataSetName = "Database1DataSet2"
        Me.Database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(465, 418)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(161, 19)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "Search by enter student id"
        '
        'GunaAdvenceButton5
        '
        Me.GunaAdvenceButton5.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton5.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.GunaAdvenceButton5.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton5.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton5.CheckedImage = Nothing
        Me.GunaAdvenceButton5.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton5.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton5.Image = CType(resources.GetObject("GunaAdvenceButton5.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton5.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton5.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton5.Location = New System.Drawing.Point(870, 383)
        Me.GunaAdvenceButton5.Name = "GunaAdvenceButton5"
        Me.GunaAdvenceButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton5.OnHoverImage = Nothing
        Me.GunaAdvenceButton5.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.Size = New System.Drawing.Size(116, 32)
        Me.GunaAdvenceButton5.TabIndex = 2
        Me.GunaAdvenceButton5.Text = "SEARCH"
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox1.Location = New System.Drawing.Point(469, 383)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.Size = New System.Drawing.Size(395, 32)
        Me.GunaTextBox1.TabIndex = 1
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(IDLabel)
        Me.GunaGroupBox1.Controls.Add(Me.IDTextBox)
        Me.GunaGroupBox1.Controls.Add(Me.GunaAdvenceButton4)
        Me.GunaGroupBox1.Controls.Add(NoMatrikLabel)
        Me.GunaGroupBox1.Controls.Add(Me.GunaAdvenceButton3)
        Me.GunaGroupBox1.Controls.Add(Me.NoMatrikTextBox)
        Me.GunaGroupBox1.Controls.Add(Me.GunaAdvenceButton2)
        Me.GunaGroupBox1.Controls.Add(NameLabel)
        Me.GunaGroupBox1.Controls.Add(Me.GunaAdvenceButton1)
        Me.GunaGroupBox1.Controls.Add(Me.NameTextBox)
        Me.GunaGroupBox1.Controls.Add(PicLabel)
        Me.GunaGroupBox1.Controls.Add(SemesterLabel)
        Me.GunaGroupBox1.Controls.Add(Me.PicPictureBox)
        Me.GunaGroupBox1.Controls.Add(Me.SemesterTextBox)
        Me.GunaGroupBox1.Controls.Add(CourseLabel)
        Me.GunaGroupBox1.Controls.Add(Birth_DateLabel)
        Me.GunaGroupBox1.Controls.Add(Me.HealthTextBox)
        Me.GunaGroupBox1.Controls.Add(Me.Birth_DateDateTimePicker)
        Me.GunaGroupBox1.Controls.Add(HealthLabel)
        Me.GunaGroupBox1.Controls.Add(AgeLabel)
        Me.GunaGroupBox1.Controls.Add(Me.StatusTextBox)
        Me.GunaGroupBox1.Controls.Add(Me.AgeTextBox)
        Me.GunaGroupBox1.Controls.Add(StatusLabel)
        Me.GunaGroupBox1.Controls.Add(NationalityLabel)
        Me.GunaGroupBox1.Controls.Add(Me.GenderTextBox)
        Me.GunaGroupBox1.Controls.Add(Me.NationalityTextBox)
        Me.GunaGroupBox1.Controls.Add(GenderLabel)
        Me.GunaGroupBox1.Controls.Add(AdressLabel)
        Me.GunaGroupBox1.Controls.Add(Me.DepartmentTextBox)
        Me.GunaGroupBox1.Controls.Add(Me.AdressTextBox)
        Me.GunaGroupBox1.Controls.Add(DepartmentLabel)
        Me.GunaGroupBox1.Controls.Add(Place_Of_BirthLabel)
        Me.GunaGroupBox1.Controls.Add(Me.CourseTextBox)
        Me.GunaGroupBox1.Controls.Add(Me.Place_Of_BirthTextBox)
        Me.GunaGroupBox1.Controls.Add(Me.ContactTextBox)
        Me.GunaGroupBox1.Controls.Add(ContactLabel)
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GunaGroupBox1.Location = New System.Drawing.Point(334, 6)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(842, 371)
        Me.GunaGroupBox1.TabIndex = 0
        Me.GunaGroupBox1.Text = "Student Information"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(119, 34)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(333, 22)
        Me.IDTextBox.TabIndex = 6
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
        Me.GunaAdvenceButton4.Location = New System.Drawing.Point(354, 316)
        Me.GunaAdvenceButton4.Name = "GunaAdvenceButton4"
        Me.GunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.OnHoverImage = Nothing
        Me.GunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.Size = New System.Drawing.Size(113, 42)
        Me.GunaAdvenceButton4.TabIndex = 61
        Me.GunaAdvenceButton4.Text = "PREVIEW"
        Me.GunaAdvenceButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(124, 316)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.Green
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(104, 42)
        Me.GunaAdvenceButton3.TabIndex = 60
        Me.GunaAdvenceButton3.Text = "SAVE"
        '
        'NoMatrikTextBox
        '
        Me.NoMatrikTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "NoMatrik", True))
        Me.NoMatrikTextBox.Location = New System.Drawing.Point(119, 62)
        Me.NoMatrikTextBox.Name = "NoMatrikTextBox"
        Me.NoMatrikTextBox.Size = New System.Drawing.Size(333, 22)
        Me.NoMatrikTextBox.TabIndex = 8
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
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(234, 316)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(113, 42)
        Me.GunaAdvenceButton2.TabIndex = 59
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
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(17, 316)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(101, 42)
        Me.GunaAdvenceButton1.TabIndex = 58
        Me.GunaAdvenceButton1.Text = "ADD"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(119, 90)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(333, 22)
        Me.NameTextBox.TabIndex = 10
        '
        'PicPictureBox
        '
        Me.PicPictureBox.BackColor = System.Drawing.Color.Gray
        Me.PicPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.StudentInfoBindingSource, "Pic", True))
        Me.PicPictureBox.Location = New System.Drawing.Point(604, 205)
        Me.PicPictureBox.Name = "PicPictureBox"
        Me.PicPictureBox.Size = New System.Drawing.Size(226, 109)
        Me.PicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPictureBox.TabIndex = 26
        Me.PicPictureBox.TabStop = False
        '
        'SemesterTextBox
        '
        Me.SemesterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Semester", True))
        Me.SemesterTextBox.Location = New System.Drawing.Point(119, 118)
        Me.SemesterTextBox.Name = "SemesterTextBox"
        Me.SemesterTextBox.Size = New System.Drawing.Size(333, 22)
        Me.SemesterTextBox.TabIndex = 12
        '
        'HealthTextBox
        '
        Me.HealthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Health", True))
        Me.HealthTextBox.Location = New System.Drawing.Point(604, 164)
        Me.HealthTextBox.Name = "HealthTextBox"
        Me.HealthTextBox.Size = New System.Drawing.Size(226, 22)
        Me.HealthTextBox.TabIndex = 36
        '
        'Birth_DateDateTimePicker
        '
        Me.Birth_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StudentInfoBindingSource, "Birth Date", True))
        Me.Birth_DateDateTimePicker.Location = New System.Drawing.Point(119, 146)
        Me.Birth_DateDateTimePicker.Name = "Birth_DateDateTimePicker"
        Me.Birth_DateDateTimePicker.Size = New System.Drawing.Size(333, 22)
        Me.Birth_DateDateTimePicker.TabIndex = 14
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(604, 136)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(226, 22)
        Me.StatusTextBox.TabIndex = 34
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(119, 174)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(333, 22)
        Me.AgeTextBox.TabIndex = 16
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(604, 108)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(226, 22)
        Me.GenderTextBox.TabIndex = 32
        '
        'NationalityTextBox
        '
        Me.NationalityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Nationality", True))
        Me.NationalityTextBox.Location = New System.Drawing.Point(119, 202)
        Me.NationalityTextBox.Name = "NationalityTextBox"
        Me.NationalityTextBox.Size = New System.Drawing.Size(333, 22)
        Me.NationalityTextBox.TabIndex = 18
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(604, 80)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(226, 22)
        Me.DepartmentTextBox.TabIndex = 30
        '
        'AdressTextBox
        '
        Me.AdressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Adress", True))
        Me.AdressTextBox.Location = New System.Drawing.Point(119, 230)
        Me.AdressTextBox.Name = "AdressTextBox"
        Me.AdressTextBox.Size = New System.Drawing.Size(333, 22)
        Me.AdressTextBox.TabIndex = 20
        '
        'CourseTextBox
        '
        Me.CourseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Course", True))
        Me.CourseTextBox.Location = New System.Drawing.Point(604, 52)
        Me.CourseTextBox.Name = "CourseTextBox"
        Me.CourseTextBox.Size = New System.Drawing.Size(226, 22)
        Me.CourseTextBox.TabIndex = 28
        '
        'Place_Of_BirthTextBox
        '
        Me.Place_Of_BirthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Place Of Birth", True))
        Me.Place_Of_BirthTextBox.Location = New System.Drawing.Point(119, 258)
        Me.Place_Of_BirthTextBox.Name = "Place_Of_BirthTextBox"
        Me.Place_Of_BirthTextBox.Size = New System.Drawing.Size(333, 22)
        Me.Place_Of_BirthTextBox.TabIndex = 22
        '
        'ContactTextBox
        '
        Me.ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Contact", True))
        Me.ContactTextBox.Location = New System.Drawing.Point(119, 286)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(333, 22)
        Me.ContactTextBox.TabIndex = 24
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GunaLabel3)
        Me.TabPage2.Controls.Add(Me.GunaDataGridView2)
        Me.TabPage2.Controls.Add(Me.GunaGroupBox2)
        Me.TabPage2.Controls.Add(Me.GunaTextBox2)
        Me.TabPage2.Controls.Add(Me.GunaAdvenceButton10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1543, 618)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(470, 340)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(161, 19)
        Me.GunaLabel3.TabIndex = 8
        Me.GunaLabel3.Text = "Search by enter student id"
        '
        'GunaDataGridView2
        '
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GunaDataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.GunaDataGridView2.AutoGenerateColumns = False
        Me.GunaDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.GunaDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.GunaDataGridView2.ColumnHeadersHeight = 77
        Me.GunaDataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.FatherNameDataGridViewTextBoxColumn, Me.ICDataGridViewTextBoxColumn, Me.AdressDataGridViewTextBoxColumn1, Me.AgeDataGridViewTextBoxColumn1, Me.OccupationDataGridViewTextBoxColumn, Me.IncomeDataGridViewTextBoxColumn, Me.SonNameDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn1, Me.MotherNameDataGridViewTextBoxColumn, Me.ICNoDataGridViewTextBoxColumn, Me.AdressMotherDataGridViewTextBoxColumn, Me.AgeMotherDataGridViewTextBoxColumn, Me.OccupationMotherDataGridViewTextBoxColumn, Me.SalaryMotherDataGridViewTextBoxColumn})
        Me.GunaDataGridView2.DataSource = Me.ParentsBindingSource
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(226, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(160, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView2.DefaultCellStyle = DataGridViewCellStyle18
        Me.GunaDataGridView2.EnableHeadersVisualStyles = False
        Me.GunaDataGridView2.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GunaDataGridView2.Location = New System.Drawing.Point(3, 362)
        Me.GunaDataGridView2.Name = "GunaDataGridView2"
        Me.GunaDataGridView2.RowHeadersVisible = False
        Me.GunaDataGridView2.RowHeadersWidth = 51
        Me.GunaDataGridView2.RowTemplate.Height = 24
        Me.GunaDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView2.Size = New System.Drawing.Size(1532, 188)
        Me.GunaDataGridView2.TabIndex = 5
        Me.GunaDataGridView2.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Emerald
        Me.GunaDataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GunaDataGridView2.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GunaDataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView2.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GunaDataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GunaDataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView2.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GunaDataGridView2.ThemeStyle.HeaderStyle.Height = 77
        Me.GunaDataGridView2.ThemeStyle.ReadOnly = False
        Me.GunaDataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GunaDataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView2.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.GunaDataGridView2.ThemeStyle.RowsStyle.Height = 24
        Me.GunaDataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GunaDataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'FatherNameDataGridViewTextBoxColumn
        '
        Me.FatherNameDataGridViewTextBoxColumn.DataPropertyName = "Father Name"
        Me.FatherNameDataGridViewTextBoxColumn.HeaderText = "Father Name"
        Me.FatherNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FatherNameDataGridViewTextBoxColumn.Name = "FatherNameDataGridViewTextBoxColumn"
        '
        'ICDataGridViewTextBoxColumn
        '
        Me.ICDataGridViewTextBoxColumn.DataPropertyName = "IC"
        Me.ICDataGridViewTextBoxColumn.HeaderText = "IC"
        Me.ICDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ICDataGridViewTextBoxColumn.Name = "ICDataGridViewTextBoxColumn"
        '
        'AdressDataGridViewTextBoxColumn1
        '
        Me.AdressDataGridViewTextBoxColumn1.DataPropertyName = "Adress"
        Me.AdressDataGridViewTextBoxColumn1.HeaderText = "Adress"
        Me.AdressDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.AdressDataGridViewTextBoxColumn1.Name = "AdressDataGridViewTextBoxColumn1"
        '
        'AgeDataGridViewTextBoxColumn1
        '
        Me.AgeDataGridViewTextBoxColumn1.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn1.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.AgeDataGridViewTextBoxColumn1.Name = "AgeDataGridViewTextBoxColumn1"
        '
        'OccupationDataGridViewTextBoxColumn
        '
        Me.OccupationDataGridViewTextBoxColumn.DataPropertyName = "Occupation"
        Me.OccupationDataGridViewTextBoxColumn.HeaderText = "Occupation"
        Me.OccupationDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OccupationDataGridViewTextBoxColumn.Name = "OccupationDataGridViewTextBoxColumn"
        '
        'IncomeDataGridViewTextBoxColumn
        '
        Me.IncomeDataGridViewTextBoxColumn.DataPropertyName = "Income"
        Me.IncomeDataGridViewTextBoxColumn.HeaderText = "Income"
        Me.IncomeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IncomeDataGridViewTextBoxColumn.Name = "IncomeDataGridViewTextBoxColumn"
        '
        'SonNameDataGridViewTextBoxColumn
        '
        Me.SonNameDataGridViewTextBoxColumn.DataPropertyName = "Son Name"
        Me.SonNameDataGridViewTextBoxColumn.HeaderText = "Son Name"
        Me.SonNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SonNameDataGridViewTextBoxColumn.Name = "SonNameDataGridViewTextBoxColumn"
        '
        'ContactDataGridViewTextBoxColumn1
        '
        Me.ContactDataGridViewTextBoxColumn1.DataPropertyName = "Contact"
        Me.ContactDataGridViewTextBoxColumn1.HeaderText = "Contact"
        Me.ContactDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.ContactDataGridViewTextBoxColumn1.Name = "ContactDataGridViewTextBoxColumn1"
        '
        'MotherNameDataGridViewTextBoxColumn
        '
        Me.MotherNameDataGridViewTextBoxColumn.DataPropertyName = "Mother Name"
        Me.MotherNameDataGridViewTextBoxColumn.HeaderText = "Mother Name"
        Me.MotherNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MotherNameDataGridViewTextBoxColumn.Name = "MotherNameDataGridViewTextBoxColumn"
        '
        'ICNoDataGridViewTextBoxColumn
        '
        Me.ICNoDataGridViewTextBoxColumn.DataPropertyName = "IC-No"
        Me.ICNoDataGridViewTextBoxColumn.HeaderText = "IC-No"
        Me.ICNoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ICNoDataGridViewTextBoxColumn.Name = "ICNoDataGridViewTextBoxColumn"
        '
        'AdressMotherDataGridViewTextBoxColumn
        '
        Me.AdressMotherDataGridViewTextBoxColumn.DataPropertyName = "Adress-Mother"
        Me.AdressMotherDataGridViewTextBoxColumn.HeaderText = "Adress-Mother"
        Me.AdressMotherDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AdressMotherDataGridViewTextBoxColumn.Name = "AdressMotherDataGridViewTextBoxColumn"
        '
        'AgeMotherDataGridViewTextBoxColumn
        '
        Me.AgeMotherDataGridViewTextBoxColumn.DataPropertyName = "Age-Mother"
        Me.AgeMotherDataGridViewTextBoxColumn.HeaderText = "Age-Mother"
        Me.AgeMotherDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AgeMotherDataGridViewTextBoxColumn.Name = "AgeMotherDataGridViewTextBoxColumn"
        '
        'OccupationMotherDataGridViewTextBoxColumn
        '
        Me.OccupationMotherDataGridViewTextBoxColumn.DataPropertyName = "Occupation_Mother"
        Me.OccupationMotherDataGridViewTextBoxColumn.HeaderText = "Occupation_Mother"
        Me.OccupationMotherDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OccupationMotherDataGridViewTextBoxColumn.Name = "OccupationMotherDataGridViewTextBoxColumn"
        '
        'SalaryMotherDataGridViewTextBoxColumn
        '
        Me.SalaryMotherDataGridViewTextBoxColumn.DataPropertyName = "Salary-Mother"
        Me.SalaryMotherDataGridViewTextBoxColumn.HeaderText = "Salary-Mother"
        Me.SalaryMotherDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SalaryMotherDataGridViewTextBoxColumn.Name = "SalaryMotherDataGridViewTextBoxColumn"
        '
        'ParentsBindingSource
        '
        Me.ParentsBindingSource.DataMember = "Parents"
        Me.ParentsBindingSource.DataSource = Me.Database1DataSet2
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.Controls.Add(IDLabel1)
        Me.GunaGroupBox2.Controls.Add(Me.IDTextBox1)
        Me.GunaGroupBox2.Controls.Add(Me.GunaAdvenceButton6)
        Me.GunaGroupBox2.Controls.Add(Father_NameLabel)
        Me.GunaGroupBox2.Controls.Add(Me.GunaAdvenceButton7)
        Me.GunaGroupBox2.Controls.Add(Me.Father_NameTextBox)
        Me.GunaGroupBox2.Controls.Add(Me.GunaAdvenceButton8)
        Me.GunaGroupBox2.Controls.Add(ICLabel)
        Me.GunaGroupBox2.Controls.Add(Me.GunaAdvenceButton9)
        Me.GunaGroupBox2.Controls.Add(Me.ICTextBox)
        Me.GunaGroupBox2.Controls.Add(Mother_NameLabel)
        Me.GunaGroupBox2.Controls.Add(AdressLabel1)
        Me.GunaGroupBox2.Controls.Add(Me.Salary_MotherTextBox)
        Me.GunaGroupBox2.Controls.Add(Me.AdressTextBox1)
        Me.GunaGroupBox2.Controls.Add(Salary_MotherLabel)
        Me.GunaGroupBox2.Controls.Add(AgeLabel1)
        Me.GunaGroupBox2.Controls.Add(Me.Occupation_MotherTextBox)
        Me.GunaGroupBox2.Controls.Add(Me.AgeTextBox1)
        Me.GunaGroupBox2.Controls.Add(Occupation_MotherLabel)
        Me.GunaGroupBox2.Controls.Add(OccupationLabel)
        Me.GunaGroupBox2.Controls.Add(Me.Age_MotherTextBox)
        Me.GunaGroupBox2.Controls.Add(Me.OccupationTextBox)
        Me.GunaGroupBox2.Controls.Add(Age_MotherLabel)
        Me.GunaGroupBox2.Controls.Add(IncomeLabel)
        Me.GunaGroupBox2.Controls.Add(Me.Adress_MotherTextBox)
        Me.GunaGroupBox2.Controls.Add(Me.IncomeTextBox)
        Me.GunaGroupBox2.Controls.Add(Adress_MotherLabel)
        Me.GunaGroupBox2.Controls.Add(Son_NameLabel)
        Me.GunaGroupBox2.Controls.Add(Me.IC_NoTextBox)
        Me.GunaGroupBox2.Controls.Add(Me.Son_NameTextBox)
        Me.GunaGroupBox2.Controls.Add(IC_NoLabel)
        Me.GunaGroupBox2.Controls.Add(ContactLabel1)
        Me.GunaGroupBox2.Controls.Add(Me.Mother_NameTextBox)
        Me.GunaGroupBox2.Controls.Add(Me.ContactTextBox1)
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GunaGroupBox2.Location = New System.Drawing.Point(326, 6)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(879, 293)
        Me.GunaGroupBox2.TabIndex = 1
        Me.GunaGroupBox2.Text = "Parents Information"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'IDTextBox1
        '
        Me.IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParentsBindingSource, "ID", True))
        Me.IDTextBox1.Location = New System.Drawing.Point(166, 36)
        Me.IDTextBox1.Name = "IDTextBox1"
        Me.IDTextBox1.Size = New System.Drawing.Size(239, 22)
        Me.IDTextBox1.TabIndex = 2
        '
        'GunaAdvenceButton6
        '
        Me.GunaAdvenceButton6.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton6.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton6.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton6.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton6.CheckedImage = CType(resources.GetObject("GunaAdvenceButton6.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton6.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton6.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton6.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton6.Image = Nothing
        Me.GunaAdvenceButton6.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton6.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton6.Location = New System.Drawing.Point(751, 235)
        Me.GunaAdvenceButton6.Name = "GunaAdvenceButton6"
        Me.GunaAdvenceButton6.OnHoverBaseColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton6.OnHoverImage = Nothing
        Me.GunaAdvenceButton6.OnHoverLineColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.Size = New System.Drawing.Size(113, 42)
        Me.GunaAdvenceButton6.TabIndex = 61
        Me.GunaAdvenceButton6.Text = "PREVIEW"
        Me.GunaAdvenceButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton7
        '
        Me.GunaAdvenceButton7.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton7.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton7.BaseColor = System.Drawing.Color.Green
        Me.GunaAdvenceButton7.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton7.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton7.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton7.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton7.CheckedImage = CType(resources.GetObject("GunaAdvenceButton7.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton7.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton7.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton7.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton7.Image = CType(resources.GetObject("GunaAdvenceButton7.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton7.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton7.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton7.Location = New System.Drawing.Point(522, 235)
        Me.GunaAdvenceButton7.Name = "GunaAdvenceButton7"
        Me.GunaAdvenceButton7.OnHoverBaseColor = System.Drawing.Color.Green
        Me.GunaAdvenceButton7.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton7.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton7.OnHoverImage = Nothing
        Me.GunaAdvenceButton7.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton7.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton7.Size = New System.Drawing.Size(104, 42)
        Me.GunaAdvenceButton7.TabIndex = 60
        Me.GunaAdvenceButton7.Text = "SAVE"
        '
        'Father_NameTextBox
        '
        Me.Father_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParentsBindingSource, "Father Name", True))
        Me.Father_NameTextBox.Location = New System.Drawing.Point(166, 64)
        Me.Father_NameTextBox.Name = "Father_NameTextBox"
        Me.Father_NameTextBox.Size = New System.Drawing.Size(239, 22)
        Me.Father_NameTextBox.TabIndex = 4
        '
        'GunaAdvenceButton8
        '
        Me.GunaAdvenceButton8.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton8.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton8.BaseColor = System.Drawing.Color.Red
        Me.GunaAdvenceButton8.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton8.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton8.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton8.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton8.CheckedImage = CType(resources.GetObject("GunaAdvenceButton8.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton8.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton8.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton8.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton8.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton8.Image = CType(resources.GetObject("GunaAdvenceButton8.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton8.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton8.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton8.Location = New System.Drawing.Point(632, 235)
        Me.GunaAdvenceButton8.Name = "GunaAdvenceButton8"
        Me.GunaAdvenceButton8.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton8.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton8.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton8.OnHoverImage = Nothing
        Me.GunaAdvenceButton8.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton8.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton8.Size = New System.Drawing.Size(113, 42)
        Me.GunaAdvenceButton8.TabIndex = 59
        Me.GunaAdvenceButton8.Text = "DELETE"
        '
        'GunaAdvenceButton9
        '
        Me.GunaAdvenceButton9.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton9.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton9.BaseColor = System.Drawing.Color.Blue
        Me.GunaAdvenceButton9.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton9.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton9.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton9.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton9.CheckedImage = CType(resources.GetObject("GunaAdvenceButton9.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton9.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton9.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton9.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton9.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton9.Image = CType(resources.GetObject("GunaAdvenceButton9.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton9.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton9.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaAdvenceButton9.Location = New System.Drawing.Point(415, 235)
        Me.GunaAdvenceButton9.Name = "GunaAdvenceButton9"
        Me.GunaAdvenceButton9.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaAdvenceButton9.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton9.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton9.OnHoverImage = Nothing
        Me.GunaAdvenceButton9.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaAdvenceButton9.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton9.Size = New System.Drawing.Size(101, 42)
        Me.GunaAdvenceButton9.TabIndex = 58
        Me.GunaAdvenceButton9.Text = "ADD"
        '
        'ICTextBox
        '
        Me.ICTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParentsBindingSource, "IC", True))
        Me.ICTextBox.Location = New System.Drawing.Point(166, 92)
        Me.ICTextBox.Name = "ICTextBox"
        Me.ICTextBox.Size = New System.Drawing.Size(239, 22)
        Me.ICTextBox.TabIndex = 6
        '
        'Salary_MotherTextBox
        '
        Me.Salary_MotherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParentsBindingSource, "Salary-Mother", True))
        Me.Salary_MotherTextBox.Location = New System.Drawing.Point(549, 178)
        Me.Salary_MotherTextBox.Name = "Salary_MotherTextBox"
        Me.Salary_MotherTextBox.Size = New System.Drawing.Size(261, 22)
        Me.Salary_MotherTextBox.TabIndex = 30
        '
        'AdressTextBox1
        '
        Me.AdressTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParentsBindingSource, "Adress", True))
        Me.AdressTextBox1.Location = New System.Drawing.Point(166, 120)
        Me.AdressTextBox1.Name = "AdressTextBox1"
        Me.AdressTextBox1.Size = New System.Drawing.Size(239, 22)
        Me.AdressTextBox1.TabIndex = 8
        '
        'Occupation_MotherTextBox
        '
        Me.Occupation_MotherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParentsBindingSource, "Occupation_Mother", True))
        Me.Occupation_MotherTextBox.Location = New System.Drawing.Point(549, 150)
        Me.Occupation_MotherTextBox.Name = "Occupation_MotherTextBox"
        Me.Occupation_MotherTextBox.Size = New System.Drawing.Size(261, 22)
        Me.Occupation_MotherTextBox.TabIndex = 28
        '
        'AgeTextBox1
        '
        Me.AgeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParentsBindingSource, "Age", True))
        Me.AgeTextBox1.Location = New System.Drawing.Point(166, 148)
        Me.AgeTextBox1.Name = "AgeTextBox1"
        Me.AgeTextBox1.Size = New System.Drawing.Size(239, 22)
        Me.AgeTextBox1.TabIndex = 10
        '
        'Age_MotherTextBox
        '
        Me.Age_MotherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParentsBindingSource, "Age-Mother", True))
        Me.Age_MotherTextBox.Location = New System.Drawing.Point(549, 122)
        Me.Age_MotherTextBox.Name = "Age_MotherTextBox"
        Me.Age_MotherTextBox.Size = New System.Drawing.Size(261, 22)
        Me.Age_MotherTextBox.TabIndex = 26
        '
        'OccupationTextBox
        '
        Me.OccupationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParentsBindingSource, "Occupation", True))
        Me.OccupationTextBox.Location = New System.Drawing.Point(166, 176)
        Me.OccupationTextBox.Name = "OccupationTextBox"
        Me.OccupationTextBox.Size = New System.Drawing.Size(239, 22)
        Me.OccupationTextBox.TabIndex = 12
        '
        'Adress_MotherTextBox
        '
        Me.Adress_MotherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParentsBindingSource, "Adress-Mother", True))
        Me.Adress_MotherTextBox.Location = New System.Drawing.Point(549, 94)
        Me.Adress_MotherTextBox.Name = "Adress_MotherTextBox"
        Me.Adress_MotherTextBox.Size = New System.Drawing.Size(261, 22)
        Me.Adress_MotherTextBox.TabIndex = 24
        '
        'IncomeTextBox
        '
        Me.IncomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParentsBindingSource, "Income", True))
        Me.IncomeTextBox.Location = New System.Drawing.Point(166, 204)
        Me.IncomeTextBox.Name = "IncomeTextBox"
        Me.IncomeTextBox.Size = New System.Drawing.Size(239, 22)
        Me.IncomeTextBox.TabIndex = 14
        '
        'IC_NoTextBox
        '
        Me.IC_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParentsBindingSource, "IC-No", True))
        Me.IC_NoTextBox.Location = New System.Drawing.Point(549, 66)
        Me.IC_NoTextBox.Name = "IC_NoTextBox"
        Me.IC_NoTextBox.Size = New System.Drawing.Size(261, 22)
        Me.IC_NoTextBox.TabIndex = 22
        '
        'Son_NameTextBox
        '
        Me.Son_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParentsBindingSource, "Son Name", True))
        Me.Son_NameTextBox.Location = New System.Drawing.Point(166, 232)
        Me.Son_NameTextBox.Name = "Son_NameTextBox"
        Me.Son_NameTextBox.Size = New System.Drawing.Size(239, 22)
        Me.Son_NameTextBox.TabIndex = 16
        '
        'Mother_NameTextBox
        '
        Me.Mother_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParentsBindingSource, "Mother Name", True))
        Me.Mother_NameTextBox.Location = New System.Drawing.Point(549, 38)
        Me.Mother_NameTextBox.Name = "Mother_NameTextBox"
        Me.Mother_NameTextBox.Size = New System.Drawing.Size(261, 22)
        Me.Mother_NameTextBox.TabIndex = 20
        '
        'ContactTextBox1
        '
        Me.ContactTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParentsBindingSource, "Contact", True))
        Me.ContactTextBox1.Location = New System.Drawing.Point(166, 260)
        Me.ContactTextBox1.Name = "ContactTextBox1"
        Me.ContactTextBox1.Size = New System.Drawing.Size(239, 22)
        Me.ContactTextBox1.TabIndex = 18
        '
        'GunaTextBox2
        '
        Me.GunaTextBox2.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox2.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox2.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox2.Location = New System.Drawing.Point(474, 305)
        Me.GunaTextBox2.Name = "GunaTextBox2"
        Me.GunaTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox2.Size = New System.Drawing.Size(395, 32)
        Me.GunaTextBox2.TabIndex = 6
        '
        'GunaAdvenceButton10
        '
        Me.GunaAdvenceButton10.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton10.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton10.BaseColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.GunaAdvenceButton10.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton10.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton10.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton10.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton10.CheckedImage = Nothing
        Me.GunaAdvenceButton10.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton10.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton10.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton10.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton10.Image = CType(resources.GetObject("GunaAdvenceButton10.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton10.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton10.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton10.Location = New System.Drawing.Point(875, 305)
        Me.GunaAdvenceButton10.Name = "GunaAdvenceButton10"
        Me.GunaAdvenceButton10.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton10.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton10.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton10.OnHoverImage = Nothing
        Me.GunaAdvenceButton10.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton10.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton10.Size = New System.Drawing.Size(116, 32)
        Me.GunaAdvenceButton10.TabIndex = 7
        Me.GunaAdvenceButton10.Text = "SEARCH"
        '
        'StudentInfoTableAdapter
        '
        Me.StudentInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.linkerTableAdapter = Nothing
        Me.TableAdapterManager.MentorTableAdapter = Nothing
        Me.TableAdapterManager.ParentsTableAdapter = Me.ParentsTableAdapter
        Me.TableAdapterManager.StudentInfoTableAdapter = Me.StudentInfoTableAdapter
        Me.TableAdapterManager.UpdateOrder = Staff_Mentoring_System.Database1DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ParentsTableAdapter
        '
        Me.ParentsTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1194, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 48)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "ADD IMAGE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StudentRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1563, 737)
        Me.Controls.Add(Me.BtnInfo)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaAdvenceTileButton2)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentRegistration"
        Me.Text = "StudentRegistration"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        CType(Me.PicPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.GunaDataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaAdvenceTileButton2 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BtnInfo As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaAdvenceButton5 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaAdvenceButton4 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Database1DataSet2 As Database1DataSet2
    Friend WithEvents StudentInfoBindingSource As BindingSource
    Friend WithEvents StudentInfoTableAdapter As Database1DataSet2TableAdapters.StudentInfoTableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSet2TableAdapters.TableAdapterManager
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoMatrikDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SemesterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NationalityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlaceOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PicDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HealthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NoMatrikTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents PicPictureBox As PictureBox
    Friend WithEvents SemesterTextBox As TextBox
    Friend WithEvents HealthTextBox As TextBox
    Friend WithEvents Birth_DateDateTimePicker As DateTimePicker
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents NationalityTextBox As TextBox
    Friend WithEvents DepartmentTextBox As TextBox
    Friend WithEvents AdressTextBox As TextBox
    Friend WithEvents CourseTextBox As TextBox
    Friend WithEvents Place_Of_BirthTextBox As TextBox
    Friend WithEvents ContactTextBox As TextBox
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaAdvenceButton6 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton7 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton8 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton9 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents ParentsTableAdapter As Database1DataSet2TableAdapters.ParentsTableAdapter
    Friend WithEvents ParentsBindingSource As BindingSource
    Friend WithEvents IDTextBox1 As TextBox
    Friend WithEvents Father_NameTextBox As TextBox
    Friend WithEvents ICTextBox As TextBox
    Friend WithEvents Salary_MotherTextBox As TextBox
    Friend WithEvents AdressTextBox1 As TextBox
    Friend WithEvents Occupation_MotherTextBox As TextBox
    Friend WithEvents AgeTextBox1 As TextBox
    Friend WithEvents Age_MotherTextBox As TextBox
    Friend WithEvents OccupationTextBox As TextBox
    Friend WithEvents Adress_MotherTextBox As TextBox
    Friend WithEvents IncomeTextBox As TextBox
    Friend WithEvents IC_NoTextBox As TextBox
    Friend WithEvents Son_NameTextBox As TextBox
    Friend WithEvents Mother_NameTextBox As TextBox
    Friend WithEvents ContactTextBox1 As TextBox
    Friend WithEvents GunaDataGridView2 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FatherNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ICDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdressDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents OccupationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IncomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SonNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MotherNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ICNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdressMotherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeMotherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OccupationMotherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalaryMotherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaAdvenceButton10 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaTextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
