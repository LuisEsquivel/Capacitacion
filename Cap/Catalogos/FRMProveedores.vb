Public Class FRMProveedores

#Region "VARIABLES"

    Dim v_Error As String
    Dim v_Op As String

#End Region

#Region "PROCEDIMIENTOS"

    Public Sub EstadoBotones(ByVal v_EstadoBotones)

        If v_EstadoBotones = "Inicial" Then
            BtnNuevo.Enabled = True
            BtnModificar.Enabled = False
            BtnGuardar.Enabled = False
            BtnBuscar.Enabled = True
            BtnCancelar.Enabled = False
            BtnSalir.Enabled = True
        End If

        If v_EstadoBotones = "Nuevo" Then
            BtnNuevo.Enabled = False
            BtnModificar.Enabled = False
            BtnGuardar.Enabled = True
            BtnBuscar.Enabled = False
            BtnCancelar.Enabled = True
            BtnSalir.Enabled = False
        End If

        If v_EstadoBotones = "Modificar" Then
            BtnNuevo.Enabled = False
            BtnBuscar.Enabled = False
            BtnModificar.Enabled = False
            BtnGuardar.Enabled = True
            BtnCancelar.Enabled = True
            BtnSalir.Enabled = False
        End If

    End Sub

    Public Sub Limpiar()
        TxtCveProveedor.Clear()
        TxtNombre.Clear()
        TxtApellidos.Clear()
        TxtCorreo.Clear()
        TxtTelefono.Clear()
        TxtRazonSocial.Clear()
        DtpFechaDeAlta.Value = Now
    End Sub

    Public Sub Habilitar()
        TxtCveProveedor.Enabled = True
        TxtNombre.Enabled = True
        TxtApellidos.Enabled = True
        TxtTelefono.Enabled = True
        TxtRazonSocial.Enabled = True
        TxtCorreo.Enabled = True
        DtpFechaDeAlta.Enabled = True
    End Sub

    Public Sub Deshabilitar()
        TxtCveProveedor.Enabled = False
        TxtNombre.Enabled = False
        TxtApellidos.Enabled = False
        TxtTelefono.Enabled = False
        TxtRazonSocial.Enabled = False
        TxtCorreo.Enabled = False
        DtpFechaDeAlta.Enabled = False
    End Sub

    Public Sub Guardar()

        If ValidarCampos() = False Then
            MsgBox("CAMPOS OBLIGATORIOS " & vbNewLine & v_Error, MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If

        ProveedoresBL.TBLPROVEEDORES.Clear()
        ProveedoresBL.Cargar(TxtCveProveedor.Text, )
        If ProveedoresBL.TBLPROVEEDORES.Rows.Count = 1 And v_Op <> "Modificar" Then
            MsgBox("La clave del proveedor ya existe" & vbNewLine & "Ingresar otra clave", MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If

        Dim row As NEGOCIOS.ProveedoresBL.TBLPROVEEDORESRow
        row = ProveedoresBL.TBLPROVEEDORES.NewTBLPROVEEDORESRow

        With row

            .CVE_PROVEEDOR_VAR = TxtCveProveedor.Text
            .NOMBRE_VAR = TxtNombre.Text
            .APELLIDOS_VAR = TxtApellidos.Text
            .TELEFONO_VAR = TxtTelefono.Text
            .RAZON_SOCIAL_VAR = TxtRazonSocial.Text
            .CORREO_VAR = TxtCorreo.Text
            .CVE_USUARIO_MOD_VAR = Generales.CVE_USUARIO_VAR
            .FECHA_MOD_DATE = Now

            If v_Op = "Nuevo" Then

                .CVE_USUARIO_VAR = Generales.CVE_USUARIO_VAR
                .FECHA_ALTA_DATE = Now

                If ProveedoresBL.Agregar(row) Then
                    MsgBox("Informacion almacenada", MsgBoxStyle.Information, Generales.MsgInformation)
                    BtnCancelar_Click(Nothing, Nothing)
                End If
            End If

            If v_Op = "Modificar" Then

                If ProveedoresBL.Modificar(row) Then
                    MsgBox("Informacion almacenada", MsgBoxStyle.Information, Generales.MsgInformation)
                    BtnCancelar_Click(Nothing, Nothing)
                End If

            End If
        End With

    End Sub

    Public Sub CargarProveedor(ByVal row As NEGOCIOS.ProveedoresBL.TBLPROVEEDORESRow)

        With row

            TxtCveProveedor.Text = .CVE_PROVEEDOR_VAR
            TxtNombre.Text = .NOMBRE_VAR
            TxtApellidos.Text = .APELLIDOS_VAR
            TxtTelefono.Text = .TELEFONO_VAR
            TxtRazonSocial.Text = .RAZON_SOCIAL_VAR
            TxtCorreo.Text = .CORREO_VAR

        End With

        BtnCancelar.Enabled = True

        If v_Op <> "Modificar" Then
            BtnModificar.Enabled = True
        End If

    End Sub

    Public Function ValidarCampos() As Boolean

        v_Error = ""

        If TxtCveProveedor.Text.Trim.Length = 0 Then
            v_Error = "CVE PROVEEDOR"
        End If

        If TxtNombre.Text.Trim.Length = 0 Then
            v_Error = v_Error & vbNewLine & "NOMBRE"
        End If

        If TxtApellidos.Text.Trim.Length <= 0 Then
            v_Error = v_Error & vbNewLine & "APELLIDOS"
        End If

        If v_Error = "" Then
            Return True
        Else
            Return False
        End If

    End Function

#End Region

#Region "BOTONES"
    Private Sub FRMProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v_Op = "Inicial"
        EstadoBotones(v_Op)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        v_Op = "Inicial"
        EstadoBotones(v_Op)
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Guardar()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        v_Op = "Modificar"
        EstadoBotones(v_Op)
        Habilitar()
        TxtCveProveedor.Enabled = False
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        v_Op = "Nuevo"
        EstadoBotones(v_Op)
        Limpiar()
        Habilitar()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        ProveedoresBL.TBLPROVEEDORES.Clear()

        Dim browse As New FRMBrowseProveedores
        browse.ShowDialog()

        If browse.p_CveProveedor.Trim.Length > 0 Then
            ProveedoresBL.Cargar(browse.p_CveProveedor, )
        End If

        If ProveedoresBL.TBLPROVEEDORES.Rows.Count = 1 Then
            CargarProveedor(ProveedoresBL.TBLPROVEEDORES.Rows(0))
        End If

    End Sub

#End Region

End Class