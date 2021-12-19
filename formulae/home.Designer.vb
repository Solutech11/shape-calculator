<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.perimeter = New System.Windows.Forms.Button()
        Me.Area = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'perimeter
        '
        Me.perimeter.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.perimeter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.perimeter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.perimeter.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.perimeter.ForeColor = System.Drawing.Color.White
        Me.perimeter.Location = New System.Drawing.Point(-5, 0)
        Me.perimeter.Name = "perimeter"
        Me.perimeter.Size = New System.Drawing.Size(819, 228)
        Me.perimeter.TabIndex = 0
        Me.perimeter.Text = "Perimeter"
        Me.perimeter.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.perimeter.UseVisualStyleBackColor = False
        '
        'Area
        '
        Me.Area.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Area.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Area.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Area.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Area.ForeColor = System.Drawing.Color.White
        Me.Area.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Area.Location = New System.Drawing.Point(-5, 224)
        Me.Area.Name = "Area"
        Me.Area.Size = New System.Drawing.Size(819, 229)
        Me.Area.TabIndex = 1
        Me.Area.Text = "Area"
        Me.Area.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Area.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(314, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 86)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Shape " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calculator"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(757, 203)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Exit"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Area)
        Me.Controls.Add(Me.perimeter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "home"
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents perimeter As Button
    Friend WithEvents Area As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
