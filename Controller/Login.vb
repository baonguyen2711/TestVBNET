
Imports System.Data.SqlClient
Public Class Login
    Dim home As New Home
    Private Sub submitLogin_Click(sender As Object, e As EventArgs) Handles submitLogin.Click
        Dim userName As String
        Dim password As String
        userName = txtUserName.Text
        password = txtPassword.Text
        Dim connection As SqlConnection = DBConnect.GetInstance
        Dim cmd As New SqlCommand("SELECT * FROM HRM_Login WHERE username = @username AND password = @password", connection)
        cmd.Parameters.AddWithValue("@username", userName)
        cmd.Parameters.AddWithValue("@password", password)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim userTable As New DataTable()
        adapter.Fill(userTable)
        If userTable.Rows.Count > 0 Then
            MessageBox.Show("Login Success", "infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()

            ' Kiểm tra vai trò của người dùng và hiển thị/ẩn các nút chức năng tương ứng
            Dim role As String = userTable.Rows(0)("role").ToString()
            home.UserName = userName
            home.txtUserName.Text = userName
            home.btnCreate.Visible = False
            home.btnEdit.Visible = False
            home.btnDelete.Visible = False
            home.btnImport.Visible = False
            home.btnExport.Visible = False
            If role = "admin" Then
                home.btnCreate.Visible = True
                home.btnEdit.Visible = True
                home.btnDelete.Visible = True
                home.btnImport.Visible = True
                home.btnExport.Visible = True
                home.btnSearch.Visible = True
            End If

            home.Show()
        Else
            MessageBox.Show("User name or Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class