<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMBrowseVentas
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbEstatus = New System.Windows.Forms.ComboBox()
        Me.TxtCveVentaFinal = New Componentes.TextBoxEx()
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.ChkFecha = New System.Windows.Forms.CheckBox()
        Me.ChkEstatus = New System.Windows.Forms.CheckBox()
        Me.TxtCveVentaInicial = New Componentes.TextBoxEx()
        Me.ChkCveVenta = New System.Windows.Forms.CheckBox()
        Me.VentasBL = New NEGOCIOS.VentasBL()
        Me.ClientesBL = New NEGOCIOS.ClientesBL()
        Me.SucursalesBL = New NEGOCIOS.SucursalesBL()
        Me.DgvVentas = New System.Windows.Forms.DataGridView()
        Me.CVE_VENTA_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CVE_SUC_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CVE_CLIENTE_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_SUC_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_CLIENTE_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBTOTAL_DEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA_DEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_DEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_ALTA_DEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUS_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VentasBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(666, 24)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(66, 76)
        Me.BtnBuscar.TabIndex = 29
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(738, 24)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(66, 76)
        Me.BtnRegresar.TabIndex = 28
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbEstatus)
        Me.GroupBox1.Controls.Add(Me.TxtCveVentaFinal)
        Me.GroupBox1.Controls.Add(Me.DtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.DtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.ChkFecha)
        Me.GroupBox1.Controls.Add(Me.ChkEstatus)
        Me.GroupBox1.Controls.Add(Me.TxtCveVentaInicial)
        Me.GroupBox1.Controls.Add(Me.ChkCveVenta)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 109)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'CmbEstatus
        '
        Me.CmbEstatus.Enabled = False
        Me.CmbEstatus.FormattingEnabled = True
        Me.CmbEstatus.Items.AddRange(New Object() {"---SELECCIONAR---", "EMITIDA", "CANCELADA"})
        Me.CmbEstatus.Location = New System.Drawing.Point(110, 43)
        Me.CmbEstatus.Name = "CmbEstatus"
        Me.CmbEstatus.Size = New System.Drawing.Size(205, 21)
        Me.CmbEstatus.TabIndex = 23
        Me.CmbEstatus.Text = "---SELECCIONAR---"
        '
        'TxtCveVentaFinal
        '
        Me.TxtCveVentaFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveVentaFinal.Enabled = False
        Me.TxtCveVentaFinal.Location = New System.Drawing.Point(216, 16)
        Me.TxtCveVentaFinal.Name = "TxtCveVentaFinal"
        Me.TxtCveVentaFinal.Size = New System.Drawing.Size(99, 20)
        Me.TxtCveVentaFinal.TabIndex = 22
        Me.TxtCveVentaFinal.Text = "0"
        Me.TxtCveVentaFinal.TipoDato = Componentes.Enumeraciones.TipoDatos.Entero
        '
        'DtpFechaFinal
        '
        Me.DtpFechaFinal.Enabled = False
        Me.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFinal.Location = New System.Drawing.Point(216, 70)
        Me.DtpFechaFinal.Name = "DtpFechaFinal"
        Me.DtpFechaFinal.Size = New System.Drawing.Size(99, 20)
        Me.DtpFechaFinal.TabIndex = 21
        '
        'DtpFechaInicio
        '
        Me.DtpFechaInicio.Enabled = False
        Me.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicio.Location = New System.Drawing.Point(110, 68)
        Me.DtpFechaInicio.Name = "DtpFechaInicio"
        Me.DtpFechaInicio.Size = New System.Drawing.Size(99, 20)
        Me.DtpFechaInicio.TabIndex = 20
        '
        'ChkFecha
        '
        Me.ChkFecha.AutoSize = True
        Me.ChkFecha.Location = New System.Drawing.Point(28, 73)
        Me.ChkFecha.Name = "ChkFecha"
        Me.ChkFecha.Size = New System.Drawing.Size(56, 17)
        Me.ChkFecha.TabIndex = 18
        Me.ChkFecha.Text = "Fecha"
        Me.ChkFecha.UseVisualStyleBackColor = True
        '
        'ChkEstatus
        '
        Me.ChkEstatus.AutoSize = True
        Me.ChkEstatus.Location = New System.Drawing.Point(28, 46)
        Me.ChkEstatus.Name = "ChkEstatus"
        Me.ChkEstatus.Size = New System.Drawing.Size(61, 17)
        Me.ChkEstatus.TabIndex = 17
        Me.ChkEstatus.Text = "Estatus"
        Me.ChkEstatus.UseVisualStyleBackColor = True
        '
        'TxtCveVentaInicial
        '
        Me.TxtCveVentaInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveVentaInicial.Enabled = False
        Me.TxtCveVentaInicial.Location = New System.Drawing.Point(110, 16)
        Me.TxtCveVentaInicial.Name = "TxtCveVentaInicial"
        Me.TxtCveVentaInicial.Size = New System.Drawing.Size(99, 20)
        Me.TxtCveVentaInicial.TabIndex = 16
        Me.TxtCveVentaInicial.Text = "0"
        Me.TxtCveVentaInicial.TipoDato = Componentes.Enumeraciones.TipoDatos.Entero
        '
        'ChkCveVenta
        '
        Me.ChkCveVenta.AutoSize = True
        Me.ChkCveVenta.Location = New System.Drawing.Point(28, 19)
        Me.ChkCveVenta.Name = "ChkCveVenta"
        Me.ChkCveVenta.Size = New System.Drawing.Size(76, 17)
        Me.ChkCveVenta.TabIndex = 15
        Me.ChkCveVenta.Text = "Cve Venta"
        Me.ChkCveVenta.UseVisualStyleBackColor = True
        '
        'VentasBL
        '
        Me.VentasBL.DataSetName = "DSVentas"
        Me.VentasBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBL
        '
        Me.ClientesBL.DataSetName = "DSClientes"
        Me.ClientesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SucursalesBL
        '
        Me.SucursalesBL.DataSetName = "DSSucursales"
        Me.SucursalesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DgvVentas
        '
        Me.DgvVentas.AllowUserToAddRows = False
        Me.DgvVentas.AllowUserToDeleteRows = False
        Me.DgvVentas.AutoGenerateColumns = False
        Me.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_VENTA_INT, Me.CVE_SUC_VAR, Me.CVE_CLIENTE_INT, Me.NOMBRE_SUC_VAR, Me.NOMBRE_CLIENTE_VAR, Me.SUBTOTAL_DEC, Me.IVA_DEC, Me.TOTAL_DEC, Me.FECHA_ALTA_DEC, Me.ESTATUS_INT})
        Me.DgvVentas.DataSource = Me.VentasBL.TBLVENTA
        Me.DgvVentas.Location = New System.Drawing.Point(12, 127)
        Me.DgvVentas.Name = "DgvVentas"
        Me.DgvVentas.ReadOnly = True
        Me.DgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVentas.Size = New System.Drawing.Size(846, 367)
        Me.DgvVentas.TabIndex = 30
        '
        'CVE_VENTA_INT
        '
        Me.CVE_VENTA_INT.DataPropertyName = "CVE_VENTA_INT"
        Me.CVE_VENTA_INT.HeaderText = "CVE_VENTA_INT"
        Me.CVE_VENTA_INT.Name = "CVE_VENTA_INT"
        Me.CVE_VENTA_INT.ReadOnly = True
        '
        'CVE_SUC_VAR
        '
        Me.CVE_SUC_VAR.DataPropertyName = "CVE_SUC_VAR"
        Me.CVE_SUC_VAR.HeaderText = "CVE_SUC_VAR"
        Me.CVE_SUC_VAR.Name = "CVE_SUC_VAR"
        Me.CVE_SUC_VAR.ReadOnly = True
        Me.CVE_SUC_VAR.Visible = False
        '
        'CVE_CLIENTE_INT
        '
        Me.CVE_CLIENTE_INT.DataPropertyName = "CVE_CLIENTE_INT"
        Me.CVE_CLIENTE_INT.HeaderText = "CVE_CLIENTE_INT"
        Me.CVE_CLIENTE_INT.Name = "CVE_CLIENTE_INT"
        Me.CVE_CLIENTE_INT.ReadOnly = True
        Me.CVE_CLIENTE_INT.Visible = False
        '
        'NOMBRE_SUC_VAR
        '
        Me.NOMBRE_SUC_VAR.HeaderText = "SUCURSAL"
        Me.NOMBRE_SUC_VAR.Name = "NOMBRE_SUC_VAR"
        Me.NOMBRE_SUC_VAR.ReadOnly = True
        '
        'NOMBRE_CLIENTE_VAR
        '
        Me.NOMBRE_CLIENTE_VAR.HeaderText = "CLIENTE"
        Me.NOMBRE_CLIENTE_VAR.Name = "NOMBRE_CLIENTE_VAR"
        Me.NOMBRE_CLIENTE_VAR.ReadOnly = True
        '
        'SUBTOTAL_DEC
        '
        Me.SUBTOTAL_DEC.DataPropertyName = "SUBTOTAL_DEC"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.SUBTOTAL_DEC.DefaultCellStyle = DataGridViewCellStyle1
        Me.SUBTOTAL_DEC.HeaderText = "SUBTOTAL_DEC"
        Me.SUBTOTAL_DEC.Name = "SUBTOTAL_DEC"
        Me.SUBTOTAL_DEC.ReadOnly = True
        '
        'IVA_DEC
        '
        Me.IVA_DEC.DataPropertyName = "IVA_DEC"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.IVA_DEC.DefaultCellStyle = DataGridViewCellStyle2
        Me.IVA_DEC.HeaderText = "IVA_DEC"
        Me.IVA_DEC.Name = "IVA_DEC"
        Me.IVA_DEC.ReadOnly = True
        '
        'TOTAL_DEC
        '
        Me.TOTAL_DEC.DataPropertyName = "TOTAL_DEC"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.TOTAL_DEC.DefaultCellStyle = DataGridViewCellStyle3
        Me.TOTAL_DEC.HeaderText = "TOTAL_DEC"
        Me.TOTAL_DEC.Name = "TOTAL_DEC"
        Me.TOTAL_DEC.ReadOnly = True
        '
        'FECHA_ALTA_DEC
        '
        Me.FECHA_ALTA_DEC.DataPropertyName = "FECHA_ALTA_DEC"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.FECHA_ALTA_DEC.DefaultCellStyle = DataGridViewCellStyle4
        Me.FECHA_ALTA_DEC.HeaderText = "FECHA_ALTA_DEC"
        Me.FECHA_ALTA_DEC.Name = "FECHA_ALTA_DEC"
        Me.FECHA_ALTA_DEC.ReadOnly = True
        '
        'ESTATUS_INT
        '
        Me.ESTATUS_INT.DataPropertyName = "ESTATUS_INT"
        Me.ESTATUS_INT.HeaderText = "ESTATUS_INT"
        Me.ESTATUS_INT.Name = "ESTATUS_INT"
        Me.ESTATUS_INT.ReadOnly = True
        '
        'FRMBrowseVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(869, 517)
        Me.Controls.Add(Me.DgvVentas)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FRMBrowseVentas"
        Me.Text = "Bísqueda De Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VentasBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents VentasBL As NEGOCIOS.VentasBL
    Friend WithEvents TxtCveVentaFinal As Componentes.TextBoxEx
    Friend WithEvents DtpFechaFinal As DateTimePicker
    Friend WithEvents DtpFechaInicio As DateTimePicker
    Friend WithEvents ChkFecha As CheckBox
    Friend WithEvents ChkEstatus As CheckBox
    Friend WithEvents TxtCveVentaInicial As Componentes.TextBoxEx
    Friend WithEvents ChkCveVenta As CheckBox
    Friend WithEvents CmbEstatus As ComboBox
    Friend WithEvents ClientesBL As NEGOCIOS.ClientesBL
    Friend WithEvents SucursalesBL As NEGOCIOS.SucursalesBL
    Friend WithEvents DgvVentas As DataGridView
    Friend WithEvents CVE_VENTA_INT As DataGridViewTextBoxColumn
    Friend WithEvents CVE_SUC_VAR As DataGridViewTextBoxColumn
    Friend WithEvents CVE_CLIENTE_INT As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_SUC_VAR As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_CLIENTE_VAR As DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTAL_DEC As DataGridViewTextBoxColumn
    Friend WithEvents IVA_DEC As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_DEC As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_ALTA_DEC As DataGridViewTextBoxColumn
    Friend WithEvents ESTATUS_INT As DataGridViewTextBoxColumn
End Class
