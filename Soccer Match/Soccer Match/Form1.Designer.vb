<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSoccerMatch
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTickets = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkFoodHamper = New System.Windows.Forms.CheckBox()
        Me.chkVuvuzela = New System.Windows.Forms.CheckBox()
        Me.chkBeanie = New System.Windows.Forms.CheckBox()
        Me.chkSurprisePack = New System.Windows.Forms.CheckBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 128)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Soccer Match" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Coca-Cola Park" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "England vs France" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "20 April 2010"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(626, 134)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Only R 500" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pre-Match refreshments" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Join us in the Manzi Travel Agency Company Su" & _
    "it"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(208, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of Tickets:"
        '
        'txtTickets
        '
        Me.txtTickets.Location = New System.Drawing.Point(355, 261)
        Me.txtTickets.Name = "txtTickets"
        Me.txtTickets.Size = New System.Drawing.Size(100, 20)
        Me.txtTickets.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkSurprisePack)
        Me.GroupBox1.Controls.Add(Me.chkBeanie)
        Me.GroupBox1.Controls.Add(Me.chkVuvuzela)
        Me.GroupBox1.Controls.Add(Me.chkFoodHamper)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 287)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(626, 116)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Optional Items"
        '
        'chkFoodHamper
        '
        Me.chkFoodHamper.AutoSize = True
        Me.chkFoodHamper.Location = New System.Drawing.Point(42, 37)
        Me.chkFoodHamper.Name = "chkFoodHamper"
        Me.chkFoodHamper.Size = New System.Drawing.Size(178, 24)
        Me.chkFoodHamper.TabIndex = 0
        Me.chkFoodHamper.Text = "Food Hamper - R120"
        Me.chkFoodHamper.UseVisualStyleBackColor = True
        '
        'chkVuvuzela
        '
        Me.chkVuvuzela.AutoSize = True
        Me.chkVuvuzela.Location = New System.Drawing.Point(42, 76)
        Me.chkVuvuzela.Name = "chkVuvuzela"
        Me.chkVuvuzela.Size = New System.Drawing.Size(136, 24)
        Me.chkVuvuzela.TabIndex = 1
        Me.chkVuvuzela.Text = "Vuvuzela - R50"
        Me.chkVuvuzela.UseVisualStyleBackColor = True
        '
        'chkBeanie
        '
        Me.chkBeanie.AutoSize = True
        Me.chkBeanie.Location = New System.Drawing.Point(335, 37)
        Me.chkBeanie.Name = "chkBeanie"
        Me.chkBeanie.Size = New System.Drawing.Size(233, 24)
        Me.chkBeanie.TabIndex = 2
        Me.chkBeanie.Text = "Red Coca-Cola Beanie - R80"
        Me.chkBeanie.UseVisualStyleBackColor = True
        '
        'chkSurprisePack
        '
        Me.chkSurprisePack.AutoSize = True
        Me.chkSurprisePack.Location = New System.Drawing.Point(335, 76)
        Me.chkSurprisePack.Name = "chkSurprisePack"
        Me.chkSurprisePack.Size = New System.Drawing.Size(264, 24)
        Me.chkSurprisePack.TabIndex = 3
        Me.chkSurprisePack.Text = "Memorabila Surprise Pack - R250"
        Me.chkSurprisePack.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(62, 409)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "C&alculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(513, 409)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(274, 409)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(20, 477)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(626, 67)
        Me.lblResult.TabIndex = 8
        Me.lblResult.Text = "The total due is:"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmSoccerMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 553)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTickets)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmSoccerMatch"
        Me.Text = "Soccer Match"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTickets As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSurprisePack As System.Windows.Forms.CheckBox
    Friend WithEvents chkBeanie As System.Windows.Forms.CheckBox
    Friend WithEvents chkVuvuzela As System.Windows.Forms.CheckBox
    Friend WithEvents chkFoodHamper As System.Windows.Forms.CheckBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
