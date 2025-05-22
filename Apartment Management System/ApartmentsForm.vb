Public Class ApartmentsForm
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListView1.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select an apartment to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)

        Dim popup As New Pop_Up_Edit_Apartment()
        popup.StartPosition = FormStartPosition.CenterParent

        popup.UnitId = selectedItem.SubItems(0).Text
        popup.UnitNo = selectedItem.SubItems(1).Text
        popup.Description = selectedItem.SubItems(2).Text
        popup.Price = selectedItem.SubItems(3).Text
        popup.Status = If(selectedItem.SubItems.Count > 4, selectedItem.SubItems(4).Text, "Vacant") ' Default to 'Vacant'

        If popup.ShowDialog() = DialogResult.OK Then
            selectedItem.SubItems(0).Text = popup.UnitId
            selectedItem.SubItems(1).Text = popup.UnitNo
            selectedItem.SubItems(2).Text = popup.Description
            selectedItem.SubItems(3).Text = popup.Price
            selectedItem.SubItems(4).Text = popup.Status
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim unitId As String = TextBox1.Text
        Dim unitNo As String = TextBox2.Text
        Dim description As String = TextBox3.Text
        Dim price As String = TextBox4.Text

        If String.IsNullOrWhiteSpace(unitId) OrElse String.IsNullOrWhiteSpace(unitNo) OrElse
           String.IsNullOrWhiteSpace(description) OrElse String.IsNullOrWhiteSpace(price) Then
            MessageBox.Show("Please fill all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim item As New ListViewItem(unitId)
        item.SubItems.Add(unitNo)
        item.SubItems.Add(description)
        item.SubItems.Add(price)
        item.SubItems.Add("Vacant")

        ListView1.Items.Add(item)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub ApartmentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Clear()
        ListView1.View = View.Details

        ListView1.Columns.Add("Unit ID", 70)
        ListView1.Columns.Add("Unit No", 70)
        ListView1.Columns.Add("Description", 120)
        ListView1.Columns.Add("Price", 100)
        ListView1.Columns.Add("Status", 80)
    End Sub
End Class