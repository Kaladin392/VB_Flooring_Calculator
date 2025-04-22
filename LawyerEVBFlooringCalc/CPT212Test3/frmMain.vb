'Programmer: Elijah Lawyer
'Project: CPT 212 Test 3
'Purpose: Build a flooring calculator application with seperate forms to:
'  - enter measurements of floor area to be covered
'  - select the type of flooring
'  - display summary information 

Option Strict On
Option Explicit On

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateMainLabels()
    End Sub

    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        UpdateMainLabels()
    End Sub
    Private Sub EnterMeasurementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterMeasurementsToolStripMenuItem.Click
        Dim frmEnterMeasurments As New frmEnterMeasurements
        frmEnterMeasurements.ShowDialog()
    End Sub

    Private Sub SelectFlooringTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectFlooringTypeToolStripMenuItem.Click
        Dim frmFlooringType As New frmFlooringType
        frmFlooringType.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        decTotalSqFt = 0
        strFlooringType = ""
        strWasteAllowance = ""
        intSqFtNeeded = 0
        intBoxesNeeded = 0
        decTotalArea = 0

        UpdateMainLabels()
    End Sub
    Sub UpdateMainLabels()
        lblTotalSqFtOutput.Text = decTotalSqFt.ToString()
        lblFlooringTypeOut.Text = strFlooringType
        lblWasteAllowanceOut.Text = strWasteAllowance
        lblSqFtNeededOut.Text = intSqFtNeeded.ToString()
        lblBoxesNeededOut.Text = intBoxesNeeded.ToString()
    End Sub
End Class
