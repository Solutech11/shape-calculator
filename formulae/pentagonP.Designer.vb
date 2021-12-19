<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pentagonP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pentagonP))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ansP = New System.Windows.Forms.Label()
        Me.ans = New System.Windows.Forms.Label()
        Me.perrimeter = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.screens = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(249, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 32)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "a"
        '
        'ansP
        '
        Me.ansP.AutoSize = True
        Me.ansP.Font = New System.Drawing.Font("Rockwell", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ansP.ForeColor = System.Drawing.Color.White
        Me.ansP.Location = New System.Drawing.Point(329, 347)
        Me.ansP.Name = "ansP"
        Me.ansP.Size = New System.Drawing.Size(65, 54)
        Me.ansP.TabIndex = 66
        Me.ansP.Text = "..."
        '
        'ans
        '
        Me.ans.AutoSize = True
        Me.ans.Font = New System.Drawing.Font("Rockwell", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ans.ForeColor = System.Drawing.Color.White
        Me.ans.Location = New System.Drawing.Point(405, 347)
        Me.ans.Name = "ans"
        Me.ans.Size = New System.Drawing.Size(0, 54)
        Me.ans.TabIndex = 65
        '
        'perrimeter
        '
        Me.perrimeter.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.perrimeter.ForeColor = System.Drawing.Color.White
        Me.perrimeter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.perrimeter.Location = New System.Drawing.Point(338, 284)
        Me.perrimeter.Name = "perrimeter"
        Me.perrimeter.Size = New System.Drawing.Size(185, 60)
        Me.perrimeter.TabIndex = 64
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
        Me.Label1.Location = New System.Drawing.Point(218, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 39)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Perimeter Of Pentagon"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.formulae.My.Resources.Resources.pentagon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(286, 311)
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(389, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 32)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "a"
        '
        'screens
        '
        Me.screens.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.screens.Font = New System.Drawing.Font("Rockwell", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.screens.ForeColor = System.Drawing.Color.White
        Me.screens.Location = New System.Drawing.Point(395, 144)
        Me.screens.Name = "screens"
        Me.screens.Size = New System.Drawing.Size(353, 120)
        Me.screens.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(320, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 106)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "5"
        '
        'pentagonP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.screens)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ansP)
        Me.Controls.Add(Me.ans)
        Me.Controls.Add(Me.perrimeter)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pentagonP"
        Me.Text = "Perimeter Pentagon"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ansP As Label
    Friend WithEvents ans As Label
    Friend WithEvents perrimeter As Button
    Friend WithEvents back As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents screens As TextBox
    Friend WithEvents Label3 As Label
End Class
