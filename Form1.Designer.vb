<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.cmdBalls = New System.Windows.Forms.Button()
        Me.lblBalls = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdBalls
        '
        Me.cmdBalls.Location = New System.Drawing.Point(59, 104)
        Me.cmdBalls.Name = "cmdBalls"
        Me.cmdBalls.Size = New System.Drawing.Size(94, 29)
        Me.cmdBalls.TabIndex = 0
        Me.cmdBalls.Text = "Get Balls"
        Me.cmdBalls.UseVisualStyleBackColor = True
        '
        'lblBalls
        '
        Me.lblBalls.Location = New System.Drawing.Point(179, 104)
        Me.lblBalls.Name = "lblBalls"
        Me.lblBalls.Size = New System.Drawing.Size(161, 29)
        Me.lblBalls.TabIndex = 1
        Me.lblBalls.Text = " "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 256)
        Me.Controls.Add(Me.lblBalls)
        Me.Controls.Add(Me.cmdBalls)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdBalls As Button
    Friend WithEvents lblBalls As Label
End Class
