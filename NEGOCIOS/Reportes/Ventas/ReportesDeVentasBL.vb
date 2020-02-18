
Public Class ReportesDeVentasBL

    Inherits ESTRUCTURAS.DSReportesDeVentas

    Dim DAL As DATOS.ReportesDeVentasDAL

    Public Sub CargarAdicional(ByVal FECHA_INICIAL_DATE As DateTime,
                      ByVal FECHA_FINAL_DATE As DateTime,
                      Optional ByVal OPCION As String = "",
                      Optional ByVal CVE_VENTA_INICIAL_INT As Integer = 0,
                      Optional ByVal CVE_VENTA_FINAL_INT As Integer = 0,
                      Optional ByVal CVE_CLIENTE_INICIAL_INT As Integer = 0,
                      Optional ByVal CVE_CLIENTE_FINAL As Integer = 0)

        DAL = New DATOS.ReportesDeVentasDAL
        DAL.CargarAdicional(TBLVENTA,
                            FECHA_INICIAL_DATE,
                            FECHA_FINAL_DATE,
                            OPCION,
                            CVE_VENTA_INICIAL_INT,
                            CVE_VENTA_FINAL_INT,
                            CVE_CLIENTE_INICIAL_INT,
                            CVE_CLIENTE_FINAL)

    End Sub


    Public Sub Cargar(Optional ByVal CVE_VENTA_INT As Int32 = 0,
                      Optional ByVal OPCION As String = "")

        DAL = New DATOS.ReportesDeVentasDAL
        DAL.Cargar(TBLVENTA, CVE_VENTA_INT, OPCION)

    End Sub

    Public Sub CargarDetalle(ByVal FECHA_INICIAL_DATE As DateTime,
                              ByVal FECHA_FINAL_DATE As DateTime,
                              Optional ByVal OPCION As String = "",
                              Optional ByVal CVE_VENTA_INICIAL_INT As Integer = 0,
                              Optional ByVal CVE_VENTA_FINAL_INT As Integer = 0,
                              Optional ByVal CVE_CLIENTE_INICIAL_INT As Integer = 0,
                              Optional ByVal CVE_CLIENTE_FINAL As Integer = 0)

        DAL = New DATOS.ReportesDeVentasDAL
        DAL.CargarDetalle(TBLDETALLE_VENTA,
                          FECHA_INICIAL_DATE,
                          FECHA_FINAL_DATE,
                          OPCION,
                          CVE_VENTA_INICIAL_INT,
                          CVE_VENTA_FINAL_INT,
                          CVE_CLIENTE_INICIAL_INT,
                          CVE_CLIENTE_FINAL
                          )

    End Sub

End Class
