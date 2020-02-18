Public Class FRMBrowseClientes

#Region "VARIABLES"

    Public p_cveCliente As Integer = 0
    Dim v_FechaInicial As DateTime = "1900-01-01"
    Dim v_FechaFinal As DateTime = "1900-01-01"

#End Region

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click

        If DgvClientes.SelectedRows.Count > 0 Then

            p_cveCliente = DgvClientes.SelectedRows(0).Cells("CVE_CLIENTE_INT").Value
            Me.Hide()
        Else

            Dim mensaje As String = MsgBox("Ningun cliente seleccionado" & vbNewLine & "Desea salir?" & MsgBoxStyle.YesNo, Generales.MsgInformation)
            If mensaje = DialogResult.Yes Then
                Me.Close()
            End If

        End If

    End Sub

    Private Sub FRMBrowseClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientesBL.Cargar()
    End Sub

    Private Sub DgvClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvClientes.CellDoubleClick

        BtnRegresar_Click(Nothing, Nothing)

    End Sub

    Private Sub DgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvClientes.CellContentClick

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        ClientesBL.TBLCLIENTE.Clear()

        If TxtCveClienteFinal.Text < TxtCveClienteInicial.Text Then
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

        ClientesBL.CargarAdicional(v_FechaInicial,
                                   v_FechaFinal,
                                   TxtCveClienteInicial.Text,
                                   TxtCveClienteFinal.Text,
                                   TxtNombre.Text)

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

    Private Sub ChkNombre_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNombre.CheckedChanged
        If ChkNombre.Checked Then
            TxtNombre.Enabled = True
            TxtNombre.Clear()

        Else
            TxtNombre.Enabled = False
            TxtNombre.Clear()

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

    Private Sub TxtCveClienteInicial_Leave(sender As Object, e As EventArgs) Handles TxtCveClienteInicial.Leave
        TxtCveClienteFinal.Text = TxtCveClienteInicial.Text
    End Sub
End Class