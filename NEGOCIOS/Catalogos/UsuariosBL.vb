
Public Class UsuariosBL : Inherits ESTRUCTURAS.DSUsuarios

    Dim DAL As New DATOS.UsuariosDAL

    Public Sub Cargar(Optional ByVal CVE_USUAARIO_VAR As String = "",
                     Optional ByVal NOMBRE_USUARIO_VAR As String = "",
                     Optional ByVal DEPARTAMENTO_VAR As String = "",
                      Optional ByVal RUTA_FOTO_VAR As String = ""
                     )

        DAL = New DATOS.UsuariosDAL
        DAL.Cargar(TBLUSUARIOS, CVE_USUAARIO_VAR, NOMBRE_USUARIO_VAR, DEPARTAMENTO_VAR, RUTA_FOTO_VAR)

    End Sub

    Public Sub CargarUsuario(Optional ByVal CVE_USUAARIO_VAR As String = "",
                             Optional ByVal PASSWORD_VAR As String = "")
        DAL = New DATOS.UsuariosDAL
        DAL.CargarUsuario(TBLUSUARIOS, CVE_USUAARIO_VAR, PASSWORD_VAR)

    End Sub

    Public Sub CargarAdicional(ByVal FECHA_INICIAL_DATE As DateTime,
                               ByVal FECHA_FINAL_DATE As DateTime,
                               Optional ByVal CVE_USUARIO_VAR As String = "",
                               Optional ByVal NOMBRE_VAR As String = "")

        DAL = New DATOS.UsuariosDAL
        DAL.CargarAdicional(TBLUSUARIOS, FECHA_INICIAL_DATE, FECHA_FINAL_DATE, CVE_USUARIO_VAR, NOMBRE_VAR)

    End Sub

    Public Function Agregar(ByRef usuarios As TBLUSUARIOSRow)

        DAL = New DATOS.UsuariosDAL
        If DAL.Agregar(usuarios) Then
            TBLUSUARIOS.Rows.Add(usuarios)
        End If
        Return True

    End Function

    Public Function Modificar(ByVal usuarios As TBLUSUARIOSRow)

        DAL = New DATOS.UsuariosDAL
        If DAL.Modificar(usuarios) Then
        End If

        Return True

    End Function

End Class
