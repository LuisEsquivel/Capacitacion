Public Class CotizacionesDAL

    Dim SQL As New SQLconn.ADONet.SQLConn
    Dim dt As ESTRUCTURAS.DSCotizaciones.TBLCOTIZACIONDataTable

    Public Sub Cargar(ByVal tabla As DataTable, Optional ByVal CVE_COTIZACION_INT As Int32 = 0)

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_COTIZACION_INT", CVE_COTIZACION_INT, SqlDbType.Int)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)

        SQL.cmdText = "PROC_MDCOTIZACIONES"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar cotizacion " & ex.Message)
        End Try

    End Sub

    Public Sub CargarAdicional(ByVal tabla As DataTable,
                               ByVal FECHA_INICIAL_DATE As DateTime,
                               ByVal FECHA_FINAL_DATE As DateTime,
                               Optional ByVal CVE_COTIZACION_INICIAL_INT As Integer = 0,
                               Optional ByVal CVE_COTIZACION_FINAL_INT As Integer = 0,
                               Optional ByVal ESTATUS_INT As Integer = 0)

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@FECHA_INICIAL_DATE", FECHA_INICIAL_DATE, SqlDbType.DateTime)
        SQL.AddParam("@FECHA_FINAL_DATE", FECHA_FINAL_DATE, SqlDbType.DateTime)
        SQL.AddParam("@CVE_COTIZACION_INICIAL_INT", CVE_COTIZACION_INICIAL_INT, SqlDbType.Int)
        SQL.AddParam("@CVE_COTIZACION_FINAL_INT", CVE_COTIZACION_FINAL_INT, SqlDbType.Int)
        SQL.AddParam("@ESTATUS_INT", ESTATUS_INT, SqlDbType.Int)
        SQL.AddParam("@Accion", Accion.ConsultaAdicional, SqlDbType.Int)
        SQL.cmdText = "PROC_MDCOTIZACIONES"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar cotizacion" & ex.Message)
        End Try

    End Sub

    Public Function GrabarXML(ByVal dt As DataTable,
                              ByVal XML As String,
                              Optional ByVal OPCION As String = "",
                              Optional ByVal CVE_COTIZACION_INT As Int32 = 0) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@OPCION", OPCION, SqlDbType.VarChar)
        SQL.AddParam("@CVE_COTIZACION_INT", CVE_COTIZACION_INT, SqlDbType.Int)
        SQL.AddParam("@XML", XML, SqlDbType.Text)
        SQL.AddParam("@Accion", Accion.Agregar, SqlDbType.Int)
        SQL.cmdText = "PROC_MDCOTIZACIONES"

        Try
            dt.Clear()
            SQL.FillDt(dt)
        Catch ex As Exception
            MsgBox("Data Access Layer Exception " & ex.Message)
        End Try

        Return True
    End Function

    Public Function CargarDetalle(ByVal tabla As DataTable,
                                 Optional ByVal CVE_COTIZACION_INT As Int32 = 0) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_COTIZACION_INT", CVE_COTIZACION_INT, SqlDbType.Int)
        SQL.AddParam("@Accion", Accion.ConsultaAdicional2, SqlDbType.Int)

        SQL.cmdText = "PROC_MDCOTIZACIONES"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Data Access Layer Exception" & ex.Message)
        End Try

        Return True
    End Function


End Class
