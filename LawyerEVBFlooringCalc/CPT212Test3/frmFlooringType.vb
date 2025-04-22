'Programmer: Elijah Lawyer
'Project: CPT 212 Test 3
'Purpose: Build a flooring calculator application with seperate forms to:
'  - enter measurements of floor area to be covered
'  - select the type of flooring
'  - display summary information 
'This form allows the user to select a type of flooring
'and displays square footage each box of that type will cover


Option Strict On
Option Explicit On

Public Class frmFlooringType

    Const intSqrFtPerBoxWood As Integer = 65
    Const intSqrFtPerBoxCarpet As Integer = 75
    Const intSqrFtPerBoxTile As Integer = 50
    Const intSqrFtPerBoxVinyl As Integer = 100
    Private Sub frmFlooringType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstFlooringType.Items.Add("Wood")
        lstFlooringType.Items.Add("Carpet")
        lstFlooringType.Items.Add("Tile")
        lstFlooringType.Items.Add("Vinyl")
    End Sub

    Private Sub lstFlooringType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFlooringType.SelectedIndexChanged
        Dim strSelectedItem As String = lstFlooringType.Items(lstFlooringType.SelectedIndex).ToString()

        If strSelectedItem <> "" Then
            If strSelectedItem = "Wood" Then
                lblSqFtPerBoxOut.Text = intSqrFtPerBoxWood.ToString()
            ElseIf strSelectedItem = "Carpet" Then
                lblSqFtPerBoxOut.Text = intSqrFtPerBoxCarpet.ToString()
            ElseIf strSelectedItem = "Tile" Then
                lblSqFtPerBoxOut.Text = intSqrFtPerBoxTile.ToString()
            ElseIf strSelectedItem = "Vinyl" Then
                lblSqFtPerBoxOut.Text = intSqrFtPerBoxVinyl.ToString()
            End If
        End If
    End Sub

    Private Sub btnExitWithSave_Click(sender As Object, e As EventArgs) Handles btnExitWithSave.Click
        Dim strSelectedItem As String = lstFlooringType.Items(lstFlooringType.SelectedIndex).ToString()

        If strSelectedItem <> "" Then
            If strSelectedItem = "Wood" Then
                strFlooringType = "Wood"
                strWasteAllowance = "15%"
                intBoxesNeeded = CInt(Math.Ceiling(decTotalArea / intSqrFtPerBoxWood))
                intSqFtNeeded = intBoxesNeeded * intSqrFtPerBoxWood
            ElseIf strSelectedItem = "Carpet" Then
                strFlooringType = "Carpet"
                strWasteAllowance = "10%"
                intBoxesNeeded = CInt(Math.Ceiling(decTotalArea / intSqrFtPerBoxCarpet))
                intSqFtNeeded = intBoxesNeeded * intSqrFtPerBoxCarpet
            ElseIf strSelectedItem = "Tile" Then
                strFlooringType = "Tile"
                strWasteAllowance = "10%"
                intBoxesNeeded = CInt(Math.Ceiling(decTotalArea / intSqrFtPerBoxTile))
                intSqFtNeeded = intBoxesNeeded * intSqrFtPerBoxTile
            Else
                strFlooringType = "Vinyl"
                strWasteAllowance = "8%"
                intBoxesNeeded = CInt(Math.Ceiling(decTotalArea / intSqrFtPerBoxVinyl))
                intSqFtNeeded = intBoxesNeeded * intSqrFtPerBoxVinyl
            End If
        Else
            MessageBox.Show("Please select a floor type.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        btnExitNoSave_Click(sender, e)
    End Sub

    Private Sub btnExitNoSave_Click(sender As Object, e As EventArgs) Handles btnExitNoSave.Click
        Me.Close()
    End Sub


End Class