<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMBrowseSucursal
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.ChkFecha = New System.Windows.Forms.CheckBox()
        Me.TxtNombre = New Componentes.TextBoxEx()
        Me.ChkNombre = New System.Windows.Forms.CheckBox()
        Me.TxtCveSucursal = New Componentes.TextBoxEx()
        Me.ChkCveSucursal = New System.Windows.Forms.CheckBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.DgvSucursales = New System.Windows.Forms.DataGridView()
        Me.SucursalesBL = New NEGOCIOS.SucursalesBL()
        Me.CVE_SUC_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_SUC_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CALLE_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMERO_INTERIOR_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUM_EXTERIOR_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONO_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_ALTA_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.DtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.ChkFecha)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.ChkNombre)
        Me.GroupBox1.Controls.Add(Me.TxtCveSucursal)
        Me.GroupBox1.Controls.Add(Me.ChkCveSucursal)
        Me.GroupBox1.Location = New System.Drawing.Point(77, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 102)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'DtpFechaFinal
        '
        Me.DtpFechaFinal.Enabled = False
        Me.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFinal.Location = New System.Drawing.Point(201, 71)
        Me.DtpFechaFinal.Name = "DtpFechaFinal"
        Me.DtpFechaFinal.Size = New System.Drawing.Size(95, 20)
        Me.DtpFechaFinal.TabIndex = 6
        '
        'DtpFechaInicio
        '
        Me.DtpFechaInicio.Enabled = False
        Me.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicio.Location = New System.Drawing.Point(93, 73)
        Me.DtpFechaInicio.Name = "DtpFechaInicio"
        Me.DtpFechaInicio.Size = New System.Drawing.Size(102, 20)
        Me.DtpFechaInicio.TabIndex = 5
        '
        'ChkFecha
        '
        Me.ChkFecha.AutoSize = True
        Me.ChkFecha.Location = New System.Drawing.Point(7, 76)
        Me.ChkFecha.Name = "ChkFecha"
        Me.ChkFecha.Size = New System.Drawing.Size(56, 17)
        Me.ChkFecha.TabIndex = 4
        Me.ChkFecha.Text = "Fecha"
        Me.ChkFecha.UseVisualStyleBackColor = True
        '
        'TxtNombre
        '
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Location = New System.Drawing.Point(93, 47)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(203, 20)
        Me.TxtNombre.TabIndex = 3
        Me.TxtNombre.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'ChkNombre
        '
        Me.ChkNombre.AutoSize = True
        Me.ChkNombre.Location = New System.Drawing.Point(7, 47)
        Me.ChkNombre.Name = "ChkNombre"
        Me.ChkNombre.Size = New System.Drawing.Size(63, 17)
        Me.ChkNombre.TabIndex = 2
        Me.ChkNombre.Text = "Nombre"
        Me.ChkNombre.UseVisualStyleBackColor = True
        '
        'TxtCveSucursal
        '
        Me.TxtCveSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveSucursal.Enabled = False
        Me.TxtCveSucursal.Location = New System.Drawing.Point(93, 17)
        Me.TxtCveSucursal.Name = "TxtCveSucursal"
        Me.TxtCveSucursal.Size = New System.Drawing.Size(102, 20)
        Me.TxtCveSucursal.TabIndex = 1
        Me.TxtCveSucursal.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'ChkCveSucursal
        '
        Me.ChkCveSucursal.AutoSize = True
        Me.ChkCveSucursal.Location = New System.Drawing.Point(7, 20)
        Me.ChkCveSucursal.Name = "ChkCveSucursal"
        Me.ChkCveSucursal.Size = New System.Drawing.Size(89, 17)
        Me.ChkCveSucursal.TabIndex = 0
        Me.ChkCveSucursal.Text = "Cve Sucursal"
        Me.ChkCveSucursal.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(616, 27)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(66, 76)
        Me.BtnBuscar.TabIndex = 32
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(684, 27)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(66, 76)
        Me.BtnRegresar.TabIndex = 31
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'DgvSucursales
        '
        Me.DgvSucursales.AllowUserToAddRows = False
        Me.DgvSucursales.AllowUserToDeleteRows = False
        Me.DgvSucursales.AutoGenerateColumns = False
        Me.DgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSucursales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_SUC_VAR, Me.NOMBRE_SUC_VAR, Me.CALLE_VAR, Me.NUMERO_INTERIOR_INT, Me.NUM_EXTERIOR_INT, Me.TELEFONO_VAR, Me.FECHA_ALTA_DATE})
        Me.DgvSucursales.DataSource = Me.SucursalesBL.TBLSUCURSAL
        Me.DgvSucursales.Location = New System.Drawing.Point(12, 120)
        Me.DgvSucursales.Name = "DgvSucursales"
        Me.DgvSucursales.ReadOnly = True
        Me.DgvSucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSucursales.Size = New System.Drawing.Size(740, 305)
        Me.DgvSucursales.TabIndex = 34
        '
        'SucursalesBL
        '
        Me.SucursalesBL.DataSetName = "DSSucursales"
        Me.SucursalesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CVE_SUC_VAR
        '
        Me.CVE_SUC_VAR.DataPropertyName = "CVE_SUC_VAR"
        Me.CVE_SUC_VAR.HeaderText = "CVE_SUC_VAR"
        Me.CVE_SUC_VAR.Name = "CVE_SUC_VAR"
        Me.CVE_SUC_VAR.ReadOnly = True
        '
        'NOMBRE_SUC_VAR
        '
        Me.NOMBRE_SUC_VAR.DataPropertyName = "NOMBRE_SUC_VAR"
        Me.NOMBRE_SUC_VAR.HeaderText = "NOMBRE_SUC_VAR"
        Me.NOMBRE_SUC_VAR.Name = "NOMBRE_SUC_VAR"
        Me.NOMBRE_SUC_VAR.ReadOnly = True
        '
        'CALLE_VAR
        '
        Me.CALLE_VAR.DataPropertyName = "CALLE_VAR"
        Me.CALLE_VAR.HeaderText = "CALLE_VAR"
        Me.CALLE_VAR.Name = "CALLE_VAR"
        Me.CALLE_VAR.ReadOnly = True
        '
        'NUMERO_INTERIOR_INT
        '
        Me.NUMERO_INTERIOR_INT.DataPropertyName = "NUMERO_INTERIOR_INT"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NUMERO_INTERIOR_INT.DefaultCellStyle = DataGridViewCellStyle1
        Me.NUMERO_INTERIOR_INT.HeaderText = "NUMERO_INTERIOR_INT"
        Me.NUMERO_INTERIOR_INT.Name = "NUMERO_INTERIOR_INT"
        Me.NUMERO_INTERIOR_INT.ReadOnly = True
        '
        'NUM_EXTERIOR_INT
        '
        Me.NUM_EXTERIOR_INT.DataPropertyName = "NUM_EXTERIOR_INT"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NUM_EXTERIOR_INT.DefaultCellStyle = DataGridViewCellStyle2
        Me.NUM_EXTERIOR_INT.HeaderText = "NUM_EXTERIOR_INT"
        Me.NUM_EXTERIOR_INT.Name = "NUM_EXTERIOR_INT"
        Me.NUM_EXTERIOR_INT.ReadOnly = True
        '
        'TELEFONO_VAR
        '
        Me.TELEFONO_VAR.DataPropertyName = "TELEFONO_VAR"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TELEFONO_VAR.DefaultCellStyle = DataGridViewCellStyle3
        Me.TELEFONO_VAR.HeaderText = "TELEFONO_VAR"
        Me.TELEFONO_VAR.Name = "TELEFONO_VAR"
        Me.TELEFONO_VAR.ReadOnly = True
        '
        'FECHA_ALTA_DATE
        '
        Me.FECHA_ALTA_DATE.DataPropertyName = "FECHA_ALTA_DATE"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.FECHA_ALTA_DATE.DefaultCellStyle = DataGridViewCellStyle4
        Me.FECHA_ALTA_DATE.HeaderText = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.Name = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.ReadOnly = True
        '
        'FRMBrowseSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(765, 450)
        Me.Controls.Add(Me.DgvSucursales)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Name = "FRMBrowseSucursal"
        Me.Text = "Busqueda de Sucursal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DtpFechaFinal As DateTimePicker
    Friend WithEvents DtpFechaInicio As DateTimePicker
    Friend WithEvents ChkFecha As CheckBox
    Friend WithEvents TxtNombre As Componentes.TextBoxEx
    Friend WithEvents ChkNombre As CheckBox
    Friend WithEvents TxtCveSucursal As Componentes.TextBoxEx
    Friend WithEvents ChkCveSucursal As CheckBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents DgvSucursales As DataGridView
    Friend WithEvents SucursalesBL As NEGOCIOS.SucursalesBL
    Friend WithEvents CVE_SUC_VAR As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_SUC_VAR As DataGridViewTextBoxColumn
    Friend WithEvents CALLE_VAR As DataGridViewTextBoxColumn
    Friend WithEvents NUMERO_INTERIOR_INT As DataGridViewTextBoxColumn
    Friend WithEvents NUM_EXTERIOR_INT As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONO_VAR As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_ALTA_DATE As DataGridViewTextBoxColumn
End Class
