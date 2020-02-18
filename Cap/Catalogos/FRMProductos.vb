


Public Class FRMProductos


#Region "VARIABLES"
    Dim v_Error As String = ""
    Dim v_Op As String = ""

    Public p_Nombre As String = ""
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
            BtnBuscar.Enabled = False
            BtnGuardar.Enabled = True
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
        TxtCveProducto.Clear()
        TxtNombreProducto.Clear()
        TxtPrecio.Clear()
        DtpFechaDeAlta.Value = Now
    End Sub


    Public Sub Habilitar()
        TxtNombreProducto.Enabled = True
        TxtPrecio.Enabled = True
        DtpFechaDeAlta.Enabled = True
    End Sub

    Public Sub Deshabiltar()
        TxtCveProducto.Enabled = False
        TxtNombreProducto.Enabled = False
        TxtPrecio.Enabled = False
        DtpFechaDeAlta.Enabled = False
    End Sub

    Public Sub Guardar()

        If ValidarCampos() = False Then
            MsgBox("CAMPOS OBLIGATORIOS " & vbNewLine & v_Error, MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If

        ProductosBL.TBLPRODUCTOS.Clear()
        ProductosBL.Cargar(TxtCveProducto.Text, )
        If ProductosBL.TBLPRODUCTOS.Rows.Count = 1 And v_Op <> "modificar" Then
            MsgBox("La clave del producto ya existe" & vbNewLine & "Por ingresa otra clave", MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If



        Dim row As NEGOCIOS.ProductosBL.TBLPRODUCTOSRow
        row = ProductosBL.TBLPRODUCTOS.NewTBLPRODUCTOSRow


        With row


            .CVE_PRODUCTO_VAR = TxtCveProducto.Text
            .NOMBRE_VAR = TxtNombreProducto.Text
            .PRECIO_DEC = TxtPrecio.Text
            .CVE_USUARIO_MOD_VAR = Generales.CVE_USUARIO_VAR
            .FECHA_MOD_DATET = Now


            If v_Op = "Nuevo" Then

                .CVE_USUARIO_VAR = Generales.CVE_USUARIO_VAR
                .FECHA_ALTA_DATE = Now

                If ProductosBL.Agregar(row) Then
                    MsgBox("Información Almacenada ", MsgBoxStyle.Information, Generales.MsgInformation)
                    BtnCancelar_Click(Nothing, Nothing)
                End If

            End If


            If v_Op = "Modificar" Then

                If ProductosBL.Modificar(row) Then
                    MsgBox("Información Almacenada ", MsgBoxStyle.Information, Generales.MsgInformation)
                    BtnCancelar_Click(Nothing, Nothing)
                End If


            End If


        End With

    End Sub

    Private Sub CargarProducto(ByVal row As NEGOCIOS.ProductosBL.TBLPRODUCTOSRow)

        With row

            TxtCveProducto.Text = .CVE_PRODUCTO_VAR
            TxtNombreProducto.Text = .NOMBRE_VAR
            TxtPrecio.Text = .PRECIO_DEC
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

        If TxtCveProducto.Text.Trim.Length = 0 Then
            v_Error = "CVE PRODUCTO"
        End If

        If TxtNombreProducto.Text.Trim.Length = 0 Then
            v_Error = v_Error & vbNewLine & "NOMBRE"
        End If

        If TxtPrecio.Text.Trim.Length = 0 Then
            v_Error = v_Error & vbNewLine & "PRECIO"
        End If


        If v_Error = "" Then
            Return True

        Else
            Return False
        End If

    End Function

    Private Sub FRMProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v_Op = "Inicial"
        EstadoBotones(v_Op)
        ProductosBL.Cargar()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        v_Op = "Nuevo"
        EstadoBotones(v_Op)
        Limpiar()
        Habilitar()
        TxtCveProducto.Enabled = True
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
        ProductosBL.TBLPRODUCTOS.Clear()
        Dim browse As New FRMBrowseProductos
        browse.ShowDialog()

        If browse.p_cveProducto.Trim.Length > 0 Then
            ProductosBL.Cargar(browse.p_cveProducto, )
        End If

        If ProductosBL.TBLPRODUCTOS.Rows.Count = 1 Then
            CargarProducto(ProductosBL.TBLPRODUCTOS.Rows(0))
        End If
    End Sub

#End Region



End Class