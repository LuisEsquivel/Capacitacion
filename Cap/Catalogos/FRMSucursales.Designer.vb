<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMSucursales
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTelefono = New Componentes.TextBoxEx()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNumEsterior = New Componentes.TextBoxEx()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNumInterior = New Componentes.TextBoxEx()
        Me.label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCalle = New Componentes.TextBoxEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombreSucursal = New Componentes.TextBoxEx()
        Me.TxtCveSucursal = New Componentes.TextBoxEx()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFechaDeAlta = New System.Windows.Forms.DateTimePicker()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SucursalesBL = New NEGOCIOS.SucursalesBL()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SucursalesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtNumEsterior)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtNumInterior)
        Me.GroupBox1.Controls.Add(Me.label)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtCalle)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtNombreSucursal)
        Me.GroupBox1.Controls.Add(Me.TxtCveSucursal)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 168)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'TxtTelefono
        '
        Me.TxtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTelefono.Enabled = False
        Me.TxtTelefono.Location = New System.Drawing.Point(0, 129)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(152, 20)
        Me.TxtTelefono.TabIndex = 29
        Me.TxtTelefono.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "TELEFONO"
        '
        'TxtNumEsterior
        '
        Me.TxtNumEsterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNumEsterior.Enabled = False
        Me.TxtNumEsterior.Location = New System.Drawing.Point(275, 81)
        Me.TxtNumEsterior.Name = "TxtNumEsterior"
        Me.TxtNumEsterior.Size = New System.Drawing.Size(107, 20)
        Me.TxtNumEsterior.TabIndex = 27
        Me.TxtNumEsterior.TipoDato = Componentes.Enumeraciones.TipoDatos.Entero
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(272, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "NUM EXTERIOR"
        '
        'TxtNumInterior
        '
        Me.TxtNumInterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNumInterior.Enabled = False
        Me.TxtNumInterior.Location = New System.Drawing.Point(159, 81)
        Me.TxtNumInterior.Name = "TxtNumInterior"
        Me.TxtNumInterior.Size = New System.Drawing.Size(107, 20)
        Me.TxtNumInterior.TabIndex = 25
        Me.TxtNumInterior.TipoDato = Componentes.Enumeraciones.TipoDatos.Entero
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(156, 61)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(110, 13)
        Me.label.TabIndex = 24
        Me.label.Text = "NUMERO INTERIOR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "CALLE"
        '
        'TxtCalle
        '
        Me.TxtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCalle.Enabled = False
        Me.TxtCalle.Location = New System.Drawing.Point(0, 81)
        Me.TxtCalle.Name = "TxtCalle"
        Me.TxtCalle.Size = New System.Drawing.Size(153, 20)
        Me.TxtCalle.TabIndex = 22
        Me.TxtCalle.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "NOMBRE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "CVE SUCURSAL"
        '
        'TxtNombreSucursal
        '
        Me.TxtNombreSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreSucursal.Enabled = False
        Me.TxtNombreSucursal.Location = New System.Drawing.Point(159, 30)
        Me.TxtNombreSucursal.Name = "TxtNombreSucursal"
        Me.TxtNombreSucursal.Size = New System.Drawing.Size(312, 20)
        Me.TxtNombreSucursal.TabIndex = 19
        Me.TxtNombreSucursal.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'TxtCveSucursal
        '
        Me.TxtCveSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveSucursal.Enabled = False
        Me.TxtCveSucursal.Location = New System.Drawing.Point(1, 30)
        Me.TxtCveSucursal.Name = "TxtCveSucursal"
        Me.TxtCveSucursal.Size = New System.Drawing.Size(152, 20)
        Me.TxtCveSucursal.TabIndex = 18
        Me.TxtCveSucursal.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "FECHA"
        '
        'DtpFechaDeAlta
        '
        Me.DtpFechaDeAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaDeAlta.Location = New System.Drawing.Point(376, 108)
        Me.DtpFechaDeAlta.Name = "DtpFechaDeAlta"
        Me.DtpFechaDeAlta.Size = New System.Drawing.Size(110, 20)
        Me.DtpFechaDeAlta.TabIndex = 38
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(287, 12)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(66, 76)
        Me.BtnBuscar.TabIndex = 37
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(353, 12)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(66, 76)
        Me.BtnCancelar.TabIndex = 36
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(221, 12)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(66, 76)
        Me.BtnGuardar.TabIndex = 35
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(155, 12)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(66, 76)
        Me.BtnModificar.TabIndex = 34
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(89, 12)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(66, 76)
        Me.BtnNuevo.TabIndex = 33
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(419, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(66, 76)
        Me.BtnSalir.TabIndex = 41
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'SucursalesBL
        '
        Me.SucursalesBL.DataSetName = "DSSucursales"
        Me.SucursalesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FRMSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(501, 324)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DtpFechaDeAlta)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Name = "FRMSucursales"
        Me.Text = "Sucursales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SucursalesBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtTelefono As Componentes.TextBoxEx
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNumEsterior As Componentes.TextBoxEx
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNumInterior As Componentes.TextBoxEx
    Friend WithEvents label As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCalle As Componentes.TextBoxEx
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombreSucursal As Componentes.TextBoxEx
    Friend WithEvents TxtCveSucursal As Componentes.TextBoxEx
    Friend WithEvents Label3 As Label
    Friend WithEvents DtpFechaDeAlta As DateTimePicker
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents SucursalesBL As NEGOCIOS.SucursalesBL
End Class
