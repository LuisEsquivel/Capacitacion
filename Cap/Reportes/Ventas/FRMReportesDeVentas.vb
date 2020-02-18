Public Class FRMReportesDeVentas

#Region "VARIABLES"
    Dim v_FechaInicial As DateTime = "1900-01-01"
    Dim v_FechaFinal As DateTime = "1900-01-01"
    Public p_CveVenta As Int32 = 0
    Dim v_Op As String = ""
#End Region

#Region "PROCEDIMIENTO"

    Private Sub Habilitar()
        CmbTipoReporte.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        CmbTipoReporte.Enabled = False
    End Sub

    Private Sub Limpiar()
        CmbTipoReporte.Text = "--SELECCIONE--"
        ReportesDeVentasBL.Clear()

    End Sub

    Public Sub EstadoBotones(ByVal v_estadoBotones)

        If v_estadoBotones = "Inicial" Then

            CmbTipoReporte.Text = "--SELECCIONE--"
            BtnBuscar.Enabled = True
            BtnSalir.Enabled = True
            BtnImprmir.Enabled = False
            BtnCancelar.Enabled = False
        End If

        If v_estadoBotones = "Buscar" Then
            BtnImprmir.Enabled = True
            BtnCancelar.Enabled = True
            BtnSalir.Enabled = True
            BtnBuscar.Enabled = True
        End If

    End Sub

