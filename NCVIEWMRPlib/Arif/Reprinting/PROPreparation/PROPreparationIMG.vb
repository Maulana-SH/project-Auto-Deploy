Imports System.Drawing.Printing

Public Class PROPreparationIMG
    Implements IDisposable

    Public Property prop_01IMGPROPreparation As Image
    Public Property prop_02IMGPROPreparation As Image
    Public Property prop_03IMGPROPreparation As Image

    Private Sub PROPreparationIMG_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint

        ProPrepPicture01.Image = prop_01IMGPROPreparation
        ProPrepPicture02.Image = prop_02IMGPROPreparation
        ProPrepPicture03.Image = prop_03IMGPROPreparation

    End Sub
End Class