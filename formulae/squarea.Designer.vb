<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class squarea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(squarea))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.b = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ansP = New System.Windows.Forms.Label()
        Me.perrimeter = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(348, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 32)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "a"
        '
        'b
        '
        Me.b.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.b.Font = New System.Drawing.Font("Rockwell", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b.ForeColor = System.Drawing.Color.White
        Me.b.Location = New System.Drawing.Point(354, 142)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(119, 120)
        Me.b.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(470, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 32)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "2"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.formulae.My.Resources.Resources.square
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(310, 298)
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'ansP
        '
        Me.ansP.AutoSize = True
        Me.ansP.Font = New System.Drawing.Font("Rockwell", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ansP.ForeColor = System.Drawing.Color.White
        Me.ansP.Location = New System.Drawing.Point(345, 350)
        Me.ansP.Name = "ansP"
        Me.ansP.Size = New System.Drawing.Size(65, 54)
        Me.ansP.TabIndex = 44
        Me.ansP.Text = "..."
        '
        'perrimeter
        '
        Me.perrimeter.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.perrimeter.ForeColor = System.Drawing.Color.White
        Me.perrimeter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.perrimeter.Location = New System.Drawing.Point(354, 273)
        Me.perrimeter.Name = "perrimeter"
        Me.perrimeter.Size = New System.Drawing.Size(185, 60)
        Me.perrimeter.TabIndex = 43
        Me.perrimeter.Text = "Area"
        Me.perrimeter.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ForeColor = System.Drawing.Color.White
        Me.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.back.Location = New System.Drawing.Point(-11, -12)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(143, 60)
        Me.back.TabIndex = 42
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(276, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 39)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Area Of Square"
        '
        'squarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ansP)
        Me.Controls.Add(Me.perrimeter)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "squarea"
        Me.Text = "Area Square"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents b As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ansP As Label
    Friend WithEvents perrimeter As Button
    Friend WithEvents back As Button
    Friend WithEvents Label1 As Label
End Class
