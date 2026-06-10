Public Class arisnjp01General_clsVariabelGlobal

#Region "All About SERVER"

#Region "    Location Server Local"
    Const Login As Integer = 1 ' 0:server local | 1:server live
    Public Shared ReadOnly Property prop_arisnjp11svrAddress() As String
        Get
            Select Case Login
                Case 0
                    Return "MAULANADEV"
                  '  Return "MAULANADEV\SQLEXPRESS"
                Case 1
                    Return "172.25.0.2,1500" '"192.168.2.150,1500"  '"103.247.218.155" ' "192.168.2.155"     'server GJ gd.08
                Case 2
                    Return "172.25.0.4" '"192.168.2.150,1500"  '"103.247.218.155" ' "192.168.2.155"     'server GJ gd.08
            End Select
        End Get
    End Property

    Public Shared ReadOnly Property prop_arisnjp12UserSQL() As String
        Get
            Select Case Login
                Case 0
                    Return "sa"  'SQL Express
                Case 1
                    Return "aris"  'user Name Server GJ
                Case 2
                    Return "sa"  'user Name Server GJ
            End Select

        End Get
    End Property

    Public Shared ReadOnly Property prop_arisnjp13Keys() As String
        Get
            Select Case Login
                Case 0
                    Return "asdf@123" ' Lokal server pasword
                Case 1
                    Return "s@k@2020" 'server Gj pasword
                Case 2
                    Return "nasa@123" 'server Gj pasword
            End Select

        End Get
    End Property

#End Region

#End Region

#Region "All About DATABASE NEW CENTRAL"

    Public Shared ReadOnly Property prop_arisnjpdb01NC() As String
        Get
            Return "NEWCENTRAL"
        End Get
    End Property

    Public Shared ReadOnly Property prop_arisnjpdb02MRP() As String
        Get
            Return "MRP"
        End Get
    End Property

    Public Shared ReadOnly Property prop_arisnjpdb03GAMBAR() As String
        Get
            Return "GAMBAR"
        End Get
    End Property

    Public Shared ReadOnly Property prop_arisnjpdb04PRODUCTION() As String
        Get
            Return "PRODUCTION"
        End Get
    End Property


    Public Shared ReadOnly Property prop_arisnjpdb05SUPPORTCENTER() As String
        Get
            Return "SUPPORTCENTER"
        End Get
    End Property


    Public Shared ReadOnly Property prop_arisnjpdb09WS() As String
        Get
            Return "WS"
        End Get
    End Property

#End Region

End Class
