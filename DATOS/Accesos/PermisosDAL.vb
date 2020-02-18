Public Class PermisosDAL

    Dim SQL As SQLconn.ADONet.SQLConn
    Dim dt As ESTRUCTURAS.DSPermisos.TBLPERMISOSDataTable

    Private Sub Llenar(ByVal renglon As DataRow, ByRef permisos As ESTRUCTURAS.DSPermisos.TBLPERMISOSRow)

        permisos.CVE_PERMISO_INT = renglon.Item("CVE_PERMISO_INT")
        permisos.ACCESO_CLIENTES_BIT = renglon.Item("ACCESO_CLIENTES_BIT")
        permisos.ACEESO_COTIZACIONES_BIT = renglon.Item("ACEESO_COTIZACIONES_BIT")
        permisos.ACCESO_PRODUCTOS_BIT = renglon.Item("ACCESO_PRODUCTOS_BIT")
        permisos.ACCESO_SUCURSALES_BIT = renglon.Item("ACCESO_SUCURSALES_BIT")
        permisos.ACCESO_USUARIOS_BIT = renglon.Item("ACCESO_USUARIOS_BIT")
        permisos.ACCESO_VENTAS_BIT = renglon.Item("ACCESO_VENTAS_BIT")
        permisos.ACCESO_ROLES_BIT = renglon.Item("ACCESO_ROLES_BIT")
        permisos.ACCESO_REPORTE_VENTAS_BIT = renglon.Item("ACCESO_REPORTE_VENTAS_BIT")
        permisos.ACCESO_REPORTE_COT_BIT = renglon.Item("ACCESO_REPORTE_COT_BIT")
        permisos.ACCESO_PROVEEDORES_BIT = renglon.Item("ACCESO_PROVEEDORES_BIT")

    End Sub

    Public Sub Cargar(ByVal tabla As DataTable,
                      Optional ByVal CVE_PERMISO_INT As Integer = 0)

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_PERMISO_INT", CVE_PERMISO_INT, SqlDbType.Int)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLPERMISOS"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar permiso " & ex.Message)
        End Try

    End Sub

    Public Function Agregar(ByRef permisos As ESTRUCTURAS.DSPermisos.TBLPERMISOSRow) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_PERMISO_INT", permisos.CVE_PERMISO_INT, SqlDbType.Int)
        SQL.AddParam("@ACCESO_CLIENTES_BIT", permisos.ACCESO_CLIENTES_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_COTIZACIONES_BIT", permisos.ACEESO_COTIZACIONES_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_PRODUCTOS_BIT", permisos.ACCESO_PRODUCTOS_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_SUCURSALES_BIT", permisos.ACCESO_SUCURSALES_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_USUARIOS_BIT", permisos.ACCESO_USUARIOS_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_VENTAS_BIT", permisos.ACCESO_VENTAS_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_ROLES_BIT", permisos.ACCESO_ROLES_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_REPORTE_VENTAS_BIT", permisos.ACCESO_REPORTE_VENTAS_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_REPORTE_COT_BIT", permisos.ACCESO_REPORTE_COT_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_PERMISOS_BIT", permisos.ACCESO_PERMISOS_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_PROVEEDORES_BIT", permisos.ACCESO_PROVEEDORES_BIT, SqlDbType.Bit)
        SQL.AddParam("@Accion", Accion.Agregar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLPERMISOS"

        Try
            dt = New ESTRUCTURAS.DSPermisos.TBLPERMISOSDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), permisos)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al agregar permiso " & ex.Message)
        End Try

        Return False

    End Function

    Public Function Modificar(ByRef permisos As ESTRUCTURAS.DSPermisos.TBLPERMISOSRow) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_PERMISO_INT", permisos.CVE_PERMISO_INT, SqlDbType.Int)
        SQL.AddParam("@ACCESO_CLIENTES_BIT", permisos.ACCESO_CLIENTES_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_COTIZACIONES_BIT", permisos.ACEESO_COTIZACIONES_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_PRODUCTOS_BIT", permisos.ACCESO_PRODUCTOS_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_SUCURSALES_BIT", permisos.ACCESO_SUCURSALES_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_USUARIOS_BIT", permisos.ACCESO_USUARIOS_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_VENTAS_BIT", permisos.ACCESO_VENTAS_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_ROLES_BIT", permisos.ACCESO_ROLES_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_REPORTE_VENTAS_BIT", permisos.ACCESO_REPORTE_VENTAS_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_REPORTE_COT_BIT", permisos.ACCESO_REPORTE_COT_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_PERMISOS_BIT", permisos.ACCESO_PERMISOS_BIT, SqlDbType.Bit)
        SQL.AddParam("@ACCESO_PROVEEDORES_BIT", permisos.ACCESO_PROVEEDORES_BIT, SqlDbType.Bit)
        SQL.AddParam("@Accion", Accion.Modificar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLPERMISOS"

        Try
            dt = New ESTRUCTURAS.DSPermisos.TBLPERMISOSDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), permisos)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al modificar permiso " & ex.Message)
        End Try

        Return False

    End Function

End Class
