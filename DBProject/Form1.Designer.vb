<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class auth
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox_UN = New System.Windows.Forms.TextBox()
        Me.TextBox_DB = New System.Windows.Forms.TextBox()
        Me.TextBox_Pwd = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = Global.DBProject.My.Resources.Resources.cooltext1836774822
        Me.Button1.Location = New System.Drawing.Point(585, 577)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(455, 86)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(270, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(270, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Database"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DBProject.My.Resources.Resources.cooltext1836750849
        Me.PictureBox1.Location = New System.Drawing.Point(68, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(651, 88)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'TextBox_UN
        '
        Me.TextBox_UN.BackColor = System.Drawing.SystemColors.Highlight
        Me.TextBox_UN.Location = New System.Drawing.Point(377, 133)
        Me.TextBox_UN.Name = "TextBox_UN"
        Me.TextBox_UN.Size = New System.Drawing.Size(239, 20)
        Me.TextBox_UN.TabIndex = 5
        '
        'TextBox_DB
        '
        Me.TextBox_DB.BackColor = System.Drawing.SystemColors.Highlight
        Me.TextBox_DB.Location = New System.Drawing.Point(377, 294)
        Me.TextBox_DB.Name = "TextBox_DB"
        Me.TextBox_DB.Size = New System.Drawing.Size(239, 20)
        Me.TextBox_DB.TabIndex = 6
        '
        'TextBox_Pwd
        '
        Me.TextBox_Pwd.BackColor = System.Drawing.SystemColors.Highlight
        Me.TextBox_Pwd.Location = New System.Drawing.Point(377, 216)
        Me.TextBox_Pwd.Name = "TextBox_Pwd"
        Me.TextBox_Pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(64)
        Me.TextBox_Pwd.Size = New System.Drawing.Size(239, 20)
        Me.TextBox_Pwd.TabIndex = 7
        '
        'auth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DBProject.My.Resources.Resources.harbor_ship_sea_mast_water_pirate_boat_sailboat
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1419, 675)
        Me.Controls.Add(Me.TextBox_Pwd)
        Me.Controls.Add(Me.TextBox_DB)
        Me.Controls.Add(Me.TextBox_UN)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "auth"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox_UN As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_DB As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Pwd As System.Windows.Forms.TextBox
End Class
