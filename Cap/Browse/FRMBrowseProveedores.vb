Public Class FRMBrowseProveedores

#Region "VARIABLES"

    Public p_CveProveedor As String = ""
    Dim v_FechaInicial As DateTime = "1900-01-01"
    Dim v_FechaFinal As DateTime = "1900-01-01"

#End Region

    Private Sub FRMBrowseProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProveedoresBL.Cargar()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        If DgvProveedores.SelectedRows.Count > 0 Then

            p_CveProveedor = DgvProveedores.SelectedRows(0).Cells("CVE_PROVEEDOR_VAR").Value
            Me.Hide()
        Else

            Dim mensaje As String = MsgBox("Ningun proveedor seleccionado" & vbNewLine & "Desea salir?" & MsgBoxStyle.YesNo, Generales.MsgInformation)
            If mensaje = DialogResult.Yes Then
                Me.Close()
            End If

        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        ProveedoresBL.TBLPROVEEDORES.Clear()

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

        ProveedoresBL.CargarAdicional(v_FechaInicial,
                                   v_FechaFinal,
                                   TxtCveProveedor.Text,
                                   TxtNombre.Text, )
    End Sub

    Private Sub DgvProveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProveedores.CellDoubleClick
        BtnRegresar_Click(Nothing, Nothing)
    End Sub

    Private Sub ChkCveProveedor_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCveProveedor.CheckedChanged
        If ChkCveProveedor.Checked Then
            TxtCveProveedor.Enabled = True
            TxtCveProveedor.Clear()
        Else
            TxtCveProveedor.Enabled = False
            TxtCveProveedor.Clear()
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
End Class