#End Region

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub ChkCveVenta_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCveVenta.CheckedChanged
        If ChkCveVenta.Checked Then
            TxtCveVentaInicial.Enabled = True
            TxtCveVentaFinal.Enabled = True
            TxtCveVentaInicial.Text = 0
        Else
            TxtCveVentaInicial.Enabled = False
            TxtCveVentaFinal.Enabled = False
            TxtCveVentaInicial.Text = 0
        End If
    End Sub

    Private Sub ChkCveCliente_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCveCliente.CheckedChanged
        If ChkCveCliente.Checked Then
            TxtCveClienteInicial.Enabled = True
            TxtCveClienteFinal.Enabled = True
            TxtCveClienteInicial.Text = 0
            TxtCveClienteFinal.Text = 0
        Else
            TxtCveClienteInicial.Enabled = False
            TxtCveClienteFinal.Enabled = False
            TxtCveClienteInicial.Text = 0
            TxtCveClienteFinal.Text = 0
        End If
    End Sub

    Private Sub ChkFecha_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFecha.CheckedChanged
        If ChkFecha.Checked Then
            DtpFechaInicial.Enabled = True
            DtpFechaFinal.Enabled = True
            DtpFechaFinal.Value = Now
            DtpFechaInicial.Value = Now
        Else
            DtpFechaInicial.Enabled = False
            DtpFechaFinal.Enabled = False
            DtpFechaFinal.Value = Now
            DtpFechaInicial.Value = Now
        End If
    End Sub

    Private Sub FRMReportesDeVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v_Op = "Inicial"
        EstadoBotones(v_Op)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        If CmbTipoReporte.Text = "--SELECCIONE--" Then
            Exit Sub
        End If


        If TxtCveVentaFinal.Text < TxtCveVentaInicial.Text Then
            MsgBox("LA CLAVE FINAL DE VENTA DEBE SER MAYOR QUE LA INICIAL" & vbNewLine, MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If

        If TxtCveClienteFinal.Text < TxtCveClienteInicial.Text Then
            MsgBox("LA CLAVE FINAL DEL CLIENTE DEBE SER MAYOR A LA INICIAL" & vbNewLine, MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If

        If ChkFecha.Checked Then
            v_FechaInicial = DtpFechaInicial.Value
            v_FechaFinal = DtpFechaFinal.Value

            If DtpFechaFinal.Value < DtpFechaFinal.Value Then
                MsgBox("LA FECHA FINAL DEBE SER MAYOR QUE LA INICIAL" & vbNewLine, MsgBoxStyle.Information, Generales.MsgInformation)
                Exit Sub
            End If

        Else
            v_FechaInicial = "1900-01-01"
            v_FechaFinal = "1900-01-01"
        End If


        If CmbTipoReporte.Text = "CONSECUTIVO DE VENTAS" Then

            ReportesDeVentasBL.TBLVENTA.Clear()
            ReportesDeVentasBL.CargarAdicional(v_FechaInicial,
                                               v_FechaFinal,
                                               CmbTipoReporte.Text,
                                               TxtCveVentaInicial.Text,
                                               TxtCveVentaFinal.Text,
                                               TxtCveClienteInicial.Text,
                                               TxtCveClienteFinal.Text
                                               )

            ReportesDeVentasBL.TBLDETALLE_VENTA.Clear()

        End If

        If CmbTipoReporte.Text = "CONSECUTIVO DE VENTAS DESGLOSADO" Then


            ReportesDeVentasBL.TBLVENTA.Clear()

            ReportesDeVentasBL.CargarAdicional(v_FechaInicial,
                                               v_FechaFinal,
                                               "CONSECUTIVO DE VENTAS",
                                               TxtCveVentaInicial.Text,
                                               TxtCveVentaFinal.Text,
                                               TxtCveClienteInicial.Text,
                                               TxtCveClienteFinal.Text
                                               )


            ReportesDeVentasBL.TBLDETALLE_VENTA.Clear()

            ReportesDeVentasBL.CargarDetalle(v_FechaInicial,
                                             v_FechaFinal,
                                             CmbTipoReporte.Text,
                                             TxtCveVentaInicial.Text,
                                             TxtCveVentaFinal.Text,
                                             TxtCveClienteInicial.Text,
                                             TxtCveClienteFinal.Text
                                              )

        End If

        v_Op = "Buscar"
        EstadoBotones(v_Op)

    End Sub

    Private Sub TxtCveVentaInicial_TextChanged(sender As Object, e As EventArgs) Handles TxtCveVentaInicial.TextChanged
        TxtCveVentaFinal.Text = TxtCveVentaInicial.Text
    End Sub

    Private Sub TxtCveClienteInicial_TextChanged(sender As Object, e As EventArgs) Handles TxtCveClienteInicial.TextChanged
        TxtCveClienteFinal.Text = TxtCveClienteInicial.Text
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        v_Op = "Inicial"
        EstadoBotones(v_Op)
        Limpiar()
        ReportesDeVentasBL.Clear()
    End Sub

    Private Sub DgvVenta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVenta.CellDoubleClick

        If CmbTipoReporte.Text = "CONSECUTIVO DE VENTAS" Then
            Exit Sub
        End If

        If CmbTipoReporte.Text = "CONSECUTIVO DE VENTAS DESGLOSADO" Then
            ReportesDeVentasBL.TBLDETALLE_VENTA.Clear()
            ReportesDeVentasBL.CargarDetalle(v_FechaInicial,
                                             v_FechaFinal,
                                             CmbTipoReporte.Text,
                                             DgvVenta.SelectedRows(0).Cells("CVE_VENTA_INT").Value,
                                             DgvVenta.SelectedRows(0).Cells("CVE_VENTA_INT").Value,
                                             TxtCveClienteInicial.Text,
                                             TxtCveClienteFinal.Text)
        End If

    End Sub

    Private Sub BtnImprmir_Click(sender As Object, e As EventArgs) Handles BtnImprmir.Click

        If CmbTipoReporte.Text = "--SELECCIONE--" Then
            Exit Sub
        End If

        Dim viewer As New FRMReportViewer

        If CmbTipoReporte.Text = "CONSECUTIVO DE VENTAS" Then
            viewer.DataSource = ReportesDeVentasBL.TBLVENTA
            viewer.DataSourceName = ReportesDeVentasBL.TBLVENTA.TableName
            viewer.ReportPath = Generales.ReportPath & Generales.rdlcConsecutivoDeVentas
            viewer.RutaLogo = Generales.RutaLogo
        End If

        If CmbTipoReporte.Text = "CONSECUTIVO DE VENTAS DESGLOSADO" Then
            viewer.DataSource = ReportesDeVentasBL.TBLVENTA
            viewer.DataSourceName = ReportesDeVentasBL.TBLVENTA.TableName
            viewer.SubReportDataSource = ReportesDeVentasBL.TBLDETALLE_VENTA
            viewer.SubReportDataSourceName = ReportesDeVentasBL.TBLDETALLE_VENTA.TableName
            viewer.ReportPath = Generales.ReportPath & Generales.rdlcConsecutivoVentasDesglosado
            viewer.RutaLogo = Generales.RutaNovo
        End If

        viewer.Show()
    End Sub

End Class