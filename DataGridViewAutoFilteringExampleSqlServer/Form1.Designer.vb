﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridViewAutoFilterTextBoxColumn5 = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.DataGridViewAutoFilterTextBoxColumn4 = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.DataGridViewAutoFilterTextBoxColumn3 = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.DataGridViewAutoFilterTextBoxColumn2 = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.DataGridViewAutoFilterTextBoxColumn1 = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.filterStatusLabel = New System.Windows.Forms.Label()
        Me.removeAlFiltersButton = New System.Windows.Forms.Button()
        Me.currentCompanyIdentifier = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CompanyColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.ContactTitleColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.AddressColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.PostalCodeColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.CountryColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewAutoFilterTextBoxColumn5
        '
        Me.DataGridViewAutoFilterTextBoxColumn5.DataPropertyName = "Country"
        Me.DataGridViewAutoFilterTextBoxColumn5.HeaderText = "Country"
        Me.DataGridViewAutoFilterTextBoxColumn5.Name = "DataGridViewAutoFilterTextBoxColumn5"
        '
        'DataGridViewAutoFilterTextBoxColumn4
        '
        Me.DataGridViewAutoFilterTextBoxColumn4.DataPropertyName = "PostalCode"
        Me.DataGridViewAutoFilterTextBoxColumn4.HeaderText = "Postal"
        Me.DataGridViewAutoFilterTextBoxColumn4.Name = "DataGridViewAutoFilterTextBoxColumn4"
        '
        'DataGridViewAutoFilterTextBoxColumn3
        '
        Me.DataGridViewAutoFilterTextBoxColumn3.DataPropertyName = "City"
        Me.DataGridViewAutoFilterTextBoxColumn3.HeaderText = "City"
        Me.DataGridViewAutoFilterTextBoxColumn3.Name = "DataGridViewAutoFilterTextBoxColumn3"
        '
        'DataGridViewAutoFilterTextBoxColumn2
        '
        Me.DataGridViewAutoFilterTextBoxColumn2.DataPropertyName = "Title"
        Me.DataGridViewAutoFilterTextBoxColumn2.HeaderText = "Contact"
        Me.DataGridViewAutoFilterTextBoxColumn2.Name = "DataGridViewAutoFilterTextBoxColumn2"
        '
        'DataGridViewAutoFilterTextBoxColumn1
        '
        Me.DataGridViewAutoFilterTextBoxColumn1.DataPropertyName = "CompanyName"
        Me.DataGridViewAutoFilterTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewAutoFilterTextBoxColumn1.Name = "DataGridViewAutoFilterTextBoxColumn1"
        '
        'filterStatusLabel
        '
        Me.filterStatusLabel.AutoSize = True
        Me.filterStatusLabel.Location = New System.Drawing.Point(271, 19)
        Me.filterStatusLabel.Name = "filterStatusLabel"
        Me.filterStatusLabel.Size = New System.Drawing.Size(39, 13)
        Me.filterStatusLabel.TabIndex = 2
        Me.filterStatusLabel.Text = "Label1"
        '
        'removeAlFiltersButton
        '
        Me.removeAlFiltersButton.Location = New System.Drawing.Point(138, 14)
        Me.removeAlFiltersButton.Name = "removeAlFiltersButton"
        Me.removeAlFiltersButton.Size = New System.Drawing.Size(84, 23)
        Me.removeAlFiltersButton.TabIndex = 1
        Me.removeAlFiltersButton.Text = "Remove filters"
        Me.removeAlFiltersButton.UseVisualStyleBackColor = True
        '
        'currentCompanyIdentifier
        '
        Me.currentCompanyIdentifier.Location = New System.Drawing.Point(21, 14)
        Me.currentCompanyIdentifier.Name = "currentCompanyIdentifier"
        Me.currentCompanyIdentifier.Size = New System.Drawing.Size(84, 23)
        Me.currentCompanyIdentifier.TabIndex = 0
        Me.currentCompanyIdentifier.Text = "Company Id"
        Me.currentCompanyIdentifier.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.filterStatusLabel)
        Me.Panel1.Controls.Add(Me.removeAlFiltersButton)
        Me.Panel1.Controls.Add(Me.currentCompanyIdentifier)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 296)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(662, 55)
        Me.Panel1.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CompanyColumn, Me.ContactTitleColumn, Me.AddressColumn, Me.CityColumn, Me.PostalCodeColumn, Me.CountryColumn})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(662, 351)
        Me.DataGridView1.TabIndex = 2
        '
        'CompanyColumn
        '
        Me.CompanyColumn.DataPropertyName = "CompanyName"
        Me.CompanyColumn.HeaderText = "Name"
        Me.CompanyColumn.Name = "CompanyColumn"
        '
        'ContactTitleColumn
        '
        Me.ContactTitleColumn.DataPropertyName = "ContactTitle"
        Me.ContactTitleColumn.HeaderText = "Contact"
        Me.ContactTitleColumn.Name = "ContactTitleColumn"
        '
        'AddressColumn
        '
        Me.AddressColumn.DataPropertyName = "Street"
        Me.AddressColumn.HeaderText = "Address"
        Me.AddressColumn.Name = "AddressColumn"
        '
        'CityColumn
        '
        Me.CityColumn.DataPropertyName = "City"
        Me.CityColumn.HeaderText = "City"
        Me.CityColumn.Name = "CityColumn"
        '
        'PostalCodeColumn
        '
        Me.PostalCodeColumn.DataPropertyName = "PostalCode"
        Me.PostalCodeColumn.HeaderText = "Postal"
        Me.PostalCodeColumn.Name = "PostalCodeColumn"
        '
        'CountryColumn
        '
        Me.CountryColumn.DataPropertyName = "CountryName"
        Me.CountryColumn.HeaderText = "Country"
        Me.CountryColumn.Name = "CountryColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 351)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataGridView auto filter with SQL-Server"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewAutoFilterTextBoxColumn5 As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewAutoFilterTextBoxColumn4 As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewAutoFilterTextBoxColumn3 As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewAutoFilterTextBoxColumn2 As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewAutoFilterTextBoxColumn1 As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents filterStatusLabel As Label
    Friend WithEvents removeAlFiltersButton As Button
    Friend WithEvents currentCompanyIdentifier As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CompanyColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents ContactTitleColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents AddressColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents PostalCodeColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents CountryColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
End Class
