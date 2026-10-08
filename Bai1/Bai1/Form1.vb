Imports System.Globalization

Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Validate unit price (allow decimals)
        Dim unitPrice As Decimal
        If String.IsNullOrWhiteSpace(txtUnitPrice.Text) OrElse Not Decimal.TryParse(txtUnitPrice.Text, unitPrice) Then
            MessageBox.Show("Vui lòng nhập Đơn giá hợp lệ (số).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUnitPrice.Focus()
            Return
        End If

        ' Validate quantity (integer)
        Dim quantity As Integer
        If String.IsNullOrWhiteSpace(txtQuantity.Text) OrElse Not Integer.TryParse(txtQuantity.Text, quantity) Then
            MessageBox.Show("Vui lòng nhập Số lượng hợp lệ (số nguyên).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantity.Focus()
            Return
        End If

        ' Validate discount (allow decimals, 0-100)
        Dim discount As Decimal = 0D
        If Not String.IsNullOrWhiteSpace(txtDiscount.Text) Then
            If Not Decimal.TryParse(txtDiscount.Text, discount) Then
                MessageBox.Show("Vui lòng nhập Mã giảm giá hợp lệ (số).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtDiscount.Focus()
                Return
            End If
        End If

        If unitPrice < 0D OrElse quantity < 0 OrElse discount < 0D OrElse discount > 100D Then
            MessageBox.Show("Các giá trị không được âm và % giảm phải trong khoảng 0 - 100.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Calculate total: (unitPrice * quantity) * (100 - discount)/100
        Dim total As Decimal = (unitPrice * quantity) * (100D - discount) / 100D

        lblTotal.Text = total.ToString("N2", CultureInfo.CurrentCulture)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUnitPrice.Text = String.Empty
        txtQuantity.Text = String.Empty
        txtDiscount.Text = String.Empty
        lblTotal.Text = "0.00"
        txtUnitPrice.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblTotalLabel_Click(sender As Object, e As EventArgs) Handles lblTotalLabel.Click

    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub
End Class
