Public Class FRMCotizaciones

#Region "VARIABLES"
    Dim v_ErrorCabecera As String = ""
    Dim v_ErrorDetalle As String = ""
    Dim v_Op As String = ""
#End Region

#Region "PROCEDIMIENTOS"

    Private Sub Habilitar()
        TxtCveCliente.Enabled = True
        TxtNombreCliente.Enabled = True
        DtpFechaDeAlta.Enabled = True

        TxtCveProducto.Enabled = True
        TxtNombreProducto.Enabled = True
        TxtPrecioProducto.Enabled = True
        TxtCantidadProducto.Enabled = True
        TxtSubtotal.Enabled = True
        TxtIva.Enabled = True
        TxtTotal.Enabled = True
        BtnOk.Enabled = True

    End Sub

    Private Sub Deshabilitar()
        TxtCveCliente.Enabled = False
        TxtNombreCliente.Enabled = False
        DtpFechaDeAlta.Enabled = False

        TxtCveProducto.Enabled = False
        TxtNombreProducto.Enabled = False
        TxtPrecioProducto.Enabled = False
        TxtCantidadProducto.Enabled = False
        TxtSubtotal.Enabled = False
        TxtIva.Enabled = False
        TxtTotal.Enabled = False
        BtnOk.Enabled = False
        BtnDel.Enabled = False
    End Sub

    Private Sub LimpiarCabecera()
        TxtCveCotizacion.Clear()
        TxtCveCliente.Clear()
        TxtNombreCliente.Clear()
        DtpFechaDeAlta.Value = Now
        LblEstatus.Visible = False
    End Sub

    Private Sub LimpiarDetalle()
        TxtCveProducto.Clear()
        TxtNombreProducto.Clear()
        TxtPrecioProducto.Clear()
        TxtCantidadProducto.Clear()
        TxtSubtotal.Clear()
        TxtIva.Clear()
        TxtTotal.Clear()
    End Sub


    Public Sub EstadoBotones(ByVal v_estadoBotones)

        If v_estadoBotones = "Inicial" Then
            BtnNuevo.Enabled = True
            BtnBajas.Enabled = False
            BtnModificar.Enabled = False
            BtnGuardar.Enabled = False
            BtnCancelar.Enabled = False
            BtnSalir.Enabled = True
            BtnBuscar.Enabled = True
        End If

        If v_estadoBotones = "Nuevo" Then
            BtnNuevo.Enabled = False
            BtnModificar.Enabled = False
            BtnGuardar.Enabled = True
            BtnCancelar.Enabled = True
            BtnSalir.Enabled = False
            BtnBuscar.Enabled = False
        End If


        If v_estadoBotones = "Modificar" Then
            BtnNuevo.Enabled = False
            BtnModificar.Enabled = False
            BtnGuardar.Enabled = True
            BtnCancelar.Enabled = True
            BtnSalir.Enabled = False
            BtnBuscar.Enabled = True
        End If

        If v_estadoBotones = "Bajas" Then
            BtnNuevo.Enabled = True
            BtnModificar.Enabled = False
            BtnCancelar.Enabled = True
            BtnSalir.Enabled = True

        End If
    End Sub

    Private Sub CalcularTotales()

        Dim Subtotal As Decimal = 0
        Dim Iva As Decimal = 0
        Dim Total As Decimal = 0

        For Each row As DataGridViewRow In DgvDetalleCotizaciones.Rows

            Subtotal = Subtotal + row.Cells("TOTAL_PRODUCTO_DEC").Value

        Next

        Iva = (Subtotal * Generales.IVA)
        Total = Subtotal + Iva

        TxtSubtotal.Text = FormatCurrency(Math.Round(Subtotal), 2)
        TxtIva.Text = FormatCurrency(Math.Round(Iva), 2)
        TxtTotal.Text = FormatCurrency(Math.Round(Total), 2)

    End Sub

    Private Sub Guardar()

        If ValidarCabecera() = False Then
            MsgBox("CAMPOS OBLIGATORIOS " & vbNewLine & v_ErrorCabecera, MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If

        If DgvDetalleCotizaciones.Rows.Count = 0 Then
            MsgBox("FALTA AGREGAR PRODUCTOS", MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If

        CotizacionesBL.TBLCOTIZACION.Clear()

        Dim row As NEGOCIOS.CotizacionesBL.TBLCOTIZACIONRow
        row = CotizacionesBL.TBLCOTIZACION.NewTBLCOTIZACIONRow

        With row

            .CVE_CLIENTE_INT = TxtCveCliente.Text
            .CVE_EMPLEADO_MOD_VAR = Generales.CVE_USUARIO_VAR
            .FECHA_MOD_DATE = Now
            .SUBTOTAL_DEC = TxtSubtotal.Text
            .IVA_DEC = TxtIva.Text
            .TOTAL_DEC = TxtTotal.Text
            .ESTATUS_INT = 1

            If v_Op = "Nuevo" Then

                .CVE_EMPLEADO_VAR = Generales.CVE_USUARIO_VAR
                .FECHA_ALTA_DEC = DtpFechaDeAlta.Value

                CotizacionesBL.TBLCOTIZACION.Rows.Add(row)

                If CotizacionesBL.GrabarXML("AGREGAR") Then
                    MsgBox("Información Almacenada ", MsgBoxStyle.Information, Generales.MsgInformation)
                    BtnCancelar_Click(Nothing, Nothing)
                End If

            End If


            If v_Op = "Modificar" Then

                CotizacionesBL.TBLCOTIZACION.Rows.Add(row)

                If CotizacionesBL.GrabarXML("MODIFICAR", TxtCveCotizacion.Text) Then
                    MsgBox("Información Almacenada ", MsgBoxStyle.Information, Generales.MsgInformation)
                    BtnCancelar_Click(Nothing, Nothing)
                End If

            End If

            If v_Op = "Bajas" Then

                .ESTATUS_INT = 2
                CotizacionesBL.TBLCOTIZACION.Rows.Add(row)

                If CotizacionesBL.GrabarXML("MODIFICAR", TxtCveCotizacion.Text) Then
                    MsgBox("Venta Cancelada", MsgBoxStyle.Information, Generales.MsgInformation)
                    BtnCancelar_Click(Nothing, Nothing)

                End If

            End If
        End With

    End Sub

    Private Sub CargarCotizacion(ByVal row As NEGOCIOS.CotizacionesBL.TBLCOTIZACIONRow)

        With row

            DtpFechaDeAlta.Value = .FECHA_ALTA_DEC
            TxtCveCotizacion.Text = .CVE_COTIZACION_INT
            TxtCveCliente.Text = .CVE_CLIENTE_INT
            ClientesBL.Cargar(.CVE_CLIENTE_INT)
            TxtNombreCliente.Text = ClientesBL.TBLCLIENTE.FindByCVE_CLIENTE_INT(.CVE_CLIENTE_INT).NOMBRE_VAR

            If .ESTATUS_INT = 1 Then
                LblEstatus.Text = "EMITIDA"
                LblEstatus.Visible = True
            End If

            If .ESTATUS_INT = 2 Then
                LblEstatus.Text = "CANCELADA"
                LblEstatus.Visible = True

            End If

            If v_Op <> "Modificar" Then
                BtnModificar.Enabled = True
            End If

            BtnCancelar.Enabled = True
            CotizacionesBL.CargarDetalle(.CVE_COTIZACION_INT)
            CalcularTotales()
        End With

    End Sub

#End Region

#Region "FUNCIONES"


    Private Function ValidarCabecera() As Boolean
        v_ErrorCabecera = ""

        If TxtCveCliente.Text.Trim.Length = 0 Then
            v_ErrorCabecera = "CVE CLIENTE"
        End If

        'If TxtNombreCliente.Text.Trim.Length = 0 Then
        '    v_ErrorCabecera = v_ErrorDetalle & vbNewLine & "NOMBRE CLIENTE"
        'End If


        If v_ErrorCabecera = "" Then
            Return True

        Else
            Return False
        End If
    End Function

    Private Function ValidarDetalle() As Boolean
        v_ErrorDetalle = ""

        If TxtCveProducto.Text.Trim.Length = 0 Then
            v_ErrorDetalle = "CVE PRODUCTO"
        End If

        If TxtNombreProducto.Text.Trim.Length = 0 Then
            v_ErrorDetalle = v_ErrorDetalle & vbNewLine & "NOMBRE PRODUCTO"
        End If

        If TxtCantidadProducto.Text.Trim.Length = 0 Then
            v_ErrorDetalle = v_ErrorDetalle & vbNewLine & "CANTIDAD"
        End If

        If v_ErrorDetalle = "" Then
            Return True

        Else
            Return False
        End If
    End Function

#End Region

#Region "BOTONES"

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click

        If DgvDetalleCotizaciones.SelectedRows.Count > 0 Then
            DgvDetalleCotizaciones.Rows.Remove(DgvDetalleCotizaciones.CurrentRow)
        End If

        CalcularTotales()

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        If ValidarDetalle() = False Then
            MsgBox("CAMPOS OBLIGATORIOS " & vbNewLine & v_ErrorDetalle, MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If

        Dim rowDetalle As NEGOCIOS.CotizacionesBL.TBLDETALLE_COTIZACIONRow
        rowDetalle = CotizacionesBL.TBLDETALLE_COTIZACION.NewTBLDETALLE_COTIZACIONRow

        With rowDetalle

            .CVE_PRODUCTO_VAR = TxtCveProducto.Text
            .PRECIO_PRODUCTO_DEC = TxtPrecioProducto.Text
            .CANTIDAD_INT = TxtCantidadProducto.Text
            .TOTAL_PRODUCTO_DEC = (.CANTIDAD_INT * .PRECIO_PRODUCTO_DEC)

        End With

        CotizacionesBL.TBLDETALLE_COTIZACION.Rows.Add(rowDetalle)

        CalcularTotales()
        LimpiarDetalle()

    End Sub

    Private Sub DgvDetalleCotizaciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDetalleCotizaciones.CellDoubleClick
        BtnDel.Enabled = False
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FRMCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v_Op = "Inicial"
        EstadoBotones(v_Op)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        v_Op = "Inicial"
        EstadoBotones(v_Op)
        LimpiarCabecera()
        LimpiarDetalle()
        Deshabilitar()
        CotizacionesBL.Clear()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        v_Op = "Nuevo"
        EstadoBotones(v_Op)
        Habilitar()
        LimpiarCabecera()
        LimpiarDetalle()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        v_Op = "Modificar"
        EstadoBotones(v_Op)
        Habilitar()
    End Sub

    Private Sub TxtCveCliente_Leave(sender As Object, e As EventArgs) Handles TxtCveCliente.Leave
        Dim browse As New FRMBrowseClientes
        ClientesBL.Clear()

        If TxtCveCliente.Text <> "" Then


            ClientesBL.Cargar(TxtCveCliente.Text)

            If ClientesBL.TBLCLIENTE.Rows.Count = 1 Then
                TxtCveCliente.Text = ClientesBL.TBLCLIENTE.FindByCVE_CLIENTE_INT(TxtCveCliente.Text).CVE_CLIENTE_INT
                TxtNombreCliente.Text = ClientesBL.TBLCLIENTE.FindByCVE_CLIENTE_INT(TxtCveCliente.Text).NOMBRE_VAR

            Else

                browse.ShowDialog()
                ClientesBL.Cargar(browse.p_cveCliente)

                If ClientesBL.TBLCLIENTE.Rows.Count = 1 Then
                    TxtCveCliente.Text = ClientesBL.TBLCLIENTE.FindByCVE_CLIENTE_INT(browse.p_cveCliente).CVE_CLIENTE_INT
                    TxtNombreCliente.Text = ClientesBL.TBLCLIENTE.FindByCVE_CLIENTE_INT(browse.p_cveCliente).NOMBRE_VAR
                End If

            End If

        Else

            browse.ShowDialog()
            ClientesBL.Cargar(browse.p_cveCliente)

            If ClientesBL.TBLCLIENTE.Rows.Count = 1 Then
                TxtCveCliente.Text = ClientesBL.TBLCLIENTE.FindByCVE_CLIENTE_INT(browse.p_cveCliente).CVE_CLIENTE_INT
                TxtNombreCliente.Text = ClientesBL.TBLCLIENTE.FindByCVE_CLIENTE_INT(browse.p_cveCliente).NOMBRE_VAR
            End If

        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Guardar()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        CotizacionesBL.Clear()
        Dim browse As New FRMBrowseCotizaciones
        browse.ShowDialog()

        If browse.p_CveCotizacon > 0 Then
            CotizacionesBL.Cargar(browse.p_CveCotizacon)
        End If

        If CotizacionesBL.TBLCOTIZACION.Rows.Count = 1 Then
            CargarCotizacion(CotizacionesBL.TBLCOTIZACION.Rows(0))
        End If

        If LblEstatus.Text = "CANCELADA" Then
            BtnModificar.Enabled = False
            BtnBajas.Enabled = False
        Else
            BtnBajas.Enabled = True
        End If

    End Sub

    Private Sub BtnBajas_Click(sender As Object, e As EventArgs) Handles BtnBajas.Click
        v_Op = "Bajas"
        EstadoBotones(v_Op)

        Dim mensaje As String
        mensaje = MsgBox("Desea dar de baja la venta", MsgBoxStyle.YesNo, Generales.MsgInformation)

        If mensaje = MsgBoxResult.Yes Then
            Guardar()
        End If

    End Sub

    Private Sub TxtCveProducto_Leave(sender As Object, e As EventArgs) Handles TxtCveProducto.Leave

        Dim browse As New FRMBrowseProductos
        ProductosBL.Clear()

        If TxtCveProducto.Text <> "" Then

            ProductosBL.Cargar(TxtCveProducto.Text)

            If ProductosBL.TBLPRODUCTOS.Rows.Count = 1 Then
                TxtCveProducto.Text = ProductosBL.TBLPRODUCTOS.FindByCVE_PRODUCTO_VAR(TxtCveProducto.Text).CVE_PRODUCTO_VAR
                TxtNombreProducto.Text = ProductosBL.TBLPRODUCTOS.FindByCVE_PRODUCTO_VAR(TxtCveProducto.Text).NOMBRE_VAR
                TxtPrecioProducto.Text = ProductosBL.TBLPRODUCTOS.FindByCVE_PRODUCTO_VAR(TxtCveProducto.Text).PRECIO_DEC

            Else
                browse.ShowDialog()
                ProductosBL.Cargar(browse.p_CveProducto)

                If ProductosBL.TBLPRODUCTOS.Rows.Count = 1 Then
                    TxtCveProducto.Text = ProductosBL.TBLPRODUCTOS.FindByCVE_PRODUCTO_VAR(browse.p_CveProducto).CVE_PRODUCTO_VAR
                    TxtNombreProducto.Text = ProductosBL.TBLPRODUCTOS.FindByCVE_PRODUCTO_VAR(browse.p_CveProducto).NOMBRE_VAR
                    TxtPrecioProducto.Text = ProductosBL.TBLPRODUCTOS.FindByCVE_PRODUCTO_VAR(browse.p_CveProducto).PRECIO_DEC

                End If

            End If

        Else

            browse.ShowDialog()
            ProductosBL.Cargar(browse.p_CveProducto)

            If ProductosBL.TBLPRODUCTOS.Rows.Count = 1 Then
                TxtCveProducto.Text = ProductosBL.TBLPRODUCTOS.FindByCVE_PRODUCTO_VAR(browse.p_CveProducto).CVE_PRODUCTO_VAR
                TxtNombreProducto.Text = ProductosBL.TBLPRODUCTOS.FindByCVE_PRODUCTO_VAR(browse.p_CveProducto).NOMBRE_VAR
                TxtPrecioProducto.Text = ProductosBL.TBLPRODUCTOS.FindByCVE_PRODUCTO_VAR(browse.p_CveProducto).PRECIO_DEC

            End If

        End If

    End Sub

    'Private Sub BtnImprimir_Click(sender As Object, e As EventArgs)
    '    Dim viewer As New FRMReportViewer
    '    viewer.DataSource = CotizacionesBL.TBLCOTIZACION
    '    viewer.DataSourceName = CotizacionesBL.TBLCOTIZACION.TableName
    '    viewer.ReportPath = Generales.ReportPath & Generales.rdlcConsecutivoDeCotizaciones
    '    viewer.RutaLogo = Generales.RutaNovo
    '    viewer.Show()
    'End Sub

#End Region

End Class