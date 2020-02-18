Public Class ReporteDeCotizacionesBL
    Inherits ESTRUCTURAS.DSReporteDeCotizaciones

    Dim DAL As DATOS.ReporteCotizacionesDAL

    Public Sub CargarAdicional(ByVal FECHA_INICIAL_DATE As DateTime,
                      ByVal FECHA_FINAL_DATE As DateTime,
                      Optional ByVal OPCION As String = "",
                      Optional ByVal CVE_COTIZACION_INICIAL_INT As Integer = 0,
                      Optional ByVal CVE_COTIZACION_FINAL_INT As Integer = 0,
                      Optional ByVal CVE_CLIENTE_INICIAL_INT As Integer = 0,
                      Optional ByVal CVE_CLIENTE_FINAL As Integer = 0)

        DAL = New DATOS.ReporteCotizacionesDAL
        DAL.CargarAdicional(TBLCOTIZACION,
                            FECHA_INICIAL_DATE,
                            FECHA_FINAL_DATE,
                            OPCION,
                            CVE_COTIZACION_INICIAL_INT,
                            CVE_COTIZACION_FINAL_INT,
                            CVE_CLIENTE_INICIAL_INT,
                            CVE_CLIENTE_FINAL)

    End Sub


    Public Sub Cargar(Optional ByVal CVE_COTIZACION_INT As Int32 = 0,
                      Optional ByVal OPCION As String = "")

        DAL = New DATOS.ReporteCotizacionesDAL
        DAL.Cargar(TBLCOTIZACION, CVE_COTIZACION_INT, OPCION)

    End Sub

    Public Sub CargarDetalle(ByVal FECHA_INICIAL_DATE As DateTime,
                              ByVal FECHA_FINAL_DATE As DateTime,
                              Optional ByVal OPCION As String = "",
                              Optional ByVal CVE_COTIZACION_INICIAL_INT As Integer = 0,
                              Optional ByVal CVE_COTIZACION_FINAL_INT As Integer = 0,
                              Optional ByVal CVE_CLIENTE_INICIAL_INT As Integer = 0,
                              Optional ByVal CVE_CLIENTE_FINAL As Integer = 0)

        DAL = New DATOS.ReporteCotizacionesDAL
        DAL.CargarDetalle(TBLDETALLE_COTIZACION,
                          FECHA_INICIAL_DATE,
                          FECHA_FINAL_DATE,
                          OPCION,
                          CVE_COTIZACION_INICIAL_INT,
                          CVE_COTIZACION_FINAL_INT,
                          CVE_CLIENTE_INICIAL_INT,
                          CVE_CLIENTE_FINAL
                          )

    End Sub

End Class