<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMBrowseProveedores
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
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.ChkFecha = New System.Windows.Forms.CheckBox()
        Me.TxtNombre = New Componentes.TextBoxEx()
        Me.ChkNombre = New System.Windows.Forms.CheckBox()
        Me.TxtCveProveedor = New Componentes.TextBoxEx()
        Me.ChkCveProveedor = New System.Windows.Forms.CheckBox()
        Me.DgvProveedores = New System.Windows.Forms.DataGridView()
        Me.CVE_PROVEEDOR_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOS_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAZON_SOCIAL_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONO_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CORREO_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_ALTA_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedoresBL = New NEGOCIOS.ProveedoresBL()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(478, 27)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(66, 76)
        Me.BtnBuscar.TabIndex = 31
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(543, 27)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(66, 76)
        Me.BtnRegresar.TabIndex = 30
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.DtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.ChkFecha)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.ChkNombre)
        Me.GroupBox1.Controls.Add(Me.TxtCveProveedor)
        Me.GroupBox1.Controls.Add(Me.ChkCveProveedor)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 102)
        Me.GroupBox1.TabIndex = 32
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
        'TxtCveProveedor
        '
        Me.TxtCveProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveProveedor.Enabled = False
        Me.TxtCveProveedor.Location = New System.Drawing.Point(110, 17)
        Me.TxtCveProveedor.Name = "TxtCveProveedor"
        Me.TxtCveProveedor.Size = New System.Drawing.Size(102, 20)
        Me.TxtCveProveedor.TabIndex = 1
        Me.TxtCveProveedor.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'ChkCveProveedor
        '
        Me.ChkCveProveedor.AutoSize = True
        Me.ChkCveProveedor.Location = New System.Drawing.Point(7, 20)
        Me.ChkCveProveedor.Name = "ChkCveProveedor"
        Me.ChkCveProveedor.Size = New System.Drawing.Size(97, 17)
        Me.ChkCveProveedor.TabIndex = 0
        Me.ChkCveProveedor.Text = "Cve Proveedor"
        Me.ChkCveProveedor.UseVisualStyleBackColor = True
        '
        'DgvProveedores
        '
        Me.DgvProveedores.AllowUserToAddRows = False
        Me.DgvProveedores.AllowUserToDeleteRows = False
        Me.DgvProveedores.AutoGenerateColumns = False
        Me.DgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_PROVEEDOR_VAR, Me.NOMBRE_VAR, Me.APELLIDOS_VAR, Me.RAZON_SOCIAL_VAR, Me.TELEFONO_VAR, Me.CORREO_VAR, Me.FECHA_ALTA_DATE})
        Me.DgvProveedores.DataSource = Me.ProveedoresBL.TBLPROVEEDORES
        Me.DgvProveedores.Location = New System.Drawing.Point(12, 120)
        Me.DgvProveedores.Name = "DgvProveedores"
        Me.DgvProveedores.ReadOnly = True
        Me.DgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProveedores.Size = New System.Drawing.Size(597, 318)
        Me.DgvProveedores.TabIndex = 33
        '
        'CVE_PROVEEDOR_VAR
        '
        Me.CVE_PROVEEDOR_VAR.DataPropertyName = "CVE_PROVEEDOR_VAR"
        Me.CVE_PROVEEDOR_VAR.HeaderText = "CVE_PROVEEDOR_VAR"
        Me.CVE_PROVEEDOR_VAR.Name = "CVE_PROVEEDOR_VAR"
        Me.CVE_PROVEEDOR_VAR.ReadOnly = True
        '
        'NOMBRE_VAR
        '
        Me.NOMBRE_VAR.DataPropertyName = "NOMBRE_VAR"
        Me.NOMBRE_VAR.HeaderText = "NOMBRE_VAR"
        Me.NOMBRE_VAR.Name = "NOMBRE_VAR"
        Me.NOMBRE_VAR.ReadOnly = True
        '
        'APELLIDOS_VAR
        '
        Me.APELLIDOS_VAR.DataPropertyName = "APELLIDOS_VAR"
        Me.APELLIDOS_VAR.HeaderText = "APELLIDOS_VAR"
        Me.APELLIDOS_VAR.Name = "APELLIDOS_VAR"
        Me.APELLIDOS_VAR.ReadOnly = True
        '
        'RAZON_SOCIAL_VAR
        '
        Me.RAZON_SOCIAL_VAR.DataPropertyName = "RAZON_SOCIAL_VAR"
        Me.RAZON_SOCIAL_VAR.HeaderText = "RAZON_SOCIAL_VAR"
        Me.RAZON_SOCIAL_VAR.Name = "RAZON_SOCIAL_VAR"
        Me.RAZON_SOCIAL_VAR.ReadOnly = True
        '
        'TELEFONO_VAR
        '
        Me.TELEFONO_VAR.DataPropertyName = "TELEFONO_VAR"
        Me.TELEFONO_VAR.HeaderText = "TELEFONO_VAR"
        Me.TELEFONO_VAR.Name = "TELEFONO_VAR"
        Me.TELEFONO_VAR.ReadOnly = True
        '
        'CORREO_VAR
        '
        Me.CORREO_VAR.DataPropertyName = "CORREO_VAR"
        Me.CORREO_VAR.HeaderText = "CORREO_VAR"
        Me.CORREO_VAR.Name = "CORREO_VAR"
        Me.CORREO_VAR.ReadOnly = True
        '
        'FECHA_ALTA_DATE
        '
        Me.FECHA_ALTA_DATE.DataPropertyName = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.HeaderText = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.Name = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.ReadOnly = True
        '
        'ProveedoresBL
        '
        Me.ProveedoresBL.DataSetName = "DSProveedores"
        Me.ProveedoresBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FRMBrowseProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(621, 450)
        Me.Controls.Add(Me.DgvProveedores)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Name = "FRMBrowseProveedores"
        Me.Text = "Busqueda de Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DtpFechaFinal As DateTimePicker
    Friend WithEvents DtpFechaInicio As DateTimePicker
    Friend WithEvents ChkFecha As CheckBox
    Friend WithEvents TxtNombre As Componentes.TextBoxEx
    Friend WithEvents ChkNombre As CheckBox
    Friend WithEvents TxtCveProveedor As Componentes.TextBoxEx
    Friend WithEvents ChkCveProveedor As CheckBox
    Friend WithEvents DgvProveedores As DataGridView
    Friend WithEvents ProveedoresBL As NEGOCIOS.ProveedoresBL
    Friend WithEvents CVE_PROVEEDOR_VAR As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_VAR As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOS_VAR As DataGridViewTextBoxColumn
    Friend WithEvents RAZON_SOCIAL_VAR As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONO_VAR As DataGridViewTextBoxColumn
    Friend WithEvents CORREO_VAR As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_ALTA_DATE As DataGridViewTextBoxColumn
End Class
