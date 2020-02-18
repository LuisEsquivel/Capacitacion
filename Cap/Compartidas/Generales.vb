Public Class Generales

    Public Shared Nombre_Empresa As String = ""
    Public Shared RutaEmpresa As String = ""
    Public Shared CveEmpresa As Int32 = 0
    Public Shared IVA_Producto As Decimal = 0
    Public Shared Ret_ISR As Decimal = 0
    Public Shared Ret_IVA As Decimal = 0

    Public Shared g_TituloMesageBox As String = "Novosys TI S.A. de C.V."

    ''Para formatear las cajas de texto o datagridview
    Public Shared Moneda As String = "$ ###,###,###,##0.00"
    Public Shared Moneda4Decimales As String = "$ ###,###,###,##0.0000"
    Public Shared Entero As String = "###,###,###,##0"
    Public Shared Prcentaje As String = "###.## %"
    Public Shared FechaGrid As String = "dd/MM/yyyy"
    '-----------------------------------------------------

    'Sirve para los permisos del usuario Bitacora
    'Public Shared PERMISOS As New NEGOCIOS.Relacion_Perfil_Proceso
    'PERFIL DEL EMPLEADO
    Public Shared CVE_PERFIL_INT As Integer = 0
    Public Shared CVE_EMPLEADO As String = "RTREVINO"
    Public Shared Mes_de_Trabajo As Integer = 0
    Public Shared Anio_de_Trabajo As Integer = 0
    Public Shared ColorBtn As Int16 = 0
    'Public Shared RutaFactElectronica As String = System.Configuration.ConfigurationManager.AppSettings("XMLFactElectronica")

    'Variables de Factura Electronica
    Public Shared ProcesamientodeFacturaElectronicaTiempoReal As Boolean = True
    Public Shared TiempodeBusquedadePDFyXML As Int16


    'Public Shared ColorBtn As ColorBotones = System.Configuration.ConfigurationManager.AppSettings("ColorBtn")
    Public Shared ReadOnly pathFotosProductos As String = ""
    'System.Configuration.ConfigurationManager.AppSettings("FotosProductos")
    Public Shared ReadOnly BtnImageNuevo As String = "Nuevo.jpg"
    Public Shared ReadOnly BtnImageModificar As String = "Modificar.jpg"
    Public Shared ReadOnly BtnImageGuardar As String = "Grabar.jpg"
    Public Shared ReadOnly BtnImageCancelar As String = "Cancelar.jpg"
    Public Shared ReadOnly BtnImageBuscar As String = "Buscar.jpg"
    Public Shared ReadOnly BtnImageImprimir As String = "Imprimir.jpg"
    Public Shared ReadOnly BtnImageExcel As String = "Excel.jpg"
    Public Shared ReadOnly BtnImageSalir As String = "Salir.jpg"
    Public Shared ReadOnly BtnIniciar As String = "Iniciar.jpg"
    Public Shared ReadOnly BtnBajas As String = "Bajas.jpg"
    Public Shared ReadOnly BtnBorrar As String = "Borrar.jpg"
    Public Shared ReadOnly btnRegresar As String = "Regresar.jpg"
    Public Shared ReadOnly BtnAgregar As String = "AGREGAR.jpg"


    Private Declare Function GetSystemMenu Lib "user32" (ByVal hwnd As Integer, ByVal bRevert As Integer) As Integer
    Private Declare Function RemoveMenu Lib "user32" (ByVal hMenu As Integer, ByVal nPosition As Integer, ByVal wFlags As Integer) As Integer
    Private Const SC_CLOSE = &HF060&
    Private Const MF_BYCOMMAND = &H0&
    Public Shared Function RemoveXButton(ByVal iHWND As Integer) As Integer
        Dim iSysMenu As Integer
        iSysMenu = GetSystemMenu(iHWND, False)
        Return RemoveMenu(iSysMenu, SC_CLOSE, MF_BYCOMMAND)
    End Function

    Public Shared Function Buscar_Formularios_Activos(ByVal Formulario As Form)
        Dim FormulariosActivos As Integer
        For Each Forms As Form In Formulario.MdiChildren
            FormulariosActivos = FormulariosActivos + 1
        Next
        If FormulariosActivos > 0 Then
            Dim Opcion = MsgBox("Se encontraron Formularios Activos" + vbCrLf + _
                                "¿Desea Cerrarlos?" + vbCrLf + _
                                "NO SE GUARDARAN LOS CAMBIOS REALIZADOS", MsgBoxStyle.YesNo, "Aviso")
            If Opcion = MsgBoxResult.Yes Then
                Cerrar_Formularios_Activos(Formulario)
                Return False
            Else
                MsgBox("Los Formularios Deben cerrarse antes de salir del sistema", MsgBoxStyle.Information, "Aviso")
                Return True
            End If
        Else
            Return False
        End If
    End Function
    Private Shared Sub Cerrar_Formularios_Activos(ByVal Formulario As Form)
        For Each Forms As Form In Formulario.MdiChildren
            Forms.Close()
        Next
    End Sub
    Public Shared Sub HabilitarBotones(ByRef forma As Form, ByVal Estado As EstadoBotones)
        Select Case Estado
            Case EstadoBotones.Inicial

                If forma.Controls("btnnuevo") IsNot Nothing Then
                    CType(forma.Controls("btnnuevo"), Button).Enabled = True
                End If
                If forma.Controls("btnbajas") IsNot Nothing Then
                    CType(forma.Controls("btnbajas"), Button).Enabled = False
                End If
                If forma.Controls("btnBorrar") IsNot Nothing Then
                    CType(forma.Controls("btnBorrar"), Button).Enabled = True
                End If
                If forma.Controls("btnguardar") IsNot Nothing Then
                    CType(forma.Controls("btnguardar"), Button).Enabled = False
                End If
                If forma.Controls("btncancelar") IsNot Nothing Then
                    CType(forma.Controls("btncancelar"), Button).Enabled = False
                End If
                If forma.Controls("btnmodificar") IsNot Nothing Then
                    CType(forma.Controls("btnmodificar"), Button).Enabled = True
                End If
                If forma.Controls("btnsalir") IsNot Nothing Then
                    CType(forma.Controls("btnsalir"), Button).Enabled = True
                End If

                If forma.Controls("btnexcel") IsNot Nothing Then
                    CType(forma.Controls("btnexcel"), Button).Enabled = True
                End If
                If forma.Controls("btnbuscar") IsNot Nothing Then
                    CType(forma.Controls("btnbuscar"), Button).Enabled = True
                End If

            Case EstadoBotones.Modificar, EstadoBotones.Nuevo
                If forma.Controls("btnnuevo") IsNot Nothing Then
                    CType(forma.Controls("btnnuevo"), Button).Enabled = False
                End If
                If forma.Controls("btnBorrar") IsNot Nothing Then
                    CType(forma.Controls("btnBorrar"), Button).Enabled = False
                End If
                If forma.Controls("btnguardar") IsNot Nothing Then
                    CType(forma.Controls("btnguardar"), Button).Enabled = True
                End If
                If forma.Controls("btnmodificar") IsNot Nothing Then
                    CType(forma.Controls("btnmodificar"), Button).Enabled = False
                End If
                CType(forma.Controls("btncancelar"), Button).Enabled = True
                CType(forma.Controls("btnsalir"), Button).Enabled = False
                If forma.Controls("btnexcel") IsNot Nothing Then
                    CType(forma.Controls("btnexcel"), Button).Enabled = False
                End If
                If forma.Controls("btnbuscar") IsNot Nothing Then
                    CType(forma.Controls("btnbuscar"), Button).Enabled = False
                End If
            Case EstadoBotones.Buscar
                CType(forma.Controls("btnnuevo"), Button).Enabled = False
                CType(forma.Controls("btnguardar"), Button).Enabled = True
                If forma.Controls("btnmodificar") IsNot Nothing Then
                    CType(forma.Controls("btnmodificar"), Button).Enabled = False
                End If
                If forma.Controls("btnBorrar") IsNot Nothing Then
                    CType(forma.Controls("btnBorrar"), Button).Enabled = False
                End If
                CType(forma.Controls("btncancelar"), Button).Enabled = True
                CType(forma.Controls("btnsalir"), Button).Enabled = False
                If forma.Controls("btnexcel") IsNot Nothing Then
                    CType(forma.Controls("btnexcel"), Button).Enabled = False
                End If
                CType(forma.Controls("btnbuscar"), Button).Enabled = False
        End Select
    End Sub
    Public Shared Function BotonesFocused(ByRef forma As Form) As Boolean
        If CType(forma.Controls("btnnuevo"), Button).Focused = True Then
            Return True
        End If
        'If CType(forma.Controls("btnguardar"), Button).Focused = True Then
        '    Return True
        'End If
        If CType(forma.Controls("btncancelar"), Button).Focused = True Then
            Return True
        End If
        If CType(forma.Controls("btnsalir"), Button).Focused = True Then
            Return True
        End If
        If forma.Controls("btnmodificar") IsNot Nothing Then
            If CType(forma.Controls("btnmodificar"), Button).Focused = True Then
                Return True
            End If
        End If
        If forma.Controls("btnexcel") IsNot Nothing Then
            If CType(forma.Controls("btnexcel"), Button).Focused = True Then
                Return True
            End If
        End If
        If forma.Controls("btnbuscar") IsNot Nothing Then
            If CType(forma.Controls("btnbuscar"), Button).Focused = True Then
                Return True
            End If
        End If
        If forma.Controls("BtnCancelarDocumento") IsNot Nothing Then
            If CType(forma.Controls("BtnCancelarDocumento"), Button).Focused = True Then
                Return True
            End If
        End If
        If forma.Controls("btnImprimir") IsNot Nothing Then
            If CType(forma.Controls("btnImprimir"), Button).Focused = True Then
                Return True
            End If
        End If
        Return False
    End Function
    Public Shared Function ValidarTeclaDecimal(ByVal caja As TextBox, ByVal caracter As Char) As Boolean
        If (Char.IsDigit(caracter) Or caracter = Chr(8) Or caracter = ".") Then
            If caracter = "." Then
                If caja.Text.IndexOf(caracter) > -1 Then
                    Return True
                End If
            End If
        Else
            Return True
        End If
        Return False
    End Function
    Public Shared Sub ConfiguracionBotones(ByVal forma As Form, ByVal Color As ColorBotones)

        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\BOTONES\" & CInt(Color)) Then
            Dim directorio As String = My.Application.Info.DirectoryPath & "\BOTONES\" & CInt(Color) & "\"
            If forma.Controls("btnagregar") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnAgregar) Then
                    CType(forma.Controls("btnagregar"), Button).Image = Bitmap.FromFile(directorio & BtnAgregar)
                End If
            End If
            If forma.Controls("btnnuevo") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnImageNuevo) Then
                    CType(forma.Controls("btnnuevo"), Button).Image = Bitmap.FromFile(directorio & BtnImageNuevo)
                End If
            End If

            If forma.Controls("btnbajas") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnBajas) Then
                    CType(forma.Controls("btnbajas"), Button).Image = Bitmap.FromFile(directorio & BtnBajas)
                End If
            End If

            If forma.Controls("btniniciar") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnIniciar) Then
                    CType(forma.Controls("btniniciar"), Button).Image = Bitmap.FromFile(directorio & BtnIniciar)
                End If
            End If

            If forma.Controls("btnregresar") IsNot Nothing Then
                If IO.File.Exists(directorio & btnRegresar) Then
                    CType(forma.Controls("btnregresar"), Button).Image = Bitmap.FromFile(directorio & btnRegresar)
                End If
            End If

            If forma.Controls("btnBorrar") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnBorrar) Then
                    CType(forma.Controls("btnBorrar"), Button).Image = Bitmap.FromFile(directorio & BtnBorrar)
                End If
            End If
            If forma.Controls("btnmodificar") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnImageModificar) Then
                    CType(forma.Controls("btnmodificar"), Button).Image = Bitmap.FromFile(directorio & BtnImageModificar)
                End If
            End If
            If forma.Controls("btnguardar") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnImageGuardar) Then
                    CType(forma.Controls("btnguardar"), Button).Image = Bitmap.FromFile(directorio & BtnImageGuardar)
                End If
            End If
            If forma.Controls("btncancelar") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnImageCancelar) Then
                    CType(forma.Controls("btncancelar"), Button).Image = Bitmap.FromFile(directorio & BtnImageCancelar)
                End If
            End If
            If forma.Controls("btnbuscar") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnImageBuscar) Then
                    CType(forma.Controls("btnbuscar"), Button).Image = Bitmap.FromFile(directorio & BtnImageBuscar)
                End If
            End If
            If forma.Controls("btnImprimir") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnImageImprimir) Then
                    CType(forma.Controls("btnImprimir"), Button).Image = Bitmap.FromFile(directorio & BtnImageImprimir)
                End If
            End If
            If forma.Controls("btnexcel") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnImageExcel) Then
                    CType(forma.Controls("btnexcel"), Button).Image = Bitmap.FromFile(directorio & BtnImageExcel)
                End If
            End If
            If forma.Controls("btnsalir") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnImageSalir) Then
                    CType(forma.Controls("btnsalir"), Button).Image = Bitmap.FromFile(directorio & BtnImageSalir)
                End If
            End If
        End If
    End Sub
    Public Shared Sub ConfigurarForms(ByVal Formulario As Form)
        ConfiguracionBotones(Formulario, Generales.ColorBtn)
        Formulario.MaximizeBox = False
        Formulario.MinimizeBox = False
        Formulario.ShowInTaskbar = False
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        RemoveXButton(Formulario.Handle.ToInt32)
        Formulario.ShowDialog()
    End Sub
    Public Shared Sub LimpiarCombo(ByVal combo As ComboBox)
        If combo.Items.Count > 0 Then
            combo.SelectedValue = 0
        Else
            combo.Text = ""
        End If
    End Sub


    Public Enum EstadoBotones
        Inicial = 1
        Nuevo = 2
        Modificar = 3
        Buscar = 4

    End Enum

    Public Enum Sexo
        Masculino = 1
        Femenino = 0
    End Enum

    Public Enum Usando
        Activo = 1
        Inactivo = 0
    End Enum
    Public Enum EstatusFactura
        Emitida = 1
        Pagada = 2
        ParcialmentePagada = 3
        Cancelada = 4
    End Enum
    Public Enum EstatusProductoFactura
        Emitido = 1
        Devuelto = 2
    End Enum
    Public Enum EstatusDescuento
        Emitida = 1
        Aplicada = 2
        Cancelada = 3
        Parcial = 4
    End Enum
    Public Enum EstatusDescuentoClientes
        SELECCIONE = 0
        EMITIDA = 1
        APLICADA = 2
        PARCIALMENTE_APLICADA = 3
        CANCELADA = 4

    End Enum
    Public Enum EstatusDevolucionProveedores
        SELECCIONE = 0
        EMITIDA = 1
        CANCELADA = 2
        PARCIALMENTE_APLICADA = 3
        APLICADA = 4
    End Enum


    Public Enum EstatusVentas
        Emitida = 1
        Cancelada = 2
        ParcialmenteCancelada = 3
        Pagada = 4
        ParcialmentePagada = 5
    End Enum

    Public Enum EstatusDetalleVentaPago
        Emitida = 1
        Aplicada = 2
        Cancelada = 3
    End Enum

    Public Enum EstatusChequesPosFechados
        SELECCIONE = 0
        Emitido = 1
        Aplicado = 2
        ParcialmenteAplicado = 3
        Cancelado = 4
    End Enum

    Public Enum EstatusEmisionCheques
        Emitido = 1
        Aplicado = 2
        ParcialmenteAplicado = 3
        Cancelado = 4
    End Enum

    Public Enum ColorBotones
        Naranja = 0
        Plata = 1
        Negro = 2
        Azul = 3
        Verde = 4
        Morado = 5
        AzulObscuro = 6
        Rojo = 7
        Violeta = 8
        Beige = 9
        Blanco = 10
    End Enum

    Public Enum TIPO_MODULO_PROVENIENTE_DEP
        Facturas_de_Contado = 1
        Otro_Movmiento_Bancario = 2

    End Enum


    Public Enum EstatusDevolucionClientes
        Emitida = 1
        Cancelada = 2
        Parcial = 3
        Pagada = 4
    End Enum


    Public Enum EstatusNota_Cheq_DevClientes
        Emitida = 1
        Cancelada = 2
        Aplicada = 3
        Parcialmente_Aplicada = 4
    End Enum

    Public Enum EstatusNota_Cheq_DevProveedores
        Emitida = 1
        Cancelada = 2
        Parcialmente_Cancelada = 3
        Aplicada = 4
        Parcialmente_Aplicada = 5
    End Enum

    Public Enum EstatusAplicacion_cobranza
        Aplicada = 1
        Cancelada = 2
    End Enum

    Public Enum EstatusAplicacion_Pagos
        Aplicada = 1
        Cancelada = 2
    End Enum

    Public Enum EstatusNotasVenta
        Emitida = 1
        Cancelada = 2
        Pagada = 3
        Facturada = 4
    End Enum
    Public Enum Tipo_prov
        Fisica = 0
        Moral = 1
    End Enum
    Public Enum Prov_acree
        Proveedor = 1
        Acreedor = 2
    End Enum

    Public Enum Estatus_Dev_prov
        EMITIDA = 1
        CANCELADA = 2
        PARCIALMENTE_APLICADA = 3
        APLICADA = 4

        '1.- Emitida 2.- Aplicada 3.- Cancelada 4.- Parcialmente Aplicada
    End Enum
    Public Enum Estatus_Fact_Prov
        EMITIDA = 1
        SURTIDA = 2
        CANCELADA = 3
        FACTURADA = 4
    End Enum

    Public Enum Estatus_Desc_Dev
        EMITIDA = 1
        APLICADA = 2
        CANCELADA = 3
        PARCIALMENTE_APLICADA = 4

    End Enum

    Public Enum Estatus_Des_Dev_Clte
        EMITIDA = 1
        APLICADA = 2
        PARCIALMENTE_APLICADA = 3
        CANCELADA = 4
    End Enum
    Public Enum Estatus_req_formal
        EMITIDA = 1
        SURTIDA = 2
        CANCELADA = 3
    End Enum
    Public Enum Tipo_Req
        CON_REQUISICION = 1
        DIRECTA = 2
    End Enum
    Public Enum tipo_orden
        DIRECTA = 1
        CON_REQUISICION = 2
    End Enum

    Public Enum mov_banco
        EMITIDO = 1
        CONCILIADO = 2
    End Enum

    Public Enum Entradas
        SELECCIONE = 0
        MERMA = 5
    End Enum
    Public Enum Salidas
        SELECCIONE = 0
        MERMA = 4
    End Enum
    Public Enum ReportesdeProveedores
        SELECCIONE = 0
        INFORMACION_PROVEEDOR = 1
        DIRECTORIO_TELEFONICO = 2
    End Enum

