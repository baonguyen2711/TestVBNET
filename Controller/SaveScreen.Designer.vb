<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SaveScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaveScreen))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelUser = New System.Windows.Forms.Panel()
        Me.txtCrRole = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCrPassword = New System.Windows.Forms.TextBox()
        Me.txtCrUsername = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDepartment = New System.Windows.Forms.ComboBox()
        Me.txtDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HRM_TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRM_TableDataSet = New HRMTable.HRM_TableDataSet()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.HRM_TableTableAdapter = New HRMTable.HRM_TableDataSetTableAdapters.HRM_TableTableAdapter()
        Me.TableAdapterManager = New HRMTable.HRM_TableDataSetTableAdapters.TableAdapterManager()
        Me.today = New System.Windows.Forms.Label()
        Me.dateNow = New System.Windows.Forms.Label()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.panelUser.SuspendLayout()
        CType(Me.HRM_TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRM_TableDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Màn hình đăng kí/Thay đổi nhân sự"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.panelUser)
        Me.Panel1.Controls.Add(Me.txtDepartment)
        Me.Panel1.Controls.Add(Me.txtDateOfBirth)
        Me.Panel1.Controls.Add(Me.txtNote)
        Me.Panel1.Controls.Add(Me.txtPosition)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(37, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 392)
        Me.Panel1.TabIndex = 2
        '
        'panelUser
        '
        Me.panelUser.Controls.Add(Me.txtCrRole)
        Me.panelUser.Controls.Add(Me.Label10)
        Me.panelUser.Controls.Add(Me.txtCrPassword)
        Me.panelUser.Controls.Add(Me.txtCrUsername)
        Me.panelUser.Controls.Add(Me.Label9)
        Me.panelUser.Controls.Add(Me.Label2)
        Me.panelUser.Location = New System.Drawing.Point(3, 264)
        Me.panelUser.Name = "panelUser"
        Me.panelUser.Size = New System.Drawing.Size(740, 113)
        Me.panelUser.TabIndex = 4
        Me.panelUser.Visible = False
        '
        'txtCrRole
        '
        Me.txtCrRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCrRole.FormattingEnabled = True
        Me.txtCrRole.Items.AddRange(New Object() {"admin", "view"})
        Me.txtCrRole.Location = New System.Drawing.Point(117, 79)
        Me.txtCrRole.Name = "txtCrRole"
        Me.txtCrRole.Size = New System.Drawing.Size(623, 21)
        Me.txtCrRole.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(42, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Role"
        '
        'txtCrPassword
        '
        Me.txtCrPassword.Location = New System.Drawing.Point(117, 46)
        Me.txtCrPassword.Name = "txtCrPassword"
        Me.txtCrPassword.Size = New System.Drawing.Size(623, 20)
        Me.txtCrPassword.TabIndex = 8
        '
        'txtCrUsername
        '
        Me.txtCrUsername.Location = New System.Drawing.Point(117, 13)
        Me.txtCrUsername.Name = "txtCrUsername"
        Me.txtCrUsername.Size = New System.Drawing.Size(623, 20)
        Me.txtCrUsername.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "User name"
        '
        'txtDepartment
        '
        Me.txtDepartment.AllowDrop = True
        Me.txtDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtDepartment.FormattingEnabled = True
        Me.txtDepartment.Items.AddRange(New Object() {"DEV", "HR", "IT", "SALE"})
        Me.txtDepartment.Location = New System.Drawing.Point(120, 139)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(620, 21)
        Me.txtDepartment.Sorted = True
        Me.txtDepartment.TabIndex = 4
        '
        'txtDateOfBirth
        '
        Me.txtDateOfBirth.Location = New System.Drawing.Point(120, 79)
        Me.txtDateOfBirth.Name = "txtDateOfBirth"
        Me.txtDateOfBirth.Size = New System.Drawing.Size(620, 20)
        Me.txtDateOfBirth.TabIndex = 2
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(120, 207)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(620, 51)
        Me.txtNote.TabIndex = 6
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(120, 171)
        Me.txtPosition.Multiline = True
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(620, 20)
        Me.txtPosition.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(120, 112)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(620, 20)
        Me.txtAddress.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(120, 44)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 3, 3, 50)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(620, 20)
        Me.txtName.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Ghi chú"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Chức vụ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Bộ phận"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Địa chỉ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Năm sinh"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Họ tên"
        '
        'HRM_TableBindingSource
        '
        Me.HRM_TableBindingSource.DataMember = "HRM_Table"
        Me.HRM_TableBindingSource.DataSource = Me.HRM_TableDataSet
        '
        'HRM_TableDataSet
        '
        Me.HRM_TableDataSet.DataSetName = "HRM_TableDataSet"
        Me.HRM_TableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(40, 502)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 40)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Lưu"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(217, 502)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 40)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Thoát"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'HRM_TableTableAdapter
        '
        Me.HRM_TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HRM_TableTableAdapter = Me.HRM_TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = HRMTable.HRM_TableDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'today
        '
        Me.today.AutoSize = True
        Me.today.Location = New System.Drawing.Point(34, 52)
        Me.today.Name = "today"
        Me.today.Size = New System.Drawing.Size(37, 13)
        Me.today.TabIndex = 5
        Me.today.Text = "Today"
        '
        'dateNow
        '
        Me.dateNow.AutoSize = True
        Me.dateNow.Location = New System.Drawing.Point(69, 52)
        Me.dateNow.Name = "dateNow"
        Me.dateNow.Size = New System.Drawing.Size(0, 13)
        Me.dateNow.TabIndex = 5
        '
        'btnCreateUser
        '
        Me.btnCreateUser.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCreateUser.Location = New System.Drawing.Point(397, 502)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(100, 40)
        Me.btnCreateUser.TabIndex = 10
        Me.btnCreateUser.Text = "Create"
        Me.btnCreateUser.UseVisualStyleBackColor = False
        '
        'SaveScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 563)
        Me.Controls.Add(Me.btnCreateUser)
        Me.Controls.Add(Me.dateNow)
        Me.Controls.Add(Me.today)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "SaveScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SaveScreen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelUser.ResumeLayout(False)
        Me.panelUser.PerformLayout()
        CType(Me.HRM_TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRM_TableDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNote As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtDepartment As ComboBox
    Friend WithEvents txtDateOfBirth As DateTimePicker
    Friend WithEvents HRM_TableDataSet As HRM_TableDataSet
    Friend WithEvents HRM_TableBindingSource As BindingSource
    Friend WithEvents HRM_TableTableAdapter As HRM_TableDataSetTableAdapters.HRM_TableTableAdapter
    Friend WithEvents TableAdapterManager As HRM_TableDataSetTableAdapters.TableAdapterManager
    Friend WithEvents today As Label
    Friend WithEvents dateNow As Label
    Friend WithEvents btnCreateUser As Button
    Friend WithEvents panelUser As Panel
    Friend WithEvents txtCrPassword As TextBox
    Friend WithEvents txtCrUsername As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCrRole As ComboBox
    Friend WithEvents Label10 As Label
End Class
