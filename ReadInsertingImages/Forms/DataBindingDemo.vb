﻿Imports UsingAccess_2007_BinaryField.Classes

Namespace Forms
    Public Class DataBindingDemo

        WithEvents _bsData As New BindingSource
        Private _currentImage As Image

        Private Sub DataBindingDemo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim ops As New Operations
            _bsData.DataSource = ops.PictureDataTable
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = _bsData
        End Sub
        Private Sub bsData_PositionChanged(sender As Object, e As EventArgs) Handles _bsData.PositionChanged
            If _bsData.Current IsNot Nothing Then

                _currentImage = Image.FromStream(
                    New IO.MemoryStream(
                        CType(_bsData.Current, DataRowView).Row.Field(Of Byte())("Picture"))
                    )

                PictureBox1.Image = _currentImage
                _currentImage = Nothing
            Else
                PictureBox1.Image = Nothing
            End If
        End Sub
    End Class
End Namespace