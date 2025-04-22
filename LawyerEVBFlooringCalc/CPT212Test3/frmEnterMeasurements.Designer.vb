<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnterMeasurements
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
        Me.btnSubtractArea = New System.Windows.Forms.Button()
        Me.btnAddArea = New System.Windows.Forms.Button()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.lblTotalAreaOut = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnExitWithSave = New System.Windows.Forms.Button()
        Me.btnExitNoSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSubtractArea)
        Me.GroupBox1.Controls.Add(Me.btnAddArea)
        Me.GroupBox1.Controls.Add(Me.txtWidth)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLength)
        Me.GroupBox1.Controls.Add(Me.lblTotalAreaOut)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 205)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Room / Area Dimensions"
        '
        'btnSubtractArea
        '
        Me.btnSubtractArea.Location = New System.Drawing.Point(145, 115)
        Me.btnSubtractArea.Name = "btnSubtractArea"
        Me.btnSubtractArea.Size = New System.Drawing.Size(108, 24)
        Me.btnSubtractArea.TabIndex = 3
        Me.btnSubtractArea.Text = "Subtract From Area"
        Me.btnSubtractArea.UseVisualStyleBackColor = True
        '
        'btnAddArea
        '
        Me.btnAddArea.Location = New System.Drawing.Point(28, 115)
        Me.btnAddArea.Name = "btnAddArea"
        Me.btnAddArea.Size = New System.Drawing.Size(108, 24)
        Me.btnAddArea.TabIndex = 2
        Me.btnAddArea.Text = "Add To Area"
        Me.btnAddArea.UseVisualStyleBackColor = True
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(123, 72)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Width:"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(123, 46)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 20)
        Me.txtLength.TabIndex = 0
        '
        'lblTotalAreaOut
        '
        Me.lblTotalAreaOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAreaOut.Location = New System.Drawing.Point(135, 162)
        Me.lblTotalAreaOut.Name = "lblTotalAreaOut"
        Me.lblTotalAreaOut.Size = New System.Drawing.Size(72, 18)
        Me.lblTotalAreaOut.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total Area:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Length:"
        '
        'btnExitWithSave
        '
        Me.btnExitWithSave.Location = New System.Drawing.Point(35, 257)
        Me.btnExitWithSave.Name = "btnExitWithSave"
        Me.btnExitWithSave.Size = New System.Drawing.Size(108, 24)
        Me.btnExitWithSave.TabIndex = 0
        Me.btnExitWithSave.Text = "&Save and Exit"
        Me.btnExitWithSave.UseVisualStyleBackColor = True
        '
        'btnExitNoSave
        '
        Me.btnExitNoSave.Location = New System.Drawing.Point(187, 257)
        Me.btnExitNoSave.Name = "btnExitNoSave"
        Me.btnExitNoSave.Size = New System.Drawing.Size(108, 24)
        Me.btnExitNoSave.TabIndex = 1
        Me.btnExitNoSave.Text = "E&xit without Saving"
        Me.btnExitNoSave.UseVisualStyleBackColor = True
        '
        'frmEnterMeasurements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 303)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExitNoSave)
        Me.Controls.Add(Me.btnExitWithSave)
        Me.Name = "frmEnterMeasurements"
        Me.Text = "Lawyer, Elijah Measurements"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtLength As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSubtractArea As Button
    Friend WithEvents btnAddArea As Button
    Friend WithEvents lblTotalAreaOut As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExitWithSave As Button
    Friend WithEvents btnExitNoSave As Button
End Class
