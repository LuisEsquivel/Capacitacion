<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMBrowseProductos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.TxtNombrePRoducto = New Componentes.TextBoxEx()
        Me.ChkFecha = New System.Windows.Forms.CheckBox()
        Me.ChkNombreProducto = New System.Windows.Forms.CheckBox()
        Me.TxtCveProducto = New Componentes.TextBoxEx()
        Me.ChkCveProducto = New System.Windows.Forms.CheckBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.DgvProductos = New System.Windows.Forms.DataGridView()
        Me.CVE_PRODUCTO_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO_DEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_ALTA_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBL = New NEGOCIOS.ProductosBL()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.DtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.TxtNombrePRoducto)
        Me.GroupBox1.Controls.Add(Me.ChkFecha)
        Me.GroupBox1.Controls.Add(Me.ChkNombreProducto)
        Me.GroupBox1.Controls.Add(Me.TxtCveProducto)
        Me.GroupBox1.Controls.Add(Me.ChkCveProducto)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 102)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'DtpFechaFinal
        '
        Me.DtpFechaFinal.Enabled = False
        Me.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFinal.Location = New System.Drawing.Point(200, 69)
        Me.DtpFechaFinal.Name = "DtpFechaFinal"
        Me.DtpFechaFinal.Size = New System.Drawing.Size(99, 20)
        Me.DtpFechaFinal.TabIndex = 6
        '
        'DtpFechaInicio
        '
        Me.DtpFechaInicio.Enabled = False
        Me.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicio.Location = New System.Drawing.Point(94, 69)
        Me.DtpFechaInicio.Name = "DtpFechaInicio"
        Me.DtpFechaInicio.Size = New System.Drawing.Size(99, 20)
        Me.DtpFechaInicio.TabIndex = 5
        '
        'TxtNombrePRoducto
        '
        Me.TxtNombrePRoducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombrePRoducto.Enabled = False
        Me.TxtNombrePRoducto.Location = New System.Drawing.Point(94, 44)
        Me.TxtNombrePRoducto.Name = "TxtNombrePRoducto"
        Me.TxtNombrePRoducto.Size = New System.Drawing.Size(205, 20)
        Me.TxtNombrePRoducto.TabIndex = 4
        Me.TxtNombrePRoducto.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'ChkFecha
        '
        Me.ChkFecha.AutoSize = True
        Me.ChkFecha.Location = New System.Drawing.Point(7, 74)
        Me.ChkFecha.Name = "ChkFecha"
        Me.ChkFecha.Size = New System.Drawing.Size(56, 17)
        Me.ChkFecha.TabIndex = 3
        Me.ChkFecha.Text = "Fecha"
        Me.ChkFecha.UseVisualStyleBackColor = True
        '
        'ChkNombreProducto
        '
        Me.ChkNombreProducto.AutoSize = True
        Me.ChkNombreProducto.Location = New System.Drawing.Point(7, 47)
        Me.ChkNombreProducto.Name = "ChkNombreProducto"
        Me.ChkNombreProducto.Size = New System.Drawing.Size(63, 17)
        Me.ChkNombreProducto.TabIndex = 2
        Me.ChkNombreProducto.Text = "Nombre"
        Me.ChkNombreProducto.UseVisualStyleBackColor = True
        '
        'TxtCveProducto
        '
        Me.TxtCveProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveProducto.Enabled = False
        Me.TxtCveProducto.Location = New System.Drawing.Point(94, 17)
        Me.TxtCveProducto.Name = "TxtCveProducto"
        Me.TxtCveProducto.Size = New System.Drawing.Size(99, 20)
        Me.TxtCveProducto.TabIndex = 1
        Me.TxtCveProducto.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'ChkCveProducto
        '
        Me.ChkCveProducto.AutoSize = True
        Me.ChkCveProducto.Location = New System.Drawing.Point(7, 20)
        Me.ChkCveProducto.Name = "ChkCveProducto"
        Me.ChkCveProducto.Size = New System.Drawing.Size(91, 17)
        Me.ChkCveProducto.TabIndex = 0
        Me.ChkCveProducto.Text = "Cve Producto"
        Me.ChkCveProducto.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(438, 25)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(66, 76)
        Me.BtnBuscar.TabIndex = 25
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(510, 25)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(66, 76)
        Me.BtnRegresar.TabIndex = 24
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'DgvProductos
        '
        Me.DgvProductos.AllowUserToAddRows = False
        Me.DgvProductos.AllowUserToDeleteRows = False
        Me.DgvProductos.AutoGenerateColumns = False
        Me.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_PRODUCTO_VAR, Me.NOMBRE_VAR, Me.PRECIO_DEC, Me.FECHA_ALTA_DATE})
        Me.DgvProductos.DataSource = Me.ProductosBL.TBLPRODUCTOS
        Me.DgvProductos.Location = New System.Drawing.Point(12, 120)
        Me.DgvProductos.Name = "DgvProductos"
        Me.DgvProductos.ReadOnly = True
        Me.DgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProductos.Size = New System.Drawing.Size(591, 385)
        Me.DgvProductos.TabIndex = 0
        '
        'CVE_PRODUCTO_VAR
        '
        Me.CVE_PRODUCTO_VAR.DataPropertyName = "CVE_PRODUCTO_VAR"
        Me.CVE_PRODUCTO_VAR.HeaderText = "CVE_PRODUCTO_VAR"
        Me.CVE_PRODUCTO_VAR.Name = "CVE_PRODUCTO_VAR"
        Me.CVE_PRODUCTO_VAR.ReadOnly = True
        Me.CVE_PRODUCTO_VAR.Width = 150
        '
        'NOMBRE_VAR
        '
        Me.NOMBRE_VAR.DataPropertyName = "NOMBRE_VAR"
        Me.NOMBRE_VAR.HeaderText = "NOMBRE_VAR"
        Me.NOMBRE_VAR.Name = "NOMBRE_VAR"
        Me.NOMBRE_VAR.ReadOnly = True
        Me.NOMBRE_VAR.Width = 200
        '
        'PRECIO_DEC
        '
        Me.PRECIO_DEC.DataPropertyName = "PRECIO_DEC"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PRECIO_DEC.DefaultCellStyle = DataGridViewCellStyle1
        Me.PRECIO_DEC.HeaderText = "PRECIO_DEC"
        Me.PRECIO_DEC.Name = "PRECIO_DEC"
        Me.PRECIO_DEC.ReadOnly = True
        '
        'FECHA_ALTA_DATE
        '
        Me.FECHA_ALTA_DATE.DataPropertyName = "FECHA_ALTA_DATE"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FECHA_ALTA_DATE.DefaultCellStyle = DataGridViewCellStyle2
        Me.FECHA_ALTA_DATE.HeaderText = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.Name = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.ReadOnly = True
        '
        'ProductosBL
        '
        Me.ProductosBL.DataSetName = "DSProductos"
        Me.ProductosBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FRMBrowseProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(617, 517)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvProductos)
        Me.Name = "FRMBrowseProductos"
        Me.Text = "Búsqueda De Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvProductos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents ProductosBL As NEGOCIOS.ProductosBL
    Friend WithEvents CVE_PRODUCTO_VAR As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_VAR As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO_DEC As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_ALTA_DATE As DataGridViewTextBoxColumn
    Friend WithEvents DtpFechaInicio As DateTimePicker
    Friend WithEvents TxtNombrePRoducto As Componentes.TextBoxEx
    Friend WithEvents ChkFecha As CheckBox
    Friend WithEvents ChkNombreProducto As CheckBox
    Friend WithEvents TxtCveProducto As Componentes.TextBoxEx
    Friend WithEvents ChkCveProducto As CheckBox
    Friend WithEvents DtpFechaFinal As DateTimePicker
End Class
