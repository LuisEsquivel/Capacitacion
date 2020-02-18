Public Class CotizacionesBL : Inherits ESTRUCTURAS.DSCotizaciones

    Dim DAL As DATOS.CotizacionesDAL

    Public Sub Cargar(Optional ByVal CVE_COTIZACION_INT As Int32 = 0)

        DAL = New DATOS.CotizacionesDAL
        DAL.Cargar(TBLCOTIZACION, CVE_COTIZACION_INT)

    End Sub

    Public Sub CargarAdicional(ByVal FECHA_INICIAL_DATE As DateTime,
                               ByVal FECHA_FINAL_DATE As DateTime,
                               Optional ByVal CVE_COTIZACION_INICIAL_INT As Integer = 0,
                               Optional ByVal CVE_COTIZACION_FINAL_INT As Integer = 0,
                               Optional ByVal ESTATUS_INT As Integer = 0)

        DAL = New DATOS.CotizacionesDAL
        DAL.CargarAdicional(TBLCOTIZACION, FECHA_INICIAL_DATE, FECHA_FINAL_DATE, CVE_COTIZACION_INICIAL_INT, CVE_COTIZACION_FINAL_INT, ESTATUS_INT)

    End Sub

    Public Function GrabarXML(Optional ByVal OPCION As String = "",
                              Optional ByVal CVE_COTIZACION_INT As Int32 = 0) As Boolean

        DAL = New DATOS.CotizacionesDAL
        Return DAL.GrabarXML(TBLCOTIZACION, "<?xml version=""1.0"" encoding=""iso-8859-1""?>" + GetXml().Replace("xmlns=""http://tempuri.org/DSCotizaciones.xsd""", ""), OPCION, CVE_COTIZACION_INT)
    End Function

    Public Function CargarDetalle(Optional ByVal CVE_COTIZACION_INT As Int32 = 0) As Boolean

        DAL = New DATOS.CotizacionesDAL
        Return DAL.CargarDetalle(TBLDETALLE_COTIZACION, CVE_COTIZACION_INT)

    End Function

End Class
