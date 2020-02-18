<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMVenta
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
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTotal = New Componentes.TextBoxEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIva = New Componentes.TextBoxEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSubtotal = New Componentes.TextBoxEx()
        Me.DtpFechaDeAlta = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtPrecioProducto = New Componentes.TextBoxEx()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCantidadProducto = New Componentes.TextBoxEx()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNombreProducto = New Componentes.TextBoxEx()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCveProducto = New Componentes.TextBoxEx()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CboSucursal = New System.Windows.Forms.ComboBox()
        Me.SucursalesBL = New NEGOCIOS.SucursalesBL()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCveVenta = New Componentes.TextBoxEx()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNombreCliente = New Componentes.TextBoxEx()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCveCliente = New Componentes.TextBoxEx()
        Me.LblEstatus = New System.Windows.Forms.Label()
        Me.BtnBajas = New System.Windows.Forms.Button()
        Me.DgvDetalleVenta = New System.Windows.Forms.DataGridView()
        Me.CVE_PRODUCTO_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO_PRODUCTO_DEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_PRODUCTO_DEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentasBL = New NEGOCIOS.VentasBL()
        Me.ProductosBL = New NEGOCIOS.ProductosBL()
        Me.ClientesBL = New NEGOCIOS.ClientesBL()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SucursalesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(574, 12)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(66, 76)
        Me.BtnBuscar.TabIndex = 35
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(640, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(66, 76)
        Me.BtnSalir.TabIndex = 34
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(508, 12)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(66, 76)
        Me.BtnCancelar.TabIndex = 33
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(443, 12)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(66, 76)
        Me.BtnGuardar.TabIndex = 32
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(378, 12)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(66, 76)
        Me.BtnModificar.TabIndex = 31
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(248, 12)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(66, 76)
        Me.BtnNuevo.TabIndex = 30
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtTotal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtIva)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtSubtotal)
        Me.GroupBox1.Location = New System.Drawing.Point(428, 543)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 103)
        Me.GroupBox1.TabIndex = 37
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
        'DtpFechaDeAlta
        '
        Me.DtpFechaDeAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaDeAlta.Location = New System.Drawing.Point(611, 106)
        Me.DtpFechaDeAlta.Name = "DtpFechaDeAlta"
        Me.DtpFechaDeAlta.Size = New System.Drawing.Size(98, 20)
        Me.DtpFechaDeAlta.TabIndex = 38
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioProducto)
        Me.GroupBox2.Controls.Add(Me.BtnDel)
        Me.GroupBox2.Controls.Add(Me.BtnOk)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtCantidadProducto)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtNombreProducto)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtCveProducto)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(684, 56)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(396, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "PRECIO"
        '
        'TxtPrecioProducto
        '
        Me.TxtPrecioProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPrecioProducto.Enabled = False
        Me.TxtPrecioProducto.Location = New System.Drawing.Point(398, 27)
        Me.TxtPrecioProducto.Name = "TxtPrecioProducto"
        Me.TxtPrecioProducto.Size = New System.Drawing.Size(77, 20)
        Me.TxtPrecioProducto.TabIndex = 8
        Me.TxtPrecioProducto.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'BtnDel
        '
        Me.BtnDel.Enabled = False
        Me.BtnDel.Location = New System.Drawing.Point(619, 25)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(55, 22)
        Me.BtnDel.TabIndex = 7
        Me.BtnDel.Text = "DEL"
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'BtnOk
        '
        Me.BtnOk.Enabled = False
        Me.BtnOk.Location = New System.Drawing.Point(561, 25)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(55, 22)
        Me.BtnOk.TabIndex = 6
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(479, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CANTIDAD"
        '
        'TxtCantidadProducto
        '
        Me.TxtCantidadProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCantidadProducto.Enabled = False
        Me.TxtCantidadProducto.Location = New System.Drawing.Point(481, 27)
        Me.TxtCantidadProducto.Name = "TxtCantidadProducto"
        Me.TxtCantidadProducto.Size = New System.Drawing.Size(77, 20)
        Me.TxtCantidadProducto.TabIndex = 4
        Me.TxtCantidadProducto.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(104, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "NOMBRE PRODUCTO"
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreProducto.Enabled = False
        Me.TxtNombreProducto.Location = New System.Drawing.Point(104, 26)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(288, 20)
        Me.TxtNombreProducto.TabIndex = 2
        Me.TxtNombreProducto.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "CVE PRODUCTO"
        '
        'TxtCveProducto
        '
        Me.TxtCveProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveProducto.Enabled = False
        Me.TxtCveProducto.Location = New System.Drawing.Point(6, 27)
        Me.TxtCveProducto.Name = "TxtCveProducto"
        Me.TxtCveProducto.Size = New System.Drawing.Size(92, 20)
        Me.TxtCveProducto.TabIndex = 0
        Me.TxtCveProducto.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CboSucursal)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TxtCveVenta)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxtNombreCliente)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtCveCliente)
        Me.GroupBox3.Location = New System.Drawing.Point(25, 157)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(680, 67)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        '
        'CboSucursal
        '
        Me.CboSucursal.DataSource = Me.SucursalesBL
        Me.CboSucursal.DisplayMember = "TBLSUCURSAL.NOMBRE_SUC_VAR"
        Me.CboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSucursal.Enabled = False
        Me.CboSucursal.FormattingEnabled = True
        Me.CboSucursal.Location = New System.Drawing.Point(493, 32)
        Me.CboSucursal.Name = "CboSucursal"
        Me.CboSucursal.Size = New System.Drawing.Size(181, 21)
        Me.CboSucursal.TabIndex = 12
        Me.CboSucursal.ValueMember = "TBLSUCURSAL.CVE_SUC_VAR"
        '
        'SucursalesBL
        '
        Me.SucursalesBL.DataSetName = "DSSucursales"
        Me.SucursalesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "CVE VENTA"
        '
        'TxtCveVenta
        '
        Me.TxtCveVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveVenta.Enabled = False
        Me.TxtCveVenta.Location = New System.Drawing.Point(6, 32)
        Me.TxtCveVenta.Name = "TxtCveVenta"
        Me.TxtCveVenta.Size = New System.Drawing.Size(92, 20)
        Me.TxtCveVenta.TabIndex = 10
        Me.TxtCveVenta.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(209, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "NOMBRE CLIENTE"
        '
        'TxtNombreCliente
        '
        Me.TxtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreCliente.Enabled = False
        Me.TxtNombreCliente.Location = New System.Drawing.Point(209, 32)
        Me.TxtNombreCliente.Name = "TxtNombreCliente"
        Me.TxtNombreCliente.ReadOnly = True
        Me.TxtNombreCliente.Size = New System.Drawing.Size(274, 20)
        Me.TxtNombreCliente.TabIndex = 8
        Me.TxtNombreCliente.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(113, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "CVE CLIENTE"
        '
        'TxtCveCliente
        '
        Me.TxtCveCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveCliente.Enabled = False
        Me.TxtCveCliente.Location = New System.Drawing.Point(104, 32)
        Me.TxtCveCliente.Name = "TxtCveCliente"
        Me.TxtCveCliente.Size = New System.Drawing.Size(101, 20)
        Me.TxtCveCliente.TabIndex = 8
        Me.TxtCveCliente.TipoDato = Componentes.Enumeraciones.TipoDatos.Entero
        '
        'LblEstatus
        '
        Me.LblEstatus.AutoSize = True
        Me.LblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstatus.ForeColor = System.Drawing.Color.Red
        Me.LblEstatus.Location = New System.Drawing.Point(68, 50)
        Me.LblEstatus.Name = "LblEstatus"
        Me.LblEstatus.Size = New System.Drawing.Size(90, 20)
        Me.LblEstatus.TabIndex = 41
        Me.LblEstatus.Text = "ESTATUS"
        Me.LblEstatus.Visible = False
        '
        'BtnBajas
        '
        Me.BtnBajas.Location = New System.Drawing.Point(313, 12)
        Me.BtnBajas.Name = "BtnBajas"
        Me.BtnBajas.Size = New System.Drawing.Size(66, 76)
        Me.BtnBajas.TabIndex = 42
        Me.BtnBajas.Text = "Bajas"
        Me.BtnBajas.UseVisualStyleBackColor = True
        '
        'DgvDetalleVenta
        '
        Me.DgvDetalleVenta.AllowUserToAddRows = False
        Me.DgvDetalleVenta.AllowUserToDeleteRows = False
        Me.DgvDetalleVenta.AutoGenerateColumns = False
        Me.DgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalleVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_PRODUCTO_VAR, Me.PRECIO_PRODUCTO_DEC, Me.CANTIDAD_INT, Me.TOTAL_PRODUCTO_DEC})
        Me.DgvDetalleVenta.DataSource = Me.VentasBL.TBLDETALLE_VENTA
        Me.DgvDetalleVenta.Location = New System.Drawing.Point(25, 298)
        Me.DgvDetalleVenta.Name = "DgvDetalleVenta"
        Me.DgvDetalleVenta.ReadOnly = True
        Me.DgvDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDetalleVenta.Size = New System.Drawing.Size(684, 239)
        Me.DgvDetalleVenta.TabIndex = 36
        '
        'CVE_PRODUCTO_VAR
        '
        Me.CVE_PRODUCTO_VAR.DataPropertyName = "CVE_PRODUCTO_VAR"
        Me.CVE_PRODUCTO_VAR.HeaderText = "CVE PRODUCTO"
        Me.CVE_PRODUCTO_VAR.Name = "CVE_PRODUCTO_VAR"
        Me.CVE_PRODUCTO_VAR.ReadOnly = True
        Me.CVE_PRODUCTO_VAR.Width = 150
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
        'VentasBL
        '
        Me.VentasBL.DataSetName = "DSVentas"
        Me.VentasBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBL
        '
        Me.ProductosBL.DataSetName = "DSProductos"
        Me.ProductosBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBL
        '
        Me.ClientesBL.DataSetName = "DSClientes"
        Me.ClientesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FRMVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(717, 652)
        Me.Controls.Add(Me.BtnBajas)
        Me.Controls.Add(Me.LblEstatus)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DtpFechaDeAlta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvDetalleVenta)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Name = "FRMVenta"
        Me.Text = "Venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.SucursalesBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents DgvDetalleVenta As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtSubtotal As Componentes.TextBoxEx
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTotal As Componentes.TextBoxEx
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIva As Componentes.TextBoxEx
    Friend WithEvents Label1 As Label
    Friend WithEvents DtpFechaDeAlta As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCveProducto As Componentes.TextBoxEx
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNombreProducto As Componentes.TextBoxEx
    Friend WithEvents BtnDel As Button
    Friend WithEvents BtnOk As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCantidadProducto As Componentes.TextBoxEx
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCveCliente As Componentes.TextBoxEx
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNombreCliente As Componentes.TextBoxEx
    Friend WithEvents LblEstatus As Label
    Friend WithEvents BtnBajas As Button
    Friend WithEvents VentasBL As NEGOCIOS.VentasBL
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtPrecioProducto As Componentes.TextBoxEx
    Friend WithEvents ProductosBL As NEGOCIOS.ProductosBL
    Friend WithEvents ClientesBL As NEGOCIOS.ClientesBL
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCveVenta As Componentes.TextBoxEx
    Friend WithEvents SucursalesBL As NEGOCIOS.SucursalesBL
    Friend WithEvents CboSucursal As ComboBox
    Friend WithEvents CVE_PRODUCTO_VAR As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO_PRODUCTO_DEC As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD_INT As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_PRODUCTO_DEC As DataGridViewTextBoxColumn
End Class
