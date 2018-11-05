<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Upload
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Upload))
        Me.showtag = New System.Windows.Forms.TextBox()
        Me.showname = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.showdesc = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.t0 = New System.Windows.Forms.Label()
        Me.t1 = New System.Windows.Forms.Label()
        Me.t2 = New System.Windows.Forms.Label()
        Me.t3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'showtag
        '
        Me.showtag.Location = New System.Drawing.Point(86, 307)
        Me.showtag.Name = "showtag"
        Me.showtag.Size = New System.Drawing.Size(100, 20)
        Me.showtag.TabIndex = 0
        '
        'showname
        '
        Me.showname.Location = New System.Drawing.Point(86, 55)
        Me.showname.Name = "showname"
        Me.showname.Size = New System.Drawing.Size(221, 20)
        Me.showname.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(145, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "UPLOAD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "YOU ARE UPLOADING:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "-"
        '
        'showdesc
        '
        Me.showdesc.Location = New System.Drawing.Point(86, 90)
        Me.showdesc.Name = "showdesc"
        Me.showdesc.Size = New System.Drawing.Size(221, 96)
        Me.showdesc.TabIndex = 6
        Me.showdesc.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Show Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 26)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Show" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Description:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Show Tags: "
        '
        't0
        '
        Me.t0.AutoSize = True
        Me.t0.Location = New System.Drawing.Point(86, 231)
        Me.t0.Name = "t0"
        Me.t0.Size = New System.Drawing.Size(10, 13)
        Me.t0.TabIndex = 10
        Me.t0.Text = "-"
        '
        't1
        '
        Me.t1.AutoSize = True
        Me.t1.Location = New System.Drawing.Point(86, 248)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(10, 13)
        Me.t1.TabIndex = 11
        Me.t1.Text = "-"
        '
        't2
        '
        Me.t2.AutoSize = True
        Me.t2.Location = New System.Drawing.Point(86, 265)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(10, 13)
        Me.t2.TabIndex = 12
        Me.t2.Text = "-"
        '
        't3
        '
        Me.t3.AutoSize = True
        Me.t3.Location = New System.Drawing.Point(86, 282)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(10, 13)
        Me.t3.TabIndex = 13
        Me.t3.Text = "-"
        '
        'Upload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 410)
        Me.Controls.Add(Me.t3)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.t0)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.showdesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.showname)
        Me.Controls.Add(Me.showtag)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Upload"
        Me.Text = "IRISLogger - Uploader Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents showtag As TextBox
    Friend WithEvents showname As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents showdesc As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents t0 As Label
    Friend WithEvents t1 As Label
    Friend WithEvents t2 As Label
    Friend WithEvents t3 As Label
End Class
