Imports System.Data.SqlClient
Imports System.Linq.Expressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports System.Windows.Forms.ToolTip
Imports Models

Public Class SaveScreen
    Public Property Id As Integer ' Thêm thuộc tính Id để lưu trữ giá trị id.
    Dim userId As Integer ' Thêm thuộc tính Id để lưu trữ giá trị id.
    Public Sub New(id As Integer)
        InitializeComponent()
        Me.Id = id
        Me.userId = userId ' Gán giá trị id vào thuộc tính Id.
        txtDepartment.SelectedIndex = 1
        txtCrRole.SelectedIndex = 1
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim queryString As String
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn làm việc này?", "Xác nhận", MessageBoxButtons.YesNo)
        Dim tooltip As New ToolTip()
        tooltip.ToolTipTitle = "Information"
        tooltip.ToolTipIcon = ToolTipIcon.Warning
        tooltip.IsBalloon = True
        If result = DialogResult.Yes Then
            Using connection As SqlConnection = DBConnect.GetInstance
                Dim transaction As SqlTransaction = connection.BeginTransaction()
                Try
                    If Id > 0 Then
                        queryString = SQLString.UPDATE_TO_FROM_HRM_TABLE
                    Else
                        queryString = SQLString.INSERT_TO_FROM_HRM_TABLE
                    End If

                    Using command As SqlCommand = New SqlCommand(queryString, connection, transaction)
                        command.Parameters.AddWithValue("@Id", Id)
                        command.Parameters.AddWithValue("@Name", txtName.Text)
                        command.Parameters.AddWithValue("@BirthYear", txtDateOfBirth.Value.ToString("dd/MM/yyyy"))
                        command.Parameters.AddWithValue("@Address", txtAddress.Text)
                        command.Parameters.AddWithValue("@Department", txtDepartment.Text)
                        command.Parameters.AddWithValue("@Position", txtPosition.Text)
                        command.Parameters.AddWithValue("@Note", txtNote.Text)
                        command.ExecuteNonQuery()
                        If Id = 0 Then
                            ' Lấy giá trị UserId từ bảng From_HRM_Table
                            userId = CInt(command.Parameters("@Id").Value)
                        End If
                    End Using

                    If panelUser.Visible = True Then
                        If Id = 0 Then
                            queryString = SQLString.INSERT_TO_FROM_HRM_LOGIN
                        Else
                            queryString = SQLString.UPDATE_TO_FROM_HRM_LOGIN
                        End If

                        Using command As SqlCommand = New SqlCommand(queryString, connection, transaction)
                            command.Parameters.AddWithValue("@UserName", txtCrUsername.Text)
                            command.Parameters.AddWithValue("@Password", txtCrPassword.Text)
                            command.Parameters.AddWithValue("@Role", txtCrRole.Text)
                            command.ExecuteNonQuery()
                        End Using
                    End If
                    Dim isValid = True
                    isValid = isValidate(txtName, 50) AndAlso isValid
                    isValid = isValidate(txtAddress, 50) AndAlso isValid
                    isValid = isValidate(txtPosition, 50) AndAlso isValid
                    If Not isValid Then
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin.")
                        Return
                    End If
                    transaction.Commit()
                    MessageBox.Show("Dữ liệu đã được lưu vào database!")
                    Me.Hide()
                    Dim frm1 As New Home()
                    frm1.Show()

                Catch ex As Exception
                    transaction.Rollback() ' Hủy bỏ các thay đổi đã được thực hiện.
                    MessageBox.Show("Lỗi xảy ra: " & ex.Message)
                End Try
            End Using

        ElseIf result = DialogResult.No Then
            MessageBox.Show("Dữ liệu không được lưu vào database.")
            Me.Hide()
            Dim frm1 As New Home()
            frm1.Show()
        End If
    End Sub

    Private Sub Save_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ' Gọi hàm xử lý lưu dữ liệu tương tự như trong sự kiện Click của nút btnSave.
            btnSave_Click(sender, e)
        End If
    End Sub
    Private Function isValidate(ByVal txtBox As TextBox, ByVal maxLength As Integer) As Boolean
        Dim isValid = True
        Dim tt As New ToolTip() With {
        .ToolTipTitle = "Information",
        .ToolTipIcon = ToolTipIcon.Warning,
        .IsBalloon = True
    }

        If txtBox.Text.Length > maxLength Then
            tt.SetToolTip(txtBox, $"Maximum character limit reached ({maxLength} characters).")
            tt.Show($"Maximum character limit reached ({maxLength} characters).", txtBox, txtBox.Width, 0, 2000)
            txtBox.Text = txtBox.Text.Substring(0, maxLength)
            txtBox.SelectionStart = maxLength

            isValid = False
        End If

        If txtBox.Equals(txtName) AndAlso String.IsNullOrWhiteSpace(txtBox.Text) Then
            tt.SetToolTip(txtName, "Vui lòng nhập tên nhân viên.")
            tt.Show("Vui lòng nhập tên nhân viên.", txtName, txtName.Width, 0, 2000)

            isValid = False
        End If

        If txtBox.Equals(txtPosition) AndAlso String.IsNullOrWhiteSpace(txtBox.Text) Then
            tt.SetToolTip(txtPosition, "Vui lòng nhập chức vụ của nhân viên.")
            tt.Show("Vui lòng nhập chức vụ của nhân viên.", txtPosition, txtPosition.Width, 0, 2000)

            isValid = False
        End If
        If txtBox.Equals(txtAddress) AndAlso String.IsNullOrWhiteSpace(txtBox.Text) Then
            tt.SetToolTip(txtAddress, "Vui lòng nhập địa chỉ của nhân viên.")
            tt.Show("Vui lòng nhập địa chỉ của nhân viên.", txtAddress, txtAddress.Width, 0, 2000)

            isValid = False
        End If

        Return isValid
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Dim homeForm As New Home()
        homeForm.Show()
    End Sub
    Private Sub HRM_TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.HRM_TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HRM_TableDataSet)

    End Sub

    Private Sub SaveScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDateOfBirth.Format = DateTimePickerFormat.Custom
        txtDateOfBirth.CustomFormat = "dd/MM/yyyy"
        Me.HRM_TableTableAdapter.Fill(Me.HRM_TableDataSet.HRM_Table)
        Me.btnSave.Focus()
    End Sub

    Private Sub today_Click(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentDate As DateTime = DateTime.Now
        dateNow.Text = currentDate.ToString("dd/MM/yyyy")
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.HRM_TableTableAdapter.FillBy(Me.HRM_TableDataSet.HRM_Table)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        If panelUser.Visible = False Then
            panelUser.Visible = True
        Else
            panelUser.Visible = False
        End If
    End Sub
End Class