Public Class FRMLogin

    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown

        If e.KeyCode = Keys.Enter Then
            BtnIniciar_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub TxtNombreUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCveUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnIniciar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click
        UsuariosBL.TBLUSUARIOS.Clear()
        UsuariosBL.CargarUsuario(TxtCveUsuario.Text, TxtPassword.Text)

        If UsuariosBL.TBLUSUARIOS.Rows.Count = 1 Then
            Me.Close()

            With CType(UsuariosBL.TBLUSUARIOS.Rows(0), NEGOCIOS.UsuariosBL.TBLUSUARIOSRow)
                Generales.CVE_USUARIO_VAR = .CVE_USUARIO_VAR
            End With

        Else
            MsgBox("Usuario y/o contraseña incorrecta" & vbNewLine, MsgBoxStyle.Information, Generales.MsgInformation)
        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        Dim opcion = MsgBox("Esta seguro que desea terminar la sesión?" & vbNewLine, MsgBoxStyle.YesNo, "Aviso")
        If opcion = MsgBoxResult.Yes Then
            End
        Else
            TxtCveUsuario.Select()
        End If

    End Sub

    Private Sub FRMLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblFecha.Text = TimeOfDay
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblFecha.Text = TimeOfDay
    End Sub
End Class