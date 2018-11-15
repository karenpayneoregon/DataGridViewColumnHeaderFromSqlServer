<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colCustomerIdentifier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCompanyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContactName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRegion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPostalCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCountry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContactTypeIdentifier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colModifiedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCurrentRow = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCustomerIdentifier, Me.colCompanyName, Me.colContactName, Me.colAddress, Me.colCity, Me.colRegion, Me.colPostalCode, Me.colCountry, Me.colPhone, Me.colFax, Me.colContactTypeIdentifier, Me.colModifiedDate})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1218, 392)
        Me.DataGridView1.TabIndex = 3
        '
        'colCustomerIdentifier
        '
        Me.colCustomerIdentifier.DataPropertyName = "CustomerIdentifier"
        Me.colCustomerIdentifier.HeaderText = "Column1"
        Me.colCustomerIdentifier.Name = "colCustomerIdentifier"
        '
        'colCompanyName
        '
        Me.colCompanyName.DataPropertyName = "CompanyName"
        Me.colCompanyName.HeaderText = "Column1"
        Me.colCompanyName.Name = "colCompanyName"
        '
        'colContactName
        '
        Me.colContactName.DataPropertyName = "ContactName"
        Me.colContactName.HeaderText = "Column1"
        Me.colContactName.Name = "colContactName"
        '
        'colAddress
        '
        Me.colAddress.DataPropertyName = "Address"
        Me.colAddress.HeaderText = "Column1"
        Me.colAddress.Name = "colAddress"
        '
        'colCity
        '
        Me.colCity.DataPropertyName = "City"
        Me.colCity.HeaderText = "Column1"
        Me.colCity.Name = "colCity"
        '
        'colRegion
        '
        Me.colRegion.DataPropertyName = "Region"
        Me.colRegion.HeaderText = "Column1"
        Me.colRegion.Name = "colRegion"
        '
        'colPostalCode
        '
        Me.colPostalCode.DataPropertyName = "PostalCode"
        Me.colPostalCode.HeaderText = "Column1"
        Me.colPostalCode.Name = "colPostalCode"
        '
        'colCountry
        '
        Me.colCountry.DataPropertyName = "Country"
        Me.colCountry.HeaderText = "Column1"
        Me.colCountry.Name = "colCountry"
        '
        'colPhone
        '
        Me.colPhone.DataPropertyName = "Phone"
        Me.colPhone.HeaderText = "Column1"
        Me.colPhone.Name = "colPhone"
        '
        'colFax
        '
        Me.colFax.DataPropertyName = "Fax"
        Me.colFax.HeaderText = "Column1"
        Me.colFax.Name = "colFax"
        '
        'colContactTypeIdentifier
        '
        Me.colContactTypeIdentifier.DataPropertyName = "ContactTypeIdentifier"
        Me.colContactTypeIdentifier.HeaderText = "Column1"
        Me.colContactTypeIdentifier.Name = "colContactTypeIdentifier"
        '
        'colModifiedDate
        '
        Me.colModifiedDate.DataPropertyName = "ModifiedDate"
        Me.colModifiedDate.HeaderText = "Column1"
        Me.colModifiedDate.Name = "colModifiedDate"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdCurrentRow)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 392)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1218, 58)
        Me.Panel1.TabIndex = 2
        '
        'cmdCurrentRow
        '
        Me.cmdCurrentRow.Location = New System.Drawing.Point(12, 23)
        Me.cmdCurrentRow.Name = "cmdCurrentRow"
        Me.cmdCurrentRow.Size = New System.Drawing.Size(133, 23)
        Me.cmdCurrentRow.TabIndex = 3
        Me.cmdCurrentRow.Text = "Current roiw"
        Me.cmdCurrentRow.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents colCustomerIdentifier As DataGridViewTextBoxColumn
    Friend WithEvents colCompanyName As DataGridViewTextBoxColumn
    Friend WithEvents colContactName As DataGridViewTextBoxColumn
    Friend WithEvents colAddress As DataGridViewTextBoxColumn
    Friend WithEvents colCity As DataGridViewTextBoxColumn
    Friend WithEvents colRegion As DataGridViewTextBoxColumn
    Friend WithEvents colPostalCode As DataGridViewTextBoxColumn
    Friend WithEvents colCountry As DataGridViewTextBoxColumn
    Friend WithEvents colPhone As DataGridViewTextBoxColumn
    Friend WithEvents colFax As DataGridViewTextBoxColumn
    Friend WithEvents colContactTypeIdentifier As DataGridViewTextBoxColumn
    Friend WithEvents colModifiedDate As DataGridViewTextBoxColumn
    Friend WithEvents cmdCurrentRow As Button
End Class
