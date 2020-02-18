Public Class RolesBL : Inherits ESTRUCTURAS.DSRoles

    Dim DAL As DATOS.RolesDAL

    Public Sub Cargar(Optional ByVal CVE_ROL_INT As Integer = 0, Optional ByVal NOMBRE_ROL_VAR As String = "")

        DAL = New DATOS.RolesDAL
        DAL.Cargar(TBLROLES, CVE_ROL_INT, NOMBRE_ROL_VAR)
    End Sub

    Public Sub CargarAdicional(ByVal FECHA_INICIAL_DATE As DateTime,
                               ByVal FECHA_FINAL_DATE As DateTime,
                               Optional ByVal CVE_ROL_INICIAL_INT As Integer = 0,
                               Optional ByVal CVE_ROL_FINAL_INT As Integer = 0,
                               Optional ByVal NOMBRE_ROL_VAR As String = "")

        DAL = New DATOS.RolesDAL
        DAL.CargarAdicional(TBLROLES, FECHA_INICIAL_DATE, FECHA_FINAL_DATE, CVE_ROL_INICIAL_INT,
                            CVE_ROL_FINAL_INT, NOMBRE_ROL_VAR)

    End Sub

    Public Function Agregar(ByVal roles As TBLROLESRow) As Boolean

        DAL = New DATOS.RolesDAL
        If DAL.Agregar(roles) Then
            TBLROLES.Rows.Add(roles)
        End If
        Return True

    End Function

    Public Function Modificar(ByVal roles As TBLROLESRow) As Boolean
        DAL = New DATOS.RolesDAL
        If DAL.Modificar(roles) Then

        End If
        Return True
    End Function

End Class
