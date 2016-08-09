<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_lo = New System.Windows.Forms.Button
        Me.btn_wv = New System.Windows.Forms.Button
        Me.btn_ow = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_lo
        '
        Me.btn_lo.Image = Global.OpenDoc.My.Resources.Resources.lo
        Me.btn_lo.Location = New System.Drawing.Point(12, 12)
        Me.btn_lo.Name = "btn_lo"
        Me.btn_lo.Size = New System.Drawing.Size(79, 79)
        Me.btn_lo.TabIndex = 0
        Me.btn_lo.UseVisualStyleBackColor = True
        '
        'btn_wv
        '
        Me.btn_wv.Image = Global.OpenDoc.My.Resources.Resources.wv
        Me.btn_wv.Location = New System.Drawing.Point(117, 12)
        Me.btn_wv.Name = "btn_wv"
        Me.btn_wv.Size = New System.Drawing.Size(79, 79)
        Me.btn_wv.TabIndex = 1
        Me.btn_wv.UseVisualStyleBackColor = True
        '
        'btn_ow
        '
        Me.btn_ow.Image = Global.OpenDoc.My.Resources.Resources.ow
        Me.btn_ow.Location = New System.Drawing.Point(223, 12)
        Me.btn_ow.Name = "btn_ow"
        Me.btn_ow.Size = New System.Drawing.Size(79, 79)
        Me.btn_ow.TabIndex = 2
        Me.btn_ow.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Libre Office"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Word Viewer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(229, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Office Word"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 113)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_ow)
        Me.Controls.Add(Me.btn_wv)
        Me.Controls.Add(Me.btn_lo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ouvrir le DOC avec..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_lo As System.Windows.Forms.Button
    Friend WithEvents btn_wv As System.Windows.Forms.Button
    Friend WithEvents btn_ow As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
