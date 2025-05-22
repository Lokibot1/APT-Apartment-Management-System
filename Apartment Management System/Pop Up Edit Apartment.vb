Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Pop_Up_Edit_Apartment
    Public Property UnitId As String
    Public Property UnitNo As String
    Public Property Description As String
    Public Property Price As String
    Public Property Status As String

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles Save.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox3.Text) OrElse String.IsNullOrWhiteSpace(TextBox4.Text) Then
            MessageBox.Show("Please fill all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Save the update
        UnitId = TextBox1.Text
        UnitNo = TextBox2.Text
        Description = TextBox3.Text
        Price = TextBox4.Text
        Status = ComboBox1.SelectedItem?.ToString()

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Pop_Up_Edit_Apartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = UnitId
        TextBox2.Text = UnitNo
        TextBox3.Text = Description
        TextBox4.Text = Price

        ComboBox1.Items.Clear() 'para di mag duplicate
        ComboBox1.Items.AddRange(New String() {"Vacant", "Occupied"}) 'range ng laman ng combox
        ComboBox1.SelectedItem = Status
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub
End Class