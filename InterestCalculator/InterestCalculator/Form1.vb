Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim Year As Integer
        Dim TotalSimple As Double
        Dim TotalCompound As Double
        Dim SimpleBeginning As Double
        Dim SimpleRunningTotal As Double
        Dim CompoundBeginning As Double
        Dim CompoundRunningTotal As Double
        Dim InterestRate As Double
        Dim TimesCompounded As Integer

        Dim fmtstr As String = "{0,-6} {1,12:C2} {2,12:C2}" 'Use for formating output.
        lstOutput.Items.Clear()
        lstOutput.Items.Add("")
        lstOutput.Items.Add(String.Format(fmtstr, "", "Amount", "Amount"))

        SimpleBeginning = InputBox("Beginning simple interest amount", "Enter beginning amount: ")
        CompoundBeginning = InputBox("Beginning compound interest amount", "Enter beginning amount: ")
        TimesCompounded = InputBox("Amount of times compounded per year", "Enter amount of times to compound: ")
        InterestRate = InputBox("Interest Rate as percent", "Enter interest rate: ")
        Year = InputBox("Periods in years", "Enter amount of years: ")
        Dim ConvertedCompoundInterest As Double = (InterestRate / 100) + 1
        Dim ConvertedInterest As Double = (InterestRate / 100)
        SimpleRunningTotal = SimpleBeginning
        CompoundRunningTotal = CompoundBeginning
        For J = 1 To Year

            TotalSimple = SimpleRunningTotal + (SimpleBeginning * ConvertedInterest)
            'TotalCompound = (CompoundRunningTotal * (1 + ConvertedInterest)) 'compound interest?
            TotalCompound = (CompoundRunningTotal * (((1 + ConvertedInterest)) / TimesCompounded) ^ J)
            lstOutput.Items.Add(String.Format(fmtstr, J, TotalSimple, TotalCompound))
            SimpleRunningTotal = TotalSimple
            CompoundRunningTotal = TotalCompound

        Next


    End Sub
End Class
