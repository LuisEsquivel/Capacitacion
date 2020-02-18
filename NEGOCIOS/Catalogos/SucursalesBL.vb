Public Class SucursalesBL : Inherits ESTRUCTURAS.DSSucursales

    Dim DAL As DATOS.SucursalesDAL

    Public Sub Cargar(Optional ByVal CVE_SUC_VAR As String = "",
                      Optional ByVal NOMBRE_SUC_VAR As String = "", Optional ByVal CALLE_VAR As String = "",
                      Optional ByVal NUMERO_INTERIOR_INT As Integer = 0, Optional ByVal NUM_EXTERIOR_INT As Integer = 0,
                      Optional ByVal TELEFONO_VAR As String = "")

        DAL = New DATOS.SucursalesDAL
        DAL.Cargar(TBLSUCURSAL, CVE_SUC_VAR, NOMBRE_SUC_VAR, CALLE_VAR, NUMERO_INTERIOR_INT, NUM_EXTERIOR_INT, TELEFONO_VAR)

    End Sub

    Public Sub CargarAdicional(ByVal FECHA_INICIAL_DATE As DateTime,
                               ByVal FECHA_FINAL_DATE As DateTime,
                               Optional ByVal CVE_SUC_VAR As String = "",
                               Optional ByVal NOMBRE_SUC_VAR As String = "")

        DAL = New DATOS.SucursalesDAL
        DAL.CargarAdicional(TBLSUCURSAL, FECHA_INICIAL_DATE, FECHA_FINAL_DATE, CVE_SUC_VAR, NOMBRE_SUC_VAR)

    End Sub

    Public Function Agregar(ByVal sucursal As TBLSUCURSALRow)

        DAL = New DATOS.SucursalesDAL
        If DAL.Agregar(sucursal) Then
            TBLSUCURSAL.Rows.Add(sucursal)
        End If

        Return True
    End Function

    Public Function Modificar(ByVal sucursal As TBLSUCURSALRow)

        DAL = New DATOS.SucursalesDAL
        If DAL.Modificar(sucursal) Then
            TBLSUCURSAL.Rows.Add(sucursal)
        End If

        Return True

    End Function

End Class
