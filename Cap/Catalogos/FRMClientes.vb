Public Class FRMClientes

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
        TxtCveCliente.Clear()
        TxtNombreCliente.Clear()
        TxtTelefono.Clear()
        TxtRfc.Clear()
        DtpFechaDeAlta.Value = Now
    End Sub

    Public Sub Habilitar()
        TxtNombreCliente.Enabled = True
        TxtTelefono.Enabled = True
        TxtRfc.Enabled = True
        DtpFechaDeAlta.Enabled = True
    End Sub

    Public Sub Deshabilitar()
        TxtCveCliente.Enabled = False
        TxtNombreCliente.Enabled = False
        TxtTelefono.Enabled = False
        TxtRfc.Enabled = False
        DtpFechaDeAlta.Enabled = False
    End Sub

    Public Sub Guardar()

        If ValidarCampos() = False Then
            MsgBox("CAMPOS OBLIGATORIOS " & vbNewLine & v_Error, MsgBoxStyle.Information, Generales.MsgInformation)
        End If

        ClientesBL.TBLCLIENTE.Clear()
        ClientesBL.Cargar(TxtNombreCliente.Text.Length, )
        If ClientesBL.TBLCLIENTE.Rows.Count = 1 And v_Op <> "Modificar" Then
            MsgBox("El nombre del cliente ya existe" & vbNewLine & "Ingresar otro nombre", MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If

        Dim row As NEGOCIOS.ClientesBL.TBLCLIENTERow
        row = ClientesBL.TBLCLIENTE.NewTBLCLIENTERow

        With row

            .NOMBRE_VAR = TxtNombreCliente.Text
            .TELEFONO_VAR = TxtTelefono.Text
            .RFC_VAR = TxtRfc.Text
            .CVE_USUARIO_MOD_VAR = Generales.CVE_USUARIO_VAR
            .FECHA_MOD_DATE = Now

            If v_Op = "Nuevo" Then

                .CVE_USUAIRO_VAR = Generales.CVE_USUARIO_VAR
                .FECHA_ALTA_DATE = Now

                If ClientesBL.Agregar(row) Then
                    MsgBox("Informacion almacenada", MsgBoxStyle.Information, Generales.MsgInformation)
                    BtnCancelar_Click(Nothing, Nothing)
                End If
            End If

            If v_Op = "Modificar" Then

                .CVE_CLIENTE_INT = TxtCveCliente.Text

                If ClientesBL.Modificar(row) Then
                    MsgBox("Informacion almacenada", MsgBoxStyle.Information, Generales.MsgInformation)
                    BtnCancelar_Click(Nothing, Nothing)
                End If
            End If
        End With

    End Sub

    Public Sub CargarCliente(ByVal row As NEGOCIOS.ClientesBL.TBLCLIENTERow)

        With row

            TxtCveCliente.Text = .CVE_CLIENTE_INT
            TxtNombreCliente.Text = .NOMBRE_VAR
            TxtTelefono.Text = .TELEFONO_VAR
            TxtRfc.Text = .RFC_VAR

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

        If TxtNombreCliente.Text.Trim.Length = 0 Then
            v_Error = "NOMBRE"
        End If

        If TxtTelefono.Text.Trim.Length = 0 Then
            v_Error = v_Error & vbNewLine & "TELEFONO"
        End If

        If TxtRfc.Text.Trim.Length = 0 Then
            v_Error = v_Error & vbNewLine & "RFC"
        End If

        If v_Error = "" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub FRMClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v_Op = "Inicial"
        EstadoBotones(v_Op)
        ClientesBL.Cargar()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        v_Op = "Nuevo"
        EstadoBotones(v_Op)
        Habilitar()
        TxtCveCliente.Enabled = False

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        v_Op = "Modificar"
        EstadoBotones(v_Op)
        Habilitar()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Guardar()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        ClientesBL.TBLCLIENTE.Clear()
        Dim browse As FRMBrowseClientes = New FRMBrowseClientes
        browse.ShowDialog()

        If browse.p_cveCliente.ToString > 0 Then
            ClientesBL.Cargar(browse.p_cveCliente, )
        End If

        If ClientesBL.TBLCLIENTE.Rows.Count = 1 Then

            CargarCliente(ClientesBL.TBLCLIENTE.Rows(0))

        End If

    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        v_Op = "Inicial"
        EstadoBotones(v_Op)
        Limpiar()
        Deshabilitar()
        BtnBuscar.Enabled = True
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

#End Region


End Class