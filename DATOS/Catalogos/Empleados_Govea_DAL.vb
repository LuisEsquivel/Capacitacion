Public Class Empleados_Govea_DAL
    Dim SQL As SQLconn.ADONet.SQLConn
    Dim dt As ESTRUCTURAS.DSEmpleados.TBLEMPLEADOS_GOVEADataTable


    Public Function Agregar(ByVal empleados As ESTRUCTURAS.DSEmpleados.TBLEMPLEADOS_GOVEARow) As Boolean

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@NOMBRE", empleados.NOMBRE, SqlDbType.VarChar)
        SQL.AddParam("@APELLIDO", empleados.APELLIDO, SqlDbType.VarChar)
        SQL.AddParam("@FECHA_ALTA", empleados.FECHA_ALTA, SqlDbType.VarChar)
        SQL.AddParam("@FECHA_MOD", empleados.FECHA_MOD, SqlDbType.VarChar)
        SQL.AddParam("@Accion", Accion.Agregar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLEMPLEADOS_GOVEA"

        Try
            dt = New ESTRUCTURAS.DSEmpleados.TBLEMPLEADOS_GOVEADataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), empleado)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al agregar empleado" & ex.Message)
        End Try
        Return False
    End Function

    Public Function Modificar(ByVal empleados As ESTRUCTURAS.DSEmpleados.TBLEMPLEADOS_GOVEARow)

        SQL = New SQLconn.ADONet.SQLConn(Generales.ConeccionBD)

        SQL.cmdType = CommandType.StoredProcedure
        SQL.AddParam("@CVE_EMPLEADO", empleados.CVE_EMPLEADO, SqlDbType.Int)
        SQL.AddParam("@NOMBRE", empleados.NOMBRE, SqlDbType.VarChar)
        SQL.AddParam("@APELLIDO", empleados.APELLIDO, SqlDbType.VarChar)
        SQL.AddParam("@FECHAR_ALTA", empleados.FECHA_ALTA, SqlDbType.DateTime)
        SQL.AddParam("@FECHAR_MOD", empleados.FECHA_MOD, SqlDbType.DateTime)
        SQL.AddParam("@Accion", Accion.Modificar, SqlDbType.Int)
        SQL.cmdText = "PROC_TBLEMPLEADOS_GOVEA"

        Try

            dt = New ESTRUCTURAS.DSEmpleados.TBLEMPLEADOS_GOVEADataTable
            SQL.FillDt(dt)
            If dt.Rows.Count > 0 Then
                Llenar(dt.Rows(0), empleados)
                Return True
            End If
        Catch ex As Exception
            MsgBox("" & ex.Message)
        End Try

        Return False
    End Function








End Class
