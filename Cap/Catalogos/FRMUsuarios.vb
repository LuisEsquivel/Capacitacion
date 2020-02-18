Public Class FRMUsuarios

#Region "VARIABLES"

    Dim v_Op As String
    Dim v_Error As String
    Public v_rutaImagen As String = ""

#End Region

#Region "PROCEDIMIENTOS"

    Private Sub ComboRoles()

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
        'CboRol.SelectedValue = 0

    End Sub

    'Private Sub ComboDepa()

    '    Dim rowDepa As NEGOCIOS.UsuariosBL.TBLUSUARIOSRow
    '    rowDepa = UsuariosBL.TBLUSUARIOS.NewTBLUSUARIOSRow

    '    With rowDepa

    '        .CVE_USUARIO_VAR = ""
    '        .NOMBRE_USUARIO_VAR = ""
    '        .DEPARTAMENTO_VAR = "---SELECCIONAR---"
    '        .CVE_ROL_INT = 0
    '        .RUTA_FOTO_VAR = ""
    '        .CVE_USUAARIO_VAR = ""
    '        .FECHA_MOD_DATE = Today

    '    End With

    '    UsuariosBL.TBLUSUARIOS.Rows.Add(rowDepa)
    '    CmbDepartamento.SelectedValue = 0
    'End Sub

    Public Sub EstadoBotones(ByVal v_EstadoBotones)

        If v_EstadoBotones = "Inicial" Then
            BtnNuevo.Enabled = True
            BtnModificar.Enabled = False
            BtnGuardar.Enabled = False
            BtnCancelar.Enabled = False
            BtnSalir.Enabled = True
            BtnCargar.Enabled = False
        End If

        If v_EstadoBotones = "Nuevo" Then
            BtnNuevo.Enabled = False
            BtnModificar.Enabled = False
            BtnGuardar.Enabled = True
            BtnBuscar.Enabled = False
            BtnCancelar.Enabled = True
            BtnSalir.Enabled = False
            BtnCargar.Enabled = True
        End If

        If v_EstadoBotones = "Modificar" Then
            BtnNuevo.Enabled = False
            BtnBuscar.Enabled = False
            BtnModificar.Enabled = False
            BtnGuardar.Enabled = True
            BtnCancelar.Enabled = True
            BtnSalir.Enabled = False
            BtnCargar.Enabled = True
        End If

    End Sub

    Public Sub Limpiar()
        TxtCveUsuario.Clear()
        TxtPassword.Clear()
        TxtNombreUsuario.Clear()
        CmbRol.Text = "--SELECCIONAR--"
        PicImagen.Image = Nothing
        CmbDepartamento.Text = "---SELECCIONAR---"
        DtpFechaDeAlta.Value = Now
    End Sub

    Public Sub Habilitar()
        TxtCveUsuario.Enabled = True
        TxtNombreUsuario.Enabled = True
        TxtPassword.Enabled = True
        CmbDepartamento.Enabled = True
        CmbRol.Enabled = True
        PicImagen.Enabled = True
        DtpFechaDeAlta.Enabled = True
    End Sub

    Public Sub Deshabilitar()
        TxtCveUsuario.Enabled = False
        TxtNombreUsuario.Enabled = False
        TxtPassword.Enabled = False
        CmbDepartamento.Enabled = False
        CmbRol.Enabled = False
        PicImagen.Enabled = False
        DtpFechaDeAlta.Enabled = False
    End Sub

    Public Sub Guardar()

        If ValidarCampos() = False Then
            MsgBox("CAMPOS OBLIGATORIOS " & vbNewLine & v_Error, MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If

        UsuariosBL.TBLUSUARIOS.Clear()
        UsuariosBL.Cargar(TxtCveUsuario.Text, )

        If UsuariosBL.TBLUSUARIOS.Rows.Count = 1 And v_Op <> "Modificar" Then
            MsgBox("La clave del usuario ya existe" & vbNewLine & "Ingresar otra clave", MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If

        Dim row As NEGOCIOS.UsuariosBL.TBLUSUARIOSRow
        row = UsuariosBL.TBLUSUARIOS.NewTBLUSUARIOSRow

        With row

            .CVE_USUARIO_VAR = TxtCveUsuario.Text
            .NOMBRE_USUARIO_VAR = TxtNombreUsuario.Text
            .PASSWORD_VAR = TxtPassword.Text
            .DEPARTAMENTO_VAR = CmbDepartamento.SelectedItem
            .CVE_ROL_INT = CmbRol.SelectedValue
            .RUTA_FOTO_VAR = v_rutaImagen
            .CVE_USUAARIO_VAR = Generales.CVE_USUARIO_VAR
            .FECHA_MOD_DATE = Now

            If v_Op = "Nuevo" Then

                '.CVE_USUAARIO_VAR = Generales.CVE_USUARIO_VAR
                .FECHA_ALTA_DATE = Now

                If UsuariosBL.Agregar(row) Then
                    MsgBox("Informacion almacenada", MsgBoxStyle.Information, Generales.MsgInformation)
                    BtnCancelar_Click(Nothing, Nothing)
                End If
            End If

            If v_Op = "Modificar" Then

                '.CVE_USUAARIO_VAR = TxtCveUsuario.Text

                If UsuariosBL.Modificar(row) Then
                    MsgBox("Informacion almacenada", MsgBoxStyle.Information, Generales.MsgInformation)
                    BtnCancelar_Click(Nothing, Nothing)
                End If

            End If

        End With

    End Sub

    Public Sub CargarUsuario(ByVal row As NEGOCIOS.UsuariosBL.TBLUSUARIOSRow)

        With row

            TxtCveUsuario.Text = .CVE_USUARIO_VAR
            TxtNombreUsuario.Text = .NOMBRE_USUARIO_VAR
            CmbDepartamento.SelectedItem = .DEPARTAMENTO_VAR
            DtpFechaDeAlta.Value = .FECHA_ALTA_DATE
            CmbRol.SelectedValue = .CVE_ROL_INT
            v_rutaImagen = .RUTA_FOTO_VAR
            TxtPassword.Text = .PASSWORD_VAR

            If System.IO.File.Exists(.RUTA_FOTO_VAR) Then
                PicImagen.Image = Image.FromFile(v_rutaImagen)
            Else
                PicImagen.Image = Nothing
            End If

        End With

        BtnCancelar.Enabled = True

        If v_Op <> "Modificar" Then
            BtnModificar.Enabled = True
        End If

    End Sub

#End Region

#Region "FUNCIONES"

    Public Function ValidarCampos() As Boolean

        v_Error = ""

        If TxtCveUsuario.Text.Trim.Length = 0 Then
            v_Error = "CVE USUARIO"
        End If

        If TxtNombreUsuario.Text.Trim.Length = 0 Then
            v_Error = v_Error & vbNewLine & "NOMBRE"
        End If

        If CmbRol.Text = "--SELECCIONAR--" Then
            v_Error = v_Error & vbNewLine & "ROL"
        End If

        'If CmbRol.Items.Count <= 0 Then
        '    v_Error = v_Error & vbNewLine & "ROL"
        'End If

        If v_Error = "" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub FRMUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        v_Op = "Inicial"
        EstadoBotones(v_Op)
        CmbDepartamento.Text = "---SELECCIONAR---"
        ComboRoles()
        RolesBL.Cargar()

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        v_Op = "Nuevo"
        EstadoBotones(v_Op)
        Limpiar()
        Habilitar()

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        v_Op = "Modificar"
        EstadoBotones(v_Op)
        Habilitar()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        v_Op = "Inicial"
        EstadoBotones(v_Op)
        Limpiar()
        Deshabilitar()
        BtnBuscar.Enabled = True
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Guardar()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        UsuariosBL.TBLUSUARIOS.Clear()
        Dim browse As New FRMBrowseUsuarios
        browse.ShowDialog()

        If browse.p_CveUsuario.Trim.Length > 0 Then
            UsuariosBL.Cargar(browse.p_CveUsuario, )
        End If

        If UsuariosBL.TBLUSUARIOS.Rows.Count = 1 Then
            CargarUsuario(UsuariosBL.TBLUSUARIOS.Rows(0))
        End If

    End Sub

    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click

        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg,| Archivo PNG|*.png"

        If file.ShowDialog() = DialogResult.OK Then
            PicImagen.Image = Image.FromFile(file.FileName)
            v_rutaImagen = file.FileName
        End If

    End Sub

    Private Sub BtnQuitarImagen_Click(sender As Object, e As EventArgs) Handles BtnQuitarImagen.Click
        v_rutaImagen = ""
        PicImagen.Image = Nothing
    End Sub

#End Region

End Class