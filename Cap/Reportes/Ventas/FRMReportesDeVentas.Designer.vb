<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMReportesDeVentas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CmbTipoReporte = New System.Windows.Forms.ComboBox()
        Me.BtnImprmir = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCveClienteFinal = New Componentes.TextBoxEx()
        Me.TxtCveClienteInicial = New Componentes.TextBoxEx()
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.TxtCveVentaFinal = New Componentes.TextBoxEx()
        Me.TxtCveVentaInicial = New Componentes.TextBoxEx()
        Me.ChkFecha = New System.Windows.Forms.CheckBox()
        Me.ChkCveCliente = New System.Windows.Forms.CheckBox()
        Me.ChkCveVenta = New System.Windows.Forms.CheckBox()
        Me.DgvVenta = New System.Windows.Forms.DataGridView()
        Me.CVE_VENTA_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_SUC_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBTOTAL_DEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA_DEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_DEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_ALTA_DEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUS_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportesDeVentasBL = New NEGOCIOS.ReportesDeVentasBL()
        Me.VentasBL = New NEGOCIOS.VentasBL()
        Me.DgvDetalleVenta = New System.Windows.Forms.DataGridView()
        Me.CVEVENTAINTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CVEPRODUCTOVARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIOPRODUCTODECDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDADINTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALPRODUCTODECDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesDeVentasBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbTipoReporte
        '
        Me.CmbTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipoReporte.FormattingEnabled = True
        Me.CmbTipoReporte.Items.AddRange(New Object() {"--SELECCIONE--", "CONSECUTIVO DE VENTAS", "CONSECUTIVO DE VENTAS DESGLOSADO"})
        Me.CmbTipoReporte.Location = New System.Drawing.Point(20, 123)
        Me.CmbTipoReporte.Name = "CmbTipoReporte"
        Me.CmbTipoReporte.Size = New System.Drawing.Size(312, 21)
        Me.CmbTipoReporte.TabIndex = 55
        '
        'BtnImprmir
        '
        Me.BtnImprmir.Enabled = False
        Me.BtnImprmir.Location = New System.Drawing.Point(450, 35)
        Me.BtnImprmir.Name = "BtnImprmir"
        Me.BtnImprmir.Size = New System.Drawing.Size(66, 76)
        Me.BtnImprmir.TabIndex = 54
        Me.BtnImprmir.Text = "Imprimir"
        Me.BtnImprmir.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(582, 35)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(66, 76)
        Me.BtnBuscar.TabIndex = 50
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(648, 35)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(66, 76)
        Me.BtnSalir.TabIndex = 49
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.Location = New System.Drawing.Point(516, 35)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(66, 76)
        Me.BtnCancelar.TabIndex = 48
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCveClienteFinal)
        Me.GroupBox1.Controls.Add(Me.TxtCveClienteInicial)
        Me.GroupBox1.Controls.Add(Me.DtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.DtpFechaInicial)
        Me.GroupBox1.Controls.Add(Me.TxtCveVentaFinal)
        Me.GroupBox1.Controls.Add(Me.TxtCveVentaInicial)
        Me.GroupBox1.Controls.Add(Me.ChkFecha)
        Me.GroupBox1.Controls.Add(Me.ChkCveCliente)
        Me.GroupBox1.Controls.Add(Me.ChkCveVenta)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 98)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        '
        'TxtCveClienteFinal
        '
        Me.TxtCveClienteFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveClienteFinal.Enabled = False
        Me.TxtCveClienteFinal.Location = New System.Drawing.Point(202, 47)
        Me.TxtCveClienteFinal.Name = "TxtCveClienteFinal"
        Me.TxtCveClienteFinal.Size = New System.Drawing.Size(101, 20)
        Me.TxtCveClienteFinal.TabIndex = 8
        Me.TxtCveClienteFinal.Text = "0"
        Me.TxtCveClienteFinal.TipoDato = Componentes.Enumeraciones.TipoDatos.Entero
        '
        'TxtCveClienteInicial
        '
        Me.TxtCveClienteInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveClienteInicial.Enabled = False
        Me.TxtCveClienteInicial.Location = New System.Drawing.Point(93, 46)
        Me.TxtCveClienteInicial.Name = "TxtCveClienteInicial"
        Me.TxtCveClienteInicial.Size = New System.Drawing.Size(102, 20)
        Me.TxtCveClienteInicial.TabIndex = 7
        Me.TxtCveClienteInicial.Text = "0"
        Me.TxtCveClienteInicial.TipoDato = Componentes.Enumeraciones.TipoDatos.Entero
        '
        'DtpFechaFinal
        '
        Me.DtpFechaFinal.Enabled = False
        Me.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFinal.Location = New System.Drawing.Point(201, 73)
        Me.DtpFechaFinal.Name = "DtpFechaFinal"
        Me.DtpFechaFinal.Size = New System.Drawing.Size(102, 20)
        Me.DtpFechaFinal.TabIndex = 6
        '
        'DtpFechaInicial
        '
        Me.DtpFechaInicial.Enabled = False
        Me.DtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicial.Location = New System.Drawing.Point(95, 73)
        Me.DtpFechaInicial.Name = "DtpFechaInicial"
        Me.DtpFechaInicial.Size = New System.Drawing.Size(100, 20)
        Me.DtpFechaInicial.TabIndex = 5
        '
        'TxtCveVentaFinal
        '
        Me.TxtCveVentaFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveVentaFinal.Enabled = False
        Me.TxtCveVentaFinal.Location = New System.Drawing.Point(201, 20)
        Me.TxtCveVentaFinal.Name = "TxtCveVentaFinal"
        Me.TxtCveVentaFinal.Size = New System.Drawing.Size(102, 20)
        Me.TxtCveVentaFinal.TabIndex = 4
        Me.TxtCveVentaFinal.Text = "0"
        Me.TxtCveVentaFinal.TipoDato = Componentes.Enumeraciones.TipoDatos.Entero
        '
        'TxtCveVentaInicial
        '
        Me.TxtCveVentaInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveVentaInicial.Enabled = False
        Me.TxtCveVentaInicial.Location = New System.Drawing.Point(94, 19)
        Me.TxtCveVentaInicial.Name = "TxtCveVentaInicial"
        Me.TxtCveVentaInicial.Size = New System.Drawing.Size(101, 20)
        Me.TxtCveVentaInicial.TabIndex = 3
        Me.TxtCveVentaInicial.Text = "0"
        Me.TxtCveVentaInicial.TipoDato = Componentes.Enumeraciones.TipoDatos.Entero
        '
        'ChkFecha
        '
        Me.ChkFecha.AutoSize = True
        Me.ChkFecha.Location = New System.Drawing.Point(6, 76)
        Me.ChkFecha.Name = "ChkFecha"
        Me.ChkFecha.Size = New System.Drawing.Size(56, 17)
        Me.ChkFecha.TabIndex = 2
        Me.ChkFecha.Text = "Fecha"
        Me.ChkFecha.UseVisualStyleBackColor = True
        '
        'ChkCveCliente
        '
        Me.ChkCveCliente.AutoSize = True
        Me.ChkCveCliente.Location = New System.Drawing.Point(6, 49)
        Me.ChkCveCliente.Name = "ChkCveCliente"
        Me.ChkCveCliente.Size = New System.Drawing.Size(80, 17)
        Me.ChkCveCliente.TabIndex = 1
        Me.ChkCveCliente.Text = "Cve Cliente"
        Me.ChkCveCliente.UseVisualStyleBackColor = True
        '
        'ChkCveVenta
        '
        Me.ChkCveVenta.AutoSize = True
        Me.ChkCveVenta.Location = New System.Drawing.Point(7, 22)
        Me.ChkCveVenta.Name = "ChkCveVenta"
        Me.ChkCveVenta.Size = New System.Drawing.Size(76, 17)
        Me.ChkCveVenta.TabIndex = 0
        Me.ChkCveVenta.Text = "Cve Venta"
        Me.ChkCveVenta.UseVisualStyleBackColor = True
        '
        'DgvVenta
        '
        Me.DgvVenta.AllowUserToAddRows = False
        Me.DgvVenta.AllowUserToDeleteRows = False
        Me.DgvVenta.AutoGenerateColumns = False
        Me.DgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_VENTA_INT, Me.NOMBRE_SUC_VAR, Me.NOMBRE_VAR, Me.SUBTOTAL_DEC, Me.IVA_DEC, Me.TOTAL_DEC, Me.FECHA_ALTA_DEC, Me.ESTATUS_VAR})
        Me.DgvVenta.DataSource = Me.ReportesDeVentasBL.TBLVENTA
        Me.DgvVenta.Location = New System.Drawing.Point(20, 150)
        Me.DgvVenta.Name = "DgvVenta"
        Me.DgvVenta.ReadOnly = True
        Me.DgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVenta.Size = New System.Drawing.Size(694, 186)
        Me.DgvVenta.TabIndex = 58
        '
        'CVE_VENTA_INT
        '
        Me.CVE_VENTA_INT.DataPropertyName = "CVE_VENTA_INT"
        Me.CVE_VENTA_INT.HeaderText = "CVE VENTA"
        Me.CVE_VENTA_INT.Name = "CVE_VENTA_INT"
        Me.CVE_VENTA_INT.ReadOnly = True
        '
        'NOMBRE_SUC_VAR
        '
        Me.NOMBRE_SUC_VAR.DataPropertyName = "NOMBRE_SUC_VAR"
        Me.NOMBRE_SUC_VAR.HeaderText = "SUCURSAL"
        Me.NOMBRE_SUC_VAR.Name = "NOMBRE_SUC_VAR"
        Me.NOMBRE_SUC_VAR.ReadOnly = True
        '
        'NOMBRE_VAR
        '
        Me.NOMBRE_VAR.DataPropertyName = "NOMBRE_VAR"
        Me.NOMBRE_VAR.HeaderText = "CLIENTE"
        Me.NOMBRE_VAR.Name = "NOMBRE_VAR"
        Me.NOMBRE_VAR.ReadOnly = True
        '
        'SUBTOTAL_DEC
        '
        Me.SUBTOTAL_DEC.DataPropertyName = "SUBTOTAL_DEC"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.SUBTOTAL_DEC.DefaultCellStyle = DataGridViewCellStyle1
        Me.SUBTOTAL_DEC.HeaderText = "SUBTOTAL"
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
        Me.IVA_DEC.HeaderText = "IVA"
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
        Me.TOTAL_DEC.HeaderText = "TOTA"
        Me.TOTAL_DEC.Name = "TOTAL_DEC"
        Me.TOTAL_DEC.ReadOnly = True
        '
        'FECHA_ALTA_DEC
        '
        Me.FECHA_ALTA_DEC.DataPropertyName = "FECHA_ALTA_DEC"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.FECHA_ALTA_DEC.DefaultCellStyle = DataGridViewCellStyle4
        Me.FECHA_ALTA_DEC.HeaderText = "FECHA ALTA"
        Me.FECHA_ALTA_DEC.Name = "FECHA_ALTA_DEC"
        Me.FECHA_ALTA_DEC.ReadOnly = True
        '
        'ESTATUS_VAR
        '
        Me.ESTATUS_VAR.DataPropertyName = "ESTATUS_VAR"
        Me.ESTATUS_VAR.HeaderText = "ESTATUS"
        Me.ESTATUS_VAR.Name = "ESTATUS_VAR"
        Me.ESTATUS_VAR.ReadOnly = True
        '
        'ReportesDeVentasBL
        '
        Me.ReportesDeVentasBL.DataSetName = "DSReportesDeVentas"
        Me.ReportesDeVentasBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasBL
        '
        Me.VentasBL.DataSetName = "DSVentas"
        Me.VentasBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DgvDetalleVenta
        '
        Me.DgvDetalleVenta.AllowUserToAddRows = False
        Me.DgvDetalleVenta.AllowUserToDeleteRows = False
        Me.DgvDetalleVenta.AutoGenerateColumns = False
        Me.DgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalleVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVEVENTAINTDataGridViewTextBoxColumn, Me.CVEPRODUCTOVARDataGridViewTextBoxColumn, Me.PRECIOPRODUCTODECDataGridViewTextBoxColumn, Me.CANTIDADINTDataGridViewTextBoxColumn, Me.TOTALPRODUCTODECDataGridViewTextBoxColumn})
        Me.DgvDetalleVenta.DataSource = Me.ReportesDeVentasBL.TBLDETALLE_VENTA
        Me.DgvDetalleVenta.Location = New System.Drawing.Point(20, 342)
        Me.DgvDetalleVenta.Name = "DgvDetalleVenta"
        Me.DgvDetalleVenta.ReadOnly = True
        Me.DgvDetalleVenta.Size = New System.Drawing.Size(697, 273)
        Me.DgvDetalleVenta.TabIndex = 60
        '
        'CVEVENTAINTDataGridViewTextBoxColumn
        '
        Me.CVEVENTAINTDataGridViewTextBoxColumn.DataPropertyName = "CVE_VENTA_INT"
        Me.CVEVENTAINTDataGridViewTextBoxColumn.HeaderText = "CVE VENTA"
        Me.CVEVENTAINTDataGridViewTextBoxColumn.Name = "CVEVENTAINTDataGridViewTextBoxColumn"
        Me.CVEVENTAINTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CVEPRODUCTOVARDataGridViewTextBoxColumn
        '
        Me.CVEPRODUCTOVARDataGridViewTextBoxColumn.DataPropertyName = "CVE_PRODUCTO_VAR"
        Me.CVEPRODUCTOVARDataGridViewTextBoxColumn.HeaderText = "CVE PRODUCTO"
        Me.CVEPRODUCTOVARDataGridViewTextBoxColumn.Name = "CVEPRODUCTOVARDataGridViewTextBoxColumn"
        Me.CVEPRODUCTOVARDataGridViewTextBoxColumn.ReadOnly = True
        Me.CVEPRODUCTOVARDataGridViewTextBoxColumn.Width = 120
        '
        'PRECIOPRODUCTODECDataGridViewTextBoxColumn
        '
        Me.PRECIOPRODUCTODECDataGridViewTextBoxColumn.DataPropertyName = "PRECIO_PRODUCTO_DEC"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.PRECIOPRODUCTODECDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.PRECIOPRODUCTODECDataGridViewTextBoxColumn.HeaderText = "PRECIO PRODUCTO"
        Me.PRECIOPRODUCTODECDataGridViewTextBoxColumn.Name = "PRECIOPRODUCTODECDataGridViewTextBoxColumn"
        Me.PRECIOPRODUCTODECDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRECIOPRODUCTODECDataGridViewTextBoxColumn.Width = 150
        '
        'CANTIDADINTDataGridViewTextBoxColumn
        '
        Me.CANTIDADINTDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD_INT"
        Me.CANTIDADINTDataGridViewTextBoxColumn.HeaderText = "CANTIDAD"
        Me.CANTIDADINTDataGridViewTextBoxColumn.Name = "CANTIDADINTDataGridViewTextBoxColumn"
        Me.CANTIDADINTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TOTALPRODUCTODECDataGridViewTextBoxColumn
        '
        Me.TOTALPRODUCTODECDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_PRODUCTO_DEC"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.TOTALPRODUCTODECDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.TOTALPRODUCTODECDataGridViewTextBoxColumn.HeaderText = "TOTAL PRODUCTO"
        Me.TOTALPRODUCTODECDataGridViewTextBoxColumn.Name = "TOTALPRODUCTODECDataGridViewTextBoxColumn"
        Me.TOTALPRODUCTODECDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTALPRODUCTODECDataGridViewTextBoxColumn.Width = 150
        '
        'FRMReportesDeVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(729, 642)
        Me.Controls.Add(Me.DgvDetalleVenta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvVenta)
        Me.Controls.Add(Me.CmbTipoReporte)
        Me.Controls.Add(Me.BtnImprmir)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Name = "FRMReportesDeVentas"
        Me.Text = "Cap"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesDeVentasBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CmbTipoReporte As ComboBox
    Friend WithEvents BtnImprmir As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents VentasBL As NEGOCIOS.VentasBL
    Friend WithEvents ReportesDeVentasBL As NEGOCIOS.ReportesDeVentasBL
    Friend WithEvents DgvVenta As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DtpFechaFinal As DateTimePicker
    Friend WithEvents DtpFechaInicial As DateTimePicker
    Friend WithEvents TxtCveVentaFinal As Componentes.TextBoxEx
    Friend WithEvents TxtCveVentaInicial As Componentes.TextBoxEx
    Friend WithEvents ChkFecha As CheckBox
    Friend WithEvents ChkCveCliente As CheckBox
    Friend WithEvents ChkCveVenta As CheckBox
    Friend WithEvents TxtCveClienteFinal As Componentes.TextBoxEx
    Friend WithEvents TxtCveClienteInicial As Componentes.TextBoxEx
    Friend WithEvents CVE_VENTA_INT As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_SUC_VAR As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_VAR As DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTAL_DEC As DataGridViewTextBoxColumn
    Friend WithEvents IVA_DEC As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_DEC As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_ALTA_DEC As DataGridViewTextBoxColumn
    Friend WithEvents ESTATUS_VAR As DataGridViewTextBoxColumn
    Friend WithEvents DgvDetalleVenta As DataGridView
    Friend WithEvents CVEVENTAINTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CVEPRODUCTOVARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECIOPRODUCTODECDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDADINTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALPRODUCTODECDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
