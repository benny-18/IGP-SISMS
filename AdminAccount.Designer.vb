<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminAccount
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
        Me.panelAdmin = New Guna.UI2.WinForms.Guna2Panel()
        Me.panAcctDetails = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnDeleteAccount = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSaveEdits = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnStallPasswordChange = New Guna.UI2.WinForms.Guna2Button()
        Me.txtStallPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Chip4 = New Guna.UI2.WinForms.Guna2Chip()
        Me.Guna2Chip5 = New Guna.UI2.WinForms.Guna2Chip()
        Me.txtStallOwnerName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtpStallOwnerBirthdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtStallUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Chip1 = New Guna.UI2.WinForms.Guna2Chip()
        Me.Guna2Chip3 = New Guna.UI2.WinForms.Guna2Chip()
        Me.btnAcctImageImport = New System.Windows.Forms.Button()
        Me.txtStallName = New System.Windows.Forms.TextBox()
        Me.acctImage = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnAddAccount = New Guna.UI2.WinForms.Guna2Button()
        Me.panAcctsList = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btnAcctsListRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.panListAcctsList = New System.Windows.Forms.ListBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHome = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.grpboxTip = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.panelAdminInfo = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnAdminChangePassword = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Chip10 = New Guna.UI2.WinForms.Guna2Chip()
        Me.Guna2Chip12 = New Guna.UI2.WinForms.Guna2Chip()
        Me.stallName = New System.Windows.Forms.Label()
        Me.stallOwnerPhoto = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse4 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse5 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse6 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse7 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.panelAdmin.SuspendLayout()
        Me.panAcctDetails.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.acctImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panAcctsList.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAdminInfo.SuspendLayout()
        CType(Me.stallOwnerPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelAdmin
        '
        Me.panelAdmin.Controls.Add(Me.panAcctDetails)
        Me.panelAdmin.Controls.Add(Me.panAcctsList)
        Me.panelAdmin.Controls.Add(Me.Label1)
        Me.panelAdmin.Controls.Add(Me.btnHome)
        Me.panelAdmin.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelAdmin.Location = New System.Drawing.Point(225, 0)
        Me.panelAdmin.Name = "panelAdmin"
        Me.panelAdmin.ShadowDecoration.Parent = Me.panelAdmin
        Me.panelAdmin.Size = New System.Drawing.Size(1086, 851)
        Me.panelAdmin.TabIndex = 45
        '
        'panAcctDetails
        '
        Me.panAcctDetails.BackColor = System.Drawing.Color.White
        Me.panAcctDetails.Controls.Add(Me.btnDeleteAccount)
        Me.panAcctDetails.Controls.Add(Me.btnSaveEdits)
        Me.panAcctDetails.Controls.Add(Me.Guna2GroupBox1)
        Me.panAcctDetails.Controls.Add(Me.btnAcctImageImport)
        Me.panAcctDetails.Controls.Add(Me.txtStallName)
        Me.panAcctDetails.Controls.Add(Me.acctImage)
        Me.panAcctDetails.Controls.Add(Me.Guna2PictureBox3)
        Me.panAcctDetails.Controls.Add(Me.btnAddAccount)
        Me.panAcctDetails.Location = New System.Drawing.Point(434, 205)
        Me.panAcctDetails.Name = "panAcctDetails"
        Me.panAcctDetails.ShadowDecoration.Parent = Me.panAcctDetails
        Me.panAcctDetails.Size = New System.Drawing.Size(585, 570)
        Me.panAcctDetails.TabIndex = 47
        '
        'btnDeleteAccount
        '
        Me.btnDeleteAccount.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteAccount.BorderRadius = 8
        Me.btnDeleteAccount.CheckedState.Parent = Me.btnDeleteAccount
        Me.btnDeleteAccount.CustomImages.Parent = Me.btnDeleteAccount
        Me.btnDeleteAccount.FillColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDeleteAccount.Font = New System.Drawing.Font("Bahnschrift", 11.25!)
        Me.btnDeleteAccount.ForeColor = System.Drawing.Color.White
        Me.btnDeleteAccount.HoverState.Parent = Me.btnDeleteAccount
        Me.btnDeleteAccount.Image = Global.System_OOP_Guna.My.Resources.Resources.delete_item
        Me.btnDeleteAccount.Location = New System.Drawing.Point(305, 504)
        Me.btnDeleteAccount.Name = "btnDeleteAccount"
        Me.btnDeleteAccount.ShadowDecoration.Parent = Me.btnDeleteAccount
        Me.btnDeleteAccount.Size = New System.Drawing.Size(240, 37)
        Me.btnDeleteAccount.TabIndex = 70
        Me.btnDeleteAccount.Text = "Delete"
        Me.btnDeleteAccount.TextOffset = New System.Drawing.Point(0, 1)
        Me.btnDeleteAccount.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.btnDeleteAccount.UseTransparentBackground = True
        '
        'btnSaveEdits
        '
        Me.btnSaveEdits.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveEdits.BorderRadius = 8
        Me.btnSaveEdits.CheckedState.Parent = Me.btnSaveEdits
        Me.btnSaveEdits.CustomImages.Parent = Me.btnSaveEdits
        Me.btnSaveEdits.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnSaveEdits.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveEdits.ForeColor = System.Drawing.Color.White
        Me.btnSaveEdits.HoverState.Parent = Me.btnSaveEdits
        Me.btnSaveEdits.Image = Global.System_OOP_Guna.My.Resources.Resources.edit_item
        Me.btnSaveEdits.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnSaveEdits.Location = New System.Drawing.Point(38, 504)
        Me.btnSaveEdits.Name = "btnSaveEdits"
        Me.btnSaveEdits.ShadowDecoration.Parent = Me.btnSaveEdits
        Me.btnSaveEdits.Size = New System.Drawing.Size(240, 37)
        Me.btnSaveEdits.TabIndex = 69
        Me.btnSaveEdits.Text = "Save edits"
        Me.btnSaveEdits.TextOffset = New System.Drawing.Point(0, 1)
        Me.btnSaveEdits.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.btnSaveEdits.UseTransparentBackground = True
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 12
        Me.Guna2GroupBox1.Controls.Add(Me.btnStallPasswordChange)
        Me.Guna2GroupBox1.Controls.Add(Me.txtStallPassword)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Chip4)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Chip5)
        Me.Guna2GroupBox1.Controls.Add(Me.txtStallOwnerName)
        Me.Guna2GroupBox1.Controls.Add(Me.dtpStallOwnerBirthdate)
        Me.Guna2GroupBox1.Controls.Add(Me.txtStallUsername)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Chip1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Chip3)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Bahnschrift", 9.75!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(38, 273)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(507, 210)
        Me.Guna2GroupBox1.TabIndex = 68
        Me.Guna2GroupBox1.Text = "ACCOUNT DETAILS"
        Me.Guna2GroupBox1.TextOffset = New System.Drawing.Point(0, 2)
        Me.Guna2GroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'btnStallPasswordChange
        '
        Me.btnStallPasswordChange.Animated = True
        Me.btnStallPasswordChange.BorderRadius = 5
        Me.btnStallPasswordChange.CheckedState.Parent = Me.btnStallPasswordChange
        Me.btnStallPasswordChange.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStallPasswordChange.CustomImages.ImageOffset = New System.Drawing.Point(6, 0)
        Me.btnStallPasswordChange.CustomImages.ImageSize = New System.Drawing.Size(12, 12)
        Me.btnStallPasswordChange.CustomImages.Parent = Me.btnStallPasswordChange
        Me.btnStallPasswordChange.FillColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnStallPasswordChange.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnStallPasswordChange.ForeColor = System.Drawing.Color.White
        Me.btnStallPasswordChange.HoverState.Parent = Me.btnStallPasswordChange
        Me.btnStallPasswordChange.Image = Global.System_OOP_Guna.My.Resources.Resources.password
        Me.btnStallPasswordChange.ImageSize = New System.Drawing.Size(12, 12)
        Me.btnStallPasswordChange.Location = New System.Drawing.Point(270, 154)
        Me.btnStallPasswordChange.Name = "btnStallPasswordChange"
        Me.btnStallPasswordChange.ShadowDecoration.Parent = Me.btnStallPasswordChange
        Me.btnStallPasswordChange.Size = New System.Drawing.Size(215, 34)
        Me.btnStallPasswordChange.TabIndex = 67
        Me.btnStallPasswordChange.Text = "Click to change"
        '
        'txtStallPassword
        '
        Me.txtStallPassword.BorderRadius = 5
        Me.txtStallPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStallPassword.DefaultText = "Stall password"
        Me.txtStallPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStallPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStallPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStallPassword.DisabledState.Parent = Me.txtStallPassword
        Me.txtStallPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStallPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStallPassword.FocusedState.Parent = Me.txtStallPassword
        Me.txtStallPassword.ForeColor = System.Drawing.Color.Black
        Me.txtStallPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStallPassword.HoverState.Parent = Me.txtStallPassword
        Me.txtStallPassword.Location = New System.Drawing.Point(270, 154)
        Me.txtStallPassword.Margin = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.txtStallPassword.Name = "txtStallPassword"
        Me.txtStallPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStallPassword.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtStallPassword.PlaceholderText = ""
        Me.txtStallPassword.SelectedText = ""
        Me.txtStallPassword.SelectionStart = 14
        Me.txtStallPassword.ShadowDecoration.Parent = Me.txtStallPassword
        Me.txtStallPassword.Size = New System.Drawing.Size(215, 34)
        Me.txtStallPassword.TabIndex = 74
        '
        'Guna2Chip4
        '
        Me.Guna2Chip4.BorderRadius = 6
        Me.Guna2Chip4.FillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Guna2Chip4.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Chip4.ForeColor = System.Drawing.Color.White
        Me.Guna2Chip4.Location = New System.Drawing.Point(270, 59)
        Me.Guna2Chip4.Name = "Guna2Chip4"
        Me.Guna2Chip4.ShadowDecoration.Parent = Me.Guna2Chip4
        Me.Guna2Chip4.Size = New System.Drawing.Size(70, 18)
        Me.Guna2Chip4.TabIndex = 71
        Me.Guna2Chip4.Text = "BIRTHDATE"
        Me.Guna2Chip4.TextOffset = New System.Drawing.Point(0, 1)
        Me.Guna2Chip4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Guna2Chip5
        '
        Me.Guna2Chip5.BorderRadius = 6
        Me.Guna2Chip5.FillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Guna2Chip5.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Chip5.ForeColor = System.Drawing.Color.White
        Me.Guna2Chip5.Location = New System.Drawing.Point(23, 59)
        Me.Guna2Chip5.Name = "Guna2Chip5"
        Me.Guna2Chip5.ShadowDecoration.Parent = Me.Guna2Chip5
        Me.Guna2Chip5.Size = New System.Drawing.Size(52, 18)
        Me.Guna2Chip5.TabIndex = 69
        Me.Guna2Chip5.Text = "OWNER"
        Me.Guna2Chip5.TextOffset = New System.Drawing.Point(0, 1)
        Me.Guna2Chip5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'txtStallOwnerName
        '
        Me.txtStallOwnerName.BorderRadius = 5
        Me.txtStallOwnerName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStallOwnerName.DefaultText = "Stall owner"
        Me.txtStallOwnerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStallOwnerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStallOwnerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStallOwnerName.DisabledState.Parent = Me.txtStallOwnerName
        Me.txtStallOwnerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStallOwnerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStallOwnerName.FocusedState.Parent = Me.txtStallOwnerName
        Me.txtStallOwnerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStallOwnerName.HoverState.Parent = Me.txtStallOwnerName
        Me.txtStallOwnerName.Location = New System.Drawing.Point(23, 85)
        Me.txtStallOwnerName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtStallOwnerName.Name = "txtStallOwnerName"
        Me.txtStallOwnerName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStallOwnerName.PlaceholderText = ""
        Me.txtStallOwnerName.SelectedText = ""
        Me.txtStallOwnerName.SelectionStart = 11
        Me.txtStallOwnerName.ShadowDecoration.Parent = Me.txtStallOwnerName
        Me.txtStallOwnerName.Size = New System.Drawing.Size(216, 34)
        Me.txtStallOwnerName.TabIndex = 72
        '
        'dtpStallOwnerBirthdate
        '
        Me.dtpStallOwnerBirthdate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtpStallOwnerBirthdate.BorderRadius = 5
        Me.dtpStallOwnerBirthdate.BorderThickness = 1
        Me.dtpStallOwnerBirthdate.CheckedState.Parent = Me.dtpStallOwnerBirthdate
        Me.dtpStallOwnerBirthdate.FillColor = System.Drawing.SystemColors.Window
        Me.dtpStallOwnerBirthdate.ForeColor = System.Drawing.Color.Black
        Me.dtpStallOwnerBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpStallOwnerBirthdate.HoverState.Parent = Me.dtpStallOwnerBirthdate
        Me.dtpStallOwnerBirthdate.Location = New System.Drawing.Point(270, 85)
        Me.dtpStallOwnerBirthdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpStallOwnerBirthdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpStallOwnerBirthdate.Name = "dtpStallOwnerBirthdate"
        Me.dtpStallOwnerBirthdate.ShadowDecoration.Parent = Me.dtpStallOwnerBirthdate
        Me.dtpStallOwnerBirthdate.Size = New System.Drawing.Size(215, 34)
        Me.dtpStallOwnerBirthdate.TabIndex = 73
        Me.dtpStallOwnerBirthdate.TextOffset = New System.Drawing.Point(0, 2)
        Me.dtpStallOwnerBirthdate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.dtpStallOwnerBirthdate.Value = New Date(2024, 1, 1, 0, 0, 0, 0)
        '
        'txtStallUsername
        '
        Me.txtStallUsername.BorderRadius = 5
        Me.txtStallUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStallUsername.DefaultText = "Stall username"
        Me.txtStallUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStallUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStallUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStallUsername.DisabledState.Parent = Me.txtStallUsername
        Me.txtStallUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStallUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStallUsername.FocusedState.Parent = Me.txtStallUsername
        Me.txtStallUsername.ForeColor = System.Drawing.Color.Black
        Me.txtStallUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStallUsername.HoverState.Parent = Me.txtStallUsername
        Me.txtStallUsername.Location = New System.Drawing.Point(22, 154)
        Me.txtStallUsername.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtStallUsername.Name = "txtStallUsername"
        Me.txtStallUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStallUsername.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtStallUsername.PlaceholderText = ""
        Me.txtStallUsername.SelectedText = ""
        Me.txtStallUsername.SelectionStart = 14
        Me.txtStallUsername.ShadowDecoration.Parent = Me.txtStallUsername
        Me.txtStallUsername.Size = New System.Drawing.Size(215, 34)
        Me.txtStallUsername.TabIndex = 66
        '
        'Guna2Chip1
        '
        Me.Guna2Chip1.BorderRadius = 6
        Me.Guna2Chip1.FillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Guna2Chip1.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Chip1.ForeColor = System.Drawing.Color.White
        Me.Guna2Chip1.Location = New System.Drawing.Point(270, 128)
        Me.Guna2Chip1.Name = "Guna2Chip1"
        Me.Guna2Chip1.ShadowDecoration.Parent = Me.Guna2Chip1
        Me.Guna2Chip1.Size = New System.Drawing.Size(70, 18)
        Me.Guna2Chip1.TabIndex = 65
        Me.Guna2Chip1.Text = "PASSWORD"
        Me.Guna2Chip1.TextOffset = New System.Drawing.Point(0, 1)
        Me.Guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Guna2Chip3
        '
        Me.Guna2Chip3.BorderRadius = 6
        Me.Guna2Chip3.FillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Guna2Chip3.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Chip3.ForeColor = System.Drawing.Color.White
        Me.Guna2Chip3.Location = New System.Drawing.Point(22, 129)
        Me.Guna2Chip3.Name = "Guna2Chip3"
        Me.Guna2Chip3.ShadowDecoration.Parent = Me.Guna2Chip3
        Me.Guna2Chip3.Size = New System.Drawing.Size(70, 18)
        Me.Guna2Chip3.TabIndex = 64
        Me.Guna2Chip3.Text = "USERNAME"
        Me.Guna2Chip3.TextOffset = New System.Drawing.Point(0, 1)
        Me.Guna2Chip3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'btnAcctImageImport
        '
        Me.btnAcctImageImport.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcctImageImport.Location = New System.Drawing.Point(148, 162)
        Me.btnAcctImageImport.Name = "btnAcctImageImport"
        Me.btnAcctImageImport.Size = New System.Drawing.Size(99, 26)
        Me.btnAcctImageImport.TabIndex = 61
        Me.btnAcctImageImport.Text = "Import image"
        Me.btnAcctImageImport.UseVisualStyleBackColor = True
        '
        'txtStallName
        '
        Me.txtStallName.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStallName.Location = New System.Drawing.Point(38, 215)
        Me.txtStallName.Name = "txtStallName"
        Me.txtStallName.Size = New System.Drawing.Size(237, 36)
        Me.txtStallName.TabIndex = 62
        Me.txtStallName.Text = "Stall name"
        '
        'acctImage
        '
        Me.acctImage.BackColor = System.Drawing.Color.Transparent
        Me.acctImage.Image = Global.System_OOP_Guna.My.Resources.Resources.profile
        Me.acctImage.Location = New System.Drawing.Point(38, 98)
        Me.acctImage.Name = "acctImage"
        Me.acctImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.acctImage.ShadowDecoration.Parent = Me.acctImage
        Me.acctImage.Size = New System.Drawing.Size(100, 100)
        Me.acctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.acctImage.TabIndex = 1
        Me.acctImage.TabStop = False
        Me.acctImage.UseTransparentBackground = True
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.Image = Global.System_OOP_Guna.My.Resources.Resources.cover
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(-16, -150)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.ShadowDecoration.Parent = Me.Guna2PictureBox3
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(618, 299)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox3.TabIndex = 0
        Me.Guna2PictureBox3.TabStop = False
        '
        'btnAddAccount
        '
        Me.btnAddAccount.BorderRadius = 8
        Me.btnAddAccount.CheckedState.Parent = Me.btnAddAccount
        Me.btnAddAccount.CustomImages.Parent = Me.btnAddAccount
        Me.btnAddAccount.FillColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnAddAccount.Font = New System.Drawing.Font("Bahnschrift", 11.25!)
        Me.btnAddAccount.ForeColor = System.Drawing.Color.White
        Me.btnAddAccount.HoverState.Parent = Me.btnAddAccount
        Me.btnAddAccount.Image = Global.System_OOP_Guna.My.Resources.Resources.add_acc
        Me.btnAddAccount.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnAddAccount.Location = New System.Drawing.Point(38, 504)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.ShadowDecoration.Parent = Me.btnAddAccount
        Me.btnAddAccount.Size = New System.Drawing.Size(507, 37)
        Me.btnAddAccount.TabIndex = 71
        Me.btnAddAccount.Text = "Add account"
        Me.btnAddAccount.TextOffset = New System.Drawing.Point(0, 1)
        Me.btnAddAccount.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.btnAddAccount.Visible = False
        '
        'panAcctsList
        '
        Me.panAcctsList.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.panAcctsList.Controls.Add(Me.Guna2CircleButton1)
        Me.panAcctsList.Controls.Add(Me.btnAcctsListRefresh)
        Me.panAcctsList.Controls.Add(Me.panListAcctsList)
        Me.panAcctsList.Controls.Add(Me.Label26)
        Me.panAcctsList.Location = New System.Drawing.Point(73, 205)
        Me.panAcctsList.Name = "panAcctsList"
        Me.panAcctsList.ShadowDecoration.Parent = Me.panAcctsList
        Me.panAcctsList.Size = New System.Drawing.Size(324, 570)
        Me.panAcctsList.TabIndex = 46
        '
        'Guna2CircleButton1
        '
        Me.Guna2CircleButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton1.BorderColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.BorderThickness = 5
        Me.Guna2CircleButton1.CheckedState.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.CustomImages.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Guna2CircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.HoverState.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.Image = Global.System_OOP_Guna.My.Resources.Resources.add_acc
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(136, 506)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.ShadowDecoration.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(50, 50)
        Me.Guna2CircleButton1.TabIndex = 25
        Me.Guna2CircleButton1.UseTransparentBackground = True
        '
        'btnAcctsListRefresh
        '
        Me.btnAcctsListRefresh.Animated = True
        Me.btnAcctsListRefresh.AutoRoundedCorners = True
        Me.btnAcctsListRefresh.BorderRadius = 11
        Me.btnAcctsListRefresh.CheckedState.Parent = Me.btnAcctsListRefresh
        Me.btnAcctsListRefresh.CustomImages.Parent = Me.btnAcctsListRefresh
        Me.btnAcctsListRefresh.FillColor = System.Drawing.Color.Silver
        Me.btnAcctsListRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAcctsListRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnAcctsListRefresh.HoverState.Parent = Me.btnAcctsListRefresh
        Me.btnAcctsListRefresh.Image = Global.System_OOP_Guna.My.Resources.Resources.refresh
        Me.btnAcctsListRefresh.ImageSize = New System.Drawing.Size(18, 18)
        Me.btnAcctsListRefresh.Location = New System.Drawing.Point(218, 31)
        Me.btnAcctsListRefresh.Name = "btnAcctsListRefresh"
        Me.btnAcctsListRefresh.ShadowDecoration.Parent = Me.btnAcctsListRefresh
        Me.btnAcctsListRefresh.Size = New System.Drawing.Size(74, 24)
        Me.btnAcctsListRefresh.TabIndex = 24
        Me.btnAcctsListRefresh.Text = "Refresh"
        Me.btnAcctsListRefresh.TextOffset = New System.Drawing.Point(-1, 1)
        '
        'panListAcctsList
        '
        Me.panListAcctsList.BackColor = System.Drawing.Color.White
        Me.panListAcctsList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.panListAcctsList.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panListAcctsList.FormattingEnabled = True
        Me.panListAcctsList.HorizontalScrollbar = True
        Me.panListAcctsList.IntegralHeight = False
        Me.panListAcctsList.ItemHeight = 25
        Me.panListAcctsList.Location = New System.Drawing.Point(31, 72)
        Me.panListAcctsList.Name = "panListAcctsList"
        Me.panListAcctsList.Size = New System.Drawing.Size(261, 461)
        Me.panListAcctsList.Sorted = True
        Me.panListAcctsList.TabIndex = 23
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(26, 30)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(134, 25)
        Me.Label26.TabIndex = 7
        Me.Label26.Text = "Accounts list"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(484, 45)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Stall accounts management"
        '
        'btnHome
        '
        Me.btnHome.Animated = True
        Me.btnHome.AutoRoundedCorners = True
        Me.btnHome.BorderColor = System.Drawing.SystemColors.Control
        Me.btnHome.BorderRadius = 17
        Me.btnHome.BorderThickness = 2
        Me.btnHome.CheckedState.Parent = Me.btnHome
        Me.btnHome.CustomImages.Parent = Me.btnHome
        Me.btnHome.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnHome.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHome.HoverState.Parent = Me.btnHome
        Me.btnHome.Location = New System.Drawing.Point(73, 83)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.ShadowDecoration.Parent = Me.btnHome
        Me.btnHome.Size = New System.Drawing.Size(197, 37)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "ADMINISTRATOR ACCOUNT"
        Me.btnHome.TextOffset = New System.Drawing.Point(0, 2)
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.grpboxTip)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel1.Controls.Add(Me.panelAdminInfo)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Controls.Add(Me.btnLogout)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(248, 851)
        Me.Guna2Panel1.TabIndex = 44
        '
        'grpboxTip
        '
        Me.grpboxTip.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.grpboxTip.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxTip.ForeColor = System.Drawing.Color.White
        Me.grpboxTip.Location = New System.Drawing.Point(24, 504)
        Me.grpboxTip.Name = "grpboxTip"
        Me.grpboxTip.ShadowDecoration.Parent = Me.grpboxTip
        Me.grpboxTip.Size = New System.Drawing.Size(179, 251)
        Me.grpboxTip.TabIndex = 45
        Me.grpboxTip.Text = "ADMIN TIPS"
        Me.grpboxTip.TextOffset = New System.Drawing.Point(0, 2)
        Me.grpboxTip.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = Global.System_OOP_Guna.My.Resources.Resources.img_header_1
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(24, 78)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(179, 58)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 44
        Me.Guna2PictureBox2.TabStop = False
        '
        'panelAdminInfo
        '
        Me.panelAdminInfo.BackColor = System.Drawing.Color.White
        Me.panelAdminInfo.BorderRadius = 3
        Me.panelAdminInfo.Controls.Add(Me.btnAdminChangePassword)
        Me.panelAdminInfo.Controls.Add(Me.Guna2TextBox1)
        Me.panelAdminInfo.Controls.Add(Me.Guna2Chip10)
        Me.panelAdminInfo.Controls.Add(Me.Guna2Chip12)
        Me.panelAdminInfo.Controls.Add(Me.stallName)
        Me.panelAdminInfo.Controls.Add(Me.stallOwnerPhoto)
        Me.panelAdminInfo.Controls.Add(Me.Guna2PictureBox1)
        Me.panelAdminInfo.Location = New System.Drawing.Point(24, 168)
        Me.panelAdminInfo.Name = "panelAdminInfo"
        Me.panelAdminInfo.ShadowDecoration.Parent = Me.panelAdminInfo
        Me.panelAdminInfo.Size = New System.Drawing.Size(179, 313)
        Me.panelAdminInfo.TabIndex = 39
        '
        'btnAdminChangePassword
        '
        Me.btnAdminChangePassword.Animated = True
        Me.btnAdminChangePassword.BorderRadius = 5
        Me.btnAdminChangePassword.CheckedState.Parent = Me.btnAdminChangePassword
        Me.btnAdminChangePassword.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdminChangePassword.CustomImages.ImageOffset = New System.Drawing.Point(6, 0)
        Me.btnAdminChangePassword.CustomImages.ImageSize = New System.Drawing.Size(12, 12)
        Me.btnAdminChangePassword.CustomImages.Parent = Me.btnAdminChangePassword
        Me.btnAdminChangePassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnAdminChangePassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdminChangePassword.ForeColor = System.Drawing.Color.White
        Me.btnAdminChangePassword.HoverState.Parent = Me.btnAdminChangePassword
        Me.btnAdminChangePassword.Image = Global.System_OOP_Guna.My.Resources.Resources.password
        Me.btnAdminChangePassword.ImageSize = New System.Drawing.Size(12, 12)
        Me.btnAdminChangePassword.Location = New System.Drawing.Point(17, 268)
        Me.btnAdminChangePassword.Name = "btnAdminChangePassword"
        Me.btnAdminChangePassword.ShadowDecoration.Parent = Me.btnAdminChangePassword
        Me.btnAdminChangePassword.Size = New System.Drawing.Size(145, 25)
        Me.btnAdminChangePassword.TabIndex = 45
        Me.btnAdminChangePassword.Text = "Click to change"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderRadius = 5
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = "admin"
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(17, 204)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.ReadOnly = True
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.SelectionStart = 5
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(145, 25)
        Me.Guna2TextBox1.TabIndex = 44
        '
        'Guna2Chip10
        '
        Me.Guna2Chip10.BorderRadius = 6
        Me.Guna2Chip10.FillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Guna2Chip10.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Chip10.ForeColor = System.Drawing.Color.White
        Me.Guna2Chip10.Location = New System.Drawing.Point(17, 241)
        Me.Guna2Chip10.Name = "Guna2Chip10"
        Me.Guna2Chip10.ShadowDecoration.Parent = Me.Guna2Chip10
        Me.Guna2Chip10.Size = New System.Drawing.Size(70, 18)
        Me.Guna2Chip10.TabIndex = 43
        Me.Guna2Chip10.Text = "PASSWORD"
        Me.Guna2Chip10.TextOffset = New System.Drawing.Point(0, 1)
        Me.Guna2Chip10.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Guna2Chip12
        '
        Me.Guna2Chip12.BorderRadius = 6
        Me.Guna2Chip12.FillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Guna2Chip12.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Chip12.ForeColor = System.Drawing.Color.White
        Me.Guna2Chip12.Location = New System.Drawing.Point(17, 177)
        Me.Guna2Chip12.Name = "Guna2Chip12"
        Me.Guna2Chip12.ShadowDecoration.Parent = Me.Guna2Chip12
        Me.Guna2Chip12.Size = New System.Drawing.Size(70, 18)
        Me.Guna2Chip12.TabIndex = 38
        Me.Guna2Chip12.Text = "USERNAME"
        Me.Guna2Chip12.TextOffset = New System.Drawing.Point(0, 1)
        Me.Guna2Chip12.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'stallName
        '
        Me.stallName.AutoSize = True
        Me.stallName.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stallName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.stallName.Location = New System.Drawing.Point(12, 140)
        Me.stallName.Name = "stallName"
        Me.stallName.Size = New System.Drawing.Size(142, 25)
        Me.stallName.TabIndex = 8
        Me.stallName.Text = "Administrator"
        '
        'stallOwnerPhoto
        '
        Me.stallOwnerPhoto.BackColor = System.Drawing.Color.Transparent
        Me.stallOwnerPhoto.Image = Global.System_OOP_Guna.My.Resources.Resources._me
        Me.stallOwnerPhoto.Location = New System.Drawing.Point(17, 64)
        Me.stallOwnerPhoto.Name = "stallOwnerPhoto"
        Me.stallOwnerPhoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.stallOwnerPhoto.ShadowDecoration.Parent = Me.stallOwnerPhoto
        Me.stallOwnerPhoto.Size = New System.Drawing.Size(70, 70)
        Me.stallOwnerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.stallOwnerPhoto.TabIndex = 1
        Me.stallOwnerPhoto.TabStop = False
        Me.stallOwnerPhoto.UseTransparentBackground = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2PictureBox1.Image = Global.System_OOP_Guna.My.Resources.Resources.cover
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(179, 99)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.Animated = True
        Me.Guna2ControlBox2.BorderRadius = 10
        Me.Guna2ControlBox2.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(51, 27)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(20, 20)
        Me.Guna2ControlBox2.TabIndex = 38
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.BorderRadius = 10
        Me.Guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(24, 27)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(20, 20)
        Me.Guna2ControlBox1.TabIndex = 37
        '
        'btnLogout
        '
        Me.btnLogout.Animated = True
        Me.btnLogout.AutoRoundedCorners = True
        Me.btnLogout.BorderRadius = 21
        Me.btnLogout.CheckedState.Parent = Me.btnLogout
        Me.btnLogout.CustomImages.Parent = Me.btnLogout
        Me.btnLogout.FillColor = System.Drawing.Color.Salmon
        Me.btnLogout.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.HoverState.Parent = Me.btnLogout
        Me.btnLogout.Location = New System.Drawing.Point(21, 777)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.ShadowDecoration.Parent = Me.btnLogout
        Me.btnLogout.Size = New System.Drawing.Size(182, 45)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextOffset = New System.Drawing.Point(0, 2)
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 32
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 32
        Me.Guna2Elipse2.TargetControl = Me.panelAdmin
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 38
        Me.Guna2Elipse3.TargetControl = Me.panelAdminInfo
        '
        'Guna2Elipse4
        '
        Me.Guna2Elipse4.BorderRadius = 38
        Me.Guna2Elipse4.TargetControl = Me.grpboxTip
        '
        'Guna2Elipse5
        '
        Me.Guna2Elipse5.BorderRadius = 21
        Me.Guna2Elipse5.TargetControl = Me.panAcctsList
        '
        'Guna2Elipse6
        '
        Me.Guna2Elipse6.BorderRadius = 18
        Me.Guna2Elipse6.TargetControl = Me.panListAcctsList
        '
        'Guna2Elipse7
        '
        Me.Guna2Elipse7.BorderRadius = 18
        Me.Guna2Elipse7.TargetControl = Me.panAcctDetails
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'AdminAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 851)
        Me.Controls.Add(Me.panelAdmin)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminAccount"
        Me.panelAdmin.ResumeLayout(False)
        Me.panelAdmin.PerformLayout()
        Me.panAcctDetails.ResumeLayout(False)
        Me.panAcctDetails.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.acctImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panAcctsList.ResumeLayout(False)
        Me.panAcctsList.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAdminInfo.ResumeLayout(False)
        Me.panelAdminInfo.PerformLayout()
        CType(Me.stallOwnerPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelAdmin As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents panelAdminInfo As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2Chip10 As Guna.UI2.WinForms.Guna2Chip
    Friend WithEvents Guna2Chip12 As Guna.UI2.WinForms.Guna2Chip
    Friend WithEvents stallName As Label
    Friend WithEvents stallOwnerPhoto As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents grpboxTip As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Elipse4 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAdminChangePassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panAcctsList As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnAcctsListRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panListAcctsList As ListBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Guna2Elipse5 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse6 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents panAcctDetails As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Elipse7 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents acctImage As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btnAcctImageImport As Button
    Friend WithEvents txtStallName As TextBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnStallPasswordChange As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtStallUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Chip1 As Guna.UI2.WinForms.Guna2Chip
    Friend WithEvents Guna2Chip3 As Guna.UI2.WinForms.Guna2Chip
    Friend WithEvents Guna2Chip4 As Guna.UI2.WinForms.Guna2Chip
    Friend WithEvents Guna2Chip5 As Guna.UI2.WinForms.Guna2Chip
    Friend WithEvents txtStallOwnerName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpStallOwnerBirthdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnSaveEdits As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeleteAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents btnAddAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents txtStallPassword As Guna.UI2.WinForms.Guna2TextBox
End Class
