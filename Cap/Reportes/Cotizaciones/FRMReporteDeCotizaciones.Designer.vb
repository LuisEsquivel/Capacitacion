<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMReporteDeCotizaciones
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvDetalleCotizacion = New System.Windows.Forms.DataGridView()
        Me.CVECOTIZACIONINTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CVEPRODUCTOVARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIOPRODUCTODECDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDADINTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALPRODUCTODECDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReporteDeCotizacionesBL = New NEGOCIOS.ReporteDeCotizacionesBL()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCveClienteFinal = New Componentes.TextBoxEx()
        Me.TxtCveClienteInicial = New Componentes.TextBoxEx()
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.TxtCveCotizacionFinal = New Componentes.TextBoxEx()
        Me.TxtCveCotizacionInicial = New Componentes.TextBoxEx()
        Me.ChkFecha = New System.Windows.Forms.CheckBox()
        Me.ChkCveCliente = New System.Windows.Forms.CheckBox()
        Me.ChkCveCotizacion = New System.Windows.Forms.CheckBox()
        Me.DgvCotizacion = New System.Windows.Forms.DataGridView()
        Me.CmbTipoReporte = New System.Windows.Forms.ComboBox()
        Me.BtnImprmir = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.CotizacionesBL = New NEGOCIOS.CotizacionesBL()
        Me.CVE_COTIZACION_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREVARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBTOTALDECDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVADECDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALDECDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAALTADECDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUSVARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvDetalleCotizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteDeCotizacionesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvCotizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CotizacionesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvDetalleCotizacion
        '
        Me.DgvDetalleCotizacion.AllowUserToAddRows = False
        Me.DgvDetalleCotizacion.AllowUserToDeleteRows = False
        Me.DgvDetalleCotizacion.AutoGenerateColumns = False
        Me.DgvDetalleCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalleCotizacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVECOTIZACIONINTDataGridViewTextBoxColumn, Me.CVEPRODUCTOVARDataGridViewTextBoxColumn, Me.PRECIOPRODUCTODECDataGridViewTextBoxColumn, Me.CANTIDADINTDataGridViewTextBoxColumn, Me.TOTALPRODUCTODECDataGridViewTextBoxColumn})
        Me.DgvDetalleCotizacion.DataSource = Me.ReporteDeCotizacionesBL.TBLDETALLE_COTIZACION
        Me.DgvDetalleCotizacion.Location = New System.Drawing.Point(13, 347)
        Me.DgvDetalleCotizacion.Name = "DgvDetalleCotizacion"
        Me.DgvDetalleCotizacion.ReadOnly = True
        Me.DgvDetalleCotizacion.Size = New System.Drawing.Size(694, 273)
        Me.DgvDetalleCotizacion.TabIndex = 68
        '
        'CVECOTIZACIONINTDataGridViewTextBoxColumn
        '
        Me.CVECOTIZACIONINTDataGridViewTextBoxColumn.DataPropertyName = "CVE_COTIZACION_INT"
        Me.CVECOTIZACIONINTDataGridViewTextBoxColumn.HeaderText = "CVE COTIZACION"
        Me.CVECOTIZACIONINTDataGridViewTextBoxColumn.Name = "CVECOTIZACIONINTDataGridViewTextBoxColumn"
        Me.CVECOTIZACIONINTDataGridViewTextBoxColumn.ReadOnly = True
        Me.CVECOTIZACIONINTDataGridViewTextBoxColumn.Width = 125
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.PRECIOPRODUCTODECDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PRECIOPRODUCTODECDataGridViewTextBoxColumn.HeaderText = "PRECIO PRODUCTO"
        Me.PRECIOPRODUCTODECDataGridViewTextBoxColumn.Name = "PRECIOPRODUCTODECDataGridViewTextBoxColumn"
        Me.PRECIOPRODUCTODECDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRECIOPRODUCTODECDataGridViewTextBoxColumn.Width = 135
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.TOTALPRODUCTODECDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.TOTALPRODUCTODECDataGridViewTextBoxColumn.HeaderText = "TOTAL"
        Me.TOTALPRODUCTODECDataGridViewTextBoxColumn.Name = "TOTALPRODUCTODECDataGridViewTextBoxColumn"
        Me.TOTALPRODUCTODECDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReporteDeCotizacionesBL
        '
        Me.ReporteDeCotizacionesBL.DataSetName = "DSReporteDeCotizaciones"
        Me.ReporteDeCotizacionesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCveClienteFinal)
        Me.GroupBox1.Controls.Add(Me.TxtCveClienteInicial)
        Me.GroupBox1.Controls.Add(Me.DtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.DtpFechaInicial)
        Me.GroupBox1.Controls.Add(Me.TxtCveCotizacionFinal)
        Me.GroupBox1.Controls.Add(Me.TxtCveCotizacionInicial)
        Me.GroupBox1.Controls.Add(Me.ChkFecha)
        Me.GroupBox1.Controls.Add(Me.ChkCveCliente)
        Me.GroupBox1.Controls.Add(Me.ChkCveCotizacion)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 98)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        '
        'TxtCveClienteFinal
        '
        Me.TxtCveClienteFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveClienteFinal.Enabled = False
        Me.TxtCveClienteFinal.Location = New System.Drawing.Point(209, 48)
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
        Me.TxtCveClienteInicial.Location = New System.Drawing.Point(100, 47)
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
        Me.DtpFechaFinal.Location = New System.Drawing.Point(209, 73)
        Me.DtpFechaFinal.Name = "DtpFechaFinal"
        Me.DtpFechaFinal.Size = New System.Drawing.Size(102, 20)
        Me.DtpFechaFinal.TabIndex = 6
        '
        'DtpFechaInicial
        '
        Me.DtpFechaInicial.Enabled = False
        Me.DtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicial.Location = New System.Drawing.Point(100, 73)
        Me.DtpFechaInicial.Name = "DtpFechaInicial"
        Me.DtpFechaInicial.Size = New System.Drawing.Size(100, 20)
        Me.DtpFechaInicial.TabIndex = 5
        '
        'TxtCveCotizacionFinal
        '
        Me.TxtCveCotizacionFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveCotizacionFinal.Enabled = False
        Me.TxtCveCotizacionFinal.Location = New System.Drawing.Point(208, 21)
        Me.TxtCveCotizacionFinal.Name = "TxtCveCotizacionFinal"
        Me.TxtCveCotizacionFinal.Size = New System.Drawing.Size(102, 20)
        Me.TxtCveCotizacionFinal.TabIndex = 4
        Me.TxtCveCotizacionFinal.Text = "0"
        Me.TxtCveCotizacionFinal.TipoDato = Componentes.Enumeraciones.TipoDatos.Entero
        '
        'TxtCveCotizacionInicial
        '
        Me.TxtCveCotizacionInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveCotizacionInicial.Enabled = False
        Me.TxtCveCotizacionInicial.Location = New System.Drawing.Point(101, 20)
        Me.TxtCveCotizacionInicial.Name = "TxtCveCotizacionInicial"
        Me.TxtCveCotizacionInicial.Size = New System.Drawing.Size(101, 20)
        Me.TxtCveCotizacionInicial.TabIndex = 3
        Me.TxtCveCotizacionInicial.Text = "0"
        Me.TxtCveCotizacionInicial.TipoDato = Componentes.Enumeraciones.TipoDatos.Entero
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
        'ChkCveCotizacion
        '
        Me.ChkCveCotizacion.AutoSize = True
        Me.ChkCveCotizacion.Location = New System.Drawing.Point(7, 22)
        Me.ChkCveCotizacion.Name = "ChkCveCotizacion"
        Me.ChkCveCotizacion.Size = New System.Drawing.Size(97, 17)
        Me.ChkCveCotizacion.TabIndex = 0
        Me.ChkCveCotizacion.Text = "Cve Cotizacion"
        Me.ChkCveCotizacion.UseVisualStyleBackColor = True
        '
        'DgvCotizacion
        '
        Me.DgvCotizacion.AllowUserToAddRows = False
        Me.DgvCotizacion.AllowUserToDeleteRows = False
        Me.DgvCotizacion.AutoGenerateColumns = False
        Me.DgvCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCotizacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_COTIZACION_INT, Me.NOMBREVARDataGridViewTextBoxColumn, Me.SUBTOTALDECDataGridViewTextBoxColumn, Me.IVADECDataGridViewTextBoxColumn, Me.TOTALDECDataGridViewTextBoxColumn, Me.FECHAALTADECDataGridViewTextBoxColumn, Me.ESTATUSVARDataGridViewTextBoxColumn})
        Me.DgvCotizacion.DataSource = Me.ReporteDeCotizacionesBL.TBLCOTIZACION
        Me.DgvCotizacion.Location = New System.Drawing.Point(13, 155)
        Me.DgvCotizacion.Name = "DgvCotizacion"
        Me.DgvCotizacion.ReadOnly = True
        Me.DgvCotizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCotizacion.Size = New System.Drawing.Size(694, 186)
        Me.DgvCotizacion.TabIndex = 66
        '
        'CmbTipoReporte
        '
        Me.CmbTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipoReporte.FormattingEnabled = True
        Me.CmbTipoReporte.Items.AddRange(New Object() {"--SELECCIONE--", "CONSECUTIVO DE COTIZACION", "CONSECUTIVO DE COTIZACION DESGLOSADO"})
        Me.CmbTipoReporte.Location = New System.Drawing.Point(13, 128)
        Me.CmbTipoReporte.Name = "CmbTipoReporte"
        Me.CmbTipoReporte.Size = New System.Drawing.Size(312, 21)
        Me.CmbTipoReporte.TabIndex = 65
        '
        'BtnImprmir
        '
        Me.BtnImprmir.Enabled = False
        Me.BtnImprmir.Location = New System.Drawing.Point(443, 35)
        Me.BtnImprmir.Name = "BtnImprmir"
        Me.BtnImprmir.Size = New System.Drawing.Size(66, 76)
        Me.BtnImprmir.TabIndex = 64
        Me.BtnImprmir.Text = "Imprimir"
        Me.BtnImprmir.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(575, 35)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(66, 76)
        Me.BtnBuscar.TabIndex = 63
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(641, 35)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(66, 76)
        Me.BtnSalir.TabIndex = 62
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.Location = New System.Drawing.Point(509, 35)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(66, 76)
        Me.BtnCancelar.TabIndex = 61
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'CotizacionesBL
        '
        Me.CotizacionesBL.DataSetName = "DSCotizaciones"
        Me.CotizacionesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CVE_COTIZACION_INT
        '
        Me.CVE_COTIZACION_INT.DataPropertyName = "CVE_COTIZACION_INT"
        Me.CVE_COTIZACION_INT.HeaderText = "CVE COTIZACION"
        Me.CVE_COTIZACION_INT.Name = "CVE_COTIZACION_INT"
        Me.CVE_COTIZACION_INT.ReadOnly = True
        Me.CVE_COTIZACION_INT.Width = 125
        '
        'NOMBREVARDataGridViewTextBoxColumn
        '
        Me.NOMBREVARDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_VAR"
        Me.NOMBREVARDataGridViewTextBoxColumn.HeaderText = "CLIENTE"
        Me.NOMBREVARDataGridViewTextBoxColumn.Name = "NOMBREVARDataGridViewTextBoxColumn"
        Me.NOMBREVARDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SUBTOTALDECDataGridViewTextBoxColumn
        '
        Me.SUBTOTALDECDataGridViewTextBoxColumn.DataPropertyName = "SUBTOTAL_DEC"
        Me.SUBTOTALDECDataGridViewTextBoxColumn.HeaderText = "SUBTOTAL"
        Me.SUBTOTALDECDataGridViewTextBoxColumn.Name = "SUBTOTALDECDataGridViewTextBoxColumn"
        Me.SUBTOTALDECDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IVADECDataGridViewTextBoxColumn
        '
        Me.IVADECDataGridViewTextBoxColumn.DataPropertyName = "IVA_DEC"
        Me.IVADECDataGridViewTextBoxColumn.HeaderText = "IVA"
        Me.IVADECDataGridViewTextBoxColumn.Name = "IVADECDataGridViewTextBoxColumn"
        Me.IVADECDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TOTALDECDataGridViewTextBoxColumn
        '
        Me.TOTALDECDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_DEC"
        Me.TOTALDECDataGridViewTextBoxColumn.HeaderText = "TOTAL"
        Me.TOTALDECDataGridViewTextBoxColumn.Name = "TOTALDECDataGridViewTextBoxColumn"
        Me.TOTALDECDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FECHAALTADECDataGridViewTextBoxColumn
        '
        Me.FECHAALTADECDataGridViewTextBoxColumn.DataPropertyName = "FECHA_ALTA_DEC"
        Me.FECHAALTADECDataGridViewTextBoxColumn.HeaderText = "FECHA ALTA"
        Me.FECHAALTADECDataGridViewTextBoxColumn.Name = "FECHAALTADECDataGridViewTextBoxColumn"
        Me.FECHAALTADECDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ESTATUSVARDataGridViewTextBoxColumn
        '
        Me.ESTATUSVARDataGridViewTextBoxColumn.DataPropertyName = "ESTATUS_VAR"
        Me.ESTATUSVARDataGridViewTextBoxColumn.HeaderText = "ESTATUS"
        Me.ESTATUSVARDataGridViewTextBoxColumn.Name = "ESTATUSVARDataGridViewTextBoxColumn"
        Me.ESTATUSVARDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FRMReporteDeCotizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(726, 632)
        Me.Controls.Add(Me.DgvDetalleCotizacion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvCotizacion)
        Me.Controls.Add(Me.CmbTipoReporte)
        Me.Controls.Add(Me.BtnImprmir)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Name = "FRMReporteDeCotizaciones"
        Me.Text = "Reporte De Cotizaciones"
        CType(Me.DgvDetalleCotizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteDeCotizacionesBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvCotizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CotizacionesBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvDetalleCotizacion As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCveClienteFinal As Componentes.TextBoxEx
    Friend WithEvents TxtCveClienteInicial As Componentes.TextBoxEx
    Friend WithEvents DtpFechaFinal As DateTimePicker
    Friend WithEvents DtpFechaInicial As DateTimePicker
    Friend WithEvents TxtCveCotizacionFinal As Componentes.TextBoxEx
    Friend WithEvents TxtCveCotizacionInicial As Componentes.TextBoxEx
    Friend WithEvents ChkFecha As CheckBox
    Friend WithEvents ChkCveCliente As CheckBox
    Friend WithEvents ChkCveCotizacion As CheckBox
    Friend WithEvents DgvCotizacion As DataGridView
    Friend WithEvents CmbTipoReporte As ComboBox
    Friend WithEvents BtnImprmir As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents CotizacionesBL As NEGOCIOS.CotizacionesBL
    Friend WithEvents ReporteDeCotizacionesBL As NEGOCIOS.ReporteDeCotizacionesBL
    Friend WithEvents CVECOTIZACIONINTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CVEPRODUCTOVARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECIOPRODUCTODECDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDADINTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALPRODUCTODECDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CVE_COTIZACION_INT As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREVARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTALDECDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IVADECDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALDECDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAALTADECDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESTATUSVARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
