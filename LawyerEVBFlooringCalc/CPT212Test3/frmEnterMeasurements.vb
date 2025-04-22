'Programmer: Elijah Lawyer
'Project: CPT 212 Test 3
'Purpose: Build a flooring calculator application with seperate forms to:
'  - enter measurements of floor area to be covered
'  - select the type of flooring
'  - display summary information 
'This form allows the user to enter the length and width of multiple areas which are added together. 
'The use can either save or abandon the area calculated in this form


Option Strict On
Option Explicit On

Public Class frmEnterMeasurements

    Private Sub btnAddArea_Click(sender As Object, e As EventArgs) Handles btnAddArea.Click
        Dim decLength As Decimal = 0
        Dim decWidth As Decimal = 0

        If txtLength.Text <> "" Then
            If IsNumeric(txtLength.Text) Then
                If txtWidth.Text <> "" Then
                    If IsNumeric(txtWidth.Text) Then
                        decLength = CDec(txtLength.Text)
                        decWidth = CDec(txtWidth.Text)
                        decTotalArea += decLength * decWidth
                        lblTotalAreaOut.Text = decTotalArea.ToString()
                    Else
                        MessageBox.Show("Width must be a number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Width can't be empty", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Length must be a number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Length can't be empty", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnSubtractArea_Click(sender As Object, e As EventArgs) Handles btnSubtractArea.Click
        Dim decLength As Decimal = 0
        Dim decWidth As Decimal = 0

        If txtLength.Text <> "" Then
            If IsNumeric(txtLength.Text) Then
                If txtWidth.Text <> "" Then
                    If IsNumeric(txtWidth.Text) Then
                        decLength = CDec(txtLength.Text)
                        decWidth = CDec(txtWidth.Text)
                        If decTotalArea - (decLength * decWidth) >= 0 Then
                            decTotalArea -= decLength * decWidth
                            lblTotalAreaOut.Text = decTotalArea.ToString()
                        Else
                            MessageBox.Show("Total Area cannot be negative", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    Else
                        MessageBox.Show("Width must be a number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Width can't be empty", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Length must be a number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Length can't be empty", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnExitNoSave_Click(sender As Object, e As EventArgs) Handles btnExitNoSave.Click
        txtLength.Text = ""
        txtWidth.Text = ""
        lblTotalAreaOut.Text = ""
        Me.Close()
    End Sub

    Private Sub btnExitWithSave_Click(sender As Object, e As EventArgs) Handles btnExitWithSave.Click
        decTotalSqFt = decTotalArea
        btnExitNoSave_Click(sender, e)
    End Sub
End Class