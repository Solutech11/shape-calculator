<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cylinderp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cylinderp))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ansP = New System.Windows.Forms.Label()
        Me.perrimeter = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.inpr = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.inph = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(253, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 32)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "h"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(164, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 32)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "r"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(713, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 32)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "h"
        '
        'ansP
        '
        Me.ansP.AutoSize = True
        Me.ansP.Font = New System.Drawing.Font("Rockwell", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ansP.ForeColor = System.Drawing.Color.White
        Me.ansP.Location = New System.Drawing.Point(305, 334)
        Me.ansP.Name = "ansP"
        Me.ansP.Size = New System.Drawing.Size(65, 54)
        Me.ansP.TabIndex = 64
        Me.ansP.Text = "..."
        '
        'perrimeter
        '
        Me.perrimeter.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.perrimeter.ForeColor = System.Drawing.Color.White
        Me.perrimeter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.perrimeter.Location = New System.Drawing.Point(304, 266)
        Me.perrimeter.Name = "perrimeter"
        Me.perrimeter.Size = New System.Drawing.Size(185, 60)
        Me.perrimeter.TabIndex = 63
        Me.perrimeter.Text = "perimeter"
        Me.perrimeter.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ForeColor = System.Drawing.Color.White
        Me.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.back.Location = New System.Drawing.Point(-11, -10)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(143, 60)
        Me.back.TabIndex = 62
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(243, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 39)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Perimeter Of Cylinder"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.formulae.My.Resources.Resources.cylinder
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 298)
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.formulae.My.Resources.Resources.line
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.formulae.My.Resources.Resources.line
        Me.PictureBox2.Location = New System.Drawing.Point(133, 110)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 17)
        Me.PictureBox2.TabIndex = 78
        Me.PictureBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(417, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 32)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "r"
        '
        'inpr
        '
        Me.inpr.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.inpr.Font = New System.Drawing.Font("Rockwell", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inpr.ForeColor = System.Drawing.Color.White
        Me.inpr.Location = New System.Drawing.Point(423, 140)
        Me.inpr.Name = "inpr"
        Me.inpr.Size = New System.Drawing.Size(69, 120)
        Me.inpr.TabIndex = 80
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(286, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 106)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "2π"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(485, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 39)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(498, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 39)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "+"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Rockwell", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(527, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(157, 106)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "2π"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(664, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 106)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "r"
        '
        'inph
        '
        Me.inph.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.inph.Font = New System.Drawing.Font("Rockwell", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inph.ForeColor = System.Drawing.Color.White
        Me.inph.Location = New System.Drawing.Point(719, 136)
        Me.inph.Name = "inph"
        Me.inph.Size = New System.Drawing.Size(69, 120)
        Me.inph.TabIndex = 86
        '
        'cylinderp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.inph)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.inpr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ansP)
        Me.Controls.Add(Me.perrimeter)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "cylinderp"
        Me.Text = "Perimeter Cylinder"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ansP As Label
    Friend WithEvents perrimeter As Button
    Friend WithEvents back As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents inpr As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents inph As TextBox
End Class
