Public Class FRMBrowseCotizaciones

#Region "VARIABLES"
    Public p_CveCotizacon As Int32 = 0
    Dim v_FechaInicial As DateTime = "1900-01-01"
    Dim v_FechaFinal As DateTime = "1900-01-01"
    Dim v_ListaCveCliente As New List(Of Integer)

#End Region

#Region "PROCEDIMIENTOS"

    Private Sub LlenarCeldas()

        v_ListaCveCliente.Clear()

        For Each rowCliente As NEGOCIOS.ClientesBL.TBLCLIENTERow In ClientesBL.TBLCLIENTE.Rows
            v_ListaCveCliente.Add(rowCliente.CVE_CLIENTE_INT)
        Next

        For Each row As DataGridViewRow In DgvCotizaciones.Rows
            If v_ListaCveCliente.Contains(row.Cells("CVE_CLIENTE_INT").Value) Then
                row.Cells("NOMBRE_CLIENTE_VAR").Value = ClientesBL.TBLCLIENTE.FindByCVE_CLIENTE_INT(row.Cells("CVE_CLIENTE_INT").Value).NOMBRE_VAR

            End If
        Next

    End Sub

#End Region

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        If DgvCotizaciones.SelectedRows.Count > 0 Then
            p_CveCotizacon = DgvCotizaciones.SelectedRows(0).Cells("CVE_COTIZACION_INT").Value
            Me.Hide()
        Else
            Dim mensaje As String = MsgBox("Ninguna cotizacion seleccionada " & vbNewLine & "¿Desea Salir?", MsgBoxStyle.YesNo, Generales.MsgInformation)
            If mensaje = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub FRMBrowseCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CotizacionesBL.Cargar()
        ClientesBL.Cargar()

        LlenarCeldas()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        CotizacionesBL.TBLCOTIZACION.Clear()

        If TxtCveCotizacionFinal.Text < TxtCveCotizacionInicial.Text Then
            MsgBox("LA CLAVE FINAL DEBE SER MAYOR QUE LA INICIAL" & vbNewLine, MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If

        If ChkFecha.Checked Then
            v_FechaInicial = DtpFechaInicio.Value
            v_FechaFinal = DtpFechaFinal.Value

            If DtpFechaFinal.Value < DtpFechaInicio.Value Then
                MsgBox("LA FECHA FINAL DEBE SER MAYOR QUE LA INICIAL" & vbNewLine, MsgBoxStyle.Information, Generales.MsgInformation)
                Exit Sub
            End If

        Else
            v_FechaInicial = "1900-01-01"
            v_FechaFinal = "1900-01-01"
        End If

        CotizacionesBL.CargarAdicional(v_FechaInicial,
                                   v_FechaFinal,
                                   TxtCveCotizacionInicial.Text,
                                   TxtCveCotizacionFinal.Text,
                                   CmbEstatus.SelectedIndex)

        LlenarCeldas()
    End Sub

    Private Sub DgvCotizaciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCotizaciones.CellDoubleClick
        BtnRegresar_Click(Nothing, Nothing)
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

    Private Sub ChkEstatus_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEstatus.CheckedChanged
        If ChkEstatus.Checked Then
            CmbEstatus.Enabled = True
            CmbEstatus.Text = "---SELECCIONAR---"
        Else
            CmbEstatus.Enabled = False
            CmbEstatus.Text = "---SELECCIONAR---"
        End If
    End Sub

    Private Sub ChkFecha_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFecha.CheckedChanged
        If ChkFecha.Checked Then
            DtpFechaInicio.Enabled = True
            DtpFechaFinal.Enabled = True
            DtpFechaInicio.Value = Now
            DtpFechaFinal.Value = Now
        Else
            DtpFechaInicio.Enabled = False
            DtpFechaFinal.Enabled = False
            DtpFechaInicio.Value = Now
            DtpFechaFinal.Value = Now
        End If
    End Sub

    Private Sub TxtCveCotizacionInicial_Leave(sender As Object, e As EventArgs) Handles TxtCveCotizacionInicial.Leave
        TxtCveCotizacionFinal.Text = TxtCveCotizacionInicial.Text
    End Sub
End Class