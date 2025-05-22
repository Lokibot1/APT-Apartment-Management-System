Public Class TenantsForm
    Private Sub AddTenant_Click(sender As Object, e As EventArgs) Handles AddTenant.Click
        Dim popup As New Pop_Up_Add_Tenant()
        popup.StartPosition = FormStartPosition.CenterParent

        If popup.ShowDialog() = DialogResult.OK Then
            Dim tenantName As String = popup.TenantName
            Dim email As String = popup.Email
            Dim contactNo As String = popup.ContactNo
            Dim unitNo As String = popup.UnitNo
            Dim registrationDate As String = popup.RegistrationDate

            Dim item As New ListViewItem(tenantName)
            item.SubItems.Add(email)
            item.SubItems.Add(contactNo)
            item.SubItems.Add(unitNo)
            item.SubItems.Add(registrationDate)

            ListView1.Items.Add(item)
        End If
    End Sub

    Private Sub TenantsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Clear()
        ListView1.View = View.Details

        ListView1.Columns.Add("Name", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Email", 200, HorizontalAlignment.Left)
        ListView1.Columns.Add("Contact No.", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Unit No.", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Reg. Date", 100, HorizontalAlignment.Left)
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        ' Warning
        If ListView1.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a tenant to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
        Dim popup As New Pop_Up_Update_Tenant_Info()
        popup.StartPosition = FormStartPosition.CenterParent

        ' Fetch the selected tenant's details sa popup form
        popup.TenantName = selectedItem.SubItems(0).Text
        popup.Email = selectedItem.SubItems(1).Text
        popup.ContactNo = selectedItem.SubItems(2).Text
        popup.UnitNo = selectedItem.SubItems(3).Text
        popup.RegistrationDate = selectedItem.SubItems(4).Text

        ' PANG UPDATE
        If popup.ShowDialog() = DialogResult.OK Then
            selectedItem.SubItems(0).Text = popup.TenantName
            selectedItem.SubItems(1).Text = popup.Email
            selectedItem.SubItems(2).Text = popup.ContactNo
            selectedItem.SubItems(3).Text = popup.UnitNo
            selectedItem.SubItems(4).Text = popup.RegistrationDate
        End If
    End Sub
End Class