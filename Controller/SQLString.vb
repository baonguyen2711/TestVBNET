Public Class SQLString
    Public Const SELECT_ALL_FROM_HRM_TABLE As String = "SELECT * FROM HRM_Table"
    Public Const INSERT_TO_FROM_HRM_TABLE As String = "INSERT INTO HRM_Table (name, dateOfBirth, address, department, position, note) VALUES (@Name, @BirthYear, @Address, @Department, @Position, @Note);"
    Public Const UPDATE_TO_FROM_HRM_TABLE As String = "UPDATE HRM_Table SET name = @Name, dateOfBirth = @BirthYear, address = @Address, department = @Department, position = @Position, note = @Note WHERE id = @Id"
    Public Const DELETE_TO_FROM_HRM_TABLE As String = "DELETE FROM HRM_Table WHERE id = @Id"
    Public Shared Function SEARCH_FROM_HRM_TABLE_BY_NAME(ByVal txtSearchValue As String) As String
        Dim sql As String = SELECT_ALL_FROM_HRM_TABLE
        If Not String.IsNullOrEmpty(txtSearchValue) Then
            sql &= " WHERE name LIKE '%" & txtSearchValue & "%'"
        End If
        Return sql
    End Function
    Public Const INSERT_TO_FROM_HRM_LOGIN As String = "INSERT INTO HRM_Login (userName, password, role) VALUES (@UserName, @Password, @Role)"
    Public Const UPDATE_TO_FROM_HRM_LOGIN As String = "UPDATE HRM_Login SET userName = @UserName, password = @Password, role = @Role WHERE userId = @UserId"

End Class
