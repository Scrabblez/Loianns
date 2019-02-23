Public Module DefineGlobals
    REM Public Variables to Pass Values From One Form to Another
    REM Common throughout application

    Public strtblName As String

    Public strFrmName As String
    Public strCurrentFrmName As String
    Public icount As Long

    Public strCityName As String
    Public strRegionName As String
    Public strRegionAbbr As String
    Public strCountryName As String

    Public Global_AgeYears As Integer
    Public varAge As Integer
    Public varDoB As Date



    ' Declare Contact Information.
    Public Function Gbl_Contact() As String

        Gbl_Contact = "crystalsingingbowls@gmail.com"

    End Function

    ' Declare Copyright Information.
    Public Function Gbl_Copyright() As String

        Gbl_Copyright = "Â© Ann Reeves 2016"

    End Function

    ' Declare Version Information.
    Public Function Gbl_Version() As String

        Gbl_Version = "1.0"

    End Function

    ' uses the Practitioner's City as the default value when inputting address City
    ' Public Function Gbl_Dflt_City_Name() As String

    'Gbl_Dflt_City_Name = DLookup("[CityName]", "tblPractitioner")

    ' End Function

    ' uses the Practitioner's Region as the default value when inputting address Province or State
    'Public Function Gbl_Dflt_Region_Name() As String

    'Gbl_Dflt_Region_Name = DLookup("[RegionName]", "tblPractitioner")

    ' End Function

    ' uses the Practitioner's Region as the default value when inputting address Province or State
    ' Public Function Gbl_Dflt_Region_Abbr() As String

    ' Gbl_Dflt_Region_Abbr = DLookup("[RegionAbbr]", "tblPractitioner")

    ' End Function

    ' uses the Practitioner's Country as the default value when inputting address Country
    'Public Function Gbl_Dflt_Country_Name() As String

    'Gbl_Dflt_Country_Name = DLookup("[CountryName]", "tblPractitioner")

    'End Function

    Public Function Gbl_FullName(varFName, varLName) As String

        Gbl_FullName = varFName & " " & varLName

    End Function

    ' Comments: Returns the age in years
    Public Function Global_AgeYears(ByVal varDoB)

        Global_AgeYears = Int((Now - varDoB) / 365.2425)

    End Function


    ' Comments: Identifies the Spiral based upon Age
    Public Function Gbl_SpiralName(Global_AgeYears) As Integer

        If varAge >= 91 And varAge < 98 Then
            Gbl_SpiralName = "Crown"
        End If
        If varAge >= 84 And varAge < 91 Then
            Gbl_SpiralName = "Third Eye"
        End If
        If varAge >= 77 And varAge < 84 Then
            Gbl_SpiralName = "Throat"
        End If
        If varAge >= 70 And varAge < 77 Then
            Gbl_SpiralName = "Heart"
        End If
        If varAge >= 63 And varAge < 70 Then
            Gbl_SpiralName = "Solar Plexus"
        End If
        If varAge >= 56 And varAge < 63 Then
            Gbl_SpiralName = "Sacral"
        End If
        If varAge >= 48 And varAge < 56 Then
            Gbl_SpiralName = "Root"
        End If
        If varAge >= 42 And varAge < 48 Then
            Gbl_SpiralName = "Crown"
        End If
        If varAge >= 35 And varAge < 42 Then
            Gbl_SpiralName = "Third Eye"
        End If
        If varAge >= 28 And varAge < 35 Then
            Gbl_SpiralName = "Throat"
        End If
        If varAge >= 21 And varAge < 28 Then
            Gbl_SpiralName = "Heart"
        End If
        If varAge >= 14 And varAge < 21 Then
            Gbl_SpiralName = "Solar Plexus"
        End If
        If varAge >= 8 And varAge < 14 Then
            Gbl_SpiralName = "Sacral"
        End If
        If varAge >= 0 And varAge < 8 Then
            Gbl_SpiralName = "Root"
        End If

    End Function

    ' Comments: Identifies the Stage based upon Age
    Public Function Gbl_StageName(varAge) As String
        Dim varStageNumber As Integer
        Dim varStage As String

        If varAge <= 7 Then

            If varAge >= 0 And varAge < 1 Then
                Gbl_StageName = "Root"
            End If
            If varAge >= 1 And varAge < 2 Then
                Gbl_StageName = "Sacral"
            End If
            If varAge >= 2 And varAge < 3 Then
                Gbl_StageName = "Solar Plexus"
            End If
            If varAge >= 3 And varAge < 4 Then
                Gbl_StageName = "Heart"
            End If
            If varAge >= 4 And varAge < 5 Then
                Gbl_StageName = "Throat"
            End If
            If varAge >= 5 And varAge < 6 Then
                Gbl_StageName = "Third Eye"
            End If
            If varAge >= 6 And varAge < 7 Then
                Gbl_StageName = "Crown"
            End If

        Else

            varStageNumber = (varAge Mod 7) - 1

            If varStageNumber >= 0 And varStageNumber < 1 Then
                Gbl_StageName = "Root"
            End If
            If varStageNumber >= 1 And varStageNumber < 2 Then
                Gbl_StageName = "Sacral"
            End If
            If varStageNumber >= 2 And varStageNumber < 3 Then
                Gbl_StageName = "Solar Plexus"
            End If
            If varStageNumber >= 3 And varStageNumber < 4 Then
                Gbl_StageName = "Heart"
            End If
            If varStageNumber >= 4 And varStageNumber < 5 Then
                Gbl_StageName = "Throat"
            End If
            If varStageNumber >= 5 And varStageNumber < 6 Then
                Gbl_StageName = "Third Eye"
            End If
            If varStageNumber >= 6 And varStageNumber < 7 Then
                Gbl_StageName = "Crown"
            End If
        End If

    End Function



End Module
