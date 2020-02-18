

Imports System.Configuration

Module Generales


    Public ConeccionBD As String = ConfigurationManager.ConnectionStrings("Cap").ConnectionString


    Public Enum Accion
        Consultar = 1
        Agregar = 2
        Modificar = 3
        ConsultaAdicional = 4
        Maestro_Detalle = 5
        Eliminar = 6
        Accion_Adicional = 7
        ConsultaAdicional2 = 8
        BajaDocumento = 9
        ConsultaAdicional3 = 10
        Reporte = 11
        Accion_Adicional2 = 12
        ConsultaAdicional4 = 13
        ConsultaAdicional5 = 14
        Iva = 0.16
    End Enum


End Module
