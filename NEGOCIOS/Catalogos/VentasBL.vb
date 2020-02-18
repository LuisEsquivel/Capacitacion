Public Class VentasBL

    Inherits ESTRUCTURAS.DSVentas

    Dim DAL As DATOS.VentasDAL


    Public Sub Cargar(Optional ByVal CVE_VENTA_INT As Int32 = 0)

        DAL = New DATOS.VentasDAL
        DAL.Cargar(TBLVENTA, CVE_VENTA_INT)

    End Sub

    Public Sub CargarAdicional(ByVal FECHA_INICIAL_DATE As DateTime,
                               ByVal FECHA_FINAL_DATE As DateTime,
                               Optional ByVal CVE_VENTA_INICIAL_INT As Integer = 0,
                               Optional ByVal CVE_VENTA_FINAL_INT As Integer = 0,
                               Optional ByVal ESTATUS_INT As Integer = 0)

        DAL = New DATOS.VentasDAL
        DAL.CargarAdicional(TBLVENTA, FECHA_INICIAL_DATE, FECHA_FINAL_DATE, CVE_VENTA_INICIAL_INT, CVE_VENTA_FINAL_INT, ESTATUS_INT)

    End Sub

    Public Function GrabarXML(Optional ByVal OPCION As String = "",
                              Optional ByVal CVE_VENTA_INT As Int32 = 0) As Boolean

        DAL = New DATOS.VentasDAL
        Return DAL.GrabarXML(TBLVENTA, "<?xml version=""1.0"" encoding=""iso-8859-1""?>" + GetXml().Replace("xmlns=""http://tempuri.org/DSVentas.xsd""", ""), OPCION, CVE_VENTA_INT)
    End Function

    Public Function CargarDetalle(Optional ByVal CVE_VENTA_INT As Int32 = 0) As Boolean

        DAL = New DATOS.VentasDAL
        Return DAL.CargarDetalle(TBLDETALLE_VENTA, CVE_VENTA_INT)

    End Function


End Class
