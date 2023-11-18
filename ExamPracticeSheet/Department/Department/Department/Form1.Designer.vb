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
        txtNo = New TextBox()
        txtBS = New TextBox()
        txtNS = New TextBox()
        GroupBox1 = New GroupBox()
        rdoPro = New RadioButton()
        rdoCom = New RadioButton()
        rdoAcc = New RadioButton()
        btnCalculate = New Button()
        btnExits = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(114, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 20)
        Label1.TabIndex = 0
        Label1.Text = "Emp No"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(114, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 1
        Label2.Text = "Basic Salary"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(96, 296)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 2
        Label3.Text = "New Salary"
        ' 
        ' txtNo
        ' 
        txtNo.Location = New Point(243, 30)
        txtNo.Name = "txtNo"
        txtNo.Size = New Size(125, 27)
        txtNo.TabIndex = 3
        ' 
        ' txtBS
        ' 
        txtBS.Location = New Point(243, 70)
        txtBS.Name = "txtBS"
        txtBS.Size = New Size(125, 27)
        txtBS.TabIndex = 4
        ' 
        ' txtNS
        ' 
        txtNS.Location = New Point(224, 296)
        txtNS.Name = "txtNS"
        txtNS.Size = New Size(125, 27)
        txtNS.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.GradientActiveCaption
        GroupBox1.Controls.Add(rdoPro)
        GroupBox1.Controls.Add(rdoCom)
        GroupBox1.Controls.Add(rdoAcc)
        GroupBox1.Location = New Point(32, 125)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 125)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Department"
        ' 
        ' rdoPro
        ' 
        rdoPro.AutoSize = True
        rdoPro.Location = New Point(32, 95)
        rdoPro.Name = "rdoPro"
        rdoPro.Size = New Size(94, 24)
        rdoPro.TabIndex = 2
        rdoPro.TabStop = True
        rdoPro.Text = "Pro (15%)"
        rdoPro.UseVisualStyleBackColor = True
        ' 
        ' rdoCom
        ' 
        rdoCom.AutoSize = True
        rdoCom.Location = New Point(32, 65)
        rdoCom.Name = "rdoCom"
        rdoCom.Size = New Size(103, 24)
        rdoCom.TabIndex = 1
        rdoCom.TabStop = True
        rdoCom.Text = "Com (10%)"
        rdoCom.UseVisualStyleBackColor = True
        ' 
        ' rdoAcc
        ' 
        rdoAcc.AutoSize = True
        rdoAcc.Location = New Point(32, 39)
        rdoAcc.Name = "rdoAcc"
        rdoAcc.Size = New Size(88, 24)
        rdoAcc.TabIndex = 0
        rdoAcc.TabStop = True
        rdoAcc.Text = "Acc (5%)"
        rdoAcc.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(495, 149)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(94, 29)
        btnCalculate.TabIndex = 7
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnExits
        ' 
        btnExits.Location = New Point(495, 206)
        btnExits.Name = "btnExits"
        btnExits.Size = New Size(94, 29)
        btnExits.TabIndex = 8
        btnExits.Text = "Exit"
        btnExits.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(620, 450)
        Controls.Add(btnExits)
        Controls.Add(btnCalculate)
        Controls.Add(GroupBox1)
        Controls.Add(txtNS)
        Controls.Add(txtBS)
        Controls.Add(txtNo)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtBS As TextBox
    Friend WithEvents txtNS As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoPro As RadioButton
    Friend WithEvents rdoCom As RadioButton
    Friend WithEvents rdoAcc As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExits As Button
End Class
