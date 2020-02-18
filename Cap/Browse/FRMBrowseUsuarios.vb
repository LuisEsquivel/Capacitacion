Public Class FRMBrowseUsuarios

#Region "VARIABLES"
    Public p_CveUsuario As String = ""

    Dim V_FechaInicial As DateTime = "1900-01-01"
    Dim v_FechaFinal As DateTime = "1900-01-01"
#End Region

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click

        If DgvUsuarios.SelectedRows.Count > 0 Then
            p_CveUsuario = DgvUsuarios.SelectedRows(0).Cells("CVE_USUARIO_VAR").Value
            Me.Hide()
        Else
            Dim mensaje As String = MsgBox("Ningun usuario seleccionado " & vbNewLine & "¿Desea Salir?", MsgBoxStyle.YesNo, Generales.MsgInformation)
            If DialogResult.Yes Then
                Me.Close()
            End If
        End If

    End Sub

    Private Sub FRMBrowseUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsuariosBL.Cargar()
    End Sub

    Private Sub DgvUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUsuarios.CellDoubleClick
        BtnRegresar_Click(Nothing, Nothing)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        UsuariosBL.TBLUSUARIOS.Clear()

        If ChkFecha.Checked Then
            V_FechaInicial = DtpFechaInicio.Value
            v_FechaFinal = DtpFechaFinal.Value

            If DtpFechaFinal.Value < DtpFechaInicio.Value Then
                MsgBox("La fecha final debe ser mayor a la inicial ", MsgBoxStyle.Information, Generales.MsgInformation)
            End If
        Else
            V_FechaInicial = "1900-01-01"
            v_FechaFinal = "1900-01-01"
        End If

        UsuariosBL.CargarAdicional(V_FechaInicial, v_FechaFinal, TxtCveUsuario.Text, TxtNombre.Text)

    End Sub

    Private Sub ChkCveUsuario_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCveUsuario.CheckedChanged

        If ChkCveUsuario.Checked Then
            TxtCveUsuario.Enabled = True
            TxtCveUsuario.Clear()
        Else
            TxtCveUsuario.Enabled = False
            TxtCveUsuario.Clear()
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