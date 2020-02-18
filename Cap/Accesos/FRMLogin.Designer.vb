<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCveUsuario = New Componentes.TextBoxEx()
        Me.TxtPassword = New Componentes.TextBoxEx()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnIniciar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.UsuariosBL = New NEGOCIOS.UsuariosBL()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave de Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'TxtCveUsuario
        '
        Me.TxtCveUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveUsuario.Location = New System.Drawing.Point(15, 197)
        Me.TxtCveUsuario.Name = "TxtCveUsuario"
        Me.TxtCveUsuario.Size = New System.Drawing.Size(177, 20)
        Me.TxtCveUsuario.TabIndex = 2
        Me.TxtCveUsuario.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'TxtPassword
        '
        Me.TxtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPassword.Location = New System.Drawing.Point(15, 236)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(177, 20)
        Me.TxtPassword.TabIndex = 3
        Me.TxtPassword.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Cap.My.Resources.Resources.novo
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(332, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'BtnIniciar
        '
        Me.BtnIniciar.Location = New System.Drawing.Point(197, 197)
        Me.BtnIniciar.Name = "BtnIniciar"
        Me.BtnIniciar.Size = New System.Drawing.Size(67, 59)
        Me.BtnIniciar.TabIndex = 7
        Me.BtnIniciar.Text = "Iniciar"
        Me.BtnIniciar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(266, 197)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(67, 59)
        Me.BtnSalir.TabIndex = 8
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'UsuariosBL
        '
        Me.UsuariosBL.DataSetName = "DSUsuarios"
        Me.UsuariosBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.BackColor = System.Drawing.Color.White
        Me.LblFecha.Location = New System.Drawing.Point(12, 160)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(39, 13)
        Me.LblFecha.TabIndex = 9
        Me.LblFecha.Text = "Label3"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'FRMLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(336, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnIniciar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtCveUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRMLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCveUsuario As Componentes.TextBoxEx
    Friend WithEvents TxtPassword As Componentes.TextBoxEx
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UsuariosBL As NEGOCIOS.UsuariosBL
    Friend WithEvents BtnIniciar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents LblFecha As Label
    Friend WithEvents Timer1 As Timer
End Class
