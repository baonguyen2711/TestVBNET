Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports System.Windows
Imports Microsoft.VisualBasic.Devices
Imports Microsoft.VisualBasic.FileIO
Imports Excel = Microsoft.Office.Interop.Excel
Imports CsvHelper
Imports System.ComponentModel

Imports Models
Imports CsvHelper.Configuration
Imports System.Data.SqlTypes

Public Class Home
    Private dataTable As DataTable
    Dim people As List(Of Person) = New List(Of Person)
    Public Property isAdmin As Boolean
    Public Property isCustomer As Boolean
    Public Property UserName As String
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.HRM_TableTableAdapter.Fill(Me.HRM_TableDataSet.HRM_Table)
        'Me.Font = New Font("Arial Unicode MS", 9, FontStyle.Regular)
        'DataGrid.DefaultCellStyle.Font = New Font("Arial Unicode MS", 9, FontStyle.Regular)
        ' Đặt lại tên các cột trên DataGridView1
        'DataGrid.Columns(0).HeaderText = "ID"
        'DataGrid.Columns(1).HeaderText = "Họ tên"
        'DataGridV.Columns(2).HeaderText = "Năm sinh"
        'DataGrid.Columns(3).HeaderText = "Địa chỉ"
        'DataGrid.Columns(4).HeaderText = "Bộ phận"
        'DataGrid.Columns(5).HeaderText = "Chức vụ"
        'DataGrid.Columns(6).HeaderText = "Ghi chú"
        'DataGrid.Columns(6).FillWeight = 1.0
        'DataGrid.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ' Thiết lập màu nền và căn giữa tiêu đề cột trên DataGridView1
        'DataGridView.EnableHeadersVisualStyles = False
        'DataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LimeGreen
        'dataTable = New DataTable()
        'dataTable.Columns.Add("ID", GetType(Integer))
        'dataTable.Columns.Add("Họ tên", GetType(String))
        'dataTable.Columns.Add("Năm sinh", GetType(String))
        'dataTable.Columns.Add("Địa chỉ", GetType(String))
        'dataTable.Columns.Add("Bộ phận", GetType(String))
        'dataTable.Columns.Add("Chức vụ", GetType(String))
        'dataTable.Columns.Add("Ghi chú", GetType(String))
        'DataGridView.DataSource = HRM_TableDataSet.HRM_Table
        LoadData()
    End Sub
    Private Sub LoadData()
        ' Tạo câu lệnh SQL để truy vấn dữ liệu
        'Dim query As String = "SELECT * FROM HRM_Table"
        Dim query As String = SQLString.SELECT_ALL_FROM_HRM_TABLE
        ' Khởi tạo đối tượng kết nối và truy vấn cơ sở dữ liệu
        'Dim connectionString As String = "Data Source=DNCPU0100\MSSQLSERVER2019;Initial Catalog=HRM_Table;Integrated Security=True"
        Using connection As SqlConnection = DBConnect.GetInstance
            Dim command As SqlCommand = New SqlCommand(query, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()

            ' Duyệt qua từng bản ghi trong kết quả truy vấn và thêm vào danh sách people
            While reader.Read()
                Dim person As Person = New Person()
                person.ID = CInt(reader("ID"))
                person.Name = reader("Name").ToString()
                person.DateOfBirth = reader("DateOfBirth").ToString()
                person.Address = reader("Address").ToString()
                person.Department = reader("Department").ToString()
                person.Position = reader("Position").ToString()
                person.Note = reader("Note").ToString()
                people.Add(person)
            End While

            reader.Close()
        End Using

        DataGrid.DefaultCellStyle.Font = New Font("Arial Unicode MS", 9, FontStyle.Regular)
        DataGrid.Columns(0).HeaderText = "ID"
        DataGrid.Columns(1).HeaderText = "Họ tên"
        DataGrid.Columns(2).HeaderText = "Năm sinh"
        DataGrid.Columns(3).HeaderText = "Địa chỉ"
        DataGrid.Columns(4).HeaderText = "Bộ phận"
        DataGrid.Columns(5).HeaderText = "Chức vụ"
        DataGrid.Columns(6).HeaderText = "Ghi chú"
        DataGrid.Columns(6).FillWeight = 1.0
        DataGrid.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ' Thiết lập màu nền và căn giữa tiêu đề cột trên DataGridView1
        DataGrid.EnableHeadersVisualStyles = False
        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.LimeGreen
        ' Hiển thị dữ liệu trên DataGridView
        DataGrid.DataSource = people
        'DataGridView.DataSource = HRM_TableDataSet.HRM_Table
        'If DataGridView.Columns.Contains("ID") Then
        'DataGridView.Columns("ID").Visible = False
        'End If
    End Sub
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Me.Hide()
        Dim frm2 As New SaveScreen(0) ' Truyền giá trị id mặc định là 0 để biết là thêm mới.
        frm2.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim selectedRows As DataGridViewSelectedRowCollection = DataGrid.SelectedRows
        If selectedRows.Count >= 0 Then
            ' Lấy thông tin của hàng được chọn trong DataGrid
            Dim selectPerson As Person = people(selectedRows(0).Index)
            Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa hàng có ID = " & selectPerson.ID & " và Tên = " & selectPerson.Name & " ?", "Xác nhận", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                'Dim id As Integer = CInt(DataGridView(0, selectedRowIndex).Value) ' Lấy khóa chính của hàng được chọn
                'Dim name As String = DataGridView(1, selectedRowIndex).Value.ToString()
                'Dim dateOfBirth As String = DataGridView(2, selectedRowIndex).Value.ToString()
                'Dim address As String = DataGridView(3, selectedRowIndex).Value.ToString()
                'Dim department As String = DataGridView(4, selectedRowIndex).Value.ToString()
                'Dim position As String = DataGridView(5, selectedRowIndex).Value.ToString()
                'Dim note As String = DataGridView(6, selectedRowIndex).Value.ToString()

                Dim frm2 As New SaveScreen(selectPerson.ID) ' Truyền giá trị id để biết là chỉnh sửa.
                frm2.txtName.Text = selectPerson.ID
                frm2.txtName.Text = selectPerson.Name
                Dim dateOfBirth As DateTime = DateTime.ParseExact(selectPerson.DateOfBirth, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                frm2.txtDateOfBirth.Value = dateOfBirth
                frm2.txtDateOfBirth.Value = dateOfBirth
                frm2.txtAddress.Text = selectPerson.Address
                frm2.txtDepartment.Text = selectPerson.Department
                frm2.txtPosition.Text = selectPerson.Position
                frm2.txtNote.Text = selectPerson.Note
                frm2.Show()
            Else
            End If

        End If
    End Sub
    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick
        If e.RowIndex >= 0 Then
            DataGrid.Rows(e.RowIndex).Selected = True
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim selectedRows As DataGridViewSelectedRowCollection = DataGrid.SelectedRows
        If selectedRows.Count >= 0 Then
            ' Lấy thông tin của hàng được chọn trong DataGrid
            Dim selectPerson As Person = people(selectedRows(0).Index)
            Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng có ID = " & selectPerson.ID & " và Tên = " & selectPerson.Name & " ?", "Xác nhận", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ' Lấy khóa chính của hàng được chọn
                Using connection As SqlConnection = DBConnect.GetInstance
                    Dim commandText As String = SQLString.DELETE_TO_FROM_HRM_TABLE
                    Using command As New SqlCommand(commandText, connection)
                        command.Parameters.AddWithValue("@Id", selectPerson.ID)
                        command.ExecuteNonQuery()
                    End Using
                End Using
                'DataGridView.Rows.RemoveAt(selectedRowIndex)
                people.RemoveAt(selectedRows(0).Index)
                DataGrid.DataSource = Nothing
                DataGrid.DataSource = people
                MessageBox.Show("xóa thành công.")
            End If
        Else
        End If
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim query As String = SQLString.SEARCH_FROM_HRM_TABLE_BY_NAME(txtSearch.Text)
        Using connection As SqlConnection = DBConnect.GetInstance
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(query, connection)
            Dim dataTable As DataTable = New DataTable()
            adapter.Fill(dataTable)
            DataGrid.DataSource = dataTable
        End Using
        'Dim keyword As String = txtSearch.Text.Trim().ToLower()
        'Dim result As List(Of Person) = New List(Of Person)()
        'For Each person As Person In people
        'If person.Name.ToLower().Contains(keyword) Then
        'Result.Add(person)
        'End If
        'Next
        'DataGridView.DataSource = Nothing
        'DataGridView.DataSource = Result
    End Sub
    Private Sub today_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentDate As DateTime = DateTime.Now
        dateNow.Text = currentDate.ToString("dd/MM/yyyy")
    End Sub
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim query As String = SQLString.SELECT_ALL_FROM_HRM_TABLE
        Using connection As SqlConnection = DBConnect.GetInstance
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(query, connection)
            Dim dataTable As DataTable = New DataTable()
            adapter.Fill(dataTable)
            If dataTable.Rows.Count = 0 Then
                MessageBox.Show("Không có dữ liệu để xuất ra file Excel.")
                Exit Sub
            End If
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
            'saveFileDialog.FilterIndex = 2
            saveFileDialog.FilterIndex = 1
            saveFileDialog.RestoreDirectory = True

            ' Tạo đối tượng Excel
            Dim excelApp As New Excel.Application()

            ' Mở một workbook mới
            Dim excelWorkbook As Excel.Workbook = excelApp.Workbooks.Add()

            ' Lấy sheet đang active
            Dim excelWorksheet As Excel.Worksheet = excelWorkbook.ActiveSheet

            ' Đặt tiêu đề cho các cột
            For i As Integer = 0 To dataTable.Columns.Count - 1
                excelWorksheet.Cells(1, i + 1) = dataTable.Columns(i).ColumnName
            Next

            ' Đổ dữ liệu từ DataTable vào Excel
            For i As Integer = 0 To dataTable.Rows.Count - 1
                For j As Integer = 0 To dataTable.Columns.Count - 1
                    If dataTable.Rows(i)(j) IsNot Nothing AndAlso Not IsDBNull(dataTable.Rows(i)(j)) Then
                        excelWorksheet.Cells(i + 2, j + 1) = dataTable.Rows(i)(j).ToString()
                    End If
                Next
            Next

            ' Tạo đường dẫn lưu file
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = saveFileDialog.FileName
                excelWorkbook.SaveAs(filePath)
                excelWorkbook.Close()
                excelApp.Quit()
                'Dim filePath As String = saveFileDialog.FileName
                Using writer As New StreamWriter(filePath)
                    Using csv As New CsvWriter(writer, CultureInfo.InvariantCulture)
                        ' Ghi tiêu đề cho các cột
                        For Each column As DataGridViewColumn In DataGrid.Columns
                            csv.WriteField(column.HeaderText)
                        Next
                        csv.NextRecord()

                        ' Ghi dữ liệu từ DataGridView
                        For Each row As DataGridViewRow In DataGrid.Rows
                            For Each cell As DataGridViewCell In row.Cells
                                csv.WriteField(cell.Value)
                            Next
                            csv.NextRecord()
                        Next
                    End Using
                End Using
                MessageBox.Show("Đã xuất dữ liệu ra file thành công!")

            End If
        End Using
    End Sub
    Private Function DataGridViewToDataTable(ByVal dataGridView As DataGridView) As DataTable
        Dim dataTable As New DataTable()
        For Each column As DataGridViewColumn In dataGridView.Columns
            dataTable.Columns.Add(column.HeaderText, column.ValueType)
        Next
        For Each row As DataGridViewRow In dataGridView.Rows
            Dim dataRow As DataRow = dataTable.NewRow()
            For Each cell As DataGridViewCell In row.Cells
                dataRow(cell.ColumnIndex) = cell.Value
            Next
            dataTable.Rows.Add(dataRow)
        Next
        Return dataTable
    End Function


    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|CSV files (*.csv)|*.csv|All files (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim filePath As String = openFileDialog.FileName
        Dim persons As New List(Of Person)

        If Path.GetExtension(filePath).Equals(".csv", StringComparison.OrdinalIgnoreCase) Then
            ' Import from CSV file
            Using reader As New StreamReader(filePath)
                Dim config As New CsvConfiguration(CultureInfo.InvariantCulture)
                Dim isFirstLine As Boolean = True

                Using csv As New CsvReader(reader, config)
                    While csv.Read()
                        If isFirstLine Then
                            isFirstLine = False
                            Continue While ' Skip the first line
                        End If
                        Dim person As New Person With {
                            .Name = csv.GetField(Of String)(1),
                            .DateOfBirth = csv.GetField(Of String)(2),
                            .Address = csv.GetField(Of String)(3),
                            .Department = csv.GetField(Of String)(4),
                            .Position = csv.GetField(Of String)(5),
                            .Note = csv.GetField(Of String)(6)
                        }
                        persons.Add(person)
                    End While
                End Using
            End Using
        Else
            ' Import from Excel file
            Dim excelApp As New Excel.Application()
            Dim excelWorkbook As Excel.Workbook = excelApp.Workbooks.Open(filePath)
            Dim excelWorksheet As Excel.Worksheet = excelWorkbook.Sheets(1)
            Dim range As Excel.Range = excelWorksheet.UsedRange

            For row As Integer = 2 To range.Rows.Count
                Dim person As New Person With {
                .Name = CStr(excelWorksheet.Cells(row, 2).Value),
                .DateOfBirth = CStr(excelWorksheet.Cells(row, 3).Value),
                .Address = CStr(excelWorksheet.Cells(row, 4).Value),
                .Department = CStr(excelWorksheet.Cells(row, 5).Value),
                .Position = CStr(excelWorksheet.Cells(row, 6).Value),
                .Note = CStr(excelWorksheet.Cells(row, 7).Value)
            }
                persons.Add(person)
            Next

            excelWorkbook.Close()
            excelApp.Quit()
        End If

        Using connection As SqlConnection = DBConnect.GetInstance()
            Dim commandText As String = "INSERT INTO HRM_Table (name, dateOfBirth, address, department, position, note) VALUES (@name, @dateOfBirth, @address, @department, @position, @note)"
            Using command As New SqlCommand(commandText, connection)
                For Each person As Person In persons
                    command.Parameters.Clear()
                    command.Parameters.AddWithValue("@name", If(String.IsNullOrEmpty(person.Name), DBNull.Value, person.Name))
                    command.Parameters.AddWithValue("@dateOfBirth", If(String.IsNullOrEmpty(person.DateOfBirth), DBNull.Value, person.DateOfBirth))
                    command.Parameters.AddWithValue("@address", If(String.IsNullOrEmpty(person.Address), DBNull.Value, person.Address))
                    command.Parameters.AddWithValue("@department", person.Department)
                    command.Parameters.AddWithValue("@position", If(String.IsNullOrEmpty(person.Position), DBNull.Value, person.Position))
                    command.Parameters.AddWithValue("@note", If(String.IsNullOrEmpty(person.Note), DBNull.Value, person.Note))
                    command.ExecuteNonQuery()
                Next
            End Using
        End Using

        MessageBox.Show("Đã nhập dữ liệu từ file thành công!")
        Me.HRM_TableTableAdapter.Fill(Me.HRM_TableDataSet.HRM_Table)
        DataGrid.DataSource = HRM_TableDataSet.HRM_Table
    End Sub
    Private Sub Search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(sender, e)
        End If
    End Sub
    Dim user As User
    Private Sub txtUserName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserName.Text = UserName
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim loginForm As New Login
        loginForm.Show()
        Me.Close()
    End Sub
End Class
