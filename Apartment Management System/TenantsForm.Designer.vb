<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TenantsForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.TenantName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContactNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UnitNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RegistrationDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Update = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AddTenant = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 42)
        Me.Label1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Update)
        Me.Panel1.Location = New System.Drawing.Point(12, 34)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1055, 597)
        Me.Panel1.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.TenantName, Me.Email, Me.ContactNo, Me.UnitNo, Me.RegistrationDate})
        Me.ListView1.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(22, 77)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(841, 505)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'TenantName
        '
        Me.TenantName.Text = "Name"
        Me.TenantName.Width = 137
        '
        'Email
        '
        Me.Email.Text = "Email"
        Me.Email.Width = 197
        '
        'ContactNo
        '
        Me.ContactNo.Text = "Contact No."
        Me.ContactNo.Width = 159
        '
        'UnitNo
        '
        Me.UnitNo.Text = "Unit No."
        Me.UnitNo.Width = 163
        '
        'RegistrationDate
        '
        Me.RegistrationDate.Text = "Reg. Date"
        Me.RegistrationDate.Width = 166
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(962, 139)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(924, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Action"
        '
        'Update
        '
        Me.Update.BackColor = System.Drawing.Color.RoyalBlue
        Me.Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Update.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update.ForeColor = System.Drawing.Color.White
        Me.Update.Location = New System.Drawing.Point(869, 139)
        Me.Update.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(79, 31)
        Me.Update.TabIndex = 6
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Panel2.Controls.Add(Me.AddTenant)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(12, 34)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1055, 52)
        Me.Panel2.TabIndex = 0
        '
        'AddTenant
        '
        Me.AddTenant.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.AddTenant.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddTenant.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddTenant.Location = New System.Drawing.Point(902, 14)
        Me.AddTenant.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddTenant.Name = "AddTenant"
        Me.AddTenant.Size = New System.Drawing.Size(116, 26)
        Me.AddTenant.TabIndex = 1
        Me.AddTenant.Text = "Add Tenant"
        Me.AddTenant.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "List of Tenants"
        '
        'TenantsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 668)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "TenantsForm"
        Me.Text = "TenantsForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Update As Button
    Friend WithEvents AddTenant As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents TenantName As ColumnHeader
    Friend WithEvents Email As ColumnHeader
    Friend WithEvents ContactNo As ColumnHeader
    Friend WithEvents UnitNo As ColumnHeader
    Friend WithEvents RegistrationDate As ColumnHeader
End Class
