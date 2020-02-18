Public Class ProveedoresBL : Inherits ESTRUCTURAS.DSProveedores
    Dim DAL As DATOS.ProveedoresDAL

    Public Sub Cargar(Optional ByVal CVE_PROVEEDOR_VAR As String = "",
                      Optional ByVal NOMBRE_VAR As String = "",
                      Optional ByVal APELLIDOS_VAR As String = "",
                      Optional ByVal TELEFONO_VAR As String = "",
                      Optional ByVal RAZON_SOCIAL_VAR As String = "",
                      Optional ByVal CORREO_VAR As String = "")

        DAL = New DATOS.ProveedoresDAL
        DAL.Cargar(TBLPROVEEDORES, CVE_PROVEEDOR_VAR,
                    NOMBRE_VAR,
                    APELLIDOS_VAR,
                    TELEFONO_VAR,
                    RAZON_SOCIAL_VAR,
                    CORREO_VAR)

    End Sub

    Public Sub CargarAdicional(ByVal FECHA_INICIAL_DATE As DateTime,
                               ByVal FECHA_FINAL_DATE As DateTime,
                               Optional ByVal CVE_PROVEEDOR_VAR As String = "",
                               Optional ByVal NOMBRE_VAR As String = "",
                               Optional ByVal APELLIDOS_VAR As String = "",
                               Optional ByVal TELEFONO_VAR As String = "",
                               Optional ByVal RAZON_SOCIAL_VAR As String = "",
                               Optional ByVal CORREO_VAR As String = "")

        DAL = New DATOS.ProveedoresDAL
        DAL.CargarAdicional(TBLPROVEEDORES,
                            FECHA_INICIAL_DATE,
                            FECHA_FINAL_DATE, CVE_PROVEEDOR_VAR,
                            NOMBRE_VAR,
                            APELLIDOS_VAR,
                            TELEFONO_VAR,
                            RAZON_SOCIAL_VAR,
                            CORREO_VAR)

    End Sub

    Public Function Agregar(ByVal proveedores As TBLPROVEEDORESRow) As Boolean

        DAL = New DATOS.ProveedoresDAL
        If DAL.Agregar(proveedores) Then
            TBLPROVEEDORES.Rows.Add(proveedores)
        End If

        Return True

    End Function

    Public Function Modificar(ByVal proveedores As TBLPROVEEDORESRow) As Boolean
        DAL = New DATOS.ProveedoresDAL
        If DAL.Modificar(proveedores) Then
            TBLPROVEEDORES.Rows.Add(proveedores)
        End If

        Return True

    End Function

End Class
