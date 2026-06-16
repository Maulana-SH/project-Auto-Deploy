Imports System.Data.SqlClient
Imports System.Threading.Tasks

Public Class arisnjp01General_clsStoredProcedureExecution
    Implements IDisposable

    Public Property SAKA2011_P1_Server() As String
    Public Property SAKA2011_P1_NamaDatabaseTarget() As String
    Public Property SAKA2011_P3_NamaDataSet() As String
    Public Property SAKA2011_P4_ObjectDataSet() As DataSet
    Public Property SAKA2011_P5_ObjectDataView() As DataView
    Public Property SAKA2011_P6_NameStoredProcedure() As String

    Public Enum arisnjpTargetTipeData
        arisnjp_string = 1
        arisnjp_integer = 2
        arisnjp_double = 3
    End Enum

#Region "Property : RETURN VALUE"
    Public Property SAKA2011_PRM_01ReturnValueParamNumeric() As String
    Public Property SAKA2011_PRM_01ReturnValueParamNumericValue() As Object
    Public Property SAKA2011_PRM_02ReturnValueTargetTipeData As arisnjpTargetTipeData
#End Region

#Region "Property : OUTPUT "
    Public Property SAKA2011_PRM_01OUTPUTParamNumeric() As String
    Public Property SAKA2011_PRM_01OUTPUTParamNumericValue() As Object

    Public Property SAKA2011_PRM_02OUTPUTParamNumeric() As String
    Public Property SAKA2011_PRM_02OUTPUTParamNumericValue() As Object

    Public Property SAKA2011_PRM_03OUTPUTParamNumeric() As String
    Public Property SAKA2011_PRM_03OUTPUTParamNumericValue() As Object
#End Region

#Region "Property : PARAMETER"
    Public Property SAKA2011_PRM_01Param() As String
    Public Property SAKA2011_PRM_01Value() As Object

    Public Property SAKA2011_PRM_02Param() As String
    Public Property SAKA2011_PRM_02Value() As Object

    Public Property SAKA2011_PRM_03Param() As String
    Public Property SAKA2011_PRM_03Value() As Object

    Public Property SAKA2011_PRM_04Param() As String
    Public Property SAKA2011_PRM_04Value() As Object

    Public Property SAKA2011_PRM_05Param() As String
    Public Property SAKA2011_PRM_05Value() As Object

    Public Property SAKA2011_PRM_06Param() As String
    Public Property SAKA2011_PRM_06Value() As Object

    Public Property SAKA2011_PRM_07Param() As String
    Public Property SAKA2011_PRM_07Value() As Object

    Public Property SAKA2011_PRM_08Param() As String
    Public Property SAKA2011_PRM_08Value() As Object

    Public Property SAKA2011_PRM_09Param() As String
    Public Property SAKA2011_PRM_09Value() As Object

    Public Property SAKA2011_PRM_10Param() As String
    Public Property SAKA2011_PRM_10Value() As Object

    Public Property SAKA2011_PRM_11Param() As String
    Public Property SAKA2011_PRM_11Value() As Object

    Public Property SAKA2011_PRM_12Param() As String
    Public Property SAKA2011_PRM_12Value() As Object

    Public Property SAKA2011_PRM_13Param() As String
    Public Property SAKA2011_PRM_13Value() As Object

    Public Property SAKA2011_PRM_14Param() As String
    Public Property SAKA2011_PRM_14Value() As Object

    Public Property SAKA2011_PRM_15Param() As String
    Public Property SAKA2011_PRM_15Value() As Object

    Public Property SAKA2011_PRM_16Param() As String
    Public Property SAKA2011_PRM_16Value() As Object

    Public Property SAKA2011_PRM_17Param() As String
    Public Property SAKA2011_PRM_17Value() As Object

    Public Property SAKA2011_PRM_18Param() As String
    Public Property SAKA2011_PRM_18Value() As Object

    Public Property SAKA2011_PRM_19Param() As String
    Public Property SAKA2011_PRM_19Value() As Object

    Public Property SAKA2011_PRM_20Param() As String
    Public Property SAKA2011_PRM_20Value() As Object

    Public Property SAKA2011_PRM_21Param() As String
    Public Property SAKA2011_PRM_21Value() As Object

    Public Property SAKA2011_PRM_22Param() As String
    Public Property SAKA2011_PRM_22Value() As Object

    Public Property SAKA2011_PRM_23Param() As String
    Public Property SAKA2011_PRM_23Value() As Object

    Public Property SAKA2011_PRM_24Param() As String
    Public Property SAKA2011_PRM_24Value() As Object

    Public Property SAKA2011_PRM_25Param() As String
    Public Property SAKA2011_PRM_25Value() As Object

    Public Property SAKA2011_PRM_26Param() As String
    Public Property SAKA2011_PRM_26Value() As Object

    Public Property SAKA2011_PRM_27Param() As String
    Public Property SAKA2011_PRM_27Value() As Object

    Public Property SAKA2011_PRM_28Param() As String
    Public Property SAKA2011_PRM_28Value() As Object

    Public Property SAKA2011_PRM_29Param() As String
    Public Property SAKA2011_PRM_29Value() As Object

    Public Property SAKA2011_PRM_30Param() As String
    Public Property SAKA2011_PRM_30Value() As Object

