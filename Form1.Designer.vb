<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoAddition = New System.Windows.Forms.RadioButton()
        Me.rdoSubtraction = New System.Windows.Forms.RadioButton()
        Me.rdoMultiplication = New System.Windows.Forms.RadioButton()
        Me.rdoDivision = New System.Windows.Forms.RadioButton()
        Me.LblNum1 = New System.Windows.Forms.Label()
        Me.LblNum2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoDivision)
        Me.GroupBox1.Controls.Add(Me.rdoMultiplication)
        Me.GroupBox1.Controls.Add(Me.rdoSubtraction)
        Me.GroupBox1.Controls.Add(Me.rdoAddition)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(625, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 169)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operation "
        '
        'rdoAddition
        '
        Me.rdoAddition.AutoSize = True
        Me.rdoAddition.Location = New System.Drawing.Point(6, 36)
        Me.rdoAddition.Name = "rdoAddition"
        Me.rdoAddition.Size = New System.Drawing.Size(98, 24)
        Me.rdoAddition.TabIndex = 0
        Me.rdoAddition.TabStop = True
        Me.rdoAddition.Text = "Addition"
        Me.rdoAddition.UseVisualStyleBackColor = True
        '
        'rdoSubtraction
        '
        Me.rdoSubtraction.AutoSize = True
        Me.rdoSubtraction.Location = New System.Drawing.Point(6, 63)
        Me.rdoSubtraction.Name = "rdoSubtraction"
        Me.rdoSubtraction.Size = New System.Drawing.Size(126, 24)
        Me.rdoSubtraction.TabIndex = 1
        Me.rdoSubtraction.TabStop = True
        Me.rdoSubtraction.Text = "Subtraction"
        Me.rdoSubtraction.UseVisualStyleBackColor = True
        '
        'rdoMultiplication
        '
        Me.rdoMultiplication.AutoSize = True
        Me.rdoMultiplication.Location = New System.Drawing.Point(6, 90)
        Me.rdoMultiplication.Name = "rdoMultiplication"
        Me.rdoMultiplication.Size = New System.Drawing.Size(142, 24)
        Me.rdoMultiplication.TabIndex = 2
        Me.rdoMultiplication.TabStop = True
        Me.rdoMultiplication.Text = "Multiplication"
        Me.rdoMultiplication.UseVisualStyleBackColor = True
        '
        'rdoDivision
        '
        Me.rdoDivision.AutoSize = True
        Me.rdoDivision.Location = New System.Drawing.Point(7, 117)
        Me.rdoDivision.Name = "rdoDivision"
        Me.rdoDivision.Size = New System.Drawing.Size(98, 24)
        Me.rdoDivision.TabIndex = 3
        Me.rdoDivision.TabStop = True
        Me.rdoDivision.Text = "Division"
        Me.rdoDivision.UseVisualStyleBackColor = True
        '
        'LblNum1
        '
        Me.LblNum1.AutoSize = True
        Me.LblNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNum1.Location = New System.Drawing.Point(314, 93)
        Me.LblNum1.Name = "LblNum1"
        Me.LblNum1.Size = New System.Drawing.Size(87, 20)
        Me.LblNum1.TabIndex = 2
        Me.LblNum1.Text = "Number 1:"
        '
        'LblNum2
        '
        Me.LblNum2.AutoSize = True
        Me.LblNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNum2.Location = New System.Drawing.Point(313, 143)
        Me.LblNum2.Name = "LblNum2"
        Me.LblNum2.Size = New System.Drawing.Size(87, 20)
        Me.LblNum2.TabIndex = 3
        Me.LblNum2.Text = "Number 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(316, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Answer:"
        '
        'lblResult
        '
        Me.lblResult.Location = New System.Drawing.Point(316, 242)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(314, 80)
        Me.lblResult.TabIndex = 0
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(317, 116)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 22)
        Me.txtNum1.TabIndex = 0
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(317, 170)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 22)
        Me.txtNum2.TabIndex = 0
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(303, 325)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(98, 33)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(276, 485)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(303, 374)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 34)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(426, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 32)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Simple Calculator"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(679, 375)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 33)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblNum2)
        Me.Controls.Add(Me.LblNum1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Calculator App"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoDivision As RadioButton
    Friend WithEvents rdoMultiplication As RadioButton
    Friend WithEvents rdoSubtraction As RadioButton
    Friend WithEvents rdoAddition As RadioButton
    Friend WithEvents LblNum1 As Label
    Friend WithEvents LblNum2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnExit As Button
End Class
