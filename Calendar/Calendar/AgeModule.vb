Module AgeModule
    ' Comments: Returns the age in years with two decimal places
    Public Function Gbl_AgeYears(ByVal DoB As Date) As Double

        Gbl_AgeYears = Math.Round((DateDiff(DateInterval.Year, DoB, Now) - 1) + ((DateDiff(DateInterval.Month, DoB, Now) Mod 12) / 12), 2)

    End Function

    'Identifies Spiral Based on Age
    Public Function Gbl_SpiralName(varAge)

        If varAge >= 91 And varAge < 98 Then
            Gbl_SpiralName = "Crown"
        ElseIf varAge >= 84 And varAge < 91 Then
            Gbl_SpiralName = "Third Eye"
        ElseIf varAge >= 77 And varAge < 84 Then
            Gbl_SpiralName = "Throat"
        ElseIf varAge >= 70 And varAge < 77 Then
            Gbl_SpiralName = "Heart"
        ElseIf varAge >= 63 And varAge < 70 Then
            Gbl_SpiralName = "Solar Plexus"
        ElseIf varAge >= 56 And varAge < 63 Then
            Gbl_SpiralName = "Sacral"
        ElseIf varAge >= 48 And varAge < 56 Then
            Gbl_SpiralName = "Sacral"
        ElseIf varAge >= 42 And varAge < 48 Then
            Gbl_SpiralName = "Crown"
        ElseIf varAge >= 35 And varAge < 42 Then
            Gbl_SpiralName = "Third Eye"
        ElseIf varAge >= 28 And varAge < 35 Then
            Gbl_SpiralName = "Throat"
        ElseIf varAge >= 21 And varAge < 28 Then
            Gbl_SpiralName = "Heart"
        ElseIf varAge >= 14 And varAge < 21 Then
            Gbl_SpiralName = "Solar Plexus"
        ElseIf varAge >= 8 And varAge < 14 Then
            Gbl_SpiralName = "Sacral"
        ElseIf varAge >= 0 And varAge < 8 Then
            Gbl_SpiralName = "Sacral"
        End If

    End Function

    'Identifies Stage based on Age
    Public Function Gbl_StageName(varAge)

        If varAge >= 0 And varAge < 1 Then
            Gbl_StageName = "Root"
        ElseIf varAge >= 1 And varAge < 2 Then
            Gbl_StageName = "Sacral"
        ElseIf varAge >= 2 And varAge < 3 Then
            Gbl_StageName = "Solar Plexus"
        ElseIf varAge >= 3 And varAge < 4 Then
            Gbl_StageName = "Heart"
        ElseIf varAge >= 4 And varAge < 5 Then
            Gbl_StageName = "Throat"
        ElseIf varAge >= 5 And varAge < 6 Then
            Gbl_StageName = "Third Eye"
        ElseIf varAge >= 6 And varAge < 7 Then
            Gbl_StageName = "Crown"
        End If

        Dim varStageNumber As Integer = (varAge Mod 7) - 1

        If varStageNumber >= 0 And varStageNumber < 1 Then
            Gbl_StageName = "Root"
        ElseIf varStageNumber >= 1 And varStageNumber < 2 Then
            Gbl_StageName = "Sacral"
        ElseIf varStageNumber >= 2 And varStageNumber < 3 Then
            Gbl_StageName = "Solar Plexus"
        ElseIf varStageNumber >= 3 And varStageNumber < 4 Then
            Gbl_StageName = "Heart"
        ElseIf varStageNumber >= 4 And varStageNumber < 5 Then
            Gbl_StageName = "Throat"
        ElseIf varStageNumber >= 5 And varStageNumber < 6 Then
            Gbl_StageName = "Third Eye"
        ElseIf varStageNumber >= 6 And varStageNumber < 7 Then
            Gbl_StageName = "Crown"
        End If

    End Function

End Module
