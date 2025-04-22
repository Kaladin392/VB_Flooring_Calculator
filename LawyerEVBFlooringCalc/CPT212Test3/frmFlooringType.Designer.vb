<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlooringType
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSqFtPerBoxOut = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstFlooringType = New System.Windows.Forms.ListBox()
        Me.btnExitWithSave = New System.Windows.Forms.Button()
        Me.btnExitNoSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSqFtPerBoxOut)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lstFlooringType)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select the type of flooring"
        '
        'lblSqFtPerBoxOut
        '
        Me.lblSqFtPerBoxOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSqFtPerBoxOut.Location = New System.Drawing.Point(277, 66)
        Me.lblSqFtPerBoxOut.Name = "lblSqFtPerBoxOut"
        Me.lblSqFtPerBoxOut.Size = New System.Drawing.Size(57, 19)
        Me.lblSqFtPerBoxOut.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Square Feet per Box:"
        '
        'lstFlooringType
        '
        Me.lstFlooringType.Location = New System.Drawing.Point(9, 20)
        Me.lstFlooringType.Name = "lstFlooringType"
        Me.lstFlooringType.Size = New System.Drawing.Size(143, 121)
        Me.lstFlooringType.TabIndex = 0
        '
        'btnExitWithSave
        '
        Me.btnExitWithSave.Location = New System.Drawing.Point(57, 209)
        Me.btnExitWithSave.Name = "btnExitWithSave"
        Me.btnExitWithSave.Size = New System.Drawing.Size(106, 23)
        Me.btnExitWithSave.TabIndex = 0
        Me.btnExitWithSave.Text = "&Save and Exit"
        Me.btnExitWithSave.UseVisualStyleBackColor = True
        '
        'btnExitNoSave
        '
        Me.btnExitNoSave.Location = New System.Drawing.Point(203, 209)
        Me.btnExitNoSave.Name = "btnExitNoSave"
        Me.btnExitNoSave.Size = New System.Drawing.Size(106, 23)
        Me.btnExitNoSave.TabIndex = 1
        Me.btnExitNoSave.Text = "E&xit without Saving"
        Me.btnExitNoSave.UseVisualStyleBackColor = True
        '
        'frmFlooringType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 256)
        Me.Controls.Add(Me.btnExitNoSave)
        Me.Controls.Add(Me.btnExitWithSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFlooringType"
        Me.Text = "Lawyer, Elijah Flooring Type"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstFlooringType As ListBox
    Friend WithEvents lblSqFtPerBoxOut As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExitWithSave As Button
    Friend WithEvents btnExitNoSave As Button
End Class
