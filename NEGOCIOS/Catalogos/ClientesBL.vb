Public Class ClientesBL : Inherits ESTRUCTURAS.DSClientes

    Dim DAL As DATOS.ClientesDAL

    Public Sub Cargar(Optional ByVal CVE_CLIENTE_INT As Integer = 0, Optional ByVal NOMBRE_VAR As String = "",
                      Optional ByVal TELEFONO_VAR As String = "", Optional ByVal RFC_VAR As String = "")

        DAL = New DATOS.ClientesDAL
        DAL.Cargar(TBLCLIENTE, CVE_CLIENTE_INT, NOMBRE_VAR, TELEFONO_VAR, RFC_VAR)

    End Sub

    Public Sub CargarAdicional(ByVal FECHA_INICIAL_DATE As DateTime,
                               ByVal FECHA_FINAL_DATE As DateTime,
                               Optional ByVal CVE_CLIENTE_INICIAL_INT As Integer = 0,
                               Optional ByVal CVE_CLIENTE_FINAL_INT As Integer = 0,
                               Optional ByVal NOMBRE_VAR As String = "",
                               Optional ByVal TELEFONO_VAR As String = "",
                               Optional ByVal RFC_VAR As String = "")

        DAL = New DATOS.ClientesDAL
        DAL.CargarAdicional(TBLCLIENTE,
                            FECHA_INICIAL_DATE,
                            FECHA_FINAL_DATE,
                            CVE_CLIENTE_INICIAL_INT,
                            CVE_CLIENTE_FINAL_INT,
                            NOMBRE_VAR,
                            TELEFONO_VAR,
                            RFC_VAR
                            )

    End Sub

    Public Function Agregar(ByVal clientes As TBLCLIENTERow) As Boolean

        DAL = New DATOS.ClientesDAL
        If DAL.Agregar(clientes) Then
            TBLCLIENTE.Rows.Add(clientes)
        End If

        Return True

    End Function

    Public Function Modificar(ByVal clientes As TBLCLIENTERow) As Boolean
        DAL = New DATOS.ClientesDAL
        If DAL.Modificar(clientes) Then

        End If
        Return True
    End Function


End Class
