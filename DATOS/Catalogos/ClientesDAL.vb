Public Class ClientesDAL

    Dim SQL As SQLconn.ADONet.SQLConn
    Dim dt As ESTRUCTURAS.DSClientes.TBLCLIENTEDataTable

    Public Sub Llenar(ByVal renglon As DataRow, ByVal clientes As ESTRUCTURAS.DSClientes.TBLCLIENTERow)

        clientes.CVE_CLIENTE_INT = renglon.Item("CVE_CLIENTE_INT")
        clientes.NOMBRE_VAR = renglon.Item("NOMBRE_VAR")
        clientes.TELEFONO_VAR = renglon.Item("TELEFONO_VAR")
        clientes.RFC_VAR = renglon.Item("RFC_VAR")
        clientes.CVE_USUAIRO_VAR = renglon.Item("CVE_USUARIO_VAR")
        clientes.CVE_USUARIO_MOD_VAR = renglon.Item("CVE_USUARIO_MOD_VAR")
        clientes.FECHA_ALTA_DATE = renglon.Item("FECHA_ALTA_DATE")
        clientes.FECHA_MOD_DATE = renglon.Item("FECHA_MOD_DATE")

    End Sub

    Public Sub Cargar(ByVal tabla As DataTable, Optional ByVal CVE_CLIENTE_INT As Integer = 0,
                      Optional ByVal NOMBRE_VAR As String = "", Optional ByVal TELEFONO_VAR As String = "",
                      Optional ByVal RFC_VAR As String = "")

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_CLIENTE_INT", CVE_CLIENTE_INT, SqlDbType.Int)
        SQL.AddParam("@NOMBRE_VAR", NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@TELEFONO_VAR", TELEFONO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@RFC_VAR", RFC_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLCLIENTES"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar cliente" & ex.Message)
        End Try
    End Sub

    Public Sub CargarAdicional(ByVal tabla As DataTable,
                               ByVal FECHA_INICIAL_DATE As DateTime,
                               ByVal FECHA_FINAL_DATE As DateTime,
                               Optional ByVal CVE_CLIENTE_INICIAL_INT As Integer = 0,
                               Optional ByVal CVE_CLIENTE_FINAL_INT As Integer = 0,
                               Optional ByVal NOMBRE_VAR As String = "",
                               Optional ByVal TELEFONO_VAR As String = "",
                               Optional ByVal RFC_VAR As String = "")

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@FECHA_INICIAL_DATE", FECHA_INICIAL_DATE, SqlDbType.DateTime)
        SQL.AddParam("@FECHA_FINAL_DATE", FECHA_FINAL_DATE, SqlDbType.DateTime)
        SQL.AddParam("@NOMBRE_VAR", NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@TELEFONO_VAR", TELEFONO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@RFC_VAR", RFC_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CVE_CLIENTE_INICIAL_INT", CVE_CLIENTE_INICIAL_INT, SqlDbType.Int)
        SQL.AddParam("@CVE_CLIENTE_FINAL_INT", CVE_CLIENTE_FINAL_INT, SqlDbType.Int)
        SQL.AddParam("@Accion", Accion.ConsultaAdicional, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLCLIENTES"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar cliente" & ex.Message)
        End Try
    End Sub

    Public Function Agregar(ByVal clientes As ESTRUCTURAS.DSClientes.TBLCLIENTERow) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@NOMBRE_VAR", clientes.NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@TELEFONO_VAR", clientes.TELEFONO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@RFC_VAR", clientes.RFC_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Agregar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLCLIENTES"

        Try
            dt = New ESTRUCTURAS.DSClientes.TBLCLIENTEDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), clientes)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error sl agregar cliente" & ex.Message)
        End Try

        Return False
    End Function

    Public Function Modificar(ByVal clientes As ESTRUCTURAS.DSClientes.TBLCLIENTERow)

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_CLIENTE_INT", clientes.CVE_CLIENTE_INT, SqlDbType.Int)
        SQL.AddParam("@NOMBRE_VAR", clientes.NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@TELEFONO_VAR", clientes.TELEFONO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@RFC_VAR", clientes.RFC_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Modificar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLCLIENTES"

        Try

            dt = New ESTRUCTURAS.DSClientes.TBLCLIENTEDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), clientes)
                Return True
            End If
        Catch ex As Exception
            MsgBox("" & ex.Message)
        End Try

        Return False
    End Function

End Class
