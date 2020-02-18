Public Class ReporteCotizacionesDAL

    Dim SQL As SQLconn.ADONet.SQLConn
    Dim dt As ESTRUCTURAS.DSReportesDeVentas.TBLVENTADataTable

    Public Sub CargarAdicional(ByVal tabla As DataTable,
                               ByVal FECHA_INICIAL_DATE As DateTime,
                               ByVal FECHA_FINAL_DATE As DateTime,
                               Optional ByVal OPCION As String = "",
                               Optional ByVal CVE_COTIZACION_INICIAL_INT As Integer = 0,
                               Optional ByVal CVE_COTIZACION_FINAL_INT As Integer = 0,
                               Optional ByVal CVE_CLIENTE_INICIAL_INT As Integer = 0,
                               Optional ByVal CVE_CLIENTE_FINAL_INT As Integer = 0)

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@FECHA_INICIAL_DATE", FECHA_INICIAL_DATE, SqlDbType.Date)
        SQL.AddParam("@FECHA_FINAL_DATE", FECHA_FINAL_DATE, SqlDbType.Date)
        SQL.AddParam("@OPCION", OPCION, SqlDbType.VarChar)
        SQL.AddParam("@CVE_COTIZACION_INICIAL_INT", CVE_COTIZACION_INICIAL_INT, SqlDbType.Int)
        SQL.AddParam("@CVE_COTIZACION_FINAL_INT", CVE_COTIZACION_FINAL_INT, SqlDbType.Int)
        SQL.AddParam("@CVE_CLIENTE_INICIAL_INT", CVE_CLIENTE_INICIAL_INT, SqlDbType.Int)
        SQL.AddParam("@CVE_CLIENTE_FINAL_INT", CVE_CLIENTE_FINAL_INT, SqlDbType.Int)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)

        SQL.cmdText = "PROC_REPORTE_COTIZACIONES"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar venta " & ex.Message)
        End Try

    End Sub

    Public Sub Cargar(ByVal tabla As DataTable,
                      Optional ByVal CVE_COTIZACION_INT As Int32 = 0,
                      Optional ByVal OPCION As String = "")

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_COTIZACION_INT", CVE_COTIZACION_INT, SqlDbType.Int)
        SQL.AddParam("@OPCION", OPCION, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)

        SQL.cmdText = "PROC_REPORTE_COTIZACIONES"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar venta " & ex.Message)
        End Try

    End Sub


    Public Sub CargarDetalle(ByVal tabla As DataTable,
                             ByVal FECHA_INICIAL_DATE As DateTime,
                             ByVal FECHA_FINAL_DATE As DateTime,
                             Optional ByVal OPCION As String = "",
                             Optional ByVal CVE_COTIZACION_INICIAL_INT As Integer = 0,
                             Optional ByVal CVE_COTIZACION_FINAL_INT As Integer = 0,
                             Optional ByVal CVE_CLIENTE_INICIAL_INT As Integer = 0,
                             Optional ByVal CVE_CLIENTE_FINAL_INT As Integer = 0)

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@FECHA_INICIAL_DATE", FECHA_INICIAL_DATE, SqlDbType.Date)
        SQL.AddParam("@FECHA_FINAL_DATE", FECHA_FINAL_DATE, SqlDbType.Date)
        SQL.AddParam("@OPCION", OPCION, SqlDbType.VarChar)
        SQL.AddParam("@CVE_COTIZACION_INICIAL_INT", CVE_COTIZACION_INICIAL_INT, SqlDbType.Int)
        SQL.AddParam("@CVE_COTIZACION_FINAL_INT", CVE_COTIZACION_FINAL_INT, SqlDbType.Int)
        SQL.AddParam("@CVE_CLIENTE_INICIAL_INT", CVE_CLIENTE_INICIAL_INT, SqlDbType.Int)
        SQL.AddParam("@CVE_CLIENTE_FINAL_INT", CVE_CLIENTE_FINAL_INT, SqlDbType.Int)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)

        SQL.cmdText = "PROC_REPORTE_COTIZACIONES"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Data Access Layer Exception" & ex.Message)
        End Try
    End Sub


End Class
