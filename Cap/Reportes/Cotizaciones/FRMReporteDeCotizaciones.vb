Public Class FRMReporteDeCotizaciones

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
        ReporteDeCotizacionesBL.Clear()

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

        If v_estadoBotones = "Cancelar" Then
            BtnCancelar.Enabled = False
            BtnImprmir.Enabled = False
        End If

    End Sub

#End Region

    Private Sub FRMReporteDeCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v_Op = "Inicial"
        EstadoBotones(v_Op)
    End Sub

    Private Sub ChkCveCotizacion_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCveCotizacion.CheckedChanged
        If ChkCveCotizacion.Checked Then
            TxtCveCotizacionInicial.Enabled = True
            TxtCveCotizacionFinal.Enabled = True
            TxtCveCotizacionInicial.Text = 0
            TxtCveCotizacionFinal.Text = 0
        Else
            TxtCveCotizacionInicial.Enabled = False
            TxtCveCotizacionFinal.Enabled = False
            TxtCveCotizacionInicial.Text = 0
            TxtCveCotizacionFinal.Text = 0
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
            DtpFechaInicial.Value = Now
            DtpFechaFinal.Value = Now
        Else
            DtpFechaInicial.Enabled = False
            DtpFechaFinal.Enabled = False
            DtpFechaInicial.Value = Now
            DtpFechaFinal.Value = Now
        End If
    End Sub

    Private Sub TxtCveCotizacionInicial_TextChanged(sender As Object, e As EventArgs) Handles TxtCveCotizacionInicial.TextChanged
        TxtCveCotizacionFinal.Text = TxtCveCotizacionInicial.Text
    End Sub

    Private Sub TxtCveClienteInicial_TextChanged(sender As Object, e As EventArgs) Handles TxtCveClienteInicial.TextChanged
        TxtCveClienteFinal.Text = TxtCveClienteInicial.Text
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpiar()
        v_Op = "Cancelar"
        EstadoBotones(v_Op)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        If CmbTipoReporte.Text = "--SELECCIONE--" Then
            Exit Sub
        End If

        If TxtCveCotizacionFinal.Text < TxtCveCotizacionInicial.Text Then
            MsgBox("La clave de cotizacion final debe ser mayor a la inicial" & vbNewLine, MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If

        If TxtCveClienteFinal.Text < TxtCveClienteInicial.Text Then
            MsgBox("La clave del cliente final debe ser mayor a la inicial" & vbNewLine, MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If

        If ChkFecha.Checked Then
            v_FechaInicial = DtpFechaInicial.Value
            v_FechaFinal = DtpFechaFinal.Value

            If DtpFechaFinal.Value < DtpFechaInicial.Value Then
                MsgBox("La fecha final debe ser mayor a la inicial" & vbNewLine, MsgBoxStyle.Information, Generales.MsgInformation)
                Exit Sub
            End If
        Else
            v_FechaInicial = "1900-01-01"
            v_FechaFinal = "1900-01-01"
        End If

        If CmbTipoReporte.Text = "CONSECUTIVO DE COTIZACION" Then

            ReporteDeCotizacionesBL.TBLCOTIZACION.Clear()
            ReporteDeCotizacionesBL.CargarAdicional(v_FechaInicial,
                                                    v_FechaFinal,
                                                    CmbTipoReporte.Text,
                                                    TxtCveCotizacionInicial.Text,
                                                    TxtCveCotizacionFinal.Text,
                                                    TxtCveClienteInicial.Text,
                                                    TxtCveClienteFinal.Text)

            ReporteDeCotizacionesBL.TBLDETALLE_COTIZACION.Clear()

        End If


        If CmbTipoReporte.Text = "CONSECUTIVO DE COTIZACION DESGLOSADO" Then

            ReporteDeCotizacionesBL.TBLCOTIZACION.Clear()
            ReporteDeCotizacionesBL.CargarAdicional(v_FechaInicial,
                                                    v_FechaFinal,
                                                    "CONSECUTIVO DE COTIZACION",
                                                    TxtCveCotizacionInicial.Text,
                                                    TxtCveCotizacionFinal.Text,
                                                    TxtCveClienteInicial.Text,
                                                    TxtCveClienteFinal.Text)

            ReporteDeCotizacionesBL.TBLDETALLE_COTIZACION.Clear()
            ReporteDeCotizacionesBL.CargarDetalle(v_FechaInicial,
                                                    v_FechaFinal,
                                                    CmbTipoReporte.Text,
                                                    TxtCveCotizacionInicial.Text,
                                                    TxtCveCotizacionFinal.Text,
                                                    TxtCveClienteInicial.Text,
                                                    TxtCveClienteFinal.Text)

        End If

        v_Op = "Buscar"
        EstadoBotones(v_Op)

    End Sub


    Private Sub BtnImprmir_Click(sender As Object, e As EventArgs) Handles BtnImprmir.Click

        If CmbTipoReporte.Text = "--SELECCIONE--" Then
            Exit Sub
        End If

        Dim viewer As New FRMReportViewer

        If CmbTipoReporte.Text = "CONSECUTIVO DE COTIZACION" Then
            viewer.DataSource = ReporteDeCotizacionesBL.TBLCOTIZACION
            viewer.DataSourceName = ReporteDeCotizacionesBL.TBLCOTIZACION.TableName
            viewer.ReportPath = Generales.ReportPath & Generales.rdlcConsecutivoDeCotizaciones
            viewer.RutaLogo = Generales.RutaNovo
        End If

        If CmbTipoReporte.Text = "CONSECUTIVO DE COTIZACION DESGLOSADO" Then
            viewer.DataSource = ReporteDeCotizacionesBL.TBLCOTIZACION
            viewer.DataSourceName = ReporteDeCotizacionesBL.TBLCOTIZACION.TableName
            viewer.SubReportDataSource = ReporteDeCotizacionesBL.TBLDETALLE_COTIZACION
            viewer.SubReportDataSourceName = ReporteDeCotizacionesBL.TBLDETALLE_COTIZACION.TableName
            viewer.ReportPath = Generales.ReportPath & Generales.rdlcConsecutivoDeCotizacionesDesglosado
            viewer.RutaLogo = Generales.RutaNovo
        End If

        viewer.Show()

    End Sub

    Private Sub DgvCotizacion_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCotizacion.CellDoubleClick

        If CmbTipoReporte.Text = "CONSECUTIVO DE COTIZACION" Then
            Exit Sub
        End If

        If CmbTipoReporte.Text = "CONSECUTIVO DE COTIZACION DESGLOSADO" Then

            ReporteDeCotizacionesBL.TBLDETALLE_COTIZACION.Clear()
            ReporteDeCotizacionesBL.CargarDetalle(v_FechaInicial,
                                                  v_FechaFinal, CmbTipoReporte.Text,
                                                  DgvCotizacion.SelectedRows(0).Cells("CVE_COTIZACION_INT").Value,
                                                  DgvCotizacion.SelectedRows(0).Cells("CVE_COTIZACION_INT").Value,
                                                  TxtCveClienteInicial.Text,
                                                  TxtCveClienteFinal.Text)

        End If
    End Sub

End Class