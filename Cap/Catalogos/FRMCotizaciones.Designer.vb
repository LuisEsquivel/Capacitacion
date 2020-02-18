<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMCotizaciones
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnBajas = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCveCotizacion = New Componentes.TextBoxEx()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNombreCliente = New Componentes.TextBoxEx()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCveCliente = New Componentes.TextBoxEx()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtCveProducto = New Componentes.TextBoxEx()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtPrecioProducto = New Componentes.TextBoxEx()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCantidadProducto = New Componentes.TextBoxEx()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNombreProducto = New Componentes.TextBoxEx()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DgvDetalleCotizaciones = New System.Windows.Forms.DataGridView()
        Me.CVE_PRODUCTO_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO_PRODUCTO_DEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_PRODUCTO_DEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CotizacionesBL = New NEGOCIOS.CotizacionesBL()
        Me.DtpFechaDeAlta = New System.Windows.Forms.DateTimePicker()
        Me.LblEstatus = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTotal = New Componentes.TextBoxEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIva = New Componentes.TextBoxEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSubtotal = New Componentes.TextBoxEx()
        Me.ClientesBL = New NEGOCIOS.ClientesBL()
        Me.ProductosBL = New NEGOCIOS.ProductosBL()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvDetalleCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CotizacionesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClientesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBajas
        '
        Me.BtnBajas.Location = New System.Drawing.Point(226, 12)
        Me.BtnBajas.Name = "BtnBajas"
        Me.BtnBajas.Size = New System.Drawing.Size(66, 76)
        Me.BtnBajas.TabIndex = 49
        Me.BtnBajas.Text = "Bajas"
        Me.BtnBajas.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(487, 12)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(66, 76)
        Me.BtnBuscar.TabIndex = 48
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(553, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(66, 76)
        Me.BtnSalir.TabIndex = 47
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(421, 12)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(66, 76)
        Me.BtnCancelar.TabIndex = 46
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(356, 12)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(66, 76)
        Me.BtnGuardar.TabIndex = 45
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(291, 12)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(66, 76)
        Me.BtnModificar.TabIndex = 44
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(161, 12)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(66, 76)
        Me.BtnNuevo.TabIndex = 43
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TxtCveCotizacion)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxtNombreCliente)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtCveCliente)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(603, 67)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "CVE COTIZACION"
        '
        'TxtCveCotizacion
        '
        Me.TxtCveCotizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveCotizacion.Enabled = False
        Me.TxtCveCotizacion.Location = New System.Drawing.Point(6, 32)
        Me.TxtCveCotizacion.Name = "TxtCveCotizacion"
        Me.TxtCveCotizacion.Size = New System.Drawing.Size(140, 20)
        Me.TxtCveCotizacion.TabIndex = 10
        Me.TxtCveCotizacion.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(321, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "NOMBRE CLIENTE"
        '
        'TxtNombreCliente
        '
        Me.TxtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreCliente.Enabled = False
        Me.TxtNombreCliente.Location = New System.Drawing.Point(321, 32)
        Me.TxtNombreCliente.Name = "TxtNombreCliente"
        Me.TxtNombreCliente.ReadOnly = True
        Me.TxtNombreCliente.Size = New System.Drawing.Size(278, 20)
        Me.TxtNombreCliente.TabIndex = 8
        Me.TxtNombreCliente.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(151, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "CVE CLIENTE"
        '
        'TxtCveCliente
        '
        Me.TxtCveCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveCliente.Enabled = False
        Me.TxtCveCliente.Location = New System.Drawing.Point(151, 32)
        Me.TxtCveCliente.Name = "TxtCveCliente"
        Me.TxtCveCliente.Size = New System.Drawing.Size(164, 20)
        Me.TxtCveCliente.TabIndex = 8
        Me.TxtCveCliente.TipoDato = Componentes.Enumeraciones.TipoDatos.Entero
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtCveProducto)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioProducto)
        Me.GroupBox2.Controls.Add(Me.BtnDel)
        Me.GroupBox2.Controls.Add(Me.BtnOk)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtCantidadProducto)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtNombreProducto)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 210)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(603, 56)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        '
        'TxtCveProducto
        '
        Me.TxtCveProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveProducto.Enabled = False
        Me.TxtCveProducto.Location = New System.Drawing.Point(6, 30)
        Me.TxtCveProducto.Name = "TxtCveProducto"
        Me.TxtCveProducto.Size = New System.Drawing.Size(139, 20)
        Me.TxtCveProducto.TabIndex = 10
        Me.TxtCveProducto.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(321, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "PRECIO"
        '
        'TxtPrecioProducto
        '
        Me.TxtPrecioProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPrecioProducto.Enabled = False
        Me.TxtPrecioProducto.Location = New System.Drawing.Point(323, 27)
        Me.TxtPrecioProducto.Name = "TxtPrecioProducto"
        Me.TxtPrecioProducto.Size = New System.Drawing.Size(77, 20)
        Me.TxtPrecioProducto.TabIndex = 8
        Me.TxtPrecioProducto.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'BtnDel
        '
        Me.BtnDel.Enabled = False
        Me.BtnDel.Location = New System.Drawing.Point(544, 25)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(55, 22)
        Me.BtnDel.TabIndex = 7
        Me.BtnDel.Text = "DEL"
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'BtnOk
        '
        Me.BtnOk.Enabled = False
        Me.BtnOk.Location = New System.Drawing.Point(486, 25)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(55, 22)
        Me.BtnOk.TabIndex = 6
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(404, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CANTIDAD"
        '
        'TxtCantidadProducto
        '
        Me.TxtCantidadProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCantidadProducto.Enabled = False
        Me.TxtCantidadProducto.Location = New System.Drawing.Point(406, 27)
        Me.TxtCantidadProducto.Name = "TxtCantidadProducto"
        Me.TxtCantidadProducto.Size = New System.Drawing.Size(77, 20)
        Me.TxtCantidadProducto.TabIndex = 4
        Me.TxtCantidadProducto.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(151, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "NOMBRE PRODUCTO"
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreProducto.Enabled = False
        Me.TxtNombreProducto.Location = New System.Drawing.Point(151, 27)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(164, 20)
        Me.TxtNombreProducto.TabIndex = 2
        Me.TxtNombreProducto.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "CVE PRODUCTO"
        '
        'DgvDetalleCotizaciones
        '
        Me.DgvDetalleCotizaciones.AllowUserToAddRows = False
        Me.DgvDetalleCotizaciones.AllowUserToDeleteRows = False
        Me.DgvDetalleCotizaciones.AutoGenerateColumns = False
        Me.DgvDetalleCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalleCotizaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_PRODUCTO_VAR, Me.PRECIO_PRODUCTO_DEC, Me.CANTIDAD_INT, Me.TOTAL_PRODUCTO_DEC})
        Me.DgvDetalleCotizaciones.DataSource = Me.CotizacionesBL.TBLDETALLE_COTIZACION
        Me.DgvDetalleCotizaciones.Location = New System.Drawing.Point(16, 273)
        Me.DgvDetalleCotizaciones.Name = "DgvDetalleCotizaciones"
        Me.DgvDetalleCotizaciones.ReadOnly = True
        Me.DgvDetalleCotizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDetalleCotizaciones.Size = New System.Drawing.Size(603, 273)
        Me.DgvDetalleCotizaciones.TabIndex = 52
        '
        'CVE_PRODUCTO_VAR
        '
        Me.CVE_PRODUCTO_VAR.DataPropertyName = "CVE_PRODUCTO_VAR"
        Me.CVE_PRODUCTO_VAR.HeaderText = "CVE PRODUCTO"
        Me.CVE_PRODUCTO_VAR.Name = "CVE_PRODUCTO_VAR"
        Me.CVE_PRODUCTO_VAR.ReadOnly = True
        Me.CVE_PRODUCTO_VAR.Width = 120
        '
        'PRECIO_PRODUCTO_DEC
        '
        Me.PRECIO_PRODUCTO_DEC.DataPropertyName = "PRECIO_PRODUCTO_DEC"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PRECIO_PRODUCTO_DEC.DefaultCellStyle = DataGridViewCellStyle1
        Me.PRECIO_PRODUCTO_DEC.HeaderText = "PRECIO PRODUCTO"
        Me.PRECIO_PRODUCTO_DEC.Name = "PRECIO_PRODUCTO_DEC"
        Me.PRECIO_PRODUCTO_DEC.ReadOnly = True
        Me.PRECIO_PRODUCTO_DEC.Width = 150
        '
        'CANTIDAD_INT
        '
        Me.CANTIDAD_INT.DataPropertyName = "CANTIDAD_INT"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CANTIDAD_INT.DefaultCellStyle = DataGridViewCellStyle2
        Me.CANTIDAD_INT.HeaderText = "CANTIDAD"
        Me.CANTIDAD_INT.Name = "CANTIDAD_INT"
        Me.CANTIDAD_INT.ReadOnly = True
        Me.CANTIDAD_INT.Width = 120
        '
        'TOTAL_PRODUCTO_DEC
        '
        Me.TOTAL_PRODUCTO_DEC.DataPropertyName = "TOTAL_PRODUCTO_DEC"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.TOTAL_PRODUCTO_DEC.DefaultCellStyle = DataGridViewCellStyle3
        Me.TOTAL_PRODUCTO_DEC.HeaderText = "TOTAL PRODUCTO"
        Me.TOTAL_PRODUCTO_DEC.Name = "TOTAL_PRODUCTO_DEC"
        Me.TOTAL_PRODUCTO_DEC.ReadOnly = True
        Me.TOTAL_PRODUCTO_DEC.Width = 150
        '
        'CotizacionesBL
        '
        Me.CotizacionesBL.DataSetName = "DSCotizaciones"
        Me.CotizacionesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DtpFechaDeAlta
        '
        Me.DtpFechaDeAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaDeAlta.Location = New System.Drawing.Point(521, 111)
        Me.DtpFechaDeAlta.Name = "DtpFechaDeAlta"
        Me.DtpFechaDeAlta.Size = New System.Drawing.Size(98, 20)
        Me.DtpFechaDeAlta.TabIndex = 53
        '
        'LblEstatus
        '
        Me.LblEstatus.AutoSize = True
        Me.LblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstatus.ForeColor = System.Drawing.Color.Red
        Me.LblEstatus.Location = New System.Drawing.Point(28, 39)
        Me.LblEstatus.Name = "LblEstatus"
        Me.LblEstatus.Size = New System.Drawing.Size(90, 20)
        Me.LblEstatus.TabIndex = 54
        Me.LblEstatus.Text = "ESTATUS"
        Me.LblEstatus.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtTotal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtIva)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtSubtotal)
        Me.GroupBox1.Location = New System.Drawing.Point(340, 552)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 103)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TOTAL"
        '
        'TxtTotal
        '
        Me.TxtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTotal.Location = New System.Drawing.Point(118, 71)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(142, 20)
        Me.TxtTotal.TabIndex = 4
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotal.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "IVA"
        '
        'TxtIva
        '
        Me.TxtIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtIva.Location = New System.Drawing.Point(118, 45)
        Me.TxtIva.Name = "TxtIva"
        Me.TxtIva.ReadOnly = True
        Me.TxtIva.Size = New System.Drawing.Size(142, 20)
        Me.TxtIva.TabIndex = 2
        Me.TxtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtIva.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SUBTOTAL"
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSubtotal.Location = New System.Drawing.Point(118, 19)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.ReadOnly = True
        Me.TxtSubtotal.Size = New System.Drawing.Size(142, 20)
        Me.TxtSubtotal.TabIndex = 0
        Me.TxtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtSubtotal.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'ClientesBL
        '
        Me.ClientesBL.DataSetName = "DSClientes"
        Me.ClientesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBL
        '
        Me.ProductosBL.DataSetName = "DSProductos"
        Me.ProductosBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FRMCotizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(626, 665)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblEstatus)
        Me.Controls.Add(Me.DtpFechaDeAlta)
        Me.Controls.Add(Me.DgvDetalleCotizaciones)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnBajas)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Name = "FRMCotizaciones"
        Me.Text = "Cotizaciones"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvDetalleCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CotizacionesBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ClientesBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBajas As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCveCotizacion As Componentes.TextBoxEx
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNombreCliente As Componentes.TextBoxEx
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCveCliente As Componentes.TextBoxEx
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtPrecioProducto As Componentes.TextBoxEx
    Friend WithEvents BtnDel As Button
    Friend WithEvents BtnOk As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCantidadProducto As Componentes.TextBoxEx
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNombreProducto As Componentes.TextBoxEx
    Friend WithEvents Label4 As Label
    Friend WithEvents DgvDetalleCotizaciones As DataGridView
    Friend WithEvents DtpFechaDeAlta As DateTimePicker
    Friend WithEvents LblEstatus As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTotal As Componentes.TextBoxEx
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIva As Componentes.TextBoxEx
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSubtotal As Componentes.TextBoxEx
    Friend WithEvents CotizacionesBL As NEGOCIOS.CotizacionesBL
    Friend WithEvents ClientesBL As NEGOCIOS.ClientesBL
    Friend WithEvents ProductosBL As NEGOCIOS.ProductosBL
    Friend WithEvents CVE_PRODUCTO_VAR As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO_PRODUCTO_DEC As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD_INT As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_PRODUCTO_DEC As DataGridViewTextBoxColumn
    Friend WithEvents TxtCveProducto As Componentes.TextBoxEx
End Class
