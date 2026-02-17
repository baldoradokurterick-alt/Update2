Public Class DashboardForm
    Private Sub btnStock_Click(sender As Object, e As EventArgs)
        AddStock.Show()
    End Sub


    Private Sub Guna2TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2TabControl1.SelectedIndexChanged
        If Guna2TabControl1.SelectedIndex = 1 Then


        End If
    End Sub

    Private Sub btnSaleSave_Click(sender As Object, e As EventArgs) Handles btnSaleSave.Click
        Dim sale As New Sale(CInt(txtSaleProductID.Text), CDec(txtSalePrice.Text), CDec(txtSaleDiscount.Text), txtSaleCategory.Text, CInt(txtSaleItemSold.Text), CInt(txtSaleStockLeft.Text))
        If btnSaleSave() Then
            MessageBox.Show("Sale data saved successfully!")
        Else
            MessageBox.Show("Failed to save sale data.")
        End If
    End Sub

    Private Sub btnSaleCancel_Click(sender As Object, e As EventArgs) Handles btnSaleCancel.Click
        'clear the form fields
        txtSaleProductID.Clear()
        txtSaleCategory.Clear()
        txtSaleDiscount.Clear()
        txtSaleItemSold.Clear()
        txtSalePrice.Clear()
        txtSaleStockLeft.Clear()
    End Sub
End Class