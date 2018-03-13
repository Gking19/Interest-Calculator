Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim Year As Integer
        Dim TotalSimple As Double
        Dim TotalCompound As Double
        Dim SimpleBeginning As Double
        Dim CompoundBeginning As Double
        Dim SimpleRunningTotal As Double
        Dim CompoundRunningTotal As Double
        Dim InterestRate As Double

        Dim fmtstr As String = "{0,-6} {1,12} {2,12}" 'Use for formating output.
        lstOutput.Items.Clear()
        lstOutput.Items.Add("")
        lstOutput.Items.Add(String.Format(fmtstr, "", "Amount", "Amount"))

        SimpleBeginning = InputBox("Beginning simple interest amount", "Enter beginning amount: ")
        CompoundBeginning = InputBox("Beginning compound interest amount", "Enter beginning amount: ")
        InterestRate = InputBox("Interest Rate", "Enter interest rate: ")
        Year = InputBox("Periods in years", "Enter amount of years: ")

        For J = 1 To Year

            SimpleRunningTotal += SimpleBeginning * ((1 + InterestRate) * Year)
            TotalSimple = SimpleRunningTotal




            lstOutput.Items.Add(String.Format(fmtstr, Year, TotalSimple, TotalCompound))

            Year += 1
        Next


    End Sub
End Class
