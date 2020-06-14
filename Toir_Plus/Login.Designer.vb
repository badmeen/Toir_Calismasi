<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Form1))
        Me.Buton_Hwid = New System.Windows.Forms.Button()
        Me.Label_Key = New System.Windows.Forms.Label()
        Me.Buton_Start = New System.Windows.Forms.Button()
        Me.Text_Licence = New System.Windows.Forms.TextBox()
        Me.Box_Status1 = New System.Windows.Forms.RichTextBox()
        Me.Box_Status2 = New System.Windows.Forms.RichTextBox()
        Me.Text_Hwid = New System.Windows.Forms.TextBox()
        Me.Timer_Login = New System.Windows.Forms.Timer(Me.components)
        Me.Text_Status = New System.Windows.Forms.TextBox()
        Me.Box_Space2 = New System.Windows.Forms.PictureBox()
        Me.Box_Space1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.Box_Space2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Box_Space1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Buton_Hwid
        '
        Me.Buton_Hwid.Enabled = False
        Me.Buton_Hwid.Location = New System.Drawing.Point(306, 59)
        Me.Buton_Hwid.Name = "Buton_Hwid"
        Me.Buton_Hwid.Size = New System.Drawing.Size(10, 10)
        Me.Buton_Hwid.TabIndex = 0
        Me.Buton_Hwid.Text = "HWID RESET"
        Me.Buton_Hwid.UseVisualStyleBackColor = True
        Me.Buton_Hwid.Visible = False
        '
        'Label_Key
        '
        Me.Label_Key.AutoSize = True
        Me.Label_Key.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label_Key.Location = New System.Drawing.Point(279, 65)
        Me.Label_Key.Name = "Label_Key"
        Me.Label_Key.Size = New System.Drawing.Size(54, 15)
        Me.Label_Key.TabIndex = 1
        Me.Label_Key.Text = "..::KEY::.."
        Me.Label_Key.Visible = False
        '
        'Buton_Start
        '
        Me.Buton_Start.Location = New System.Drawing.Point(291, 76)
        Me.Buton_Start.Name = "Buton_Start"
        Me.Buton_Start.Size = New System.Drawing.Size(10, 10)
        Me.Buton_Start.TabIndex = 2
        Me.Buton_Start.Text = "START"
        Me.Buton_Start.UseVisualStyleBackColor = True
        Me.Buton_Start.Visible = False
        '
        'Text_Licence
        '
        Me.Text_Licence.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Text_Licence.Location = New System.Drawing.Point(297, 51)
        Me.Text_Licence.Name = "Text_Licence"
        Me.Text_Licence.Size = New System.Drawing.Size(21, 24)
        Me.Text_Licence.TabIndex = 3
        Me.Text_Licence.Visible = False
        '
        'Box_Status1
        '
        Me.Box_Status1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Box_Status1.BackColor = System.Drawing.SystemColors.Control
        Me.Box_Status1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Box_Status1.Enabled = False
        Me.Box_Status1.Location = New System.Drawing.Point(301, -53)
        Me.Box_Status1.Name = "Box_Status1"
        Me.Box_Status1.Size = New System.Drawing.Size(0, 10)
        Me.Box_Status1.TabIndex = 7
        Me.Box_Status1.Text = ""
        Me.Box_Status1.Visible = False
        '
        'Box_Status2
        '
        Me.Box_Status2.BackColor = System.Drawing.SystemColors.Control
        Me.Box_Status2.Enabled = False
        Me.Box_Status2.Location = New System.Drawing.Point(292, 75)
        Me.Box_Status2.Name = "Box_Status2"
        Me.Box_Status2.Size = New System.Drawing.Size(10, 10)
        Me.Box_Status2.TabIndex = 9
        Me.Box_Status2.Text = ""
        Me.Box_Status2.Visible = False
        '
        'Text_Hwid
        '
        Me.Text_Hwid.Enabled = False
        Me.Text_Hwid.Location = New System.Drawing.Point(0, 0)
        Me.Text_Hwid.Name = "Text_Hwid"
        Me.Text_Hwid.Size = New System.Drawing.Size(0, 20)
        Me.Text_Hwid.TabIndex = 10
        Me.Text_Hwid.Visible = False
        '
        'Timer_Login
        '
        '
        'Text_Status
        '
        Me.Text_Status.Enabled = False
        Me.Text_Status.Location = New System.Drawing.Point(292, 65)
        Me.Text_Status.Name = "Text_Status"
        Me.Text_Status.Size = New System.Drawing.Size(10, 20)
        Me.Text_Status.TabIndex = 11
        Me.Text_Status.Visible = False
        '
        'Box_Space2
        '
        Me.Box_Space2.BackColor = System.Drawing.Color.Transparent
        Me.Box_Space2.Image = Global.Toir_Plus.My.Resources.Resources.V1
        Me.Box_Space2.Location = New System.Drawing.Point(297, 80)
        Me.Box_Space2.Name = "Box_Space2"
        Me.Box_Space2.Size = New System.Drawing.Size(10, 10)
        Me.Box_Space2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Box_Space2.TabIndex = 8
        Me.Box_Space2.TabStop = False
        Me.Box_Space2.Visible = False
        '
        'Box_Space1
        '
        Me.Box_Space1.BackColor = System.Drawing.Color.Transparent
        Me.Box_Space1.Image = Global.Toir_Plus.My.Resources.Resources.V1
        Me.Box_Space1.Location = New System.Drawing.Point(299, 84)
        Me.Box_Space1.Name = "Box_Space1"
        Me.Box_Space1.Size = New System.Drawing.Size(16, 10)
        Me.Box_Space1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Box_Space1.TabIndex = 6
        Me.Box_Space1.TabStop = False
        Me.Box_Space1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 40)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "CHANGE "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(191, 40)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "INJECT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Login_Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 112)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Text_Status)
        Me.Controls.Add(Me.Text_Hwid)
        Me.Controls.Add(Me.Box_Status2)
        Me.Controls.Add(Me.Box_Space2)
        Me.Controls.Add(Me.Box_Status1)
        Me.Controls.Add(Me.Box_Space1)
        Me.Controls.Add(Me.Text_Licence)
        Me.Controls.Add(Me.Buton_Start)
        Me.Controls.Add(Me.Label_Key)
        Me.Controls.Add(Me.Buton_Hwid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Login_Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOADER"
        CType(Me.Box_Space2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Box_Space1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Buton_Hwid As Button
    Friend WithEvents Label_Key As Label
    Friend WithEvents Buton_Start As Button
    Friend WithEvents Text_Licence As TextBox
    Friend WithEvents Box_Space1 As PictureBox
    Friend WithEvents Box_Status1 As RichTextBox
    Friend WithEvents Box_Space2 As PictureBox
    Friend WithEvents Box_Status2 As RichTextBox
    Friend WithEvents Text_Hwid As TextBox
    Friend WithEvents Timer_Login As Timer
    Friend WithEvents Text_Status As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
