Public Class ProveedoresDAL

    Dim SQL As SQLconn.ADONet.SQLConn
    Dim dt As ESTRUCTURAS.DSProveedores.TBLPROVEEDORESDataTable

    Public Sub Llenar(ByVal renglon As DataRow, ByVal proveedores As ESTRUCTURAS.DSProveedores.TBLPROVEEDORESRow)
        proveedores.CVE_PROVEEDOR_VAR = renglon.Item("CVE_PROVEEDOR_VAR")
        proveedores.NOMBRE_VAR = renglon.Item("NOMBRE_VAR")
        proveedores.APELLIDOS_VAR = renglon.Item("APELLIDOS_VAR")
        proveedores.TELEFONO_VAR = renglon.Item("TELEFONO_VAR")
        proveedores.RAZON_SOCIAL_VAR = renglon.Item("RAZON_SOCIAL_VAR")
        proveedores.CORREO_VAR = renglon.Item("CORREO_VAR")
        proveedores.FECHA_ALTA_DATE = renglon.Item("FECHA_ALTA_DATE")
        proveedores.FECHA_MOD_DATE = renglon.Item("FECHA_MOD_DATE")
        proveedores.CVE_USUARIO_VAR = renglon.Item("CVE_USUARIO_VAR")
        proveedores.CVE_USUARIO_MOD_VAR = renglon.Item("CVE_USUARIO_MOD_VAR")

    End Sub

    Public Sub Cargar(ByVal tabla As DataTable,
                      Optional ByVal CVE_PROVEEDOR_VAR As String = "",
                      Optional ByVal NOMBRE_VAR As String = "",
                      Optional ByVal APELLIDOS_VAR As String = "",
                      Optional ByVal TELEFONO_VAR As String = "",
                      Optional ByVal RAZON_SOCIAL_VAR As String = "",
                      Optional ByVal CORREO_VAR As String = "")

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_PROVEEDOR_VAR", CVE_PROVEEDOR_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_VAR", NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@APELLIDOS_VAR", APELLIDOS_VAR, SqlDbType.VarChar)
        SQL.AddParam("@TELEFONO_VAR", TELEFONO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@RAZON_SOCIAL_VAR", RAZON_SOCIAL_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CORREO_VAR", CORREO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLPROVEEDORES"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar tabla" & ex.Message)
        End Try

    End Sub

    Public Sub CargarAdicional(ByVal tabla As DataTable,
                               ByVal FECHA_INICIAL_DATE As DateTime,
                               ByVal FECHA_FINAL_DATE As DateTime,
                               Optional ByVal CVE_PROVEEDOR_VAR As String = "",
                               Optional ByVal NOMBRE_VAR As String = "",
                               Optional ByVal APELLIDOS_VAR As String = "",
                               Optional ByVal TELEFONO_VAR As String = "",
                               Optional ByVal RAZON_SOCIAL_VAR As String = "",
                               Optional ByVal CORREO_VAR As String = "")

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_PROVEEDOR_VAR", CVE_PROVEEDOR_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_VAR", NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@APELLIDOS_VAR", APELLIDOS_VAR, SqlDbType.VarChar)
        SQL.AddParam("@TELEFONO_VAR", TELEFONO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@RAZON_SOCIAL_VAR", RAZON_SOCIAL_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CORREO_VAR", CORREO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.ConsultaAdicional, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLPROVEEDORES"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar tabla" & ex.Message)
        End Try

    End Sub

    Public Function Agregar(ByVal proveedores As ESTRUCTURAS.DSProveedores.TBLPROVEEDORESRow) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_PROVEEDOR_VAR", proveedores.CVE_PROVEEDOR_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_VAR", proveedores.NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@APELLIDOS_VAR", proveedores.APELLIDOS_VAR, SqlDbType.VarChar)
        SQL.AddParam("@TELEFONO_VAR", proveedores.TELEFONO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@RAZON_SOCIAL_VAR", proveedores.RAZON_SOCIAL_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CORREO_VAR", proveedores.CORREO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Agregar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLPROVEEDORES"

        Try
            dt = New ESTRUCTURAS.DSProveedores.TBLPROVEEDORESDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), proveedores)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al agregar el proveedor" & ex.Message)
        End Try
        Return False
    End Function

    Public Function Modificar(ByVal proveedores As ESTRUCTURAS.DSProveedores.TBLPROVEEDORESRow) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_PROVEEDOR_VAR", proveedores.CVE_PROVEEDOR_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_VAR", proveedores.NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@APELLIDOS_VAR", proveedores.APELLIDOS_VAR, SqlDbType.VarChar)
        SQL.AddParam("@TELEFONO_VAR", proveedores.TELEFONO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@RAZON_SOCIAL_VAR", proveedores.RAZON_SOCIAL_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CORREO_VAR", proveedores.CORREO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Modificar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLPROVEEDORES"

        Try
            dt = New ESTRUCTURAS.DSProveedores.TBLPROVEEDORESDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), proveedores)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al modificar el proveedor" & ex.Message)
        End Try

        Return False
    End Function

End Class
