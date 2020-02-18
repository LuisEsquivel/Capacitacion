Public Class PermisosBL : Inherits ESTRUCTURAS.DSPermisos

    Dim DAL As DATOS.PermisosDAL

    Public Sub Cargar(Optional ByVal CVE_PERMISO_INT As Integer = 0)

        DAL = New DATOS.PermisosDAL
        DAL.Cargar(TBLPERMISOS,
                   CVE_PERMISO_INT)

    End Sub

    Public Function Agregar(ByVal permisos As TBLPERMISOSRow) As Boolean

        DAL = New DATOS.PermisosDAL
        If DAL.Agregar(permisos) Then
            TBLPERMISOS.Rows.Add(permisos)
        End If
        Return True


    End Function

    Public Function Modificar(ByVal permisos As TBLPERMISOSRow) As Boolean
        DAL = New DATOS.PermisosDAL
        If DAL.Modificar(permisos) Then

        End If
        Return True
    End Function

End Class
