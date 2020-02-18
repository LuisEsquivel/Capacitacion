


Public Class ProductosBL : Inherits ESTRUCTURAS.DSProductos


    Dim DAL As DATOS.ProductosDAL


    Public Sub Cargar(Optional ByVal CVE_PRODUCTO_VAR As String = "",
                      Optional ByVal NOMBRE_VAR As String = "")
        DAL = New DATOS.ProductosDAL
        DAL.Cargar(TBLPRODUCTOS, CVE_PRODUCTO_VAR, NOMBRE_VAR)
    End Sub

    Public Sub CargarAdicional(ByVal FECHA_INICIAL_DATE As DateTime,
                               ByVal FECHA_FINAL_DATE As DateTime,
                               Optional ByVal CVE_PRODUCTO_VAR As String = "",
                               Optional ByVal NOMBRE_VAR As String = "")

        DAL = New DATOS.ProductosDAL
        DAL.CargarAdicional(TBLPRODUCTOS, FECHA_INICIAL_DATE, FECHA_FINAL_DATE, CVE_PRODUCTO_VAR, NOMBRE_VAR)

    End Sub

    Public Function Agregar(ByVal productos As TBLPRODUCTOSRow) As Boolean
        DAL = New DATOS.ProductosDAL
        If DAL.Agregar(productos) Then
            TBLPRODUCTOS.Rows.Add(productos)
        End If
        Return True
    End Function

    Public Function Modificar(ByVal productos As TBLPRODUCTOSRow) As Boolean
        DAL = New DATOS.ProductosDAL
        If DAL.Modificar(productos) Then
        End If
        Return True
    End Function

End Class
