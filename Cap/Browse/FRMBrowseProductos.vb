Public Class FRMBrowseProductos


#Region "VARIABLES"
    Public p_CveProducto As String = ""

    Dim V_FechaInicial As DateTime = "1900-01-01"
    Dim v_FechaFinal As DateTime = "1900-01-01"
#End Region


    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click

        If DgvProductos.SelectedRows.Count > 0 Then
            p_CveProducto = DgvProductos.SelectedRows(0).Cells("CVE_PRODUCTO_VAR").Value
            Me.Hide()
        Else
            Dim mensaje As String = MsgBox("Ningun producto seleccionado " & vbNewLine & "¿Desea Salir?", MsgBoxStyle.YesNo, Generales.MsgInformation)
            If mensaje = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub FRMBrowseProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductosBL.Cargar()
    End Sub

    Private Sub DgvProductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProductos.CellDoubleClick
        BtnRegresar_Click(Nothing, Nothing)
    End Sub

    Private Sub ChkCveProducto_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCveProducto.CheckedChanged

        If ChkCveProducto.Checked Then
            TxtCveProducto.Enabled = True
            TxtCveProducto.Clear()
        Else
            TxtCveProducto.Enabled = False
            TxtCveProducto.Clear()
        End If

    End Sub

    Private Sub ChkNombreProducto_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNombreProducto.CheckedChanged

        If ChkNombreProducto.Checked Then
            TxtNombrePRoducto.Enabled = True
            TxtNombrePRoducto.Clear()
        Else
            TxtNombrePRoducto.Enabled = False
            TxtNombrePRoducto.Clear()
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

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        ProductosBL.TBLPRODUCTOS.Clear()

        If ChkFecha.Checked Then
            V_FechaInicial = DtpFechaInicio.Value
            v_FechaFinal = DtpFechaFinal.Value

            If DtpFechaFinal.Value < DtpFechaInicio.Value Then
                MsgBox("La fecha final debe ser mayor a la inicial", MsgBoxStyle.Information, Generales.MsgInformation)
                Exit Sub
            End If

        Else
            V_FechaInicial = "1900-01-01"
            v_FechaFinal = "1900-01-01"
        End If

        ProductosBL.CargarAdicional(V_FechaInicial, v_FechaFinal, TxtCveProducto.Text, TxtNombrePRoducto.Text)

    End Sub
End Class