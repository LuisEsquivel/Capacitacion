Public Class FRMBrowseSucursal

#Region "VARIABLES"

    Public p_CveSucursal As String = ""
    Dim v_FechaInicial As DateTime = "1900-01-01"
    Dim v_FechaFinal As DateTime = "1900-01-01"

#End Region
    Private Sub FRMBrowseSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SucursalesBL.Cargar()
    End Sub

    Private Sub ChkCveSucursal_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCveSucursal.CheckedChanged

        If ChkCveSucursal.Checked Then
            TxtCveSucursal.Enabled = True
            TxtCveSucursal.Clear()
        Else
            TxtCveSucursal.Enabled = False
            TxtCveSucursal.Clear()
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
            DtpFechaFinal.Value = Now
            DtpFechaInicio.Value = Now
        Else
            DtpFechaInicio.Enabled = False
            DtpFechaFinal.Enabled = False
            DtpFechaFinal.Value = Now
            DtpFechaInicio.Value = Now
        End If

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click

        If DgvSucursales.SelectedRows.Count > 0 Then

            p_CveSucursal = DgvSucursales.SelectedRows(0).Cells("CVE_SUC_VAR").Value
            Me.Hide()
        Else

            Dim mensaje As String = MsgBox("Ninguna sucursal seleccionada" & vbNewLine & "Desea salir?" & MsgBoxStyle.YesNo, Generales.MsgInformation)
            If mensaje = DialogResult.Yes Then
                Me.Close()
            End If

        End If

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        SucursalesBL.TBLSUCURSAL.Clear()

        If ChkFecha.Checked Then
            v_FechaInicial = DtpFechaInicio.Value
            v_FechaFinal = DtpFechaFinal.Value

            If DtpFechaFinal.Value < DtpFechaInicio.Value Then
                MsgBox("La fecha final debe ser mayor a la inicial" & vbNewLine & MsgBoxStyle.Information, Generales.MsgInformation)
                Exit Sub
            End If

        Else
            v_FechaInicial = "1900-01-01"
            v_FechaFinal = "1900-01-01"

        End If

        SucursalesBL.CargarAdicional(v_FechaInicial, v_FechaFinal, TxtCveSucursal.Text, TxtNombre.Text)

    End Sub

    Private Sub DgvSucursales_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSucursales.CellDoubleClick
        BtnRegresar_Click(Nothing, Nothing)
    End Sub

End Class