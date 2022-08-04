Public Class FrmSoccerMatch

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Calculate the total due for a booking
        Const intTicketPrice As Integer = 500

        Dim intNumberTicket As Integer
        Dim decTotalTickePrice As Decimal = 0
        Dim decOptionalPrice As Decimal = 0
        Dim decTotalDue As Decimal = 0

        'Input
        intNumberTicket = CInt(txtTickets.Text)

        'Processing
        'Calculate the price for tickets
        decTotalTickePrice = intNumberTicket * intTicketPrice

        'Calculate the Optional price
        If chkFoodHamper.Checked = True Then
            decOptionalPrice = decOptionalPrice + 120
        End If
        If chkVuvuzela.Checked = True Then
            decOptionalPrice = decOptionalPrice + 50
        End If
        If chkBeanie.Checked = True Then
            decOptionalPrice = decOptionalPrice + 80
        End If
        If chkSurprisePack.Checked = True Then
            decOptionalPrice = decOptionalPrice + 250
        End If

        'Calculate the total amount due
        decTotalDue = decTotalTickePrice + decOptionalPrice

        'Output: Displaying the total in the label
        lblResult.Text = "The total due is " & decTotalDue.ToString("C2")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear all controls and set the focus to the textbox
        txtTickets.Clear()
        chkBeanie.Checked = False
        chkFoodHamper.Checked = False
        chkSurprisePack.Checked = False
        chkVuvuzela.Checked = False

        lblResult.Text = " "
        txtTickets.Focus()



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form and exit the program
        Me.Close()
    End Sub
End Class
