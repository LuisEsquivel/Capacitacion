Public Class FRMPermisos

#Region "VARIABLES"
    Dim v_Op As String

#End Region

#Region "PRODECIMIENTOS"
    Private Sub Habilitar()

        ChkClientes.Enabled = True
        ChkRoles.Enabled = True
        ChkPermisos.Enabled = True
        ChkProductos.Enabled = True
        ChkVentas.Enabled = True
        ChkSucursales.Enabled = True
        ChkCotizaciones.Enabled = True
        ChkReporteVentas.Enabled = True
        ChkUsuarios.Enabled = True
        ChkReporteCotizaciones.Enabled = True
        ChkProveedores.Enabled = True

    End Sub

    Private Sub Deshabilitar()

        ChkClientes.Enabled = False
        ChkRoles.Enabled = False
        ChkPermisos.Enabled = False
        ChkProductos.Enabled = False
        ChkVentas.Enabled = False
        ChkSucursales.Enabled = False
        ChkCotizaciones.Enabled = False
        ChkReporteVentas.Enabled = False
        ChkUsuarios.Enabled = False
        ChkReporteCotizaciones.Enabled = False
        ChkProveedores.Enabled = False

    End Sub

    Private Sub Limpiar()

        ChkClientes.Checked = False
        ChkRoles.Checked = False
        ChkPermisos.Checked = False
        ChkProductos.Checked = False
        ChkVentas.Checked = False
        ChkSucursales.Checked = False
        ChkCotizaciones.Checked = False
        ChkReporteVentas.Checked = False
        ChkUsuarios.Checked = False
        ChkReporteCotizaciones.Checked = False
        ChkProveedores.Checked = False

    End Sub

    Public Sub EstadoDeBotones(ByVal v_EstadoDeBotones)

        If v_EstadoDeBotones = "Inicial" Then
            BtnNuevo.Enabled = True
            BtnGuardar.Enabled = True
            BtnSalir.Enabled = True
        End If

        If v_EstadoDeBotones = "Nuevo" Then
            BtnNuevo.Enabled = False
            BtnGuardar.Enabled = True
            BtnSalir.Enabled = True
        End If

        If v_EstadoDeBotones = "Modificar" Then

        End If

    End Sub

    Public Sub ComboRoles()

        Dim rowRoles As NEGOCIOS.RolesBL.TBLROLESRow
        rowRoles = RolesBL.TBLROLES.NewTBLROLESRow

        With rowRoles

            .CVE_ROL_INT = 0
            .NOMBRE_ROL_VAR = "--SELECCIONAR--"
            .CVE_USUARIO_VAR = ""
            .CVE_USUARIO_MOD_VAR = ""
            .FECHA_ALTA_DATE = Today
            .FECHA_MOD_DATE = Today

        End With

        RolesBL.TBLROLES.Rows.Add(rowRoles)
    End Sub

    Public Sub Guardar()

        PermisosBL.TBLPERMISOS.Clear()

        Dim rowPermiso As NEGOCIOS.PermisosBL.TBLPERMISOSRow
        rowPermiso = PermisosBL.TBLPERMISOS.NewTBLPERMISOSRow

        With rowPermiso

            .CVE_PERMISO_INT = CmbRoles.SelectedValue
            .ACCESO_CLIENTES_BIT = ChkClientes.Checked
            .ACCESO_PRODUCTOS_BIT = ChkProductos.Checked
            .ACCESO_PERMISOS_BIT = ChkPermisos.Checked
            .ACEESO_COTIZACIONES_BIT = ChkCotizaciones.Checked
            .ACCESO_VENTAS_BIT = ChkVentas.Checked
            .ACCESO_SUCURSALES_BIT = ChkSucursales.Checked
            .ACCESO_USUARIOS_BIT = ChkUsuarios.Checked
            .ACCESO_ROLES_BIT = ChkRoles.Checked
            .ACCESO_REPORTE_VENTAS_BIT = ChkReporteVentas.Checked
            .ACCESO_REPORTE_COT_BIT = ChkReporteCotizaciones.Checked
            .ACCESO_PROVEEDORES_BIT = ChkProveedores.Checked


            If v_Op = "nuevo" Then

                If PermisosBL.Agregar(rowPermiso) Then
                    MsgBox("Informacion agregada correctamente", MsgBoxStyle.Information, Generales.MsgInformation)
                    BtnCancelar_Click(Nothing, Nothing)
                End If
            End If

            If v_Op = "modificar" Then
                If PermisosBL.Modificar(rowPermiso) Then
                    MsgBox("Informacion modificada correctamente", MsgBoxStyle.Information, Generales.MsgInformation)
                    BtnCancelar_Click(Nothing, Nothing)
                End If
            End If

        End With

    End Sub

#End Region

    Private Sub FRMPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v_Op = "Inicial"
        EstadoDeBotones(v_Op)
        ComboRoles()
        RolesBL.Cargar()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Guardar()
    End Sub

    Private Sub CmbRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRoles.SelectedIndexChanged

        If CmbRoles.SelectedValue = 0 Then
            Limpiar()
            Deshabilitar()
            Exit Sub
        End If

        PermisosBL.Clear()
        PermisosBL.Cargar(CmbRoles.SelectedValue)

        If PermisosBL.TBLPERMISOS.Rows.Count = 1 Then
            With CType(PermisosBL.TBLPERMISOS.Rows(0), NEGOCIOS.PermisosBL.TBLPERMISOSRow)

                ChkClientes.Checked = .ACCESO_CLIENTES_BIT
                ChkRoles.Checked = .ACCESO_ROLES_BIT
                ChkPermisos.Checked = .ACCESO_PERMISOS_BIT
                ChkProductos.Checked = .ACCESO_PRODUCTOS_BIT
                ChkVentas.Checked = .ACCESO_VENTAS_BIT
                ChkSucursales.Checked = .ACCESO_SUCURSALES_BIT
                ChkCotizaciones.Checked = .ACEESO_COTIZACIONES_BIT
                ChkReporteVentas.Checked = .ACCESO_REPORTE_VENTAS_BIT
                ChkUsuarios.Checked = .ACCESO_USUARIOS_BIT
                ChkReporteCotizaciones.Checked = .ACCESO_REPORTE_COT_BIT
                ChkProveedores.Checked = .ACCESO_PROVEEDORES_BIT

            End With

            v_Op = "modificar"
            Habilitar()
        Else

            v_Op = "nuevo"
            Habilitar()
            Limpiar()

        End If

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        v_Op = "nuevo"
        EstadoDeBotones(v_Op)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpiar()
        Deshabilitar()
        CmbRoles.SelectedValue = 0
    End Sub

End Class