<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRRequirement
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStudentNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAY = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLRN = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.cbStudentType = New System.Windows.Forms.ComboBox()
        Me.cbCourseSub = New System.Windows.Forms.ComboBox()
        Me.cbSemester1 = New System.Windows.Forms.ComboBox()
        Me.cbYRLVL = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(243, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 23)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Student Number"
        '
        'txtStudentNum
        '
        Me.txtStudentNum.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNum.Location = New System.Drawing.Point(247, 60)
        Me.txtStudentNum.MaxLength = 5
        Me.txtStudentNum.Multiline = True
        Me.txtStudentNum.Name = "txtStudentNum"
        Me.txtStudentNum.Size = New System.Drawing.Size(242, 40)
        Me.txtStudentNum.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(351, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Last Name"
        '
        'txtLN
        '
        Me.txtLN.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLN.Location = New System.Drawing.Point(355, 260)
        Me.txtLN.MaxLength = 20
        Me.txtLN.Multiline = True
        Me.txtLN.Name = "txtLN"
        Me.txtLN.Size = New System.Drawing.Size(242, 40)
        Me.txtLN.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(351, 327)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 23)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "First Name"
        '
        'txtFN
        '
        Me.txtFN.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFN.Location = New System.Drawing.Point(355, 353)
        Me.txtFN.MaxLength = 25
        Me.txtFN.Multiline = True
        Me.txtFN.Name = "txtFN"
        Me.txtFN.Size = New System.Drawing.Size(242, 40)
        Me.txtFN.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(351, 419)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 23)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Middle Name"
        '
        'txtMN
        '
        Me.txtMN.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMN.Location = New System.Drawing.Point(355, 445)
        Me.txtMN.MaxLength = 25
        Me.txtMN.Multiline = True
        Me.txtMN.Name = "txtMN"
        Me.txtMN.Size = New System.Drawing.Size(242, 40)
        Me.txtMN.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(519, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 23)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Academic Year"
        '
        'txtAY
        '
        Me.txtAY.Enabled = False
        Me.txtAY.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAY.Location = New System.Drawing.Point(523, 60)
        Me.txtAY.MaxLength = 9
        Me.txtAY.Multiline = True
        Me.txtAY.Name = "txtAY"
        Me.txtAY.ReadOnly = True
        Me.txtAY.Size = New System.Drawing.Size(242, 40)
        Me.txtAY.TabIndex = 29
        Me.txtAY.Text = "2023 - 2024"
        Me.txtAY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Silver
        Me.Label16.Location = New System.Drawing.Point(684, 333)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 23)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Course"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Silver
        Me.Label15.Location = New System.Drawing.Point(543, 125)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 23)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Year Level"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Silver
        Me.Label14.Location = New System.Drawing.Point(686, 234)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 23)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Student Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(792, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 23)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "LRN"
        '
        'txtLRN
        '
        Me.txtLRN.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLRN.Location = New System.Drawing.Point(796, 60)
        Me.txtLRN.MaxLength = 11
        Me.txtLRN.Multiline = True
        Me.txtLRN.Name = "txtLRN"
        Me.txtLRN.Size = New System.Drawing.Size(242, 40)
        Me.txtLRN.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(684, 422)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 23)
        Me.Label7.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(682, 422)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 23)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Semester"
        '
        'btnSubmit
        '
        Me.btnSubmit.BorderRadius = 15
        Me.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSubmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnSubmit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnSubmit.Location = New System.Drawing.Point(666, 585)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(186, 53)
        Me.btnSubmit.TabIndex = 63
        Me.btnSubmit.Text = "Submit"
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 15
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(439, 585)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(186, 53)
        Me.btnCancel.TabIndex = 64
        Me.btnCancel.Text = "Cancel"
        '
        'cbStudentType
        '
        Me.cbStudentType.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStudentType.FormattingEnabled = True
        Me.cbStudentType.Items.AddRange(New Object() {"New", "Old"})
        Me.cbStudentType.Location = New System.Drawing.Point(688, 260)
        Me.cbStudentType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbStudentType.Name = "cbStudentType"
        Me.cbStudentType.Size = New System.Drawing.Size(244, 35)
        Me.cbStudentType.TabIndex = 198
        Me.cbStudentType.Text = "New"
        '
        'cbCourseSub
        '
        Me.cbCourseSub.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCourseSub.FormattingEnabled = True
        Me.cbCourseSub.Items.AddRange(New Object() {"BSIT", "BSCS"})
        Me.cbCourseSub.Location = New System.Drawing.Point(688, 358)
        Me.cbCourseSub.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbCourseSub.Name = "cbCourseSub"
        Me.cbCourseSub.Size = New System.Drawing.Size(242, 35)
        Me.cbCourseSub.TabIndex = 199
        Me.cbCourseSub.Text = "BSIT"
        '
        'cbSemester1
        '
        Me.cbSemester1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSemester1.FormattingEnabled = True
        Me.cbSemester1.Items.AddRange(New Object() {"1st Semester", "2nd Semester"})
        Me.cbSemester1.Location = New System.Drawing.Point(686, 448)
        Me.cbSemester1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbSemester1.Name = "cbSemester1"
        Me.cbSemester1.Size = New System.Drawing.Size(244, 35)
        Me.cbSemester1.TabIndex = 200
        Me.cbSemester1.Text = "1st Semester"
        '
        'cbYRLVL
        '
        Me.cbYRLVL.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbYRLVL.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cbYRLVL.Location = New System.Drawing.Point(545, 150)
        Me.cbYRLVL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbYRLVL.Name = "cbYRLVL"
        Me.cbYRLVL.Size = New System.Drawing.Size(196, 35)
        Me.cbYRLVL.TabIndex = 201
        Me.cbYRLVL.Text = "1st Year"
        '
        'frmRRequirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1258, 875)
        Me.Controls.Add(Me.cbYRLVL)
        Me.Controls.Add(Me.cbSemester1)
        Me.Controls.Add(Me.cbCourseSub)
        Me.Controls.Add(Me.cbStudentType)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLRN)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAY)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtStudentNum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRRequirement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAssessment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txtStudentNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAY As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLRN As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbStudentType As ComboBox
    Friend WithEvents cbCourseSub As ComboBox
    Friend WithEvents cbSemester1 As ComboBox
    Private WithEvents cbYRLVL As ComboBox
End Class
