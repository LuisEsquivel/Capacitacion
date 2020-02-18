Public Class UsuariosDAL

    Dim SQL As New SQLconn.ADONet.SQLConn
    Dim dt As New ESTRUCTURAS.DSUsuarios.TBLUSUARIOSDataTable

    Public Sub Llenar(ByVal renglon As DataRow, ByVal usuarios As ESTRUCTURAS.DSUsuarios.TBLUSUARIOSRow)

        usuarios.CVE_USUAARIO_VAR = renglon.Item("@CVE_USUARIO_VAR")
        usuarios.NOMBRE_USUARIO_VAR = renglon.Item("@NOMBRE_USUARIO_VAR")
        usuarios.DEPARTAMENTO_VAR = renglon.Item("@NOMBRE_USUARIO_VAR")
        'usuarios.RUTA_FOTO_VAR = renglon.Item("@RUTA_FOTO_VAR")
        usuarios.CVE_ROL_INT = renglon.Item("@CVE_ROL_INT")
        usuarios.FECHA_ALTA_DATE = renglon.Item("@FECHA_ALTA_DATE")
        usuarios.FECHA_MOD_DATE = renglon.Item("@FECHA_MOD_DATE")
        usuarios.CVE_USUAARIO_VAR = renglon.Item("@CVE_USUAARIO_VAR")
        usuarios.CVE_USUARIO_MOD_VAR = renglon.Item("@CVE_USUARIO_MOD_VAR")

    End Sub

    Public Sub CargarUsuario(ByVal tabla As DataTable, Optional ByVal CVE_USUAARIO_VAR As String = "",
                     Optional ByVal PASSWORD_VAR As String = "")

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_USUAARIO_VAR", CVE_USUAARIO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@PASSWORD_VAR", PASSWORD_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.ConsultaAdicional, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLUSUARIOS"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar usuario", ex.Message)
        End Try

    End Sub

    Public Sub Cargar(ByVal tabla As DataTable, Optional ByVal CVE_USUARIO_VAR As String = "",
                     Optional ByVal NOMBRE_USUARIO_VAR As String = "",
                     Optional ByVal DEPARTAMENTO_VAR As String = "",
                      Optional ByVal RUTA_FOTO_VAR As String = "")

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_USUARIO_VAR", CVE_USUARIO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_USUARIO_VAR", NOMBRE_USUARIO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@DEPARTAMENTO_VAR", DEPARTAMENTO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@RUTA_FOTO_VAR", RUTA_FOTO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLUSUARIOS"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar usuario", ex.Message)
        End Try

    End Sub

    Public Sub CargarAdicional(ByVal tabla As DataTable,
                               ByVal FECHA_INICIAL_DATE As DateTime,
                               ByVal FECHA_FINAL_DATE As DateTime,
                               Optional ByVal CVE_USUARIO_VAR As String = "",
                               Optional ByVal NOMBRE_USUARIO_VAR As String = "")

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@FECHA_INICIAL_DATE", FECHA_INICIAL_DATE, SqlDbType.Date)
        SQL.AddParam("@FECHA_FINAL_DATE", FECHA_FINAL_DATE, SqlDbType.Date)
        SQL.AddParam("@CVE_USUARIO_VAR", CVE_USUARIO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_USUARIO_VAR", NOMBRE_USUARIO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLUSUARIOS"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar cliente" & ex.Message)
        End Try

    End Sub

    Public Function Agregar(ByVal usuarios As ESTRUCTURAS.DSUsuarios.TBLUSUARIOSRow)

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_USUARIO_VAR", usuarios.CVE_USUARIO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_USUARIO_VAR", usuarios.NOMBRE_USUARIO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@PASSWORD_VAR", usuarios.PASSWORD_VAR, SqlDbType.VarChar)
        SQL.AddParam("@DEPARTAMENTO_VAR", usuarios.DEPARTAMENTO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CVE_ROL_INT", usuarios.CVE_ROL_INT, SqlDbType.VarChar)
        SQL.AddParam("@RUTA_FOTO_VAR", usuarios.RUTA_FOTO_VAR, SqlDbType.VarChar)
        SQL.AddParam("Accion", Accion.Agregar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLUSUARIOS"

        Try
            dt = New ESTRUCTURAS.DSUsuarios.TBLUSUARIOSDataTable
            SQL.FillDt(dt)

            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), usuarios)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al agregar usuario", ex.Message)

        End Try
        Return False
    End Function

    Public Function Modificar(ByVal usuarios As ESTRUCTURAS.DSUsuarios.TBLUSUARIOSRow)

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_USUARIO_VAR", usuarios.CVE_USUARIO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_USUARIO_VAR", usuarios.NOMBRE_USUARIO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@PASSWORD_VAR", usuarios.PASSWORD_VAR, SqlDbType.VarChar)
        SQL.AddParam("@DEPARTAMENTO_VAR", usuarios.DEPARTAMENTO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CVE_ROL_INT", usuarios.CVE_ROL_INT, SqlDbType.Int)
        SQL.AddParam("@RUTA_FOTO_VAR", usuarios.RUTA_FOTO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CVE_USUAARIO_VAR", usuarios.CVE_USUAARIO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Modificar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLUSUARIOS"

        Try

            dt = New ESTRUCTURAS.DSUsuarios.TBLUSUARIOSDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), usuarios)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al modificar usuario " & ex.Message)
        End Try

        Return False
    End Function

End Class
