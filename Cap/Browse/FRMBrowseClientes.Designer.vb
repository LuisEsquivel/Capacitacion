<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMBrowseClientes
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
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCveClienteFinal = New Componentes.TextBoxEx()
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.ChkFecha = New System.Windows.Forms.CheckBox()
        Me.TxtNombre = New Componentes.TextBoxEx()
        Me.ChkNombre = New System.Windows.Forms.CheckBox()
        Me.TxtCveClienteInicial = New Componentes.TextBoxEx()
        Me.ChkCveCliente = New System.Windows.Forms.CheckBox()
        Me.DgvClientes = New System.Windows.Forms.DataGridView()
        Me.ClientesBL = New NEGOCIOS.ClientesBL()
        Me.CVE_CLIENTE_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONO_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RFC_VAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_ALTA_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(469, 27)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(66, 76)
        Me.BtnBuscar.TabIndex = 29
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(537, 27)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(66, 76)
        Me.BtnRegresar.TabIndex = 28
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCveClienteFinal)
        Me.GroupBox1.Controls.Add(Me.DtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.DtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.ChkFecha)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.ChkNombre)
        Me.GroupBox1.Controls.Add(Me.TxtCveClienteInicial)
        Me.GroupBox1.Controls.Add(Me.ChkCveCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 102)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'TxtCveClienteFinal
        '
        Me.TxtCveClienteFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveClienteFinal.Enabled = False
        Me.TxtCveClienteFinal.Location = New System.Drawing.Point(201, 18)
        Me.TxtCveClienteFinal.Name = "TxtCveClienteFinal"
        Me.TxtCveClienteFinal.Size = New System.Drawing.Size(95, 20)
        Me.TxtCveClienteFinal.TabIndex = 7
        Me.TxtCveClienteFinal.Text = "0"
        Me.TxtCveClienteFinal.TipoDato = Componentes.Enumeraciones.TipoDatos.Entero
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
        'TxtCveClienteInicial
        '
        Me.TxtCveClienteInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCveClienteInicial.Enabled = False
        Me.TxtCveClienteInicial.Location = New System.Drawing.Point(93, 17)
        Me.TxtCveClienteInicial.Name = "TxtCveClienteInicial"
        Me.TxtCveClienteInicial.Size = New System.Drawing.Size(102, 20)
        Me.TxtCveClienteInicial.TabIndex = 1
        Me.TxtCveClienteInicial.Text = "0"
        Me.TxtCveClienteInicial.TipoDato = Componentes.Enumeraciones.TipoDatos.Entero
        '
        'ChkCveCliente
        '
        Me.ChkCveCliente.AutoSize = True
        Me.ChkCveCliente.Location = New System.Drawing.Point(7, 20)
        Me.ChkCveCliente.Name = "ChkCveCliente"
        Me.ChkCveCliente.Size = New System.Drawing.Size(80, 17)
        Me.ChkCveCliente.TabIndex = 0
        Me.ChkCveCliente.Text = "Cve Cliente"
        Me.ChkCveCliente.UseVisualStyleBackColor = True
        '
        'DgvClientes
        '
        Me.DgvClientes.AllowUserToAddRows = False
        Me.DgvClientes.AllowUserToDeleteRows = False
        Me.DgvClientes.AutoGenerateColumns = False
        Me.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVE_CLIENTE_INT, Me.NOMBRE_VAR, Me.TELEFONO_VAR, Me.RFC_VAR, Me.FECHA_ALTA_DATE})
        Me.DgvClientes.DataSource = Me.ClientesBL.TBLCLIENTE
        Me.DgvClientes.Location = New System.Drawing.Point(13, 120)
        Me.DgvClientes.Name = "DgvClientes"
        Me.DgvClientes.ReadOnly = True
        Me.DgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvClientes.Size = New System.Drawing.Size(596, 318)
        Me.DgvClientes.TabIndex = 31
        '
        'ClientesBL
        '
        Me.ClientesBL.DataSetName = "DSClientes"
        Me.ClientesBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CVE_CLIENTE_INT
        '
        Me.CVE_CLIENTE_INT.DataPropertyName = "CVE_CLIENTE_INT"
        Me.CVE_CLIENTE_INT.HeaderText = "CVE_CLIENTE_INT"
        Me.CVE_CLIENTE_INT.Name = "CVE_CLIENTE_INT"
        Me.CVE_CLIENTE_INT.ReadOnly = True
        '
        'NOMBRE_VAR
        '
        Me.NOMBRE_VAR.DataPropertyName = "NOMBRE_VAR"
        Me.NOMBRE_VAR.HeaderText = "NOMBRE_VAR"
        Me.NOMBRE_VAR.Name = "NOMBRE_VAR"
        Me.NOMBRE_VAR.ReadOnly = True
        Me.NOMBRE_VAR.Width = 150
        '
        'TELEFONO_VAR
        '
        Me.TELEFONO_VAR.DataPropertyName = "TELEFONO_VAR"
        Me.TELEFONO_VAR.HeaderText = "TELEFONO_VAR"
        Me.TELEFONO_VAR.Name = "TELEFONO_VAR"
        Me.TELEFONO_VAR.ReadOnly = True
        '
        'RFC_VAR
        '
        Me.RFC_VAR.DataPropertyName = "RFC_VAR"
        Me.RFC_VAR.HeaderText = "RFC_VAR"
        Me.RFC_VAR.Name = "RFC_VAR"
        Me.RFC_VAR.ReadOnly = True
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
        'FRMBrowseClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(621, 450)
        Me.Controls.Add(Me.DgvClientes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Name = "FRMBrowseClientes"
        Me.Text = "Busqueda De Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvClientes As DataGridView
    Friend WithEvents ClientesBL As NEGOCIOS.ClientesBL
    Friend WithEvents DtpFechaFinal As DateTimePicker
    Friend WithEvents DtpFechaInicio As DateTimePicker
    Friend WithEvents ChkFecha As CheckBox
    Friend WithEvents TxtNombre As Componentes.TextBoxEx
    Friend WithEvents ChkNombre As CheckBox
    Friend WithEvents TxtCveClienteInicial As Componentes.TextBoxEx
    Friend WithEvents ChkCveCliente As CheckBox
    Friend WithEvents TxtCveClienteFinal As Componentes.TextBoxEx
    Friend WithEvents CVE_CLIENTE_INT As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_VAR As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONO_VAR As DataGridViewTextBoxColumn
    Friend WithEvents RFC_VAR As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_ALTA_DATE As DataGridViewTextBoxColumn
End Class
