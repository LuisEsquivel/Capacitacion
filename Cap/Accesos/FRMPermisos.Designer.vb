<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMPermisos
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
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.CmbRoles = New System.Windows.Forms.ComboBox()
        Me.RolesBL = New NEGOCIOS.RolesBL()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkProveedores = New System.Windows.Forms.CheckBox()
        Me.ChkReporteCotizaciones = New System.Windows.Forms.CheckBox()
        Me.ChkReporteVentas = New System.Windows.Forms.CheckBox()
        Me.ChkSucursales = New System.Windows.Forms.CheckBox()
        Me.ChkProductos = New System.Windows.Forms.CheckBox()
        Me.ChkClientes = New System.Windows.Forms.CheckBox()
        Me.ChkUsuarios = New System.Windows.Forms.CheckBox()
        Me.ChkCotizaciones = New System.Windows.Forms.CheckBox()
        Me.ChkVentas = New System.Windows.Forms.CheckBox()
        Me.ChkPermisos = New System.Windows.Forms.CheckBox()
        Me.ChkRoles = New System.Windows.Forms.CheckBox()
        Me.PermisosBL = New NEGOCIOS.PermisosBL()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        CType(Me.RolesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PermisosBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(341, 12)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(66, 76)
        Me.BtnGuardar.TabIndex = 46
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(473, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(66, 76)
        Me.BtnSalir.TabIndex = 48
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'CmbRoles
        '
        Me.CmbRoles.DataSource = Me.RolesBL
        Me.CmbRoles.DisplayMember = "TBLROLES.NOMBRE_ROL_VAR"
        Me.CmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRoles.FormattingEnabled = True
        Me.CmbRoles.Location = New System.Drawing.Point(12, 41)
        Me.CmbRoles.Name = "CmbRoles"
        Me.CmbRoles.Size = New System.Drawing.Size(206, 21)
        Me.CmbRoles.TabIndex = 49
        Me.CmbRoles.ValueMember = "TBLROLES.CVE_ROL_INT"
        '
        'RolesBL
        '
        Me.RolesBL.DataSetName = "DSRoles"
        Me.RolesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkProveedores)
        Me.GroupBox1.Controls.Add(Me.ChkReporteCotizaciones)
        Me.GroupBox1.Controls.Add(Me.ChkReporteVentas)
        Me.GroupBox1.Controls.Add(Me.ChkSucursales)
        Me.GroupBox1.Controls.Add(Me.ChkProductos)
        Me.GroupBox1.Controls.Add(Me.ChkClientes)
        Me.GroupBox1.Controls.Add(Me.ChkUsuarios)
        Me.GroupBox1.Controls.Add(Me.ChkCotizaciones)
        Me.GroupBox1.Controls.Add(Me.ChkVentas)
        Me.GroupBox1.Controls.Add(Me.ChkPermisos)
        Me.GroupBox1.Controls.Add(Me.ChkRoles)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 242)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = ""
        Me.GroupBox1.Text = "ACCESOS"
        '
        'ChkProveedores
        '
        Me.ChkProveedores.AutoSize = True
        Me.ChkProveedores.Enabled = False
        Me.ChkProveedores.Location = New System.Drawing.Point(373, 20)
        Me.ChkProveedores.Name = "ChkProveedores"
        Me.ChkProveedores.Size = New System.Drawing.Size(108, 17)
        Me.ChkProveedores.TabIndex = 10
        Me.ChkProveedores.Text = "PROVEEDORES"
        Me.ChkProveedores.UseVisualStyleBackColor = True
        '
        'ChkReporteCotizaciones
        '
        Me.ChkReporteCotizaciones.AutoSize = True
        Me.ChkReporteCotizaciones.Enabled = False
        Me.ChkReporteCotizaciones.Location = New System.Drawing.Point(183, 191)
        Me.ChkReporteCotizaciones.Name = "ChkReporteCotizaciones"
        Me.ChkReporteCotizaciones.Size = New System.Drawing.Size(185, 17)
        Me.ChkReporteCotizaciones.TabIndex = 9
        Me.ChkReporteCotizaciones.Text = "REPORTES DE COTIZACIONES"
        Me.ChkReporteCotizaciones.UseVisualStyleBackColor = True
        '
        'ChkReporteVentas
        '
        Me.ChkReporteVentas.AutoSize = True
        Me.ChkReporteVentas.Enabled = False
        Me.ChkReporteVentas.Location = New System.Drawing.Point(183, 150)
        Me.ChkReporteVentas.Name = "ChkReporteVentas"
        Me.ChkReporteVentas.Size = New System.Drawing.Size(149, 17)
        Me.ChkReporteVentas.TabIndex = 8
        Me.ChkReporteVentas.Text = "REPORTES DE VENTAS"
        Me.ChkReporteVentas.UseVisualStyleBackColor = True
        '
        'ChkSucursales
        '
        Me.ChkSucursales.AutoSize = True
        Me.ChkSucursales.Enabled = False
        Me.ChkSucursales.Location = New System.Drawing.Point(183, 106)
        Me.ChkSucursales.Name = "ChkSucursales"
        Me.ChkSucursales.Size = New System.Drawing.Size(98, 17)
        Me.ChkSucursales.TabIndex = 7
        Me.ChkSucursales.Text = "SUCURSALES"
        Me.ChkSucursales.UseVisualStyleBackColor = True
        '
        'ChkProductos
        '
        Me.ChkProductos.AutoSize = True
        Me.ChkProductos.Enabled = False
        Me.ChkProductos.Location = New System.Drawing.Point(183, 61)
        Me.ChkProductos.Name = "ChkProductos"
        Me.ChkProductos.Size = New System.Drawing.Size(94, 17)
        Me.ChkProductos.TabIndex = 6
        Me.ChkProductos.Text = "PRODUCTOS"
        Me.ChkProductos.UseVisualStyleBackColor = True
        '
        'ChkClientes
        '
        Me.ChkClientes.AutoSize = True
        Me.ChkClientes.Enabled = False
        Me.ChkClientes.Location = New System.Drawing.Point(183, 20)
        Me.ChkClientes.Name = "ChkClientes"
        Me.ChkClientes.Size = New System.Drawing.Size(78, 17)
        Me.ChkClientes.TabIndex = 5
        Me.ChkClientes.Text = "CLIENTES"
        Me.ChkClientes.UseVisualStyleBackColor = True
        '
        'ChkUsuarios
        '
        Me.ChkUsuarios.AutoSize = True
        Me.ChkUsuarios.Enabled = False
        Me.ChkUsuarios.Location = New System.Drawing.Point(7, 191)
        Me.ChkUsuarios.Name = "ChkUsuarios"
        Me.ChkUsuarios.Size = New System.Drawing.Size(82, 17)
        Me.ChkUsuarios.TabIndex = 4
        Me.ChkUsuarios.Text = "USUARIOS"
        Me.ChkUsuarios.UseVisualStyleBackColor = True
        '
        'ChkCotizaciones
        '
        Me.ChkCotizaciones.AutoSize = True
        Me.ChkCotizaciones.Enabled = False
        Me.ChkCotizaciones.Location = New System.Drawing.Point(6, 150)
        Me.ChkCotizaciones.Name = "ChkCotizaciones"
        Me.ChkCotizaciones.Size = New System.Drawing.Size(105, 17)
        Me.ChkCotizaciones.TabIndex = 3
        Me.ChkCotizaciones.Text = "COTIZACIONES"
        Me.ChkCotizaciones.UseVisualStyleBackColor = True
        '
        'ChkVentas
        '
        Me.ChkVentas.AutoSize = True
        Me.ChkVentas.Enabled = False
        Me.ChkVentas.Location = New System.Drawing.Point(6, 106)
        Me.ChkVentas.Name = "ChkVentas"
        Me.ChkVentas.Size = New System.Drawing.Size(69, 17)
        Me.ChkVentas.TabIndex = 2
        Me.ChkVentas.Text = "VENTAS"
        Me.ChkVentas.UseVisualStyleBackColor = True
        '
        'ChkPermisos
        '
        Me.ChkPermisos.AutoSize = True
        Me.ChkPermisos.Enabled = False
        Me.ChkPermisos.Location = New System.Drawing.Point(6, 61)
        Me.ChkPermisos.Name = "ChkPermisos"
        Me.ChkPermisos.Size = New System.Drawing.Size(82, 17)
        Me.ChkPermisos.TabIndex = 1
        Me.ChkPermisos.Text = "PERMISOS"
        Me.ChkPermisos.UseVisualStyleBackColor = True
        '
        'ChkRoles
        '
        Me.ChkRoles.AutoSize = True
        Me.ChkRoles.Enabled = False
        Me.ChkRoles.Location = New System.Drawing.Point(7, 20)
        Me.ChkRoles.Name = "ChkRoles"
        Me.ChkRoles.Size = New System.Drawing.Size(62, 17)
        Me.ChkRoles.TabIndex = 0
        Me.ChkRoles.Text = "ROLES"
        Me.ChkRoles.UseVisualStyleBackColor = True
        '
        'PermisosBL
        '
        Me.PermisosBL.DataSetName = "DSPermisos"
        Me.PermisosBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(276, 12)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(66, 76)
        Me.BtnNuevo.TabIndex = 51
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(407, 12)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(66, 76)
        Me.BtnCancelar.TabIndex = 52
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FRMPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(551, 357)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmbRoles)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Name = "FRMPermisos"
        Me.Text = "Permisos"
        CType(Me.RolesBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PermisosBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents CmbRoles As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ChkReporteCotizaciones As CheckBox
    Friend WithEvents ChkReporteVentas As CheckBox
    Friend WithEvents ChkSucursales As CheckBox
    Friend WithEvents ChkProductos As CheckBox
    Friend WithEvents ChkClientes As CheckBox
    Friend WithEvents ChkUsuarios As CheckBox
    Friend WithEvents ChkCotizaciones As CheckBox
    Friend WithEvents ChkVentas As CheckBox
    Friend WithEvents ChkPermisos As CheckBox
    Friend WithEvents ChkRoles As CheckBox
    Friend WithEvents RolesBL As NEGOCIOS.RolesBL
    Friend WithEvents PermisosBL As NEGOCIOS.PermisosBL
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents ChkProveedores As CheckBox
End Class
