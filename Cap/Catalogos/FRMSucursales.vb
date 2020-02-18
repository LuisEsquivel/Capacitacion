Public Class FRMSucursales

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
        TxtCveSucursal.Clear()
        TxtNombreSucursal.Clear()
        TxtTelefono.Clear()
        TxtNumInterior.Clear()
        TxtNumEsterior.Clear()
        TxtCalle.Clear()
        DtpFechaDeAlta.Value = Now
    End Sub

    Public Sub Habilitar()
        TxtCveSucursal.Enabled = True
        TxtNombreSucursal.Enabled = True
        TxtTelefono.Enabled = True
        TxtNumInterior.Enabled = True
        TxtNumEsterior.Enabled = True
        TxtCalle.Enabled = True
        DtpFechaDeAlta.Enabled = True
    End Sub

    Public Sub Deshabilitar()
        TxtCveSucursal.Enabled = False
        TxtNombreSucursal.Enabled = False
        TxtTelefono.Enabled = False
        TxtNumInterior.Enabled = False
        TxtNumEsterior.Enabled = False
        TxtCalle.Enabled = False
        DtpFechaDeAlta.Enabled = False
    End Sub

    Public Sub Guardar()

        If ValidarCampos() = False Then
            MsgBox("CAMPOS OBLIGATORIOS " & vbNewLine & v_Error, MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If

        SucursalesBL.TBLSUCURSAL.Clear()
        SucursalesBL.Cargar(TxtCveSucursal.Text)
        If SucursalesBL.TBLSUCURSAL.Rows.Count = 1 And v_Op <> "Modificar" Then
            MsgBox("La clave se la sucursal ya existe " & vbNewLine & "Ingresar otra clave", MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If

        Dim row As NEGOCIOS.SucursalesBL.TBLSUCURSALRow
        row = SucursalesBL.TBLSUCURSAL.NewTBLSUCURSALRow

        With row

            .CVE_SUC_VAR = TxtCveSucursal.Text
            .NOMBRE_SUC_VAR = TxtNombreSucursal.Text
            .TELEFONO_VAR = TxtTelefono.Text
            .NUMERO_INTERIOR_INT = TxtNumInterior.Text
            .NUM_EXTERIOR_INT = TxtNumEsterior.Text
            .CALLE_VAR = TxtCalle.Text
            .CVE_EMPLEADO_MOD_VAR = Generales.CVE_USUARIO_VAR
            .FECHA_MOD_DATE = Now

            If v_Op = "Nuevo" Then

                .CVE_EMPLEADO_VAR = Generales.CVE_USUARIO_VAR
                .FECHA_ALTA_DATE = Now

                If SucursalesBL.Agregar(row) Then
                    MsgBox("Informacion almacenada", MsgBoxStyle.Information, Generales.MsgInformation)
                    BtnCancelar_Click(Nothing, Nothing)
                End If
            End If

            If v_Op = "Modificar" Then
                '.CVE_SUC_VAR = TxtCveSucursal.Text

                If SucursalesBL.Modificar(row) Then
                    MsgBox("Informacion almacenada", MsgBoxStyle.Information, Generales.MsgInformation)
                    BtnCancelar_Click(Nothing, Nothing)
                End If
            End If
        End With

    End Sub

    Public Sub CargarSucursal(ByVal row As NEGOCIOS.SucursalesBL.TBLSUCURSALRow)

        With row

            TxtCveSucursal.Text = .CVE_SUC_VAR
            TxtNombreSucursal.Text = .NOMBRE_SUC_VAR
            TxtTelefono.Text = .TELEFONO_VAR
            TxtNumInterior.Text = .NUMERO_INTERIOR_INT
            TxtNumEsterior.Text = .NUM_EXTERIOR_INT
            TxtCalle.Text = .CALLE_VAR

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

        If TxtCveSucursal.Text.Trim.Length = 0 Then
            v_Error = "CLAVE"
        End If

        If TxtNombreSucursal.Text.Trim.Length = 0 Then
            v_Error = v_Error & vbNewLine & "NOMBRE"
        End If

        If v_Error = "" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub FRMSucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v_Op = "Inicial"
        EstadoBotones(v_Op)
        SucursalesBL.Cargar()
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
        TxtCveSucursal.Enabled = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Guardar()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        SucursalesBL.TBLSUCURSAL.Clear()
        Dim browse As FRMBrowseSucursal = New FRMBrowseSucursal
        browse.ShowDialog()

        If browse.p_CveSucursal.ToString <> "" Then
            SucursalesBL.Cargar(browse.p_CveSucursal)
        End If

        If SucursalesBL.TBLSUCURSAL.Rows.Count = 1 Then

            CargarSucursal(SucursalesBL.TBLSUCURSAL.Rows(0))

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