<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMBrowseRoles
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCveRolFinal = New Componentes.TextBoxEx()
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.ChkFecha = New System.Windows.Forms.CheckBox()
        Me.TxtNombreRol = New Componentes.TextBoxEx()
        Me.ChkNombreRol = New System.Windows.Forms.CheckBox()
        Me.TxtCveRolInicial = New Componentes.TextBoxEx()
        Me.ChkCveRol = New System.Windows.Forms.CheckBox()
        Me.DgvRoles = New System.Windows.Forms.DataGridView()
        Me.RolesBL = New NEGOCIOS.RolesBL()
        Me.CVE_ROL_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_ROL_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CVE_USUARIO_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_ALTA_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(372, 12)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(66, 76)
        Me.BtnBuscar.TabIndex = 27
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(444, 12)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(66, 76)
        Me.BtnRegresar.TabIndex = 26
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCveRolFinal)
        Me.GroupBox1.Controls.Add(Me.DtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.DtpFechaInicial)
        Me.GroupBox1.Controls.Add(Me.ChkFecha)
        Me.GroupBox1.Controls.Add(Me.TxtNombreRol)
        Me.GroupBox1.Controls.Add(Me.ChkNombreRol)
        Me.GroupBox1.Controls.Add(Me.TxtCveRolInicial)
        Me.GroupBox1.Controls.Add(Me.ChkCveRol)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 102)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'TxtCveRolFinal
        '
        Me.TxtCveRolFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveRolFinal.Enabled = False
        Me.TxtCveRolFinal.Location = New System.Drawing.Point(179, 17)
        Me.TxtCveRolFinal.Name = "TxtCveRolFinal"
        Me.TxtCveRolFinal.Size = New System.Drawing.Size(96, 20)
        Me.TxtCveRolFinal.TabIndex = 7
        Me.TxtCveRolFinal.Text = "0"
        Me.TxtCveRolFinal.TipoDato = Componentes.Enumeraciones.TipoDatos.Entero
        '
        'DtpFechaFinal
        '
        Me.DtpFechaFinal.Enabled = False
        Me.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFinal.Location = New System.Drawing.Point(179, 73)
        Me.DtpFechaFinal.Name = "DtpFechaFinal"
        Me.DtpFechaFinal.Size = New System.Drawing.Size(96, 20)
        Me.DtpFechaFinal.TabIndex = 6
        '
        'DtpFechaInicial
        '
        Me.DtpFechaInicial.Enabled = False
        Me.DtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicial.Location = New System.Drawing.Point(77, 73)
        Me.DtpFechaInicial.Name = "DtpFechaInicial"
        Me.DtpFechaInicial.Size = New System.Drawing.Size(96, 20)
        Me.DtpFechaInicial.TabIndex = 5
        '
        'ChkFecha
        '
        Me.ChkFecha.AutoSize = True
        Me.ChkFecha.Location = New System.Drawing.Point(6, 73)
        Me.ChkFecha.Name = "ChkFecha"
        Me.ChkFecha.Size = New System.Drawing.Size(56, 17)
        Me.ChkFecha.TabIndex = 4
        Me.ChkFecha.Text = "Fecha"
        Me.ChkFecha.UseVisualStyleBackColor = True
        '
        'TxtNombreRol
        '
        Me.TxtNombreRol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreRol.Enabled = False
        Me.TxtNombreRol.Location = New System.Drawing.Point(77, 43)
        Me.TxtNombreRol.Name = "TxtNombreRol"
        Me.TxtNombreRol.Size = New System.Drawing.Size(198, 20)
        Me.TxtNombreRol.TabIndex = 3
        Me.TxtNombreRol.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'ChkNombreRol
        '
        Me.ChkNombreRol.AutoSize = True
        Me.ChkNombreRol.Location = New System.Drawing.Point(6, 46)
        Me.ChkNombreRol.Name = "ChkNombreRol"
        Me.ChkNombreRol.Size = New System.Drawing.Size(63, 17)
        Me.ChkNombreRol.TabIndex = 2
        Me.ChkNombreRol.Text = "Nombre"
        Me.ChkNombreRol.UseVisualStyleBackColor = True
        '
        'TxtCveRolInicial
        '
        Me.TxtCveRolInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveRolInicial.Enabled = False
        Me.TxtCveRolInicial.Location = New System.Drawing.Point(77, 17)
        Me.TxtCveRolInicial.Name = "TxtCveRolInicial"
        Me.TxtCveRolInicial.Size = New System.Drawing.Size(96, 20)
        Me.TxtCveRolInicial.TabIndex = 1
        Me.TxtCveRolInicial.Text = "0"
        Me.TxtCveRolInicial.TipoDato = Componentes.Enumeraciones.TipoDatos.Entero
        '
        'ChkCveRol
        '
        Me.ChkCveRol.AutoSize = True
        Me.ChkCveRol.Location = New System.Drawing.Point(7, 20)
        Me.ChkCveRol.Name = "ChkCveRol"
        Me.ChkCveRol.Size = New System.Drawing.Size(64, 17)
        Me.ChkCveRol.TabIndex = 0
        Me.ChkCveRol.Text = "Cve Rol"
        Me.ChkCveRol.UseVisualStyleBackColor = True
        '
        'DgvRoles
        '
        Me.DgvRoles.AllowUserToAddRows = False
        Me.DgvRoles.AllowUserToDeleteRows = False
        Me.DgvRoles.AutoGenerateColumns = False
        Me.DgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRoles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_ROL_INT, Me.NOMBRE_ROL_VAR, Me.CVE_USUARIO_VAR, Me.FECHA_ALTA_DATE})
        Me.DgvRoles.DataSource = Me.RolesBL.TBLROLES
        Me.DgvRoles.Location = New System.Drawing.Point(13, 139)
        Me.DgvRoles.Name = "DgvRoles"
        Me.DgvRoles.ReadOnly = True
        Me.DgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvRoles.Size = New System.Drawing.Size(497, 268)
        Me.DgvRoles.TabIndex = 29
        '
        'RolesBL
        '
        Me.RolesBL.DataSetName = "DSRoles"
        Me.RolesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CVE_ROL_INT
        '
        Me.CVE_ROL_INT.DataPropertyName = "CVE_ROL_INT"
        Me.CVE_ROL_INT.HeaderText = "CVE_ROL_INT"
        Me.CVE_ROL_INT.Name = "CVE_ROL_INT"
        Me.CVE_ROL_INT.ReadOnly = True
        '
        'NOMBRE_ROL_VAR
        '
        Me.NOMBRE_ROL_VAR.DataPropertyName = "NOMBRE_ROL_VAR"
        Me.NOMBRE_ROL_VAR.HeaderText = "NOMBRE_ROL_VAR"
        Me.NOMBRE_ROL_VAR.Name = "NOMBRE_ROL_VAR"
        Me.NOMBRE_ROL_VAR.ReadOnly = True
        Me.NOMBRE_ROL_VAR.Width = 150
        '
        'CVE_USUARIO_VAR
        '
        Me.CVE_USUARIO_VAR.DataPropertyName = "CVE_USUARIO_VAR"
        Me.CVE_USUARIO_VAR.HeaderText = "CVE_USUARIO_VAR"
        Me.CVE_USUARIO_VAR.Name = "CVE_USUARIO_VAR"
        Me.CVE_USUARIO_VAR.ReadOnly = True
        '
        'FECHA_ALTA_DATE
        '
        Me.FECHA_ALTA_DATE.DataPropertyName = "FECHA_ALTA_DATE"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FECHA_ALTA_DATE.DefaultCellStyle = DataGridViewCellStyle1
        Me.FECHA_ALTA_DATE.HeaderText = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.Name = "FECHA_ALTA_DATE"
        Me.FECHA_ALTA_DATE.ReadOnly = True
        '
        'FRMBrowseRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(518, 428)
        Me.Controls.Add(Me.DgvRoles)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Name = "FRMBrowseRoles"
        Me.Text = "Busqueda De Roles"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolesBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvRoles As DataGridView
    Friend WithEvents RolesBL As NEGOCIOS.RolesBL
    Friend WithEvents DtpFechaFinal As DateTimePicker
    Friend WithEvents DtpFechaInicial As DateTimePicker
    Friend WithEvents ChkFecha As CheckBox
    Friend WithEvents TxtNombreRol As Componentes.TextBoxEx
    Friend WithEvents ChkNombreRol As CheckBox
    Friend WithEvents TxtCveRolInicial As Componentes.TextBoxEx
    Friend WithEvents ChkCveRol As CheckBox
    Friend WithEvents TxtCveRolFinal As Componentes.TextBoxEx
    Friend WithEvents CVE_ROL_INT As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_ROL_VAR As DataGridViewTextBoxColumn
    Friend WithEvents CVE_USUARIO_VAR As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_ALTA_DATE As DataGridViewTextBoxColumn
End Class
