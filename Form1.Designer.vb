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
        Dim PC_NameLabel As System.Windows.Forms.Label
        Dim OS_NameLabel As System.Windows.Forms.Label
        Dim OS_VersionLabel As System.Windows.Forms.Label
        Dim RAMLabel As System.Windows.Forms.Label
        Dim CPU_ModelLabel As System.Windows.Forms.Label
        Dim CPU_CoresLabel As System.Windows.Forms.Label
        Dim CPU_ClockLabel As System.Windows.Forms.Label
        Dim GFX_ModelLabel As System.Windows.Forms.Label
        Dim GFX_RamLabel As System.Windows.Forms.Label
        Dim MB_ManufacturerLabel As System.Windows.Forms.Label
        Dim MB_ModelLabel As System.Windows.Forms.Label
        Dim MB_ChipsetLabel As System.Windows.Forms.Label
        Dim BIOS_ModelLabel As System.Windows.Forms.Label
        Dim BIOS_VersionLabel As System.Windows.Forms.Label
        Dim BIOS_DateLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim USERLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PC_NameTextBox = New System.Windows.Forms.TextBox()
        Me.OS_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.OS_VersionTextBox = New System.Windows.Forms.TextBox()
        Me.RAMTextBox = New System.Windows.Forms.TextBox()
        Me.CPU_ModelTextBox = New System.Windows.Forms.TextBox()
        Me.CPU_CoresComboBox = New System.Windows.Forms.ComboBox()
        Me.CPU_ClockTextBox = New System.Windows.Forms.TextBox()
        Me.GFX_ModelTextBox = New System.Windows.Forms.TextBox()
        Me.GFX_RamTextBox = New System.Windows.Forms.TextBox()
        Me.MB_ManufacturerTextBox = New System.Windows.Forms.TextBox()
        Me.MB_ModelTextBox = New System.Windows.Forms.TextBox()
        Me.MB_ChipsetTextBox = New System.Windows.Forms.TextBox()
        Me.BIOS_ModelTextBox = New System.Windows.Forms.TextBox()
        Me.BIOS_VersionTextBox = New System.Windows.Forms.TextBox()
        Me.BIOS_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.USERTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.PCTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HardwareDatabaseDataSet = New PE_Hardware_Database.HardwareDatabaseDataSet()
        Me.PCTableTableAdapter = New PE_Hardware_Database.HardwareDatabaseDataSetTableAdapters.PCTableTableAdapter()
        Me.TableAdapterManager = New PE_Hardware_Database.HardwareDatabaseDataSetTableAdapters.TableAdapterManager()
        PC_NameLabel = New System.Windows.Forms.Label()
        OS_NameLabel = New System.Windows.Forms.Label()
        OS_VersionLabel = New System.Windows.Forms.Label()
        RAMLabel = New System.Windows.Forms.Label()
        CPU_ModelLabel = New System.Windows.Forms.Label()
        CPU_CoresLabel = New System.Windows.Forms.Label()
        CPU_ClockLabel = New System.Windows.Forms.Label()
        GFX_ModelLabel = New System.Windows.Forms.Label()
        GFX_RamLabel = New System.Windows.Forms.Label()
        MB_ManufacturerLabel = New System.Windows.Forms.Label()
        MB_ModelLabel = New System.Windows.Forms.Label()
        MB_ChipsetLabel = New System.Windows.Forms.Label()
        BIOS_ModelLabel = New System.Windows.Forms.Label()
        BIOS_VersionLabel = New System.Windows.Forms.Label()
        BIOS_DateLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        USERLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.PCTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HardwareDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PC_NameLabel
        '
        PC_NameLabel.AutoSize = True
        PC_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PC_NameLabel.ForeColor = System.Drawing.Color.DodgerBlue
        PC_NameLabel.Location = New System.Drawing.Point(6, 22)
        PC_NameLabel.Name = "PC_NameLabel"
        PC_NameLabel.Size = New System.Drawing.Size(59, 13)
        PC_NameLabel.TabIndex = 3
        PC_NameLabel.Text = "PC Name"
        '
        'OS_NameLabel
        '
        OS_NameLabel.AutoSize = True
        OS_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OS_NameLabel.ForeColor = System.Drawing.Color.DodgerBlue
        OS_NameLabel.Location = New System.Drawing.Point(6, 48)
        OS_NameLabel.Name = "OS_NameLabel"
        OS_NameLabel.Size = New System.Drawing.Size(60, 13)
        OS_NameLabel.TabIndex = 5
        OS_NameLabel.Text = "OS Name"
        '
        'OS_VersionLabel
        '
        OS_VersionLabel.AutoSize = True
        OS_VersionLabel.ForeColor = System.Drawing.Color.DodgerBlue
        OS_VersionLabel.Location = New System.Drawing.Point(6, 75)
        OS_VersionLabel.Name = "OS_VersionLabel"
        OS_VersionLabel.Size = New System.Drawing.Size(60, 13)
        OS_VersionLabel.TabIndex = 7
        OS_VersionLabel.Text = "OS Version"
        '
        'RAMLabel
        '
        RAMLabel.AutoSize = True
        RAMLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RAMLabel.ForeColor = System.Drawing.Color.DodgerBlue
        RAMLabel.Location = New System.Drawing.Point(6, 100)
        RAMLabel.Name = "RAMLabel"
        RAMLabel.Size = New System.Drawing.Size(34, 13)
        RAMLabel.TabIndex = 9
        RAMLabel.Text = "RAM"
        '
        'CPU_ModelLabel
        '
        CPU_ModelLabel.AutoSize = True
        CPU_ModelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CPU_ModelLabel.ForeColor = System.Drawing.Color.DodgerBlue
        CPU_ModelLabel.Location = New System.Drawing.Point(6, 22)
        CPU_ModelLabel.Name = "CPU_ModelLabel"
        CPU_ModelLabel.Size = New System.Drawing.Size(41, 13)
        CPU_ModelLabel.TabIndex = 11
        CPU_ModelLabel.Text = "Model"
        '
        'CPU_CoresLabel
        '
        CPU_CoresLabel.AutoSize = True
        CPU_CoresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CPU_CoresLabel.ForeColor = System.Drawing.Color.DodgerBlue
        CPU_CoresLabel.Location = New System.Drawing.Point(6, 48)
        CPU_CoresLabel.Name = "CPU_CoresLabel"
        CPU_CoresLabel.Size = New System.Drawing.Size(39, 13)
        CPU_CoresLabel.TabIndex = 13
        CPU_CoresLabel.Text = "Cores"
        '
        'CPU_ClockLabel
        '
        CPU_ClockLabel.AutoSize = True
        CPU_ClockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CPU_ClockLabel.ForeColor = System.Drawing.Color.DodgerBlue
        CPU_ClockLabel.Location = New System.Drawing.Point(6, 75)
        CPU_ClockLabel.Name = "CPU_ClockLabel"
        CPU_ClockLabel.Size = New System.Drawing.Size(39, 13)
        CPU_ClockLabel.TabIndex = 15
        CPU_ClockLabel.Text = "Clock"
        '
        'GFX_ModelLabel
        '
        GFX_ModelLabel.AutoSize = True
        GFX_ModelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GFX_ModelLabel.ForeColor = System.Drawing.Color.DodgerBlue
        GFX_ModelLabel.Location = New System.Drawing.Point(6, 22)
        GFX_ModelLabel.Name = "GFX_ModelLabel"
        GFX_ModelLabel.Size = New System.Drawing.Size(41, 13)
        GFX_ModelLabel.TabIndex = 17
        GFX_ModelLabel.Text = "Model"
        '
        'GFX_RamLabel
        '
        GFX_RamLabel.AutoSize = True
        GFX_RamLabel.ForeColor = System.Drawing.Color.DodgerBlue
        GFX_RamLabel.Location = New System.Drawing.Point(6, 48)
        GFX_RamLabel.Name = "GFX_RamLabel"
        GFX_RamLabel.Size = New System.Drawing.Size(29, 13)
        GFX_RamLabel.TabIndex = 19
        GFX_RamLabel.Text = "Ram"
        '
        'MB_ManufacturerLabel
        '
        MB_ManufacturerLabel.AutoSize = True
        MB_ManufacturerLabel.ForeColor = System.Drawing.Color.DodgerBlue
        MB_ManufacturerLabel.Location = New System.Drawing.Point(6, 22)
        MB_ManufacturerLabel.Name = "MB_ManufacturerLabel"
        MB_ManufacturerLabel.Size = New System.Drawing.Size(70, 13)
        MB_ManufacturerLabel.TabIndex = 21
        MB_ManufacturerLabel.Text = "Manufacturer"
        '
        'MB_ModelLabel
        '
        MB_ModelLabel.AutoSize = True
        MB_ModelLabel.ForeColor = System.Drawing.Color.DodgerBlue
        MB_ModelLabel.Location = New System.Drawing.Point(6, 48)
        MB_ModelLabel.Name = "MB_ModelLabel"
        MB_ModelLabel.Size = New System.Drawing.Size(36, 13)
        MB_ModelLabel.TabIndex = 23
        MB_ModelLabel.Text = "Model"
        '
        'MB_ChipsetLabel
        '
        MB_ChipsetLabel.AutoSize = True
        MB_ChipsetLabel.ForeColor = System.Drawing.Color.DodgerBlue
        MB_ChipsetLabel.Location = New System.Drawing.Point(6, 74)
        MB_ChipsetLabel.Name = "MB_ChipsetLabel"
        MB_ChipsetLabel.Size = New System.Drawing.Size(42, 13)
        MB_ChipsetLabel.TabIndex = 25
        MB_ChipsetLabel.Text = "Chipset"
        '
        'BIOS_ModelLabel
        '
        BIOS_ModelLabel.AutoSize = True
        BIOS_ModelLabel.ForeColor = System.Drawing.Color.DodgerBlue
        BIOS_ModelLabel.Location = New System.Drawing.Point(6, 22)
        BIOS_ModelLabel.Name = "BIOS_ModelLabel"
        BIOS_ModelLabel.Size = New System.Drawing.Size(36, 13)
        BIOS_ModelLabel.TabIndex = 27
        BIOS_ModelLabel.Text = "Model"
        '
        'BIOS_VersionLabel
        '
        BIOS_VersionLabel.AutoSize = True
        BIOS_VersionLabel.ForeColor = System.Drawing.Color.DodgerBlue
        BIOS_VersionLabel.Location = New System.Drawing.Point(6, 48)
        BIOS_VersionLabel.Name = "BIOS_VersionLabel"
        BIOS_VersionLabel.Size = New System.Drawing.Size(42, 13)
        BIOS_VersionLabel.TabIndex = 29
        BIOS_VersionLabel.Text = "Version"
        '
        'BIOS_DateLabel
        '
        BIOS_DateLabel.AutoSize = True
        BIOS_DateLabel.ForeColor = System.Drawing.Color.DodgerBlue
        BIOS_DateLabel.Location = New System.Drawing.Point(6, 75)
        BIOS_DateLabel.Name = "BIOS_DateLabel"
        BIOS_DateLabel.Size = New System.Drawing.Size(30, 13)
        BIOS_DateLabel.TabIndex = 31
        BIOS_DateLabel.Text = "Date"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.ForeColor = System.Drawing.Color.DodgerBlue
        DateLabel.Location = New System.Drawing.Point(21, 634)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(69, 13)
        DateLabel.TabIndex = 33
        DateLabel.Text = "Last updated"
        '
        'USERLabel
        '
        USERLabel.AutoSize = True
        USERLabel.ForeColor = System.Drawing.Color.DodgerBlue
        USERLabel.Location = New System.Drawing.Point(21, 56)
        USERLabel.Name = "USERLabel"
        USERLabel.Size = New System.Drawing.Size(66, 13)
        USERLabel.TabIndex = 99
        USERLabel.Text = "Current User"
        '
        'PC_NameTextBox
        '
        Me.PC_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PCTableBindingSource, "PC Name", True))
        Me.PC_NameTextBox.Location = New System.Drawing.Point(104, 19)
        Me.PC_NameTextBox.Name = "PC_NameTextBox"
        Me.PC_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PC_NameTextBox.TabIndex = 2
        '
        'OS_NameComboBox
        '
        Me.OS_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PCTableBindingSource, "OS Name", True))
        Me.OS_NameComboBox.FormattingEnabled = True
        Me.OS_NameComboBox.Location = New System.Drawing.Point(104, 45)
        Me.OS_NameComboBox.Name = "OS_NameComboBox"
        Me.OS_NameComboBox.Size = New System.Drawing.Size(200, 21)
        Me.OS_NameComboBox.TabIndex = 3
        '
        'OS_VersionTextBox
        '
        Me.OS_VersionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PCTableBindingSource, "OS Version", True))
        Me.OS_VersionTextBox.Location = New System.Drawing.Point(104, 72)
        Me.OS_VersionTextBox.Name = "OS_VersionTextBox"
        Me.OS_VersionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OS_VersionTextBox.TabIndex = 4
        '
        'RAMTextBox
        '
        Me.RAMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PCTableBindingSource, "RAM", True))
        Me.RAMTextBox.Location = New System.Drawing.Point(104, 97)
        Me.RAMTextBox.Name = "RAMTextBox"
        Me.RAMTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RAMTextBox.TabIndex = 13
        '
        'CPU_ModelTextBox
        '
        Me.CPU_ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PCTableBindingSource, "CPU Model", True))
        Me.CPU_ModelTextBox.Location = New System.Drawing.Point(104, 19)
        Me.CPU_ModelTextBox.Name = "CPU_ModelTextBox"
        Me.CPU_ModelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CPU_ModelTextBox.TabIndex = 7
        '
        'CPU_CoresComboBox
        '
        Me.CPU_CoresComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PCTableBindingSource, "CPU Cores", True))
        Me.CPU_CoresComboBox.FormattingEnabled = True
        Me.CPU_CoresComboBox.ItemHeight = 13
        Me.CPU_CoresComboBox.Location = New System.Drawing.Point(104, 45)
        Me.CPU_CoresComboBox.Name = "CPU_CoresComboBox"
        Me.CPU_CoresComboBox.Size = New System.Drawing.Size(200, 21)
        Me.CPU_CoresComboBox.TabIndex = 8
        '
        'CPU_ClockTextBox
        '
        Me.CPU_ClockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PCTableBindingSource, "CPU Clock", True))
        Me.CPU_ClockTextBox.Location = New System.Drawing.Point(104, 72)
        Me.CPU_ClockTextBox.Name = "CPU_ClockTextBox"
        Me.CPU_ClockTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CPU_ClockTextBox.TabIndex = 9
        '
        'GFX_ModelTextBox
        '
        Me.GFX_ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PCTableBindingSource, "GFX Model", True))
        Me.GFX_ModelTextBox.Location = New System.Drawing.Point(104, 19)
        Me.GFX_ModelTextBox.Name = "GFX_ModelTextBox"
        Me.GFX_ModelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GFX_ModelTextBox.TabIndex = 5
        '
        'GFX_RamTextBox
        '
        Me.GFX_RamTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PCTableBindingSource, "GFX Ram", True))
        Me.GFX_RamTextBox.Location = New System.Drawing.Point(104, 45)
        Me.GFX_RamTextBox.Name = "GFX_RamTextBox"
        Me.GFX_RamTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GFX_RamTextBox.TabIndex = 6
        '
        'MB_ManufacturerTextBox
        '
        Me.MB_ManufacturerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PCTableBindingSource, "MB Manufacturer", True))
        Me.MB_ManufacturerTextBox.Location = New System.Drawing.Point(104, 19)
        Me.MB_ManufacturerTextBox.Name = "MB_ManufacturerTextBox"
        Me.MB_ManufacturerTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MB_ManufacturerTextBox.TabIndex = 10
        '
        'MB_ModelTextBox
        '
        Me.MB_ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PCTableBindingSource, "MB Model", True))
        Me.MB_ModelTextBox.Location = New System.Drawing.Point(104, 45)
        Me.MB_ModelTextBox.Name = "MB_ModelTextBox"
        Me.MB_ModelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MB_ModelTextBox.TabIndex = 11
        '
        'MB_ChipsetTextBox
        '
        Me.MB_ChipsetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PCTableBindingSource, "MB Chipset", True))
        Me.MB_ChipsetTextBox.Location = New System.Drawing.Point(104, 71)
        Me.MB_ChipsetTextBox.Name = "MB_ChipsetTextBox"
        Me.MB_ChipsetTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MB_ChipsetTextBox.TabIndex = 12
        '
        'BIOS_ModelTextBox
        '
        Me.BIOS_ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PCTableBindingSource, "BIOS Model", True))
        Me.BIOS_ModelTextBox.Location = New System.Drawing.Point(104, 19)
        Me.BIOS_ModelTextBox.Name = "BIOS_ModelTextBox"
        Me.BIOS_ModelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BIOS_ModelTextBox.TabIndex = 14
        '
        'BIOS_VersionTextBox
        '
        Me.BIOS_VersionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PCTableBindingSource, "BIOS Version", True))
        Me.BIOS_VersionTextBox.Location = New System.Drawing.Point(104, 45)
        Me.BIOS_VersionTextBox.Name = "BIOS_VersionTextBox"
        Me.BIOS_VersionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BIOS_VersionTextBox.TabIndex = 15
        '
        'BIOS_DateDateTimePicker
        '
        Me.BIOS_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PCTableBindingSource, "BIOS Date", True))
        Me.BIOS_DateDateTimePicker.Location = New System.Drawing.Point(104, 71)
        Me.BIOS_DateDateTimePicker.Name = "BIOS_DateDateTimePicker"
        Me.BIOS_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.BIOS_DateDateTimePicker.TabIndex = 16
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PCTableBindingSource, "Date", True))
        Me.DateDateTimePicker.Enabled = False
        Me.DateDateTimePicker.Location = New System.Drawing.Point(119, 630)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 34
        '
        'USERTextBox
        '
        Me.USERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PCTableBindingSource, "USER", True))
        Me.USERTextBox.Location = New System.Drawing.Point(119, 53)
        Me.USERTextBox.Name = "USERTextBox"
        Me.USERTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USERTextBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(CPU_ModelLabel)
        Me.GroupBox1.Controls.Add(Me.CPU_ClockTextBox)
        Me.GroupBox1.Controls.Add(CPU_ClockLabel)
        Me.GroupBox1.Controls.Add(Me.CPU_CoresComboBox)
        Me.GroupBox1.Controls.Add(CPU_CoresLabel)
        Me.GroupBox1.Controls.Add(Me.CPU_ModelTextBox)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 274)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 104)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CPU"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(GFX_ModelLabel)
        Me.GroupBox2.Controls.Add(Me.GFX_RamTextBox)
        Me.GroupBox2.Controls.Add(GFX_RamLabel)
        Me.GroupBox2.Controls.Add(Me.GFX_ModelTextBox)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 189)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 79)
        Me.GroupBox2.TabIndex = 99
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Graphic Processing Unit"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(BIOS_ModelLabel)
        Me.GroupBox3.Controls.Add(Me.BIOS_DateDateTimePicker)
        Me.GroupBox3.Controls.Add(BIOS_DateLabel)
        Me.GroupBox3.Controls.Add(Me.BIOS_VersionTextBox)
        Me.GroupBox3.Controls.Add(BIOS_VersionLabel)
        Me.GroupBox3.Controls.Add(Me.BIOS_ModelTextBox)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(15, 520)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(315, 104)
        Me.GroupBox3.TabIndex = 99
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "BIOS"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(MB_ManufacturerLabel)
        Me.GroupBox4.Controls.Add(Me.MB_ChipsetTextBox)
        Me.GroupBox4.Controls.Add(MB_ChipsetLabel)
        Me.GroupBox4.Controls.Add(Me.MB_ModelTextBox)
        Me.GroupBox4.Controls.Add(MB_ModelLabel)
        Me.GroupBox4.Controls.Add(Me.MB_ManufacturerTextBox)
        Me.GroupBox4.Controls.Add(Me.RAMTextBox)
        Me.GroupBox4.Controls.Add(RAMLabel)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(15, 384)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(315, 130)
        Me.GroupBox4.TabIndex = 99
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Mainboard"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PC_NameTextBox)
        Me.GroupBox5.Controls.Add(Me.OS_VersionTextBox)
        Me.GroupBox5.Controls.Add(OS_VersionLabel)
        Me.GroupBox5.Controls.Add(Me.OS_NameComboBox)
        Me.GroupBox5.Controls.Add(OS_NameLabel)
        Me.GroupBox5.Controls.Add(PC_NameLabel)
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(15, 79)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(315, 104)
        Me.GroupBox5.TabIndex = 99
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "General Info"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.BindingSource = Me.PCTableBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator1, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator3, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(342, 25)
        Me.BindingNavigator1.TabIndex = 100
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'PCTableBindingSource
        '
        Me.PCTableBindingSource.DataMember = "PCTable"
        Me.PCTableBindingSource.DataSource = Me.HardwareDatabaseDataSet
        '
        'HardwareDatabaseDataSet
        '
        Me.HardwareDatabaseDataSet.DataSetName = "HardwareDatabaseDataSet"
        Me.HardwareDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PCTableTableAdapter
        '
        Me.PCTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PCTableTableAdapter = Me.PCTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = PE_Hardware_Database.HardwareDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(342, 665)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(USERLabel)
        Me.Controls.Add(Me.USERTextBox)
        Me.Name = "Form1"
        Me.Text = "Process Engineering Workstation Indexer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.PCTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HardwareDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HardwareDatabaseDataSet As HardwareDatabaseDataSet
    Friend WithEvents PCTableBindingSource As BindingSource
    Friend WithEvents PCTableTableAdapter As HardwareDatabaseDataSetTableAdapters.PCTableTableAdapter
    Friend WithEvents TableAdapterManager As HardwareDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PC_NameTextBox As TextBox
    Friend WithEvents OS_NameComboBox As ComboBox
    Friend WithEvents OS_VersionTextBox As TextBox
    Friend WithEvents RAMTextBox As TextBox
    Friend WithEvents CPU_ModelTextBox As TextBox
    Friend WithEvents CPU_CoresComboBox As ComboBox
    Friend WithEvents CPU_ClockTextBox As TextBox
    Friend WithEvents GFX_ModelTextBox As TextBox
    Friend WithEvents GFX_RamTextBox As TextBox
    Friend WithEvents MB_ManufacturerTextBox As TextBox
    Friend WithEvents MB_ModelTextBox As TextBox
    Friend WithEvents MB_ChipsetTextBox As TextBox
    Friend WithEvents BIOS_ModelTextBox As TextBox
    Friend WithEvents BIOS_VersionTextBox As TextBox
    Friend WithEvents BIOS_DateDateTimePicker As DateTimePicker
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents USERTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
End Class
