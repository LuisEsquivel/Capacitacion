<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RolesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatálogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CotizacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucursalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CotizacionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosBL = New NEGOCIOS.UsuariosBL()
        Me.PermisosBL = New NEGOCIOS.PermisosBL()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New Componentes.TextBoxEx()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.UsuariosBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisosBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.CatálogosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccesosToolStripMenuItem, Me.CambiarDeUsuarioToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'AccesosToolStripMenuItem
        '
        Me.AccesosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RolesToolStripMenuItem1, Me.UsuariosToolStripMenuItem, Me.PermisosToolStripMenuItem})
        Me.AccesosToolStripMenuItem.Name = "AccesosToolStripMenuItem"
        Me.AccesosToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AccesosToolStripMenuItem.Text = "Accesos"
        '
        'RolesToolStripMenuItem1
        '
        Me.RolesToolStripMenuItem1.Name = "RolesToolStripMenuItem1"
        Me.RolesToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.RolesToolStripMenuItem1.Text = "Roles"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.PermisosToolStripMenuItem.Text = "Permisos"
        '
        'CambiarDeUsuarioToolStripMenuItem
        '
        Me.CambiarDeUsuarioToolStripMenuItem.Name = "CambiarDeUsuarioToolStripMenuItem"
        Me.CambiarDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CambiarDeUsuarioToolStripMenuItem.Text = "Cambiar de usuario"
        '
        'CatálogosToolStripMenuItem
        '
        Me.CatálogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.VentasToolStripMenuItem, Me.CotizacionesToolStripMenuItem, Me.SucursalesToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ClientesToolStripMenuItem})
        Me.CatálogosToolStripMenuItem.Name = "CatálogosToolStripMenuItem"
        Me.CatálogosToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.CatálogosToolStripMenuItem.Text = "Catálogos"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'CotizacionesToolStripMenuItem
        '
        Me.CotizacionesToolStripMenuItem.Name = "CotizacionesToolStripMenuItem"
        Me.CotizacionesToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.CotizacionesToolStripMenuItem.Text = "Cotizaciones"
        '
        'SucursalesToolStripMenuItem
        '
        Me.SucursalesToolStripMenuItem.Name = "SucursalesToolStripMenuItem"
        Me.SucursalesToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.SucursalesToolStripMenuItem.Text = "Sucursales"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem1, Me.CotizacionesToolStripMenuItem1})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'VentasToolStripMenuItem1
        '
        Me.VentasToolStripMenuItem1.Name = "VentasToolStripMenuItem1"
        Me.VentasToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
        Me.VentasToolStripMenuItem1.Text = "Ventas"
        '
        'CotizacionesToolStripMenuItem1
        '
        Me.CotizacionesToolStripMenuItem1.Name = "CotizacionesToolStripMenuItem1"
        Me.CotizacionesToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
        Me.CotizacionesToolStripMenuItem1.Text = "Cotizaciones"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'UsuariosBL
        '
        Me.UsuariosBL.DataSetName = "DSUsuarios"
        Me.UsuariosBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PermisosBL
        '
        Me.PermisosBL.DataSetName = "DSPermisos"
        Me.PermisosBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario: "
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BackColor = System.Drawing.Color.White
        Me.TxtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUsuario.Enabled = False
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(81, 32)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(104, 25)
        Me.TxtUsuario.TabIndex = 4
        Me.TxtUsuario.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'FRMMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cap.My.Resources.Resources.novo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FRMMenu"
        Me.Text = "Cap"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.UsuariosBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisosBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatálogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccesosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RolesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CotizacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SucursalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CotizacionesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PermisosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosBL As NEGOCIOS.UsuariosBL
    Friend WithEvents PermisosBL As NEGOCIOS.PermisosBL
    Friend WithEvents CambiarDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtUsuario As Componentes.TextBoxEx
End Class
