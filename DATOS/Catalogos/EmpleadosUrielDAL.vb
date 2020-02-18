Public Class EmpleadosUrielDAL
    Dim SQL As SQLconn.ADONet.SQLConn
    Dim dt As ESTRUCTURAS.DSEmpleadosUriel.TBLEMPLEADOS_URIELDataTable

    Public Function Agregar(ByVal empleados As ESTRUCTURAS.DSEmpleadosUriel.TBLEMPLEADOS_URIELRow) As Boolean
        SQL = New SQLconn.ADONet.SQLConn(ConeccionBD)
        SQL.cmdType = CommandType.StoredProcedure

        SQL.AddParam("@NOMBRE_VAR", empleados.NOMBRE_VAR, SqlDbType.VarChar)
        SQL.AddParam("@APELLIDO_VAR", empleados.APELLIDO_VAR, SqlDbType.VarChar)
        SQL.AddParam("@FECHA_ALTA_DATE", empleados.FECHA_ALTA_DATE, SqlDbType.DateTime)
        SQL.AddParam("@FECHA_MOD_DATE", empleados.FECHA_MOD_DATE, SqlDbType.DateTime)
        SQL.AddParam("@Accion", Generales.Accion.Agregar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLEMPLEADOS_URIEL"

        Try
            dt = New ESTRUCTURAS.DSEmpleadosUriel.TBLEMPLEADOS_URIELDataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error sl agregar empleado" & ex.Message)
        End Try

        Return False

    End Function

End Class
