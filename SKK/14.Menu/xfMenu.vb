Imports NCMODELlib

Public Class xfMenu
    Private Sub xfMenu_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Sub _cm01()

        Me._acMenu.Visible = True
        Me.pnlContent.Controls.Clear()

    End Sub

    Private Sub AccordionControlElement3_Click(sender As Object, e As EventArgs) Handles AccordionControlElement3.Click
        Dim objLogin As New ucLogin With {
        .Dock = DockStyle.Fill
        }
        _acMenu.Visible = False
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(objLogin)
    End Sub

    Private Sub AccordionControlElement2_Click(sender As Object, e As EventArgs) Handles AccordionControlElement2.Click
        _cm01()
    End Sub

    Private Sub AccordionControlElement9_Click(sender As Object, e As EventArgs) Handles AccordionControlElement9.Click
        Dim pdDataMasterSKK23 As New DataTable
        Dim pdDataMasterSKK51 As New DataTable

        Using objSKKMaster As clsMRP_iface = New clsMRP_impl
            pdDataMasterSKK51 = objSKKMaster.Get51MasterAllNewSKK()
        End Using


        'get dt23 MasterSTone
        Using objSKKMaster23 As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = ""
            }
            pdDataMasterSKK23 = objSKKMaster23.Sele23MCSTONES()
        End Using
        Dim objLogin As New NCVIEWMRPlib.ucMRP20EV01DesignMaster With {
       .Dock = DockStyle.Fill,
       .prop_01dvAll51DataMasterSKK = pdDataMasterSKK51,
       .prop_04dvAllDataMaster23 = pdDataMasterSKK23,
       .prop_02cUserID = "Maulana",
       .prop_03cNamaUser = "Maulana"
       }
        ' _acMenu.Visible = False
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(objLogin)
    End Sub

    Private Sub AccordionControlElement10_Click(sender As Object, e As EventArgs) Handles AccordionControlElement10.Click
        Dim objformMenu As New NCVIEWMRPlib.ucMenu With {.Dock = DockStyle.Fill}
        Dim formMenu As New DevExpress.XtraEditors.XtraForm With {.Text = "APP NAME",
                                                                           .WindowState = FormWindowState.Maximized}
        formMenu.Controls.Add(objformMenu)
        formMenu.Show()
    End Sub
End Class