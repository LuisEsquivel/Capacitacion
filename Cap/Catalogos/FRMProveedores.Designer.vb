<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMProveedores
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCveProveedor = New Componentes.TextBoxEx()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtRazonSocial = New Componentes.TextBoxEx()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCorreo = New Componentes.TextBoxEx()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New Componentes.TextBoxEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtApellidos = New Componentes.TextBoxEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre = New Componentes.TextBoxEx()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpFechaDeAlta = New System.Windows.Forms.DateTimePicker()
        Me.ProveedoresBL = New NEGOCIOS.ProveedoresBL()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProveedoresBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(348, 12)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(66, 76)
        Me.BtnBuscar.TabIndex = 41
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(478, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(66, 76)
        Me.BtnSalir.TabIndex = 40
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(413, 12)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(66, 76)
        Me.BtnCancelar.TabIndex = 39
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(283, 12)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(66, 76)
        Me.BtnGuardar.TabIndex = 38
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(218, 12)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(66, 76)
        Me.BtnModificar.TabIndex = 37
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(153, 12)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(66, 76)
        Me.BtnNuevo.TabIndex = 36
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtCveProveedor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtRazonSocial)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtCorreo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtApellidos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(533, 131)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "CVE PROVEEDOR"
        '
        'TxtCveProveedor
        '
        Me.TxtCveProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveProveedor.Enabled = False
        Me.TxtCveProveedor.Location = New System.Drawing.Point(6, 32)
        Me.TxtCveProveedor.Name = "TxtCveProveedor"
        Me.TxtCveProveedor.Size = New System.Drawing.Size(121, 20)
        Me.TxtCveProveedor.TabIndex = 51
        Me.TxtCveProveedor.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(170, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "RAZON SOCIAL"
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRazonSocial.Enabled = False
        Me.TxtRazonSocial.Location = New System.Drawing.Point(171, 84)
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.Size = New System.Drawing.Size(152, 20)
        Me.TxtRazonSocial.TabIndex = 49
        Me.TxtRazonSocial.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(334, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "E-MAIL"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCorreo.Enabled = False
        Me.TxtCorreo.Location = New System.Drawing.Point(337, 83)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(152, 20)
        Me.TxtCorreo.TabIndex = 47
        Me.TxtCorreo.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "TELEFONO"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTelefono.Enabled = False
        Me.TxtTelefono.Location = New System.Drawing.Point(6, 83)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(152, 20)
        Me.TxtTelefono.TabIndex = 47
        Me.TxtTelefono.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(306, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "APELLIDOS"
        '
        'TxtApellidos
        '
        Me.TxtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApellidos.Enabled = False
        Me.TxtApellidos.Location = New System.Drawing.Point(309, 32)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(152, 20)
        Me.TxtApellidos.TabIndex = 45
        Me.TxtApellidos.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(143, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "NOMBRE(S)"
        '
        'TxtNombre
        '
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Location = New System.Drawing.Point(143, 32)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(152, 20)
        Me.TxtNombre.TabIndex = 43
        Me.TxtNombre.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(399, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "FECHA"
        '
        'DtpFechaDeAlta
        '
        Me.DtpFechaDeAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaDeAlta.Location = New System.Drawing.Point(447, 111)
        Me.DtpFechaDeAlta.Name = "DtpFechaDeAlta"
        Me.DtpFechaDeAlta.Size = New System.Drawing.Size(97, 20)
        Me.DtpFechaDeAlta.TabIndex = 43
        '
        'ProveedoresBL
        '
        Me.ProveedoresBL.DataSetName = "DSProveedores"
        Me.ProveedoresBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FRMProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(553, 294)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DtpFechaDeAlta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Name = "FRMProveedores"
        Me.Text = "Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProveedoresBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtApellidos As Componentes.TextBoxEx
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombre As Componentes.TextBoxEx
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtRazonSocial As Componentes.TextBoxEx
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCorreo As Componentes.TextBoxEx
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTelefono As Componentes.TextBoxEx
    Friend WithEvents Label6 As Label
    Friend WithEvents DtpFechaDeAlta As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCveProveedor As Componentes.TextBoxEx
    Friend WithEvents ProveedoresBL As NEGOCIOS.ProveedoresBL
End Class
