Public Class FRMMenu

#Region "Procedimientos y Funciones"
    Private Function FormularioActivo(ByVal formulario As Form) As Boolean
        If formulario Is Nothing Then
            Return False
        Else
            If formulario.IsDisposed Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub ActivarFormulario(ByVal formulario As Form)
        Generales.ConfiguracionBotones(formulario, Generales.ColorBtn)
        formulario.MdiParent = Me
        formulario.MaximizeBox = False
        formulario.MaximumSize = formulario.Size
        formulario.StartPosition = FormStartPosition.CenterScreen
        formulario.ShowInTaskbar = False
        formulario.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        formulario.Show()
        Generales.RemoveXButton(formulario.Handle.ToInt32)
        formulario.Activate()
    End Sub

    Private Sub CargarPermisos()
        UsuariosBL.Clear()
        UsuariosBL.Cargar(Generales.CVE_USUARIO_VAR)

        If UsuariosBL.TBLUSUARIOS.Rows.Count = 1 Then

            With CType(UsuariosBL.TBLUSUARIOS.Rows(0), NEGOCIOS.UsuariosBL.TBLUSUARIOSRow)
                PermisosBL.Clear()
                PermisosBL.Cargar(.CVE_ROL_INT)
            End With

        End If

        If PermisosBL.TBLPERMISOS.Rows.Count = 1 Then

            With CType(PermisosBL.TBLPERMISOS.Rows(0), NEGOCIOS.PermisosBL.TBLPERMISOSRow)

                If .ACCESO_PERMISOS_BIT Then
                    PermisosToolStripMenuItem.Visible = True
                Else
                    PermisosToolStripMenuItem.Visible = False
                End If

                If .ACCESO_CLIENTES_BIT Then
                    ClientesToolStripMenuItem.Visible = True
                Else
                    ClientesToolStripMenuItem.Visible = False
                End If

                If .ACCESO_PRODUCTOS_BIT Then
                    ProductosToolStripMenuItem.Visible = True
                Else
                    ProductosToolStripMenuItem.Visible = False
                End If

                If .ACCESO_ROLES_BIT Then
                    RolesToolStripMenuItem1.Visible = True
                Else
                    RolesToolStripMenuItem1.Visible = False
                End If

                If .ACCESO_VENTAS_BIT Then
                    VentasToolStripMenuItem.Visible = True
                Else
                    VentasToolStripMenuItem.Visible = False
                End If

                If .ACCESO_USUARIOS_BIT Then
                    UsuariosToolStripMenuItem.Visible = True
                Else
                    UsuariosToolStripMenuItem.Visible = False
                End If

                If .ACEESO_COTIZACIONES_BIT Then
                    CotizacionesToolStripMenuItem.Visible = True
                Else
                    CotizacionesToolStripMenuItem.Visible = False
                End If

                If .ACCESO_SUCURSALES_BIT Then
                    SucursalesToolStripMenuItem.Visible = True
                Else
                    SucursalesToolStripMenuItem.Visible = False
                End If

                If .ACCESO_REPORTE_VENTAS_BIT Then
                    VentasToolStripMenuItem1.Visible = True
                Else
                    VentasToolStripMenuItem1.Visible = False
                End If

                If .ACCESO_REPORTE_COT_BIT Then
                    CotizacionesToolStripMenuItem1.Visible = True
                Else
                    CotizacionesToolStripMenuItem1.Visible = False
                End If

                If .ACCESO_PROVEEDORES_BIT Then
                    ProveedoresToolStripMenuItem.Visible = True
                Else
                    ProveedoresToolStripMenuItem.Visible = False
                End If

            End With

        End If

    End Sub

    Private Sub MostrarUsuario()
        UsuariosBL.Clear()
        UsuariosBL.Cargar(Login.TxtCveUsuario.Text)

        If UsuariosBL.TBLUSUARIOS.Rows.Count = 1 Then
            TxtUsuario.Text = UsuariosBL.TBLUSUARIOS.FindByCVE_USUARIO_VAR(Login.TxtCveUsuario.Text).NOMBRE_USUARIO_VAR
        End If
    End Sub

