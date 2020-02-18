Public Class FRMBrowseVentas

#Region "VARIABLES"
    Public p_CveVenta As Int32 = 0
    Dim v_FechaInicial As DateTime = "1900-01-01"
    Dim v_FechaFinal As DateTime = "1900-01-01"
    Dim v_ListaCveCliente As New List(Of Integer)
    Dim v_ListaCveSuc As New List(Of String)
#End Region

#Region "PROCEDIMINETOS"
    Private Sub LlenarCeldas()

        v_ListaCveCliente.Clear()

        For Each rowCliente As NEGOCIOS.ClientesBL.TBLCLIENTERow In ClientesBL.TBLCLIENTE.Rows
            v_ListaCveCliente.Add(rowCliente.CVE_CLIENTE_INT)
        Next

        For Each row As DataGridViewRow In DgvVentas.Rows
            If v_ListaCveCliente.Contains(row.Cells("CVE_CLIENTE_INT").Value) Then
                row.Cells("NOMBRE_CLIENTE_VAR").Value = ClientesBL.TBLCLIENTE.FindByCVE_CLIENTE_INT(row.Cells("CVE_CLIENTE_INT").Value).NOMBRE_VAR

            End If
        Next

        v_ListaCveSuc.Clear()

        For Each rowSucursal As NEGOCIOS.SucursalesBL.TBLSUCURSALRow In SucursalesBL.TBLSUCURSAL.Rows
            v_ListaCveSuc.Add(rowSucursal.CVE_SUC_VAR)
        Next

        For Each row As DataGridViewRow In DgvVentas.Rows

            If v_ListaCveSuc.Contains(row.Cells("CVE_SUC_VAR").Value) Then
                row.Cells("NOMBRE_SUC_VAR").Value = SucursalesBL.TBLSUCURSAL.FindByCVE_SUC_VAR(row.Cells("CVE_SUC_VAR").Value).NOMBRE_SUC_VAR

            End If
        Next
    End Sub

#End Region

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        If DgvVentas.SelectedRows.Count > 0 Then
            p_CveVenta = DgvVentas.SelectedRows(0).Cells("CVE_VENTA_INT").Value
            Me.Hide()
        Else
            Dim mensaje As String = MsgBox("Ninguna venta seleccionada " & vbNewLine & "¿Desea Salir?", MsgBoxStyle.YesNo, Generales.MsgInformation)
            If mensaje = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub FRMBrowseVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VentasBL.Cargar()
        ClientesBL.Cargar()
        SucursalesBL.Cargar()
        LlenarCeldas()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        VentasBL.TBLVENTA.Clear()

        If TxtCveVentaFinal.Text < TxtCveVentaInicial.Text Then
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

        VentasBL.CargarAdicional(v_FechaInicial,
                                   v_FechaFinal,
                                   TxtCveVentaInicial.Text,
                                   TxtCveVentaFinal.Text,
                                   CmbEstatus.SelectedIndex)
        LlenarCeldas()
    End Sub

    Private Sub DgvVentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVentas.CellDoubleClick
        BtnRegresar_Click(Nothing, Nothing)
    End Sub

    Private Sub ChkCveVenta_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCveVenta.CheckedChanged

        If ChkCveVenta.Checked Then
            TxtCveVentaInicial.Enabled = True
            TxtCveVentaFinal.Enabled = True
            TxtCveVentaFinal.Text = 0
            TxtCveVentaInicial.Text = 0
        Else
            TxtCveVentaInicial.Enabled = False
            TxtCveVentaFinal.Enabled = False
            TxtCveVentaFinal.Text = 0
            TxtCveVentaInicial.Text = 0
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

    Private Sub TxtCveVentaInicial_Leave(sender As Object, e As EventArgs) Handles TxtCveVentaInicial.Leave

        TxtCveVentaFinal.Text = TxtCveVentaInicial.Text

    End Sub

    Private Sub ChkFecha_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFecha.CheckedChanged

        If ChkFecha.Checked Then
            DtpFechaInicio.Enabled = True
            DtpFechaFinal.Enabled = True
            DtpFechaFinal.Value = Now
            DtpFechaInicio.Value = Now
        Else
            DtpFechaInicio.Enabled = False
            DtpFechaFinal.Enabled = False
            DtpFechaFinal.Value = Now
            DtpFechaInicio.Value = Now
        End If

    End Sub

End Class