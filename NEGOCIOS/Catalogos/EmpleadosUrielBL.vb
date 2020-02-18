Public Class EmpleadosUrielBL
    Inherits ESTRUCTURAS.DSEmpleadosUriel

    Dim DAL As DATOS.EmpleadosUrielDAL

    Public Function Agregar(ByVal empleados As TBLEMPLEADOS_URIELRow) As Boolean
        DAL = New DATOS.EmpleadosUrielDAL
        If DAL.Agregar(empleados) Then
            TBLEMPLEADOS_URIEL.Rows.Add(empleados)
        End If
        Return True
    End Function

End Class
