<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btnClear = New Button()
        btnExist = New Button()
        txtNo = New TextBox()
        txtBS = New TextBox()
        txtName = New TextBox()
        txtDed = New TextBox()
        txtNS = New TextBox()
        txtB = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(286, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 20)
        Label1.TabIndex = 0
        Label1.Text = "Rnsarani Service Center"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(114, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 20)
        Label2.TabIndex = 1
        Label2.Text = "Employee No"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(114, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 2
        Label3.Text = "Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(114, 196)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 20)
        Label4.TabIndex = 3
        Label4.Text = "Basic Salary"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(114, 242)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 20)
        Label5.TabIndex = 4
        Label5.Text = "Deduction"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(114, 294)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 20)
        Label6.TabIndex = 5
        Label6.Text = "Net Salary"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(114, 348)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 20)
        Label7.TabIndex = 6
        Label7.Text = "Bonus"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(666, 176)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExist
        ' 
        btnExist.Location = New Point(666, 233)
        btnExist.Name = "btnExist"
        btnExist.Size = New Size(94, 29)
        btnExist.TabIndex = 8
        btnExist.Text = "Exit"
        btnExist.UseVisualStyleBackColor = True
        ' 
        ' txtNo
        ' 
        txtNo.Location = New Point(420, 124)
        txtNo.Name = "txtNo"
        txtNo.Size = New Size(125, 27)
        txtNo.TabIndex = 9
        ' 
        ' txtBS
        ' 
        txtBS.Location = New Point(420, 209)
        txtBS.Name = "txtBS"
        txtBS.Size = New Size(125, 27)
        txtBS.TabIndex = 10
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(420, 167)
        txtName.Name = "txtName"
        txtName.Size = New Size(125, 27)
        txtName.TabIndex = 11
        ' 
        ' txtDed
        ' 
        txtDed.Location = New Point(420, 254)
        txtDed.Name = "txtDed"
        txtDed.Size = New Size(125, 27)
        txtDed.TabIndex = 12
        ' 
        ' txtNS
        ' 
        txtNS.Location = New Point(420, 294)
        txtNS.Name = "txtNS"
        txtNS.Size = New Size(125, 27)
        txtNS.TabIndex = 13
        ' 
        ' txtB
        ' 
        txtB.Location = New Point(420, 341)
        txtB.Name = "txtB"
        txtB.Size = New Size(125, 27)
        txtB.TabIndex = 14
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtB)
        Controls.Add(txtNS)
        Controls.Add(txtDed)
        Controls.Add(txtName)
        Controls.Add(txtBS)
        Controls.Add(txtNo)
        Controls.Add(btnExist)
        Controls.Add(btnClear)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Service Center"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExist As Button
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtBS As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDed As TextBox
    Friend WithEvents txtNS As TextBox
    Friend WithEvents txtB As TextBox
End Class
