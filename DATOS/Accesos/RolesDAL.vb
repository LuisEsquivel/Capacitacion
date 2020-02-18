Public Class RolesDAL

    Dim SQL As SQLconn.ADONet.SQLConn
    Dim dt As ESTRUCTURAS.DSRoles.TBLROLESDataTable

    Private Sub Llenar(ByVal renglon As DataRow, ByRef roles As ESTRUCTURAS.DSRoles.TBLROLESRow)

        roles.CVE_ROL_INT = renglon.Item("CVE_ROL_INT")
        roles.NOMBRE_ROL_VAR = renglon.Item("NOMBRE_ROL_VAR")
        'roles.CVE_USUARIO_VAR = renglon.Item("CVE_USUARIO_VAR")
        roles.CVE_USUARIO_MOD_VAR = renglon.Item("CVE_USUARIO_MOD_VAR")
        roles.FECHA_MOD_DATE = renglon.Item("FECHA_MOD_DAT")
        'roles.FECHA_ALTA_DATE = renglon.Item("FECHA_ALTA_DATE")

    End Sub

    Public Sub Cargar(ByVal tabla As DataTable,
                      Optional ByVal CVE_ROL_INT As String = "",
                      Optional ByVal NOMBRE_ROL_VAR As String = "")

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_ROL_INT", CVE_ROL_INT, SqlDbType.Int)
        SQL.AddParam("@NOMBRE_ROL_VAR", NOMBRE_ROL_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLROLES"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar rol " & ex.Message)
        End Try

    End Sub

    Public Sub CargarAdicional(ByVal tabla As DataTable,
                               ByVal FECHA_INICIAL_DATE As DateTime,
                               ByVal FECHA_FINAL_DATE As DateTime,
                               Optional ByVal CVE_ROL_INICIAL_INT As Integer = 0,
                               Optional ByVal CVE_ROL_FINAL_INT As Integer = 0,
                               Optional ByVal NOMBRE_ROL_VAR As String = ""
                               )

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@FECHA_INICIAL_DATE", FECHA_INICIAL_DATE, SqlDbType.DateTime)
        SQL.AddParam("@FECHA_FINAL_DATE", FECHA_FINAL_DATE, SqlDbType.DateTime)
        SQL.AddParam("@CVE_ROL_INICIAL_INT", CVE_ROL_INICIAL_INT, SqlDbType.Int)
        SQL.AddParam("@CVE_ROL_FINAL_INT", CVE_ROL_FINAL_INT, SqlDbType.Int)
        SQL.AddParam("@NOMBRE_ROL_VAR", NOMBRE_ROL_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.ConsultaAdicional, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLROLES"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar rol", ex.Message)
        End Try

    End Sub

    Public Function Agregar(ByRef roles As ESTRUCTURAS.DSRoles.TBLROLESRow) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        'SQL.AddParam("@CVE_ROL_INT", roles.CVE_ROL_INT, SqlDbType.Int)
        SQL.AddParam("@NOMBRE_ROL_VAR", roles.NOMBRE_ROL_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CVE_USUARIO_VAR", roles.CVE_USUARIO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CVE_USUARIO_MOD_VAR", roles.CVE_USUARIO_MOD_VAR, SqlDbType.VarChar)
        SQL.AddParam("@FECHA_ALTA_DATE", roles.FECHA_ALTA_DATE, SqlDbType.DateTime)
        SQL.AddParam("@FECHA_MOD_DATE", roles.FECHA_MOD_DATE, SqlDbType.DateTime)
        SQL.AddParam("@Accion", Accion.Agregar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLROLES"

        Try
            dt = New ESTRUCTURAS.DSRoles.TBLROLESDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), roles)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al agregar rol " & ex.Message)
        End Try

        Return False

    End Function

    Public Function Modificar(ByRef roles As ESTRUCTURAS.DSRoles.TBLROLESRow) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_ROL_INT", roles.CVE_ROL_INT, SqlDbType.Int)
        SQL.AddParam("@NOMBRE_ROL_VAR", roles.NOMBRE_ROL_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CVE_USUARIO_MOD_VAR", roles.CVE_USUARIO_MOD_VAR, SqlDbType.VarChar)
        SQL.AddParam("@FECHA_MOD_DATE", roles.FECHA_MOD_DATE, SqlDbType.DateTime)
        SQL.AddParam("@Accion", Accion.Modificar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLROLES"

        Try
            dt = New ESTRUCTURAS.DSRoles.TBLROLESDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), roles)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al modificar roles " & ex.Message)
        End Try

        Return False

    End Function

End Class
