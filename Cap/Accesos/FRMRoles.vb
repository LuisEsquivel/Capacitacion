Public Class FRMRoles

#Region "Variables"

    Dim v_Error As String
    Dim v_Op As String

#End Region

#Region "PROCEDIMIENTOS"

    Public Sub EstadoBotones(ByVal v_estadoBotones)

        If v_estadoBotones = "Inicial" Then
            BtnNuevo.Enabled = True
            BtnModificar.Enabled = False
            BtnGuardar.Enabled = False
            BtnCancelar.Enabled = False
            BtnSalir.Enabled = True
        End If

        If v_estadoBotones = "Nuevo" Then
            BtnNuevo.Enabled = False
            BtnModificar.Enabled = False
            BtnGuardar.Enabled = True
            BtnBuscar.Enabled = False
            BtnCancelar.Enabled = True
            BtnSalir.Enabled = False
        End If


        If v_estadoBotones = "Modificar" Then
            BtnNuevo.Enabled = False
            BtnModificar.Enabled = False
            BtnBuscar.Enabled = False
            BtnGuardar.Enabled = True
            BtnCancelar.Enabled = True
            BtnSalir.Enabled = False
        End If
    End Sub


    Public Sub Limpiar()
        TxtCveRol.Clear()
        TxtNombreRol.Clear()
        DtpFechaDeAlta.Value = Now
    End Sub


    Public Sub Habilitar()
        TxtNombreRol.Enabled = True
        DtpFechaDeAlta.Enabled = True
    End Sub

    Public Sub Deshabiltar()
        TxtCveRol.Enabled = False
        TxtNombreRol.Enabled = False
        DtpFechaDeAlta.Enabled = False
    End Sub

    Public Sub Guardar()

        If ValidarCampos() = False Then
            MsgBox("CAMPOS OBLIGATORIOS " & vbNewLine & v_Error, MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If

        RolesBL.TBLROLES.Clear()
        RolesBL.Cargar(TxtNombreRol.Text.Length, )

        If RolesBL.TBLROLES.Rows.Count = 1 And v_Op <> "Modificar" Then
            MsgBox("El nombre del rol ya existe" & vbNewLine & "Ingresar otro nombre", MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If

        Dim row As NEGOCIOS.RolesBL.TBLROLESRow
        row = RolesBL.TBLROLES.NewTBLROLESRow

        With row



            .NOMBRE_ROL_VAR = TxtNombreRol.Text
            .CVE_USUARIO_MOD_VAR = Generales.CVE_USUARIO_VAR
            .FECHA_MOD_DATE = Now


            If v_Op = "Nuevo" Then

                .CVE_USUARIO_VAR = Generales.CVE_USUARIO_VAR
                .FECHA_ALTA_DATE = Now

                If RolesBL.Agregar(row) Then
                    MsgBox("Información Almacenada ", MsgBoxStyle.Information, Generales.MsgInformation)
                    BtnCancelar_Click(Nothing, Nothing)
                End If

            End If


            If v_Op = "Modificar" Then

                .CVE_ROL_INT = TxtCveRol.Text

                If RolesBL.Modificar(row) Then
                    MsgBox("Información Almacenada ", MsgBoxStyle.Information, Generales.MsgInformation)
                    BtnCancelar_Click(Nothing, Nothing)
                End If
            End If


        End With

    End Sub

    Private Sub CargarProducto(ByVal row As NEGOCIOS.RolesBL.TBLROLESRow)

        With row

            TxtCveRol.Text = .CVE_ROL_INT
            TxtNombreRol.Text = .NOMBRE_ROL_VAR
            DtpFechaDeAlta.Value = .FECHA_ALTA_DATE

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

        If TxtNombreRol.Text.Trim.Length = 0 Then
            v_Error = "NOMBRE"
        End If

        If v_Error = "" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub FRMRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v_Op = "Inicial"
        EstadoBotones(v_Op)
        RolesBL.Cargar()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        v_Op = "Nuevo"
        EstadoBotones(v_Op)
        Limpiar()
        Habilitar()
        TxtCveRol.Enabled = False

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
        Deshabiltar()
        BtnBuscar.Enabled = True

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Guardar()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        RolesBL.TBLROLES.Clear()
        Dim browse As New FRMBrowseRoles
        browse.ShowDialog()

        If browse.p_CveRol.ToString > 0 Then
            RolesBL.Cargar(browse.p_CveRol, )
        End If

        If RolesBL.TBLROLES.Rows.Count = 1 Then
            CargarProducto(RolesBL.TBLROLES.Rows(0))
        End If

    End Sub

#End Region

End Class