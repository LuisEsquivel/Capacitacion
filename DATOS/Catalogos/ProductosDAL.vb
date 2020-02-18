


Public Class ProductosDAL

    Dim SQL As SQLconn.ADONet.SQLConn
    Dim dt As ESTRUCTURAS.DSProductos.TBLPRODUCTOSDataTable

    Private Sub Llenar(ByVal renglon As DataRow, ByRef productos As ESTRUCTURAS.DSProductos.TBLPRODUCTOSRow)
        productos.CVE_PRODUCTO_VAR = renglon.Item("CVE_PRODUCTO_VAR")
        productos.NOMBRE_VAR = renglon.Item("NOMBRE_VAR")
        productos.PRECIO_DEC = renglon.Item("PRECIO_DEC")
        productos.CVE_USUARIO_VAR = renglon.Item("CVE_EMPLEADO_VAR")
        productos.CVE_USUARIO_MOD_VAR = renglon.Item("CVE_EMPLEADO_MOD_VAR")
        productos.FECHA_ALTA_DATE = renglon.Item("FECHA_DE_ALTA_MOD_DATETIME")
        productos.FECHA_MOD_DATET = renglon.Item("FECHA_DE_ALTA_DATETIME")
    End Sub


    Public Sub Cargar(ByVal tabla As DataTable,
                      Optional ByVal CVE_PRODUCTO_VAR As String = "",
                      Optional ByVal NOMBRE_VAR As String = "")

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_PRODUCTO_VAR", CVE_PRODUCTO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_VAR", NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Consultar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLPRODUCTOS"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar productos " & ex.Message)
        End Try
    End Sub

    Public Sub CargarAdicional(ByVal tabla As DataTable,
                               ByVal FECHA_INICIAL_DATE As DateTime,
                               ByVal FECHA_FINAL_DATE As DateTime,
                               Optional ByVal CVE_PRODUCTO_VAR As String = "",
                               Optional ByVal NOMBRE_VAR As String = ""
                               )

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@FECHA_INICIAL_DATE", FECHA_INICIAL_DATE, SqlDbType.DateTime)
        SQL.AddParam("@FECHA_FINAL_DATE", FECHA_FINAL_DATE, SqlDbType.DateTime)
        SQL.AddParam("@CVE_PRODUCTO_VAR", CVE_PRODUCTO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_VAR", NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.ConsultaAdicional, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLPRODUCTOS"

        Try
            SQL.FillDt(tabla)
        Catch ex As Exception
            MsgBox("Error al cargar productos " & ex.Message)
        End Try

    End Sub



    Public Function Agregar(ByRef productos As ESTRUCTURAS.DSProductos.TBLPRODUCTOSRow) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_PRODUCTO_VAR", productos.CVE_PRODUCTO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_VAR", productos.NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@PRECIO_DEC", productos.PRECIO_DEC, SqlDbType.Decimal)
        SQL.AddParam("@CVE_USUARIO_VAR", productos.CVE_USUARIO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@CVE_USUARIO_MOD_VAR", productos.CVE_USUARIO_MOD_VAR, SqlDbType.VarChar)
        SQL.AddParam("@FECHA_ALTA_DATE", productos.FECHA_ALTA_DATE, SqlDbType.DateTime)
        SQL.AddParam("@FECHA_MOD_DATET", productos.FECHA_MOD_DATET, SqlDbType.DateTime)
        SQL.AddParam("@Accion", Accion.Agregar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLPRODUCTOS"

        Try
            dt = New ESTRUCTURAS.DSProductos.TBLPRODUCTOSDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), productos)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al agregar productos " & ex.Message)
        End Try

        Return False

    End Function

    Public Function Modificar(ByRef productos As ESTRUCTURAS.DSProductos.TBLPRODUCTOSRow) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)


        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_PRODUCTO_VAR", productos.CVE_PRODUCTO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@NOMBRE_VAR", productos.NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@PRECIO_DEC", productos.PRECIO_DEC, SqlDbType.Decimal)
        SQL.AddParam("@CVE_USUARIO_MOD_VAR", productos.CVE_USUARIO_MOD_VAR, SqlDbType.VarChar)
        SQL.AddParam("@FECHA_MOD_DATET", productos.FECHA_MOD_DATET, SqlDbType.DateTime)
        SQL.AddParam("@Accion", Accion.Modificar, SqlDbType.Int)

        SQL.cmdText = "PROC_TBLPRODUCTOS"

        Try
            dt = New ESTRUCTURAS.DSProductos.TBLPRODUCTOSDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), productos)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al modificar productos " & ex.Message)
        End Try

        Return False

    End Function

End Class
