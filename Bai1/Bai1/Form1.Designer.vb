<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblUnitPrice = New Label()
        txtUnitPrice = New TextBox()
        lblQuantity = New Label()
        txtQuantity = New TextBox()
        lblDiscount = New Label()
        txtDiscount = New TextBox()
        lblTotalLabel = New Label()
        lblTotal = New Label()
        btnCalculate = New Button()
        btnReset = New Button()
        SuspendLayout()
        ' 
        ' lblUnitPrice
        ' 
        lblUnitPrice.AutoSize = True
        lblUnitPrice.Location = New Point(20, 9)
        lblUnitPrice.Name = "lblUnitPrice"
        lblUnitPrice.Size = New Size(188, 32)
        lblUnitPrice.TabIndex = 0
        lblUnitPrice.Text = "Đơn giá dịch vụ:"
        ' 
        ' txtUnitPrice
        ' 
        txtUnitPrice.Location = New Point(209, 10)
        txtUnitPrice.Name = "txtUnitPrice"
        txtUnitPrice.Size = New Size(200, 39)
        txtUnitPrice.TabIndex = 0
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(28, 55)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(185, 32)
        lblQuantity.TabIndex = 1
        lblQuantity.Text = "Số lượng khách:"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(209, 55)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(200, 39)
        txtQuantity.TabIndex = 1
        ' 
        ' lblDiscount
        ' 
        lblDiscount.AutoSize = True
        lblDiscount.Location = New Point(20, 97)
        lblDiscount.Name = "lblDiscount"
        lblDiscount.Size = New Size(193, 32)
        lblDiscount.TabIndex = 2
        lblDiscount.Text = "Mã giảm giá (%):"
        ' 
        ' txtDiscount
        ' 
        txtDiscount.Location = New Point(209, 100)
        txtDiscount.Multiline = True
        txtDiscount.Name = "txtDiscount"
        txtDiscount.Size = New Size(200, 39)
        txtDiscount.TabIndex = 2
        ' 
        ' lblTotalLabel
        ' 
        lblTotalLabel.AutoSize = True
        lblTotalLabel.Location = New Point(20, 140)
        lblTotalLabel.Name = "lblTotalLabel"
        lblTotalLabel.Size = New Size(122, 32)
        lblTotalLabel.TabIndex = 3
        lblTotalLabel.Text = "Tổng tiền:"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(137, 145)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(58, 32)
        lblTotal.TabIndex = 4
        lblTotal.Text = "0.00"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(160, 180)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(99, 39)
        btnCalculate.TabIndex = 3
        btnCalculate.Text = "Tính tiền"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(265, 180)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(104, 39)
        btnReset.TabIndex = 4
        btnReset.Text = "Làm mới"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AcceptButton = btnCalculate
        AutoScaleDimensions = New SizeF(13.0F, 32.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(540, 302)
        Controls.Add(lblUnitPrice)
        Controls.Add(txtUnitPrice)
        Controls.Add(lblQuantity)
        Controls.Add(txtQuantity)
        Controls.Add(lblDiscount)
        Controls.Add(txtDiscount)
        Controls.Add(lblTotalLabel)
        Controls.Add(lblTotal)
        Controls.Add(btnCalculate)
        Controls.Add(btnReset)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Máy tính cước dịch vụ"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents lblUnitPrice As System.Windows.Forms.Label
    Private WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Private WithEvents lblQuantity As System.Windows.Forms.Label
    Private WithEvents txtQuantity As System.Windows.Forms.TextBox
    Private WithEvents lblDiscount As System.Windows.Forms.Label
    Private WithEvents txtDiscount As System.Windows.Forms.TextBox
    Private WithEvents lblTotalLabel As System.Windows.Forms.Label
    Private WithEvents lblTotal As System.Windows.Forms.Label
    Private WithEvents btnCalculate As System.Windows.Forms.Button
    Private WithEvents btnReset As System.Windows.Forms.Button

End Class