#Region "REPORTES"

    Public Enum ReportesdeVentas
        SELECCIONE = 0
        CONSECUTIVO_DE_FACTURAS = 1
        FACTURAS_DESGLOSADO = 2
        FACTURAS_AGRUPADAS_POR_CLIENTE = 3
        FACTURAS_AGRUPADAS_POR_CLIENTE_DESGLOSADO = 4
        FACTURAS_AGRUPADAS_POR_PRODUCTO = 5
        FACTURAS_AGRUPADAS_POR_TIPO_Y_SUBTIPO_DE_PAGO = 6
        FACTURAS_GLOBALES = 7
        FACTURAS_AGRUPADAS_POR_AGENTE = 8
        VENTAS_NETAS = 9
    End Enum
    Public Enum ReportesdeAlmacen
        SELECCIONE = 0
        MOVIMIENTOS = 1
        EXISTENCIAS = 2
    End Enum

    Public Enum ReportesdeAplicaciondeCobranza
        SELECCIONE = 0
        COBRANZA_DETALLADA_POR_FOLIO = 1

    End Enum

    Public Enum ReportesdeCuentasXCobrar
        SELECCIONE = 0
        CXC_GLOBAL_POR_CLIENTE_ACTUAL = 1
        ANTIGÜEDAD_DE_SALDOS_POR_CLIENTE = 2
        CXC_GLOBAL_CALCULADO = 3
        ANTIGÜEDAD_DE_SALDOS_CALCULADO = 4
        CXC_GLOBAL_POR_CLIENTE_ACTUAL_POR_AGENTE = 6
        ESTADO_DE_CUENTA_CALCULADO = 7
        ESTADO_DE_CUENTA_DETALLADO_CALCULADO = 8

    End Enum

    Public Enum ReportesdePdidosdeCompra
        SELECCIONE = 0
        CONSECUTIVO_DE_PEDIDO_C = 1
        PEDIDO_C_DESGLOSADO = 2
    End Enum
    Public Enum ReportesdeSurtimientoPdidosdeCompra
        SELECCIONE = 0
        CONSECUTIVO_DE_SURTIMIENTO_PEDIDO_C = 1
        SURTIMIENTO_PEDIDO_C_DESGLOSADO = 2
        EXISTENCIAS = 3
        CONSECUTIVO_DESGLOSADO = 4
    End Enum

    Public Enum ReportesdeListasdePrecios
        SELECCIONE = 0
        LISTA_DE_PRECIOS = 1
        LISTA_DE_PRECIOS_VENTAS = 2
    End Enum

    Public Enum ReportesdeTickets
        SELECCIONE = 0
        CONSECUTIVO_TICKETS
        TICKETS_DESGLOSADO = 2
        TICKETS_AGRUPADOS_POR_TIPO_Y_SUBTIPO_DE_PAGO = 3
        TICKETS_AGRUPADOS_X_CLIENTE = 4
        TICKETS_AGRUPADOS_X_CLIENTE_DESGLOSADO = 5
        TICKETS_AGRUPADOS_X_PRODUCTO = 6
        CONSECUTIVO_DESGLOSADO = 7
    End Enum
    Public Enum ReportesdeFletes
        SELECCIONE = 0
        CONTROL_DE_FLETES = 1
    End Enum
    Public Enum ReportesdeDevoluciones
        SELECCIONE = 0
        CONSECUTIVO_DEVOLUCIONES = 1
        CONSECUTIVO_DEVOLUCIONES_DESGLOSADO = 2
    End Enum
    Public Enum ReportesdeRemisiones
        SELECCIONE = 0
        CONSECUTIVO_DE_REMISIONES = 1
        COSTEO_DE_REMISIONES = 2
    End Enum
    Public Enum ReportesdeNotasDeVenta
        SELECCIONE = 0
        CONSECUTIVO_DE_NOTAS_DE_VENTA = 1
        DETALLE_DE_NOTAS_DE_VENTA = 2
        CLIENTES_INACTIVOS = 3
    End Enum


    Public Shared MsgInformation As String = "NOVOSYS"
    Public Shared CVE_USUARIO_VAR As String = "URIEL"
    Public Shared IVA As Decimal = 0.16
    Public Shared ReportPath = "C:\Projects\Cap\Cap\Cap\Reportes\Designs\"
    Public Shared RutaLogo = "C:\Projects\Cap\Cap\Cap\Resources\strange.jpg"
    Public Shared RutaNovo = "C:\Projects\Cap\Cap\Cap\Resources\novo.jpg"

    Public Shared rdlcConsecutivoDeVentas As String = "rdlcConsecutivoVentas.rdlc"
    Public Shared rdlcConsecutivoVentasDesglosado As String = "rdlcConsecutivoVentasDesglosado.rdlc"
    Public Shared rdlcConsecutivoDeCotizaciones As String = "rdlcConsecutivoCotizaciones.rdlc"
    Public Shared rdlcConsecutivoDeCotizacionesDesglosado As String = "rdlcConsecutivoDeCotizacionesDesglosado.rdlc"

#End Region

End Class
