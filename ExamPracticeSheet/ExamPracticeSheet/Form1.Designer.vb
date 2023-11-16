<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Payment
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
        txt1 = New TextBox()
        txt2 = New TextBox()
        txt3 = New TextBox()
        txt4 = New TextBox()
        txt5 = New TextBox()
        txt6 = New TextBox()
        btnSave = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(53, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(300, 35)
        Label1.TabIndex = 0
        Label1.Text = "Ranasarani Service Center"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(68, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 20)
        Label2.TabIndex = 1
        Label2.Text = "Employee No"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(68, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 2
        Label3.Text = "Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(68, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 20)
        Label4.TabIndex = 3
        Label4.Text = "Basic Salary"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(68, 246)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 20)
        Label5.TabIndex = 4
        Label5.Text = "Deduction"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(68, 287)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 20)
        Label6.TabIndex = 5
        Label6.Text = "Net Salary"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(68, 334)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 20)
        Label7.TabIndex = 6
        Label7.Text = "Bonus"
        ' 
        ' txt1
        ' 
        txt1.Location = New Point(250, 120)
        txt1.Name = "txt1"
        txt1.Size = New Size(125, 27)
        txt1.TabIndex = 7
        ' 
        ' txt2
        ' 
        txt2.Location = New Point(250, 162)
        txt2.Name = "txt2"
        txt2.Size = New Size(125, 27)
        txt2.TabIndex = 8
        ' 
        ' txt3
        ' 
        txt3.Location = New Point(250, 201)
        txt3.Name = "txt3"
        txt3.Size = New Size(125, 27)
        txt3.TabIndex = 9
        ' 
        ' txt4
        ' 
        txt4.Location = New Point(250, 243)
        txt4.Name = "txt4"
        txt4.Size = New Size(125, 27)
        txt4.TabIndex = 10
        ' 
        ' txt5
        ' 
        txt5.Location = New Point(250, 287)
        txt5.Name = "txt5"
        txt5.Size = New Size(125, 27)
        txt5.TabIndex = 11
        ' 
        ' txt6
        ' 
        txt6.Location = New Point(250, 327)
        txt6.Name = "txt6"
        txt6.Size = New Size(125, 27)
        txt6.TabIndex = 12
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(142, 404)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 13
        btnSave.Text = "Clear"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(259, 404)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 14
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Payment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(664, 463)
        Controls.Add(btnExit)
        Controls.Add(btnSave)
        Controls.Add(txt6)
        Controls.Add(txt5)
        Controls.Add(txt4)
        Controls.Add(txt3)
        Controls.Add(txt2)
        Controls.Add(txt1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Payment"
        Text = "Employee Details"
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
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents txt4 As TextBox
    Friend WithEvents txt5 As TextBox
    Friend WithEvents txt6 As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
End Class
