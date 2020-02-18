<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMBrowseUsuarios
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
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.ChkFecha = New System.Windows.Forms.CheckBox()
        Me.TxtNombre = New Componentes.TextBoxEx()
        Me.ChkNombre = New System.Windows.Forms.CheckBox()
        Me.TxtCveUsuario = New Componentes.TextBoxEx()
        Me.ChkCveUsuario = New System.Windows.Forms.CheckBox()
        Me.DgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.UsuariosBL = New NEGOCIOS.UsuariosBL()
        Me.CVE_USUARIO_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_USUARIO_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPARTAMENTO_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_ALTA_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(379, 27)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(66, 76)
        Me.BtnBuscar.TabIndex = 31
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(447, 27)
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
        Me.GroupBox1.Controls.Add(Me.TxtCveUsuario)
        Me.GroupBox1.Controls.Add(Me.ChkCveUsuario)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 12)
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
        'TxtCveUsuario
        '
        Me.TxtCveUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveUsuario.Enabled = False
        Me.TxtCveUsuario.Location = New System.Drawing.Point(93, 17)
        Me.TxtCveUsuario.Name = "TxtCveUsuario"
        Me.TxtCveUsuario.Size = New System.Drawing.Size(102, 20)
        Me.TxtCveUsuario.TabIndex = 1
        Me.TxtCveUsuario.TipoDato = Componentes.Enumeraciones.TipoDatos.Libre
        '
        'ChkCveUsuario
        '
        Me.ChkCveUsuario.AutoSize = True
        Me.ChkCveUsuario.Location = New System.Drawing.Point(7, 20)
        Me.ChkCveUsuario.Name = "ChkCveUsuario"
        Me.ChkCveUsuario.Size = New System.Drawing.Size(84, 17)
        Me.ChkCveUsuario.TabIndex = 0
        Me.ChkCveUsuario.Text = "Cve Usuario"
        Me.ChkCveUsuario.UseVisualStyleBackColor = True
        '
        'DgvUsuarios
        '
        Me.DgvUsuarios.AllowUserToAddRows = False
        Me.DgvUsuarios.AllowUserToDeleteRows = False
        Me.DgvUsuarios.AutoGenerateColumns = False
        Me.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_USUARIO_VAR, Me.NOMBRE_USUARIO_VAR, Me.DEPARTAMENTO_VAR, Me.FECHA_ALTA_DATE})
        Me.DgvUsuarios.DataSource = Me.UsuariosBL.TBLUSUARIOS
        Me.DgvUsuarios.Location = New System.Drawing.Point(19, 141)
        Me.DgvUsuarios.Name = "DgvUsuarios"
        Me.DgvUsuarios.ReadOnly = True
        Me.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvUsuarios.Size = New System.Drawing.Size(494, 300)
        Me.DgvUsuarios.TabIndex = 33
        '
        'UsuariosBL
        '
        Me.UsuariosBL.DataSetName = "DSUsuarios"
        Me.UsuariosBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CVE_USUARIO_VAR
        '
        Me.CVE_USUARIO_VAR.DataPropertyName = "CVE_USUARIO_VAR"
        Me.CVE_USUARIO_VAR.HeaderText = "CVE_USUARIO_VAR"
        Me.CVE_USUARIO_VAR.Name = "CVE_USUARIO_VAR"
        Me.CVE_USUARIO_VAR.ReadOnly = True
        '
        'NOMBRE_USUARIO_VAR
        '
        Me.NOMBRE_USUARIO_VAR.DataPropertyName = "NOMBRE_USUARIO_VAR"
        Me.NOMBRE_USUARIO_VAR.HeaderText = "NOMBRE_USUARIO_VAR"
        Me.NOMBRE_USUARIO_VAR.Name = "NOMBRE_USUARIO_VAR"
        Me.NOMBRE_USUARIO_VAR.ReadOnly = True
        Me.NOMBRE_USUARIO_VAR.Width = 150
        '
        'DEPARTAMENTO_VAR
        '
        Me.DEPARTAMENTO_VAR.DataPropertyName = "DEPARTAMENTO_VAR"
        Me.DEPARTAMENTO_VAR.HeaderText = "DEPARTAMENTO_VAR"
        Me.DEPARTAMENTO_VAR.Name = "DEPARTAMENTO_VAR"
        Me.DEPARTAMENTO_VAR.ReadOnly = True
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
        'FRMBrowseUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(533, 453)
        Me.Controls.Add(Me.DgvUsuarios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Name = "FRMBrowseUsuarios"
        Me.Text = "Busqueda de Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBL, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TxtCveUsuario As Componentes.TextBoxEx
    Friend WithEvents ChkCveUsuario As CheckBox
    Friend WithEvents DgvUsuarios As DataGridView
    Friend WithEvents UsuariosBL As NEGOCIOS.UsuariosBL
    Friend WithEvents CVE_USUARIO_VAR As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_USUARIO_VAR As DataGridViewTextBoxColumn
    Friend WithEvents DEPARTAMENTO_VAR As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_ALTA_DATE As DataGridViewTextBoxColumn
End Class
