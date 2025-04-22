<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalSqFtOutput = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFlooringTypeOut = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblWasteAllowanceOut = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSqFtNeededOut = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblBoxesNeededOut = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FunctionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterMeasurementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectFlooringTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Square Feet:"
        '
        'lblTotalSqFtOutput
        '
        Me.lblTotalSqFtOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalSqFtOutput.Location = New System.Drawing.Point(199, 65)
        Me.lblTotalSqFtOutput.Name = "lblTotalSqFtOutput"
        Me.lblTotalSqFtOutput.Size = New System.Drawing.Size(68, 16)
        Me.lblTotalSqFtOutput.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Flooring Type:"
        '
        'lblFlooringTypeOut
        '
        Me.lblFlooringTypeOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFlooringTypeOut.Location = New System.Drawing.Point(199, 94)
        Me.lblFlooringTypeOut.Name = "lblFlooringTypeOut"
        Me.lblFlooringTypeOut.Size = New System.Drawing.Size(68, 16)
        Me.lblFlooringTypeOut.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Waste Allowance:"
        '
        'lblWasteAllowanceOut
        '
        Me.lblWasteAllowanceOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWasteAllowanceOut.Location = New System.Drawing.Point(199, 123)
        Me.lblWasteAllowanceOut.Name = "lblWasteAllowanceOut"
        Me.lblWasteAllowanceOut.Size = New System.Drawing.Size(68, 16)
        Me.lblWasteAllowanceOut.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(84, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Square Feet Needed:"
        '
        'lblSqFtNeededOut
        '
        Me.lblSqFtNeededOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSqFtNeededOut.Location = New System.Drawing.Point(199, 152)
        Me.lblSqFtNeededOut.Name = "lblSqFtNeededOut"
        Me.lblSqFtNeededOut.Size = New System.Drawing.Size(68, 16)
        Me.lblSqFtNeededOut.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(113, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Boxes Needed:"
        '
        'lblBoxesNeededOut
        '
        Me.lblBoxesNeededOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBoxesNeededOut.Location = New System.Drawing.Point(199, 185)
        Me.lblBoxesNeededOut.Name = "lblBoxesNeededOut"
        Me.lblBoxesNeededOut.Size = New System.Drawing.Size(68, 16)
        Me.lblBoxesNeededOut.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FunctionsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(375, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FunctionsToolStripMenuItem
        '
        Me.FunctionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterMeasurementsToolStripMenuItem, Me.SelectFlooringTypeToolStripMenuItem, Me.ResetToolStripMenuItem})
        Me.FunctionsToolStripMenuItem.Name = "FunctionsToolStripMenuItem"
        Me.FunctionsToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.FunctionsToolStripMenuItem.Text = "Functions"
        '
        'EnterMeasurementsToolStripMenuItem
        '
        Me.EnterMeasurementsToolStripMenuItem.Name = "EnterMeasurementsToolStripMenuItem"
        Me.EnterMeasurementsToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.EnterMeasurementsToolStripMenuItem.Text = "Enter Measurements"
        '
        'SelectFlooringTypeToolStripMenuItem
        '
        Me.SelectFlooringTypeToolStripMenuItem.Name = "SelectFlooringTypeToolStripMenuItem"
        Me.SelectFlooringTypeToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SelectFlooringTypeToolStripMenuItem.Text = "Select Flooring Type"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 237)
        Me.Controls.Add(Me.lblBoxesNeededOut)
        Me.Controls.Add(Me.lblSqFtNeededOut)
        Me.Controls.Add(Me.lblWasteAllowanceOut)
        Me.Controls.Add(Me.lblFlooringTypeOut)
        Me.Controls.Add(Me.lblTotalSqFtOutput)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Lawyer, Elijah Flooring Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalSqFtOutput As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFlooringTypeOut As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblWasteAllowanceOut As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSqFtNeededOut As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblBoxesNeededOut As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FunctionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnterMeasurementsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectFlooringTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
