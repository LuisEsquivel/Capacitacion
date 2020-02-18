Public Class FRMBrowseRoles

    Public p_CveRol As Integer = 0
    Public v_FechaInicial As DateTime = "1900-01-01"
    Public v_FechaFinal As DateTime = "1900-01-01"

    Private Sub FRMBrowseRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RolesBL.Cargar()

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click

        If DgvRoles.SelectedRows.Count > 0 Then
            p_CveRol = DgvRoles.SelectedRows(0).Cells("CVE_ROL_INT").Value
            Me.Hide()
        Else
            Dim mensaje As String = MsgBox("Ningun producto seleccionado " & vbNewLine & "¿Desea Salir?", MsgBoxStyle.YesNo, Generales.MsgInformation)
            If mensaje = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If

    End Sub

    Private Sub DgvRoles_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRoles.CellDoubleClick
        BtnRegresar_Click(Nothing, Nothing)
    End Sub

    Private Sub ChkCveRol_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCveRol.CheckedChanged

        If ChkCveRol.Checked Then
            TxtCveRolInicial.Enabled = True
            TxtCveRolFinal.Enabled = True
            TxtCveRolInicial.Text = 0
            TxtCveRolFinal.Text = 0

        Else
            TxtCveRolInicial.Enabled = False
            TxtCveRolFinal.Enabled = False
            TxtCveRolInicial.Text = 0
            TxtCveRolFinal.Text = 0
        End If

    End Sub

    Private Sub ChkNombreRol_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNombreRol.CheckedChanged

        If ChkNombreRol.Checked Then
            TxtNombreRol.Enabled = True
            TxtNombreRol.Clear()
        Else
            TxtNombreRol.Enabled = False
            TxtNombreRol.Clear()
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

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        RolesBL.TBLROLES.Clear()

        If TxtCveRolFinal.Text < TxtCveRolInicial.Text Then
            MsgBox("La clave final debe ser mayor a la inicial", MsgBoxStyle.Information, Generales.MsgInformation)
            Exit Sub
        End If

        If ChkFecha.Checked Then
            v_FechaInicial = DtpFechaInicial.Value
            v_FechaFinal = DtpFechaFinal.Value

            If DtpFechaFinal.Value < DtpFechaInicial.Value Then
                MsgBox("La fecha final debe ser mayor a la inicial", MsgBoxStyle.Information, Generales.MsgInformation)
                Exit Sub
            End If

        Else
            v_FechaInicial = "1900-01-01"
            v_FechaFinal = "1900-01-01"

        End If

        RolesBL.CargarAdicional(v_FechaInicial,
                                v_FechaFinal,
                                TxtCveRolInicial.Text,
                                TxtCveRolFinal.Text,
                                TxtNombreRol.Text)

    End Sub

    Private Sub TxtCveRolInicial_Leave(sender As Object, e As EventArgs) Handles TxtCveRolInicial.Leave
        TxtCveRolFinal.Text = TxtCveRolInicial.Text
    End Sub

End Class