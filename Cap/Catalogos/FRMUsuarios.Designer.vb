<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMUsuarios
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
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFechaDeAlta = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtPassword = New Componentes.TextBoxEx()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.BtnQuitarImagen = New System.Windows.Forms.Button()
        Me.CmbRol = New System.Windows.Forms.ComboBox()
        Me.RolesBL = New NEGOCIOS.RolesBL()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnCargar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PicImagen = New System.Windows.Forms.PictureBox()
        Me.TxtNombreUsuario = New Componentes.TextBoxEx()
        Me.TxtCveUsuario = New Componentes.TextBoxEx()
        Me.UsuariosBL = New NEGOCIOS.UsuariosBL()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RolesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(314, 12)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(66, 76)
        Me.BtnBuscar.TabIndex = 35
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(444, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(66, 76)
        Me.BtnSalir.TabIndex = 34
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(379, 12)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(66, 76)
        Me.BtnCancelar.TabIndex = 33
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(249, 12)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(66, 76)
        Me.BtnGuardar.TabIndex = 32
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(184, 12)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(66, 76)
        Me.BtnModificar.TabIndex = 31
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(119, 12)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(66, 76)
        Me.BtnNuevo.TabIndex = 30
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(365, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "FECHA"
        '
        'DtpFechaDeAlta
        '
        Me.DtpFechaDeAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaDeAlta.Location = New System.Drawing.Point(413, 105)
        Me.DtpFechaDeAlta.Name = "DtpFechaDeAlta"
        Me.DtpFechaDeAlta.Size = New System.Drawing.Size(97, 20)
        Me.DtpFechaDeAlta.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtPassword)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CmbDepartamento)
        Me.GroupBox1.Controls.Add(Me.BtnQuitarImagen)
        Me.GroupBox1.Controls.Add(Me.CmbRol)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.BtnCargar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PicImagen)
        Me.GroupBox1.Controls.Add(Me.TxtNombreUsuario)
        Me.GroupBox1.Controls.Add(Me.TxtCveUsuario)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 190)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'TxtPassword
        '
        Me.TxtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPassword.Enabled = False
        Me.TxtPassword.Location = New System.Drawing.Point(134, 86)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(152, 20)
        Me.TxtPassword.TabIndex = 32
        Me.TxtPassword.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(131, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "PASSWORD"
        '
        'CmbDepartamento
        '
        Me.CmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDepartamento.Enabled = False
        Me.CmbDepartamento.FormattingEnabled = True
        Me.CmbDepartamento.Items.AddRange(New Object() {"---SELECCIONAR---", "SISTEMAS ", "ADMINISTRACION", "RH", "CONTABILIDAD", "VENTAS", "COMPRAS "})
        Me.CmbDepartamento.Location = New System.Drawing.Point(132, 134)
        Me.CmbDepartamento.Name = "CmbDepartamento"
        Me.CmbDepartamento.Size = New System.Drawing.Size(152, 21)
        Me.CmbDepartamento.TabIndex = 30
        '
        'BtnQuitarImagen
        '
        Me.BtnQuitarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnQuitarImagen.Location = New System.Drawing.Point(13, 146)
        Me.BtnQuitarImagen.Name = "BtnQuitarImagen"
        Me.BtnQuitarImagen.Size = New System.Drawing.Size(100, 23)
        Me.BtnQuitarImagen.TabIndex = 29
        Me.BtnQuitarImagen.Text = "Quitar Imagen"
        Me.BtnQuitarImagen.UseVisualStyleBackColor = True
        '
        'CmbRol
        '
        Me.CmbRol.DataSource = Me.RolesBL
        Me.CmbRol.DisplayMember = "TBLROLES.NOMBRE_ROL_VAR"
        Me.CmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRol.Enabled = False
        Me.CmbRol.FormattingEnabled = True
        Me.CmbRol.Location = New System.Drawing.Point(292, 90)
        Me.CmbRol.Name = "CmbRol"
        Me.CmbRol.Size = New System.Drawing.Size(183, 21)
        Me.CmbRol.TabIndex = 27
        Me.CmbRol.ValueMember = "TBLROLES.CVE_ROL_INT"
        '
        'RolesBL
        '
        Me.RolesBL.DataSetName = "DSRoles"
        Me.RolesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(289, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "ROL"
        '
        'BtnCargar
        '
        Me.BtnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCargar.Location = New System.Drawing.Point(13, 117)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.Size = New System.Drawing.Size(100, 23)
        Me.BtnCargar.TabIndex = 28
        Me.BtnCargar.Text = "Examinar"
        Me.BtnCargar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "DEPARTAMENTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "NOMBRE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "CVE USUARIO"
        '
        'PicImagen
        '
        Me.PicImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicImagen.Enabled = False
        Me.PicImagen.Location = New System.Drawing.Point(13, 19)
        Me.PicImagen.Name = "PicImagen"
        Me.PicImagen.Size = New System.Drawing.Size(100, 92)
        Me.PicImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicImagen.TabIndex = 25
        Me.PicImagen.TabStop = False
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreUsuario.Enabled = False
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(292, 39)
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(183, 20)
        Me.TxtNombreUsuario.TabIndex = 19
        Me.TxtNombreUsuario.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'TxtCveUsuario
        '
        Me.TxtCveUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveUsuario.Enabled = False
        Me.TxtCveUsuario.Location = New System.Drawing.Point(134, 39)
        Me.TxtCveUsuario.Name = "TxtCveUsuario"
        Me.TxtCveUsuario.Size = New System.Drawing.Size(152, 20)
        Me.TxtCveUsuario.TabIndex = 18
        Me.TxtCveUsuario.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'UsuariosBL
        '
        Me.UsuariosBL.DataSetName = "DSUsuarios"
        Me.UsuariosBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FRMUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(526, 355)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DtpFechaDeAlta)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Name = "FRMUsuarios"
        Me.Text = "Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RolesBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DtpFechaDeAlta As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombreUsuario As Componentes.TextBoxEx
    Friend WithEvents TxtCveUsuario As Componentes.TextBoxEx
    Friend WithEvents UsuariosBL As NEGOCIOS.UsuariosBL
    Friend WithEvents PicImagen As PictureBox
    Friend WithEvents CmbRol As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnCargar As Button
    Friend WithEvents RolesBL As NEGOCIOS.RolesBL
    Friend WithEvents BtnQuitarImagen As Button
    Friend WithEvents CmbDepartamento As ComboBox
    Friend WithEvents TxtPassword As Componentes.TextBoxEx
    Friend WithEvents Label5 As Label
End Class
