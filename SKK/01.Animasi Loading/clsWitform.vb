Imports DevExpress.XtraWaitForm

Public Class clsWitform
    Inherits WaitForm

    Public Property prop_SetCaption As String
    Public Property prop_SetDescription As String


    Public Sub _cm01bindingAwal()
        Dim progrespanel As New ProgressPanel

        With progrespanel
            .AutoHeight = True
            .Caption = prop_SetCaption
            .Description = prop_SetDescription
            .Top = 5
            .Left = 5
            .BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        End With


        Me.Size = New Size(200, 50)
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Padding = New Padding(5, 5, 5, 5)
        Me.Controls.Add(progrespanel)

    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'clsWitform
        '
        Me.Name = "clsWitform"
        Me.ResumeLayout(False)

    End Sub
End Class
