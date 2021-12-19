<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class trperi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(trperi))
        Me.ansP = New System.Windows.Forms.Label()
        Me.ans = New System.Windows.Forms.Label()
        Me.perrimeter = New System.Windows.Forms.Button()
        Me.inpA = New System.Windows.Forms.TextBox()
        Me.back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.inpB = New System.Windows.Forms.TextBox()
        Me.inpC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ansP
        '
        Me.ansP.AutoSize = True
        Me.ansP.Font = New System.Drawing.Font("Rockwell", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ansP.ForeColor = System.Drawing.Color.White
        Me.ansP.Location = New System.Drawing.Point(345, 355)
        Me.ansP.Name = "ansP"
        Me.ansP.Size = New System.Drawing.Size(65, 54)
        Me.ansP.TabIndex = 28
        Me.ansP.Text = "..."
        '
        'ans
        '
        Me.ans.AutoSize = True
        Me.ans.Font = New System.Drawing.Font("Rockwell", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ans.ForeColor = System.Drawing.Color.White
        Me.ans.Location = New System.Drawing.Point(442, 341)
        Me.ans.Name = "ans"
        Me.ans.Size = New System.Drawing.Size(0, 54)
        Me.ans.TabIndex = 27
        '
        'perrimeter
        '
        Me.perrimeter.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.perrimeter.ForeColor = System.Drawing.Color.White
        Me.perrimeter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.perrimeter.Location = New System.Drawing.Point(354, 278)
        Me.perrimeter.Name = "perrimeter"
        Me.perrimeter.Size = New System.Drawing.Size(185, 60)
        Me.perrimeter.TabIndex = 26
        Me.perrimeter.Text = "perimeter"
        Me.perrimeter.UseVisualStyleBackColor = True
        '
        'inpA
        '
        Me.inpA.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.inpA.Font = New System.Drawing.Font("Rockwell", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inpA.ForeColor = System.Drawing.Color.White
        Me.inpA.Location = New System.Drawing.Point(354, 126)
        Me.inpA.Name = "inpA"
        Me.inpA.Size = New System.Drawing.Size(82, 120)
        Me.inpA.TabIndex = 25
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ForeColor = System.Drawing.Color.White
        Me.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.back.Location = New System.Drawing.Point(-11, -7)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(143, 60)
        Me.back.TabIndex = 20
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(218, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 39)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Perimeter Of Triangle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 32)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "a"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(230, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 32)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "c"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(137, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 32)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "b"
        '
        'inpB
        '
        Me.inpB.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.inpB.Font = New System.Drawing.Font("Rockwell", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inpB.ForeColor = System.Drawing.Color.White
        Me.inpB.Location = New System.Drawing.Point(494, 126)
        Me.inpB.Name = "inpB"
        Me.inpB.Size = New System.Drawing.Size(82, 120)
        Me.inpB.TabIndex = 33
        '
        'inpC
        '
        Me.inpC.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.inpC.Font = New System.Drawing.Font("Rockwell", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inpC.ForeColor = System.Drawing.Color.White
        Me.inpC.Location = New System.Drawing.Point(629, 126)
        Me.inpC.Name = "inpC"
        Me.inpC.Size = New System.Drawing.Size(82, 120)
        Me.inpC.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(448, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 39)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "+"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(583, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 39)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "+"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(623, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 32)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "c"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(488, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 32)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "b"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(348, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 32)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "a"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.formulae.My.Resources.Resources.triangle
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(286, 245)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'trperi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.inpC)
        Me.Controls.Add(Me.inpB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ansP)
        Me.Controls.Add(Me.ans)
        Me.Controls.Add(Me.perrimeter)
        Me.Controls.Add(Me.inpA)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "trperi"
        Me.Text = "Perimeter Triangle"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ansP As Label
    Friend WithEvents ans As Label
    Friend WithEvents perrimeter As Button
    Friend WithEvents inpA As TextBox
    Friend WithEvents back As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents inpB As TextBox
    Friend WithEvents inpC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
