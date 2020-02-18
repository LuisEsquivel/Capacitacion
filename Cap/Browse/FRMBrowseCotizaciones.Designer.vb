<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMBrowseCotizaciones
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbEstatus = New System.Windows.Forms.ComboBox()
        Me.TxtCveCotizacionFinal = New Componentes.TextBoxEx()
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.ChkFecha = New System.Windows.Forms.CheckBox()
        Me.ChkEstatus = New System.Windows.Forms.CheckBox()
        Me.TxtCveCotizacionInicial = New Componentes.TextBoxEx()
        Me.ChkCveCotizacion = New System.Windows.Forms.CheckBox()
        Me.DgvCotizaciones = New System.Windows.Forms.DataGridView()
        Me.CotizacionesBL = New NEGOCIOS.CotizacionesBL()
        Me.ClientesBL = New NEGOCIOS.ClientesBL()
        Me.CVE_COTIZACION_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_CLIENTE_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CVE_CLIENTE_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBTOTAL_DEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA_DEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_ALTA_DEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUS_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_DEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CotizacionesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(609, 12)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(66, 76)
        Me.BtnBuscar.TabIndex = 32
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(681, 12)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(66, 76)
        Me.BtnRegresar.TabIndex = 31
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbEstatus)
        Me.GroupBox1.Controls.Add(Me.TxtCveCotizacionFinal)
        Me.GroupBox1.Controls.Add(Me.DtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.DtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.ChkFecha)
        Me.GroupBox1.Controls.Add(Me.ChkEstatus)
        Me.GroupBox1.Controls.Add(Me.TxtCveCotizacionInicial)
        Me.GroupBox1.Controls.Add(Me.ChkCveCotizacion)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 103)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'CmbEstatus
        '
        Me.CmbEstatus.Enabled = False
        Me.CmbEstatus.FormattingEnabled = True
        Me.CmbEstatus.Items.AddRange(New Object() {"---SELECCIONAR---", "EMITIDA", "CANCELADA"})
        Me.CmbEstatus.Location = New System.Drawing.Point(109, 43)
        Me.CmbEstatus.Name = "CmbEstatus"
        Me.CmbEstatus.Size = New System.Drawing.Size(205, 21)
        Me.CmbEstatus.TabIndex = 15
        Me.CmbEstatus.Text = "---SELECCIONAR---"
        '
        'TxtCveCotizacionFinal
        '
        Me.TxtCveCotizacionFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveCotizacionFinal.Enabled = False
        Me.TxtCveCotizacionFinal.Location = New System.Drawing.Point(215, 16)
        Me.TxtCveCotizacionFinal.Name = "TxtCveCotizacionFinal"
        Me.TxtCveCotizacionFinal.Size = New System.Drawing.Size(99, 20)
        Me.TxtCveCotizacionFinal.TabIndex = 14
        Me.TxtCveCotizacionFinal.Text = "0"
        Me.TxtCveCotizacionFinal.TipoDato = Componentes.Enumeraciones.TipoDatos.Entero
        '
        'DtpFechaFinal
        '
        Me.DtpFechaFinal.Enabled = False
        Me.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFinal.Location = New System.Drawing.Point(215, 70)
        Me.DtpFechaFinal.Name = "DtpFechaFinal"
        Me.DtpFechaFinal.Size = New System.Drawing.Size(99, 20)
        Me.DtpFechaFinal.TabIndex = 13
        '
        'DtpFechaInicio
        '
        Me.DtpFechaInicio.Enabled = False
        Me.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicio.Location = New System.Drawing.Point(109, 68)
        Me.DtpFechaInicio.Name = "DtpFechaInicio"
        Me.DtpFechaInicio.Size = New System.Drawing.Size(99, 20)
        Me.DtpFechaInicio.TabIndex = 12
        '
        'ChkFecha
        '
        Me.ChkFecha.AutoSize = True
        Me.ChkFecha.Location = New System.Drawing.Point(6, 73)
        Me.ChkFecha.Name = "ChkFecha"
        Me.ChkFecha.Size = New System.Drawing.Size(56, 17)
        Me.ChkFecha.TabIndex = 10
        Me.ChkFecha.Text = "Fecha"
        Me.ChkFecha.UseVisualStyleBackColor = True
        '
        'ChkEstatus
        '
        Me.ChkEstatus.AutoSize = True
        Me.ChkEstatus.Location = New System.Drawing.Point(6, 46)
        Me.ChkEstatus.Name = "ChkEstatus"
        Me.ChkEstatus.Size = New System.Drawing.Size(61, 17)
        Me.ChkEstatus.TabIndex = 9
        Me.ChkEstatus.Text = "Estatus"
        Me.ChkEstatus.UseVisualStyleBackColor = True
        '
        'TxtCveCotizacionInicial
        '
        Me.TxtCveCotizacionInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveCotizacionInicial.Enabled = False
        Me.TxtCveCotizacionInicial.Location = New System.Drawing.Point(109, 16)
        Me.TxtCveCotizacionInicial.Name = "TxtCveCotizacionInicial"
        Me.TxtCveCotizacionInicial.Size = New System.Drawing.Size(99, 20)
        Me.TxtCveCotizacionInicial.TabIndex = 8
        Me.TxtCveCotizacionInicial.Text = "0"
        Me.TxtCveCotizacionInicial.TipoDato = Componentes.Enumeraciones.TipoDatos.Entero
        '
        'ChkCveCotizacion
        '
        Me.ChkCveCotizacion.AutoSize = True
        Me.ChkCveCotizacion.Location = New System.Drawing.Point(6, 19)
        Me.ChkCveCotizacion.Name = "ChkCveCotizacion"
        Me.ChkCveCotizacion.Size = New System.Drawing.Size(97, 17)
        Me.ChkCveCotizacion.TabIndex = 7
        Me.ChkCveCotizacion.Text = "Cve Cotizacion"
        Me.ChkCveCotizacion.UseVisualStyleBackColor = True
        '
        'DgvCotizaciones
        '
        Me.DgvCotizaciones.AllowUserToAddRows = False
        Me.DgvCotizaciones.AllowUserToDeleteRows = False
        Me.DgvCotizaciones.AutoGenerateColumns = False
        Me.DgvCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCotizaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_COTIZACION_INT, Me.NOMBRE_CLIENTE_VAR, Me.CVE_CLIENTE_INT, Me.SUBTOTAL_DEC, Me.IVA_DEC, Me.FECHA_ALTA_DEC, Me.ESTATUS_INT, Me.TOTAL_DEC})
        Me.DgvCotizaciones.DataSource = Me.CotizacionesBL.TBLCOTIZACION
        Me.DgvCotizaciones.Location = New System.Drawing.Point(13, 121)
        Me.DgvCotizaciones.Name = "DgvCotizaciones"
        Me.DgvCotizaciones.ReadOnly = True
        Me.DgvCotizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCotizaciones.Size = New System.Drawing.Size(734, 337)
        Me.DgvCotizaciones.TabIndex = 33
        '
        'CotizacionesBL
        '
        Me.CotizacionesBL.DataSetName = "DSCotizaciones"
        Me.CotizacionesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBL
        '
        Me.ClientesBL.DataSetName = "DSClientes"
        Me.ClientesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CVE_COTIZACION_INT
        '
        Me.CVE_COTIZACION_INT.DataPropertyName = "CVE_COTIZACION_INT"
        Me.CVE_COTIZACION_INT.HeaderText = "CVE_COTIZACION_INT"
        Me.CVE_COTIZACION_INT.Name = "CVE_COTIZACION_INT"
        Me.CVE_COTIZACION_INT.ReadOnly = True
        '
        'NOMBRE_CLIENTE_VAR
        '
        Me.NOMBRE_CLIENTE_VAR.HeaderText = "CLIENTE"
        Me.NOMBRE_CLIENTE_VAR.Name = "NOMBRE_CLIENTE_VAR"
        Me.NOMBRE_CLIENTE_VAR.ReadOnly = True
        '
        'CVE_CLIENTE_INT
        '
        Me.CVE_CLIENTE_INT.DataPropertyName = "CVE_CLIENTE_INT"
        Me.CVE_CLIENTE_INT.HeaderText = "CVE_CLIENTE_INT"
        Me.CVE_CLIENTE_INT.Name = "CVE_CLIENTE_INT"
        Me.CVE_CLIENTE_INT.ReadOnly = True
        Me.CVE_CLIENTE_INT.Visible = False
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
        'FECHA_ALTA_DEC
        '
        Me.FECHA_ALTA_DEC.DataPropertyName = "FECHA_ALTA_DEC"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FECHA_ALTA_DEC.DefaultCellStyle = DataGridViewCellStyle3
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
        'TOTAL_DEC
        '
        Me.TOTAL_DEC.DataPropertyName = "TOTAL_DEC"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.TOTAL_DEC.DefaultCellStyle = DataGridViewCellStyle4
        Me.TOTAL_DEC.HeaderText = "TOTAL_DEC"
        Me.TOTAL_DEC.Name = "TOTAL_DEC"
        Me.TOTAL_DEC.ReadOnly = True
        '
        'FRMBrowseCotizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(759, 486)
        Me.Controls.Add(Me.DgvCotizaciones)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FRMBrowseCotizaciones"
        Me.Text = "Busqueda de Cotizaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CotizacionesBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvCotizaciones As DataGridView
    Friend WithEvents CotizacionesBL As NEGOCIOS.CotizacionesBL
    Friend WithEvents DtpFechaFinal As DateTimePicker
    Friend WithEvents DtpFechaInicio As DateTimePicker
    Friend WithEvents ChkFecha As CheckBox
    Friend WithEvents ChkEstatus As CheckBox
    Friend WithEvents TxtCveCotizacionInicial As Componentes.TextBoxEx
    Friend WithEvents ChkCveCotizacion As CheckBox
    Friend WithEvents TxtCveCotizacionFinal As Componentes.TextBoxEx
    Friend WithEvents ClientesBL As NEGOCIOS.ClientesBL
    Friend WithEvents CmbEstatus As ComboBox
    Friend WithEvents CVE_COTIZACION_INT As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_CLIENTE_VAR As DataGridViewTextBoxColumn
    Friend WithEvents CVE_CLIENTE_INT As DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTAL_DEC As DataGridViewTextBoxColumn
    Friend WithEvents IVA_DEC As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_ALTA_DEC As DataGridViewTextBoxColumn
    Friend WithEvents ESTATUS_INT As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_DEC As DataGridViewTextBoxColumn
End Class