#End Region

    Public Sub SAKA2011_SP_IsiDataSet_P1P3P4P6()
        Try
            Using objConnDB As New SqlConnection(arisnjp01General_clsDatabaseAndServer.SAKA2011_NET_ConnectionSTRING(SAKA2011_P1_Server, SAKA2011_P1_NamaDatabaseTarget))
                objConnDB.Open()

                Using objSQLCommand As New SqlCommand() With {.Connection = objConnDB,
                                                              .CommandText = SAKA2011_P6_NameStoredProcedure,
                                                              .CommandType = CommandType.StoredProcedure,
                                                              .CommandTimeout = 500}

                    If Not String.IsNullOrEmpty(SAKA2011_PRM_01Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_01Param, SAKA2011_PRM_01Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_02Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_02Param, SAKA2011_PRM_02Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_03Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_03Param, SAKA2011_PRM_03Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_04Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_04Param, SAKA2011_PRM_04Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_05Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_05Param, SAKA2011_PRM_05Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_06Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_06Param, SAKA2011_PRM_06Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_07Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_07Param, SAKA2011_PRM_07Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_08Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_08Param, SAKA2011_PRM_08Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_09Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_09Param, SAKA2011_PRM_09Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_10Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_10Param, SAKA2011_PRM_10Value)
                    End If

                    If Not String.IsNullOrEmpty(SAKA2011_PRM_11Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_11Param, SAKA2011_PRM_11Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_12Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_12Param, SAKA2011_PRM_12Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_13Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_13Param, SAKA2011_PRM_13Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_14Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_14Param, SAKA2011_PRM_14Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_15Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_15Param, SAKA2011_PRM_15Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_16Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_16Param, SAKA2011_PRM_16Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_17Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_17Param, SAKA2011_PRM_17Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_18Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_18Param, SAKA2011_PRM_18Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_19Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_19Param, SAKA2011_PRM_19Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_20Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_20Param, SAKA2011_PRM_20Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_21Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_21Param, SAKA2011_PRM_21Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_22Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_22Param, SAKA2011_PRM_22Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_23Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_23Param, SAKA2011_PRM_23Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_24Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_24Param, SAKA2011_PRM_24Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_25Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_25Param, SAKA2011_PRM_25Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_26Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_26Param, SAKA2011_PRM_26Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_27Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_27Param, SAKA2011_PRM_27Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_28Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_28Param, SAKA2011_PRM_28Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_29Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_29Param, SAKA2011_PRM_29Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_30Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_30Param, SAKA2011_PRM_30Value)
                    End If

                    Dim objAdapter As SqlDataAdapter = New SqlDataAdapter(objSQLCommand)

                    SAKA2011_P4_ObjectDataSet.Clear()
                    objAdapter.Fill(SAKA2011_P4_ObjectDataSet, SAKA2011_P3_NamaDataSet)

                End Using

                objConnDB.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function cariReturnValueParm() As DbType

        Select Case SAKA2011_PRM_02ReturnValueTargetTipeData
            Case arisnjpTargetTipeData.arisnjp_string
                cariReturnValueParm = DbType.String
            Case arisnjpTargetTipeData.arisnjp_integer
                cariReturnValueParm = DbType.Int64
            Case arisnjpTargetTipeData.arisnjp_double
                cariReturnValueParm = DbType.Double
            Case Else
        End Select

        Return cariReturnValueParm
    End Function

    Public Sub SAKA2011_SP_ReturnValue_P1P6()
        Using objConnDB As New SqlConnection(arisnjp01General_clsDatabaseAndServer.SAKA2011_NET_ConnectionSTRING(SAKA2011_P1_Server, SAKA2011_P1_NamaDatabaseTarget))

            objConnDB.Open()

            Using objSQLCommand As New SqlCommand() With {.Connection = objConnDB,
                                                          .CommandText = SAKA2011_P6_NameStoredProcedure,
                                                          .CommandType = CommandType.StoredProcedure}

                Dim ReturnValueParm As SqlParameter = New SqlParameter() With {.ParameterName = SAKA2011_PRM_01ReturnValueParamNumeric,
                                                                               .Direction = ParameterDirection.ReturnValue,
                                                                               .IsNullable = False,
                                                                               .Value = SAKA2011_PRM_01ReturnValueParamNumericValue,
                                                                               .DbType = cariReturnValueParm()}

                If Not String.IsNullOrEmpty(SAKA2011_PRM_01ReturnValueParamNumeric) Then
                    objSQLCommand.Parameters.Add(ReturnValueParm)
                End If

                If Not String.IsNullOrEmpty(SAKA2011_PRM_01Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_01Param, SAKA2011_PRM_01Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_02Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_02Param, SAKA2011_PRM_02Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_03Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_03Param, SAKA2011_PRM_03Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_04Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_04Param, SAKA2011_PRM_04Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_05Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_05Param, SAKA2011_PRM_05Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_06Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_06Param, SAKA2011_PRM_06Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_07Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_07Param, SAKA2011_PRM_07Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_08Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_08Param, SAKA2011_PRM_08Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_09Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_09Param, SAKA2011_PRM_09Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_10Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_10Param, SAKA2011_PRM_10Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_11Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_11Param, SAKA2011_PRM_11Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_12Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_12Param, SAKA2011_PRM_12Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_13Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_13Param, SAKA2011_PRM_13Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_14Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_14Param, SAKA2011_PRM_14Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_15Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_15Param, SAKA2011_PRM_15Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_16Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_16Param, SAKA2011_PRM_16Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_17Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_17Param, SAKA2011_PRM_17Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_18Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_18Param, SAKA2011_PRM_18Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_19Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_19Param, SAKA2011_PRM_19Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_20Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_20Param, SAKA2011_PRM_20Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_21Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_21Param, SAKA2011_PRM_21Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_22Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_22Param, SAKA2011_PRM_22Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_23Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_23Param, SAKA2011_PRM_23Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_24Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_24Param, SAKA2011_PRM_24Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_25Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_25Param, SAKA2011_PRM_25Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_26Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_26Param, SAKA2011_PRM_26Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_27Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_27Param, SAKA2011_PRM_27Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_28Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_28Param, SAKA2011_PRM_28Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_29Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_29Param, SAKA2011_PRM_29Value)
                End If
                If Not String.IsNullOrEmpty(SAKA2011_PRM_30Param) Then
                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_30Param, SAKA2011_PRM_30Value)
                End If

                Dim objAdapter As SqlDataAdapter = New SqlDataAdapter(objSQLCommand)

                objAdapter.SelectCommand.ExecuteNonQuery()

                SAKA2011_PRM_01ReturnValueParamNumericValue = ReturnValueParm.Value
            End Using

            objConnDB.Close()
        End Using

    End Sub


    '*************************
    '***** TIDAK DIPAKAI *****
    '*************************
    'Public Sub SAKA2011_SP_OutputValue_P1P6()

    '    Try
    '        Using objConnDB As New SqlConnection(arisnjp01General_clsDatabaseAndServer.SAKA2011_NET_ConnectionSTRING(SAKA2011_P1_Server, SAKA2011_P1_NamaDatabaseTarget))
    '            objConnDB.Open()

    '            Using objSQLCommand As New SqlCommand() With {.Connection = objConnDB, _
    '                                                          .CommandText = SAKA2011_P6_NameStoredProcedure, _
    '                                                          .CommandType = CommandType.StoredProcedure}
    '                Dim outParm As SqlParameter = New SqlParameter() With { _
    '                                                                .ParameterName = SAKA2011_PRM_01OUTPUTParamNumeric, .DbType = DbType.Double, _
    '                                                                .Direction = ParameterDirection.Output, .IsNullable = False, .Value = SAKA2011_PRM_01OUTPUTParamNumericValue}

    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_01OUTPUTParamNumeric) Then
    '                    objSQLCommand.Parameters.Add(outParm)
    '                End If

    '                Dim outParm1 As SqlParameter = New SqlParameter() With { _
    '                                                                .ParameterName = SAKA2011_PRM_02OUTPUTParamNumeric, .DbType = DbType.Double, _
    '                                                                .Direction = ParameterDirection.Output, .IsNullable = False, .Value = SAKA2011_PRM_02OUTPUTParamNumericValue}

    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_02OUTPUTParamNumeric) Then
    '                    objSQLCommand.Parameters.Add(outParm1)
    '                End If

    '                Dim outParm2 As SqlParameter = New SqlParameter() With { _
    '                                        .ParameterName = SAKA2011_PRM_03OUTPUTParamNumeric, .DbType = DbType.Double, _
    '                                        .Direction = ParameterDirection.Output, .IsNullable = False, .Value = SAKA2011_PRM_03OUTPUTParamNumericValue}

    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_03OUTPUTParamNumeric) Then
    '                    objSQLCommand.Parameters.Add(outParm2)
    '                End If

    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_01Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_01Param, SAKA2011_PRM_01Value)
    '                End If
    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_02Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_02Param, SAKA2011_PRM_02Value)
    '                End If
    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_03Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_03Param, SAKA2011_PRM_03Value)
    '                End If
    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_04Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_04Param, SAKA2011_PRM_04Value)
    '                End If
    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_05Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_05Param, SAKA2011_PRM_05Value)
    '                End If
    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_06Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_06Param, SAKA2011_PRM_06Value)
    '                End If
    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_07Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_07Param, SAKA2011_PRM_07Value)
    '                End If
    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_08Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_08Param, SAKA2011_PRM_08Value)
    '                End If
    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_09Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_09Param, SAKA2011_PRM_09Value)
    '                End If
    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_10Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_10Param, SAKA2011_PRM_10Value)
    '                End If
    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_11Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_11Param, SAKA2011_PRM_11Value)
    '                End If
    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_12Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_12Param, SAKA2011_PRM_12Value)
    '                End If
    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_13Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_13Param, SAKA2011_PRM_13Value)
    '                End If
    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_14Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_14Param, SAKA2011_PRM_14Value)
    '                End If
    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_15Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_15Param, SAKA2011_PRM_15Value)
    '                End If
    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_16Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_16Param, SAKA2011_PRM_16Value)
    '                End If
    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_17Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_17Param, SAKA2011_PRM_17Value)
    '                End If
    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_18Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_18Param, SAKA2011_PRM_18Value)
    '                End If
    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_19Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_19Param, SAKA2011_PRM_19Value)
    '                End If
    '                If Not String.IsNullOrEmpty(SAKA2011_PRM_20Param) Then
    '                    objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_20Param, SAKA2011_PRM_20Value)
    '                End If


    '                Dim objAdapter As SqlDataAdapter = New SqlDataAdapter(objSQLCommand)

    '                objAdapter.SelectCommand.ExecuteNonQuery()

    '                SAKA2011_PRM_01OUTPUTParamNumericValue = outParm
    '                SAKA2011_PRM_02OUTPUTParamNumericValue = outParm1
    '                SAKA2011_PRM_03OUTPUTParamNumericValue = outParm2
    '            End Using

    '            objConnDB.Close()
    '        End Using
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub

    Public Sub SAKA2011_SP_ExecuteNQ_P1P6()

        Try
            Using objConnDB As New SqlConnection(arisnjp01General_clsDatabaseAndServer.SAKA2011_NET_ConnectionSTRING(SAKA2011_P1_Server, SAKA2011_P1_NamaDatabaseTarget))
                objConnDB.Open()

                Using objSQLCommand As New SqlCommand() With {.Connection = objConnDB,
                                                              .CommandText = SAKA2011_P6_NameStoredProcedure,
                                                              .CommandType = CommandType.StoredProcedure}

                    If Not String.IsNullOrEmpty(SAKA2011_PRM_01Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_01Param, SAKA2011_PRM_01Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_02Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_02Param, SAKA2011_PRM_02Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_03Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_03Param, SAKA2011_PRM_03Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_04Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_04Param, SAKA2011_PRM_04Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_05Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_05Param, SAKA2011_PRM_05Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_06Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_06Param, SAKA2011_PRM_06Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_07Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_07Param, SAKA2011_PRM_07Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_08Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_08Param, SAKA2011_PRM_08Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_09Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_09Param, SAKA2011_PRM_09Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_10Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_10Param, SAKA2011_PRM_10Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_11Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_11Param, SAKA2011_PRM_11Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_12Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_12Param, SAKA2011_PRM_12Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_13Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_13Param, SAKA2011_PRM_13Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_14Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_14Param, SAKA2011_PRM_14Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_15Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_15Param, SAKA2011_PRM_15Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_16Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_16Param, SAKA2011_PRM_16Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_17Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_17Param, SAKA2011_PRM_17Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_18Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_18Param, SAKA2011_PRM_18Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_19Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_19Param, SAKA2011_PRM_19Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_20Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_20Param, SAKA2011_PRM_20Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_21Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_21Param, SAKA2011_PRM_21Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_22Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_22Param, SAKA2011_PRM_22Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_23Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_23Param, SAKA2011_PRM_23Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_24Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_24Param, SAKA2011_PRM_24Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_25Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_25Param, SAKA2011_PRM_25Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_26Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_26Param, SAKA2011_PRM_26Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_27Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_27Param, SAKA2011_PRM_27Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_28Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_28Param, SAKA2011_PRM_28Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_29Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_29Param, SAKA2011_PRM_29Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_30Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_30Param, SAKA2011_PRM_30Value)
                    End If

                    Dim objAdapter As SqlDataAdapter = New SqlDataAdapter(objSQLCommand)

                    objAdapter.SelectCommand.ExecuteNonQuery()

                End Using

                objConnDB.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Async Function ExecMethodsSqlAdapter_Async() As Task(Of DataTable)

        Try
            Using objConnDB As New SqlConnection(arisnjp01General_clsDatabaseAndServer.SAKA2011_NET_ConnectionSTRING(SAKA2011_P1_Server, SAKA2011_P1_NamaDatabaseTarget))
                Await objConnDB.OpenAsync()

                Using objSQLCommand As New SqlCommand() With {.Connection = objConnDB,
                                                              .CommandText = SAKA2011_P6_NameStoredProcedure,
                                                              .CommandType = CommandType.StoredProcedure}

                    If Not String.IsNullOrEmpty(SAKA2011_PRM_01Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_01Param, SAKA2011_PRM_01Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_02Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_02Param, SAKA2011_PRM_02Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_03Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_03Param, SAKA2011_PRM_03Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_04Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_04Param, SAKA2011_PRM_04Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_05Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_05Param, SAKA2011_PRM_05Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_06Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_06Param, SAKA2011_PRM_06Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_07Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_07Param, SAKA2011_PRM_07Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_08Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_08Param, SAKA2011_PRM_08Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_09Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_09Param, SAKA2011_PRM_09Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_10Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_10Param, SAKA2011_PRM_10Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_11Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_11Param, SAKA2011_PRM_11Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_12Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_12Param, SAKA2011_PRM_12Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_13Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_13Param, SAKA2011_PRM_13Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_14Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_14Param, SAKA2011_PRM_14Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_15Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_15Param, SAKA2011_PRM_15Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_16Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_16Param, SAKA2011_PRM_16Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_17Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_17Param, SAKA2011_PRM_17Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_18Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_18Param, SAKA2011_PRM_18Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_19Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_19Param, SAKA2011_PRM_19Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_20Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_20Param, SAKA2011_PRM_20Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_21Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_21Param, SAKA2011_PRM_21Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_22Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_22Param, SAKA2011_PRM_22Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_23Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_23Param, SAKA2011_PRM_23Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_24Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_24Param, SAKA2011_PRM_24Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_25Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_25Param, SAKA2011_PRM_25Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_26Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_26Param, SAKA2011_PRM_26Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_27Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_27Param, SAKA2011_PRM_27Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_28Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_28Param, SAKA2011_PRM_28Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_29Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_29Param, SAKA2011_PRM_29Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_30Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_30Param, SAKA2011_PRM_30Value)
                    End If

                    Dim objAdapter As SqlDataAdapter = New SqlDataAdapter(objSQLCommand)

                    Await objAdapter.SelectCommand.ExecuteNonQueryAsync()
                    objAdapter.Fill(SAKA2011_P4_ObjectDataSet, SAKA2011_P3_NamaDataSet)

                End Using

                objConnDB.Close()
            End Using
            Return SAKA2011_P4_ObjectDataSet.Tables(SAKA2011_P3_NamaDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Async Function ExecMethodsSqlDataReader_Async() As Task(Of DataTable)

        Try
            Using objConnDB As New SqlConnection(arisnjp01General_clsDatabaseAndServer.SAKA2011_NET_ConnectionSTRING(SAKA2011_P1_Server, SAKA2011_P1_NamaDatabaseTarget))
                Await objConnDB.OpenAsync()

                Using objSQLCommand As New SqlCommand() With {.Connection = objConnDB,
                                                              .CommandText = SAKA2011_P6_NameStoredProcedure,
                                                              .CommandType = CommandType.StoredProcedure}

                    If Not String.IsNullOrEmpty(SAKA2011_PRM_01Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_01Param, SAKA2011_PRM_01Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_02Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_02Param, SAKA2011_PRM_02Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_03Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_03Param, SAKA2011_PRM_03Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_04Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_04Param, SAKA2011_PRM_04Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_05Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_05Param, SAKA2011_PRM_05Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_06Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_06Param, SAKA2011_PRM_06Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_07Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_07Param, SAKA2011_PRM_07Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_08Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_08Param, SAKA2011_PRM_08Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_09Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_09Param, SAKA2011_PRM_09Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_10Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_10Param, SAKA2011_PRM_10Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_11Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_11Param, SAKA2011_PRM_11Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_12Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_12Param, SAKA2011_PRM_12Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_13Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_13Param, SAKA2011_PRM_13Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_14Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_14Param, SAKA2011_PRM_14Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_15Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_15Param, SAKA2011_PRM_15Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_16Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_16Param, SAKA2011_PRM_16Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_17Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_17Param, SAKA2011_PRM_17Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_18Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_18Param, SAKA2011_PRM_18Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_19Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_19Param, SAKA2011_PRM_19Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_20Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_20Param, SAKA2011_PRM_20Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_21Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_21Param, SAKA2011_PRM_21Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_22Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_22Param, SAKA2011_PRM_22Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_23Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_23Param, SAKA2011_PRM_23Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_24Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_24Param, SAKA2011_PRM_24Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_25Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_25Param, SAKA2011_PRM_25Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_26Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_26Param, SAKA2011_PRM_26Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_27Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_27Param, SAKA2011_PRM_27Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_28Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_28Param, SAKA2011_PRM_28Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_29Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_29Param, SAKA2011_PRM_29Value)
                    End If
                    If Not String.IsNullOrEmpty(SAKA2011_PRM_30Param) Then
                        objSQLCommand.Parameters.AddWithValue(SAKA2011_PRM_30Param, SAKA2011_PRM_30Value)
                    End If


                    Dim objReader As SqlDataReader
                    objReader = Await objSQLCommand.ExecuteReaderAsync
                    Await objReader.ReadAsync
                    SAKA2011_P4_ObjectDataSet.Tables(0).Load(objReader)

                End Using

                objConnDB.Close()
            End Using
            Return SAKA2011_P4_ObjectDataSet.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function



#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then

                ' TODO: dispose managed state (managed objects).

            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.

        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