#End Region

#Region "Variables"

    Private Productos As FRMProductos
    Private roles As FRMRoles
    Private clientes As FRMClientes
    Private Ventas As FRMVenta
    Private Usuarios As FRMUsuarios
    Private Cotizaciones As FRMCotizaciones
    Private Sucursales As FRMSucursales
    Private ReportesDeVentas As FRMReportesDeVentas
    Private ReportesDeCotizaciones As FRMReporteDeCotizaciones
    Private Login As FRMLogin
    Private Permisos As FRMPermisos
    Private Proveedores As FRMProveedores

#End Region

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        If Not FormularioActivo(Productos) Then
            Productos = New FRMProductos
        End If
        ActivarFormulario(Productos)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        Dim Opcion = MsgBox("Esta seguro que desea terminar la sesión?" & vbNewLine, MsgBoxStyle.YesNo, "Aviso")
        If Opcion = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If

    End Sub

    Private Sub RolesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RolesToolStripMenuItem1.Click
        If Not FormularioActivo(roles) Then
            roles = New FRMRoles
        End If
        ActivarFormulario(roles)
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        If Not FormularioActivo(Ventas) Then
            Ventas = New FRMVenta
        End If
        ActivarFormulario(Ventas)
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        If Not FormularioActivo(Usuarios) Then
            Usuarios = New FRMUsuarios
        End If
        ActivarFormulario(Usuarios)
    End Sub

    Private Sub CotizacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CotizacionesToolStripMenuItem.Click

        If Not FormularioActivo(Cotizaciones) Then
            Cotizaciones = New FRMCotizaciones
        End If

        ActivarFormulario(Cotizaciones)

    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SucursalesToolStripMenuItem.Click

        If Not FormularioActivo(Sucursales) Then
            Sucursales = New FRMSucursales

        End If
        ActivarFormulario(Sucursales)

    End Sub

    Private Sub FRMMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not FormularioActivo(Login) Then
            Login = New FRMLogin

        End If
        Login.ShowDialog()

        MostrarUsuario()

    End Sub

    Private Sub PermisosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermisosToolStripMenuItem.Click
        If Not FormularioActivo(Permisos) Then
            Permisos = New FRMPermisos
        End If
        ActivarFormulario(Permisos)
    End Sub

    Private Sub VentasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem1.Click

        If Not FormularioActivo(ReportesDeVentas) Then
            ReportesDeVentas = New FRMReportesDeVentas

        End If
        ActivarFormulario(ReportesDeVentas)

    End Sub

    Private Sub CotizacionesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CotizacionesToolStripMenuItem1.Click
        If Not FormularioActivo(ReportesDeCotizaciones) Then
            ReportesDeCotizaciones = New FRMReporteDeCotizaciones

        End If

        ActivarFormulario(ReportesDeCotizaciones)
    End Sub

    Private Sub CambiarDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarDeUsuarioToolStripMenuItem.Click

        If Generales.Buscar_Formularios_Activos(Me) Then
            Exit Sub
        End If

        If Not FormularioActivo(Login) Then
            Login = New FRMLogin
        End If

        Login.TxtCveUsuario.Clear()
        Login.TxtPassword.Clear()
        Login.TxtCveUsuario.Select()
        TxtUsuario.Clear()

        Login.ShowDialog()
        MostrarUsuario()
        CargarPermisos()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click

        If Not FormularioActivo(Proveedores) Then
            Proveedores = New FRMProveedores
        End If
        ActivarFormulario(Proveedores)

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        If Not FormularioActivo(clientes) Then
            clientes = New FRMClientes
        End If
        ActivarFormulario(clientes)
    End Sub

End Class