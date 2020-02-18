<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.DtpFechaDeAlta = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New Componentes.TextBoxEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombreProducto = New Componentes.TextBoxEx()
        Me.TxtCveProducto = New Componentes.TextBoxEx()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.ProductosBL = New NEGOCIOS.ProductosBL()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProductosBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(424, 26)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(66, 76)
        Me.BtnSalir.TabIndex = 15
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(358, 26)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(66, 76)
        Me.BtnCancelar.TabIndex = 14
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(222, 26)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(66, 76)
        Me.BtnGuardar.TabIndex = 13
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(154, 26)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(66, 76)
        Me.BtnModificar.TabIndex = 12
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(88, 26)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(66, 76)
        Me.BtnNuevo.TabIndex = 11
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'DtpFechaDeAlta
        '
        Me.DtpFechaDeAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaDeAlta.Location = New System.Drawing.Point(379, 123)
        Me.DtpFechaDeAlta.Name = "DtpFechaDeAlta"
        Me.DtpFechaDeAlta.Size = New System.Drawing.Size(110, 20)
        Me.DtpFechaDeAlta.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtPrecio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtNombreProducto)
        Me.GroupBox1.Controls.Add(Me.TxtCveProducto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 105)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "PRECIO"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPrecio.Enabled = False
        Me.TxtPrecio.Location = New System.Drawing.Point(3, 77)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(150, 20)
        Me.TxtPrecio.TabIndex = 22
        Me.TxtPrecio.TipoDato = Componentes.Enumeraciones.TipoDatos.Moneda
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
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "CVE PRODUCTO"
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreProducto.Enabled = False
        Me.TxtNombreProducto.Location = New System.Drawing.Point(159, 30)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(312, 20)
        Me.TxtNombreProducto.TabIndex = 19
        Me.TxtNombreProducto.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'TxtCveProducto
        '
        Me.TxtCveProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveProducto.Enabled = False
        Me.TxtCveProducto.Location = New System.Drawing.Point(1, 30)
        Me.TxtCveProducto.Name = "TxtCveProducto"
        Me.TxtCveProducto.Size = New System.Drawing.Size(152, 20)
        Me.TxtCveProducto.TabIndex = 18
        Me.TxtCveProducto.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(331, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "FECHA"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(291, 26)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(66, 76)
        Me.BtnBuscar.TabIndex = 23
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'ProductosBL
        '
        Me.ProductosBL.DataSetName = "DSProductos"
        Me.ProductosBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FRMProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(500, 288)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtpFechaDeAlta)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Name = "FRMProductos"
        Me.Text = "Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProductosBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents DtpFechaDeAlta As DateTimePicker
    Friend WithEvents TxtCveProducto As Componentes.TextBoxEx
    Friend WithEvents TxtNombreProducto As Componentes.TextBoxEx
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPrecio As Componentes.TextBoxEx
    Friend WithEvents ProductosBL As NEGOCIOS.ProductosBL
End Class
