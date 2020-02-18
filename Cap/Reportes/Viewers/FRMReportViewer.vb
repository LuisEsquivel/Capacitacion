



Imports Microsoft.Reporting.WinForms

Public Class FRMReportViewer


#Region "Variables Reportes"
    Dim parameterValueSubReport As String = ""
#End Region

    Private RDS As ReportDataSource
    Dim parameters As New List(Of ReportParameter)
    Private _DataSource As DataTable = Nothing
    Private _DataSourceName As String = ""
    Private _ReportPath As String = ""
    Private _RutaLogo As String = ""


    Private _Filtros As String = ""
    Private _SubReportDataSource As Object = Nothing
    Private _SubReportReportPath As String = ""
    Private _SubReportDataSourceName As String = ""


    Public Property SubReportDataSource() As Object
        Get
            Return _SubReportDataSource
        End Get
        Set(value As Object)
            _SubReportDataSource = value
        End Set
    End Property

    Public Property SubReportReportPath() As String
        Get
            Return _SubReportReportPath
        End Get
        Set(value As String)
            _SubReportReportPath = value
        End Set
    End Property


    Public Property SubReportDataSourceName() As String
        Get
            Return _SubReportDataSourceName
        End Get
        Set(value As String)
            _SubReportDataSourceName = value
        End Set
    End Property


    Property RutaLogo() As String
        Get
            Return _RutaLogo
        End Get
        Set(value As String)
            _RutaLogo = value
        End Set
    End Property


    Public Property Filtros() As String
        Get
            Return _Filtros
        End Get
        Set(value As String)
            _Filtros = value
        End Set
    End Property


    Public Property DataSource() As DataTable
        Get
            Return _DataSource
        End Get
        Set(value As DataTable)
            _DataSource = value
        End Set
    End Property

    Public Property ReportPath() As String
        Get
            Return _ReportPath
        End Get
        Set(value As String)
            _ReportPath = value
        End Set
    End Property


    Public Property DataSourceName As String
        Get
            Return _DataSourceName
        End Get
        Set(value As String)
            _DataSourceName = value
        End Set
    End Property


    Private Function FiltrarDatos(Optional ByVal parameter As String = "",
                                  Optional ByVal columName As String = ""
                                  ) As List(Of DataRow)

        Dim lista As New List(Of DataRow)

        Dim dt As DataTable
        Dim fila As Int32 = 0
        Dim celda As Int32 = 0

        dt = CType(SubReportDataSource, DataTable)

        dt = SubReportDataSource


        For Each row As DataRow In dt.Rows

            'For Each row As DataRow In SubReportDataSource.Rows

            If row.Item(columName).ToString = parameter Then

                'ESTE FOR ES PARA CHECAR SI HAY CELDAS QUE NO CONTANGAN VALOR
                ' SI LAS HAY ENTONCES LAS PONEMOS COMO VACÍAS
                'PARA QUE NO NOS PINTE TODAS LAS CELDAS CORRECTAMENTE EN EL REPORTE RDLC
                For celda = 0 To dt.Columns.Count - 1

                    If IsDBNull(dt.Rows(fila).Item(celda)) Then
                        dt.Rows(fila).Item(celda) = String.Empty
                    End If

                Next

                lista.Add(row)


            End If

            fila = fila + 1
        Next

        Return lista


    End Function

    Public Sub MySubreportEventHandler(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)

        Dim RDS As New ReportDataSource
        If e.Parameters(0).Values(0).ToString <> parameterValueSubReport Then
            parameterValueSubReport = e.Parameters(0).Values(0).ToString
            Dim Data As Object = FiltrarDatos(e.Parameters(0).Values(0).ToString, e.Parameters(0).Name)

            RDS.Name = SubReportDataSourceName
            RDS.Value = Data
            e.DataSources.Add(RDS)

        End If

    End Sub


    Public Sub CargarReporte()

        Try

            'LLENADO DE INFORMACIÓN
            Me.ReportViewer.LocalReport.DataSources.Clear()
            RDS = New Microsoft.Reporting.WinForms.ReportDataSource
            RDS.Value = DataSource
            RDS.Name = DataSourceName
            Me.ReportViewer.LocalReport.DataSources.Add(RDS)

            'TRABAJAR CON IMÁGENES EXTERNAS
            Me.ReportViewer.LocalReport.ReportPath = ReportPath
            Me.ReportViewer.LocalReport.EnableHyperlinks = True 'PARA TRABAJAR CON LOS HIPERVICULOS
            Me.ReportViewer.LocalReport.EnableExternalImages = True 'PARA TRABAJAR CON LAS IMÁGENES

            'REPORTE DEL LADO DEL CLIENTE
            Me.ReportViewer.ProcessingMode = ProcessingMode.Local

            'ENVÍO DE PARÁMETROS
            Me.ReportViewer.Refresh()
            Me.ReportViewer.RefreshReport()

            EnviarParametros()

            'ANCHO Y NOMBRE DEL MAPA DE DOCUMENTO
            Me.ReportViewer.LocalReport.DisplayName = "MAPA DE NAVEGACIÓN"
            Me.ReportViewer.DocumentMapWidth = 300

            'PRESENTACIÓN NORMAL, ASI SE PUEDE VISUALIZAR EL DOCUMENT MAP
            Me.ReportViewer.SetDisplayMode(DisplayMode.Normal)

            Me.ReportViewer.Refresh()



            'PRESENTACIÓN PARA IMPRIMIR, SI EL REPORTE NO TIENE DOCUMENT MAP
            If Me.ReportViewer.LocalReport.GetDocumentMap Is Nothing Then
                Me.ReportViewer.SetDisplayMode(DisplayMode.PrintLayout)
            End If

            ' EL ZOOM
            Me.ReportViewer.ZoomMode = ZoomMode.Percent

            'PORCENTAJE DE ZOOM
            Me.ReportViewer.ZoomPercent = 100

            ''SUBRPORTE
            If SubReportDataSourceName <> "" Then
                AddHandler Me.ReportViewer.LocalReport.SubreportProcessing, AddressOf MySubreportEventHandler
            End If

            'RECARGAMOS EL REPORTE
            Me.ReportViewer.Refresh()
            Me.ReportViewer.RefreshReport()


        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Public Sub EnviarParametros()

        'OBTENER LOS PARÁMETROS DEL REPORTE
        Dim ps As ReportParameterInfoCollection
        ps = Me.ReportViewer.LocalReport.GetParameters()
        Dim param As Object = Nothing


        ' CHECAR SI EN EL REPORTE EXISTEN LOS SIGUIENTES PARÉMETROS
        ' SI EXISTEN LES MANDAMOS SU CORRESPONDIENTE VALOR 
        ' SI NO EXISTEN NO MANDAMOS NADA
        For Each param In ps


            If param.Name = "Filtros" Then
                parameters.Add(New ReportParameter("Filtros", Filtros, False))
            End If

            If param.Name = "Logo" Then

                parameters.Add(New ReportParameter("Logo", RutaLogo, False))
            End If
        Next

        Me.ReportViewer.LocalReport.SetParameters(parameters)
        Me.ReportViewer.RefreshReport()
    End Sub

    Sub procesarPulsaciones(ByVal sender As Object, ByVal e As KeyEventArgs)
        ' al pulsar ...
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select

    End Sub

    Private Sub FRMReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarReporte()
    End Sub

    Private Sub ReportViewer_Load(sender As Object, e As EventArgs)
        Me.KeyPreview = True
        AddHandler Me.KeyUp, AddressOf procesarPulsaciones
    End Sub
End Class