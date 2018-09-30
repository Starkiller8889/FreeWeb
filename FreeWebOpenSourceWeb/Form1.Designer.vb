<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Back = New System.Windows.Forms.Button()
        Me.Forward = New System.Windows.Forms.Button()
        Me.Refresh = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.go = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(2, 117)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1347, 613)
        Me.WebBrowser1.TabIndex = 0
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(12, 61)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(50, 50)
        Me.Back.TabIndex = 1
        Me.Back.Text = "<<<"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Forward
        '
        Me.Forward.Location = New System.Drawing.Point(68, 61)
        Me.Forward.Name = "Forward"
        Me.Forward.Size = New System.Drawing.Size(50, 50)
        Me.Forward.TabIndex = 2
        Me.Forward.Text = ">>>"
        Me.Forward.UseVisualStyleBackColor = True
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(124, 61)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(50, 50)
        Me.Refresh.TabIndex = 3
        Me.Refresh.Text = "↷"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(180, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 50)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "⌂"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(236, 61)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1048, 50)
        Me.TextBox1.TabIndex = 5
        '
        'go
        '
        Me.go.Location = New System.Drawing.Point(1290, 5)
        Me.go.Name = "go"
        Me.go.Size = New System.Drawing.Size(50, 50)
        Me.go.TabIndex = 6
        Me.go.Text = "Go!"
        Me.go.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Settings"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1290, 61)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 50)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 729)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.go)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.Forward)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.Text = "FreeWeb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Back As Button
    Friend WithEvents Forward As Button
    Friend WithEvents Refresh As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents go As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
