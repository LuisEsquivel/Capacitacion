Public Class Empleados_Govea_BL : Inherits ESTRUCTURAS.DSEmpleados

    Dim DAL As DATOS.Empleados_Govea_DAL


    Public Function Agregar(ByVal empleados As TBLEMPLEADOS_GOVEARow) As Boolean

        DAL = New DATOS.Empleados_Govea_DAL
        If DAL.Agregar(empleados) Then
            TBLEMPLEADOS_GOVEA.Rows.Add(empleados)
        End If

        Return True

    End Function

    Public Function Modificar(ByVal empleados As TBLEMPLEADOS_GOVEARow) As Boolean
        DAL = New DATOS.Empleados_Govea_DAL
        If DAL.Modificar(empleados) Then

        End If
        Return True
    End Function




End Class
