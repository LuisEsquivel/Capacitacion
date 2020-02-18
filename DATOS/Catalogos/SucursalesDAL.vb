Public Class SucursalesDAL

    Dim SQL As SQLconn.ADONet.SQLConn
    Dim dt As ESTRUCTURAS.DSSucursales.TBLSUCURSALDataTable

    Public Sub Llenar(ByVal renglon As DataRow, ByVal sucursal As ESTRUCTURAS.DSSucursales.TBLSUCURSALRow)

        sucursal.CVE_SUC_VAR = renglon.Item("CVE_SUC_VAR")
        sucursal.NOMBRE_SUC_VAR = renglon.Item("NOMBRE_SUC_VAR")
        sucursal.CALLE_VAR = renglon.Item("CALLE_VAR")
        sucursal.NUMERO_INTERIOR_INT = renglon.Item("NUMERO_INTERIOR_INT")
        sucursal.NUM_EXTERIOR_INT = renglon.Item("NUMERO_EXTERIOR_INT")
        sucursal.TELEFONO_VAR = renglon.Item("TELEFONO_VAR")

    End Sub

    Public Sub Cargar(ByVal tabla As DataTable, Optional ByVal CVE_SUC_VAR As String = "",
                      Optional ByVal NOMBRE_SUC_VAR As String = "", Optional ByVal CALLE_VAR As String = "",
                      Optional ByVal NUMERO_INTERIOR_INT As Integer = 0, Optional ByVal NUM_EXTERIOR_INT As Integer = 0,
                      Optional ByVal TELEFONO_VAR As String = "")

        Dim SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure

        SQL.AddParam("@CVE_SUC_VAR", CVE_SUC_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_SUC_VAR", NOMBRE_SUC_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CALLE_VAR", CALLE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NUM_INTERIOR_INT", NUMERO_INTERIOR_INT, SqlDbType.Int)
        SQL.AddParam("@NUM_EXTERIOR_INT", NUM_EXTERIOR_INT, SqlDbType.Int)
        SQL.AddParam("@TELEFONO_VAR", TELEFONO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLSUCURSALES"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar sucursal " & ex.Message)
        End Try

    End Sub

    Public Sub CargarAdicional(ByVal tabla As DataTable,
                               ByVal FECHA_INICIAL_DATE As DateTime,
                               ByVal FECHA_FINAL_DATE As DateTime,
                               Optional ByVal CVE_SUC_VAR As String = "",
                               Optional ByVal NOMBRE_SUC_VAR As String = "")

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@FECHA_INICIAL_DATE", FECHA_INICIAL_DATE, SqlDbType.DateTime)
        SQL.AddParam("@FECHA_FINAL_DATE", FECHA_FINAL_DATE, SqlDbType.DateTime)
        SQL.AddParam("@CVE_SUC_VAR", CVE_SUC_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_SUC_VAR", NOMBRE_SUC_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.ConsultaAdicional, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLSUCURSALES"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar sucursal" & ex.Message)
        End Try
    End Sub

    Public Function Agregar(ByVal sucursal As ESTRUCTURAS.DSSucursales.TBLSUCURSALRow) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_SUC_VAR", sucursal.CVE_SUC_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_SUC_VAR", sucursal.NOMBRE_SUC_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CALLE_VAR", sucursal.CALLE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NUM_INTERIOR_INT", sucursal.NUMERO_INTERIOR_INT, SqlDbType.Int)
        SQL.AddParam("@NUM_EXTERIOR_INT", sucursal.NUM_EXTERIOR_INT, SqlDbType.Int)
        SQL.AddParam("@TELEFONO_VAR", sucursal.TELEFONO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Agregar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLSUCURSALES"

        Try
            dt = New ESTRUCTURAS.DSSucursales.TBLSUCURSALDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), sucursal)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error sl agregar sucursal" & ex.Message)
        End Try

        Return False
    End Function

    Public Function Modificar(ByVal sucursal As ESTRUCTURAS.DSSucursales.TBLSUCURSALRow)

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_SUC_VAR", sucursal.CVE_SUC_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_SUC_VAR", sucursal.NOMBRE_SUC_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CALLE_VAR", sucursal.CALLE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NUM_INTERIOR_INT", sucursal.NUMERO_INTERIOR_INT, SqlDbType.Int)
        SQL.AddParam("@NUM_EXTERIOR_INT", sucursal.NUM_EXTERIOR_INT, SqlDbType.Int)
        SQL.AddParam("@TELEFONO_VAR", sucursal.TELEFONO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Modificar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLSUCURSALES"

        Try

            dt = New ESTRUCTURAS.DSSucursales.TBLSUCURSALDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), sucursal)
                Return True
            End If
        Catch ex As Exception
            MsgBox("" & ex.Message)
        End Try

        Return False
    End Function

End Class
