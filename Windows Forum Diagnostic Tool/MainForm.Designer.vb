<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.cmdDXDiag = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.cmdMGADiag = New System.Windows.Forms.Button()
        Me.cmdMSInfo32 = New System.Windows.Forms.Button()
        Me.cmdHosts = New System.Windows.Forms.Button()
        Me.cmdCPUZ = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdDXDiag
        '
        Me.cmdDXDiag.Location = New System.Drawing.Point(64, 36)
        Me.cmdDXDiag.Name = "cmdDXDiag"
        Me.cmdDXDiag.Size = New System.Drawing.Size(173, 96)
        Me.cmdDXDiag.TabIndex = 0
        Me.cmdDXDiag.Text = "DXDiag"
        Me.cmdDXDiag.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(30, 167)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(1263, 348)
        Me.txtOutput.TabIndex = 1
        '
        'cmdMGADiag
        '
        Me.cmdMGADiag.Location = New System.Drawing.Point(252, 36)
        Me.cmdMGADiag.Name = "cmdMGADiag"
        Me.cmdMGADiag.Size = New System.Drawing.Size(187, 96)
        Me.cmdMGADiag.TabIndex = 2
        Me.cmdMGADiag.Text = "MGADiag"
        Me.cmdMGADiag.UseVisualStyleBackColor = True
        '
        'cmdMSInfo32
        '
        Me.cmdMSInfo32.Location = New System.Drawing.Point(459, 36)
        Me.cmdMSInfo32.Name = "cmdMSInfo32"
        Me.cmdMSInfo32.Size = New System.Drawing.Size(175, 96)
        Me.cmdMSInfo32.TabIndex = 3
        Me.cmdMSInfo32.Text = "MSInfo32"
        Me.cmdMSInfo32.UseVisualStyleBackColor = True
        '
        'cmdHosts
        '
        Me.cmdHosts.Location = New System.Drawing.Point(654, 36)
        Me.cmdHosts.Name = "cmdHosts"
        Me.cmdHosts.Size = New System.Drawing.Size(177, 96)
        Me.cmdHosts.TabIndex = 4
        Me.cmdHosts.Text = "Hosts"
        Me.cmdHosts.UseVisualStyleBackColor = True
        '
        'cmdCPUZ
        '
        Me.cmdCPUZ.Location = New System.Drawing.Point(862, 36)
        Me.cmdCPUZ.Name = "cmdCPUZ"
        Me.cmdCPUZ.Size = New System.Drawing.Size(177, 96)
        Me.cmdCPUZ.TabIndex = 5
        Me.cmdCPUZ.Text = "CPU-Z"
        Me.cmdCPUZ.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1560, 699)
        Me.Controls.Add(Me.cmdCPUZ)
        Me.Controls.Add(Me.cmdHosts)
        Me.Controls.Add(Me.cmdMSInfo32)
        Me.Controls.Add(Me.cmdMGADiag)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.cmdDXDiag)
        Me.Name = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdDXDiag As Button
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents cmdMGADiag As Button
    Friend WithEvents cmdMSInfo32 As Button
    Friend WithEvents cmdHosts As Button
    Friend WithEvents cmdCPUZ As Button
End Class
