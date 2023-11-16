<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalary
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
        btnClear = New Button()
        btnCalculate = New Button()
        btnExit = New Button()
        txtBasicSalary = New TextBox()
        txtOH = New TextBox()
        txtSex = New TextBox()
        txtOR = New TextBox()
        txtAllow1 = New TextBox()
        txtAllow2 = New TextBox()
        txtNetSal = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.Location = New Point(526, 112)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 35)
        btnClear.TabIndex = 0
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnCalculate.Location = New Point(526, 203)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(94, 41)
        btnCalculate.TabIndex = 1
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnExit.Location = New Point(526, 310)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 37)
        btnExit.TabIndex = 2
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' txtBasicSalary
        ' 
        txtBasicSalary.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtBasicSalary.Location = New Point(277, 54)
        txtBasicSalary.Name = "txtBasicSalary"
        txtBasicSalary.Size = New Size(125, 31)
        txtBasicSalary.TabIndex = 3
        ' 
        ' txtOH
        ' 
        txtOH.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtOH.Location = New Point(277, 101)
        txtOH.Name = "txtOH"
        txtOH.Size = New Size(125, 31)
        txtOH.TabIndex = 4
        ' 
        ' txtSex
        ' 
        txtSex.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtSex.Location = New Point(277, 150)
        txtSex.Name = "txtSex"
        txtSex.Size = New Size(125, 31)
        txtSex.TabIndex = 5
        ' 
        ' txtOR
        ' 
        txtOR.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtOR.Location = New Point(277, 203)
        txtOR.Name = "txtOR"
        txtOR.Size = New Size(125, 31)
        txtOR.TabIndex = 6
        ' 
        ' txtAllow1
        ' 
        txtAllow1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtAllow1.Location = New Point(277, 249)
        txtAllow1.Name = "txtAllow1"
        txtAllow1.Size = New Size(125, 31)
        txtAllow1.TabIndex = 7
        ' 
        ' txtAllow2
        ' 
        txtAllow2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtAllow2.Location = New Point(277, 295)
        txtAllow2.Name = "txtAllow2"
        txtAllow2.Size = New Size(125, 31)
        txtAllow2.TabIndex = 8
        ' 
        ' txtNetSal
        ' 
        txtNetSal.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtNetSal.Location = New Point(277, 340)
        txtNetSal.Name = "txtNetSal"
        txtNetSal.Size = New Size(125, 31)
        txtNetSal.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(109, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 25)
        Label1.TabIndex = 10
        Label1.Text = "Basic Salary"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(109, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 25)
        Label2.TabIndex = 11
        Label2.Text = "OT Hours"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(109, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 25)
        Label3.TabIndex = 12
        Label3.Text = "Sex(M/F)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(109, 203)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 25)
        Label4.TabIndex = 13
        Label4.Text = "OT Rate"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(109, 252)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 25)
        Label5.TabIndex = 14
        Label5.Text = "Allownces 1"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(109, 298)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 25)
        Label6.TabIndex = 15
        Label6.Text = "Allownces 2"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(109, 347)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 25)
        Label7.TabIndex = 16
        Label7.Text = "Net Salary"
        ' 
        ' frmSalary
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNetSal)
        Controls.Add(txtAllow2)
        Controls.Add(txtAllow1)
        Controls.Add(txtOR)
        Controls.Add(txtSex)
        Controls.Add(txtOH)
        Controls.Add(txtBasicSalary)
        Controls.Add(btnExit)
        Controls.Add(btnCalculate)
        Controls.Add(btnClear)
        Name = "frmSalary"
        Text = "Basic Salary"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtBasicSalary As TextBox
    Friend WithEvents txtOH As TextBox
    Friend WithEvents txtSex As TextBox
    Friend WithEvents txtOR As TextBox
    Friend WithEvents txtAllow1 As TextBox
    Friend WithEvents txtAllow2 As TextBox
    Friend WithEvents txtNetSal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
