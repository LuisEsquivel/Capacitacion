﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMReportViewer
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
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportViewer
        '
        Me.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer.DocumentMapWidth = 300
        Me.ReportViewer.IsDocumentMapWidthFixed = True
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.ServerReport.BearerToken = Nothing
        Me.ReportViewer.Size = New System.Drawing.Size(318, 276)
        Me.ReportViewer.TabIndex = 0
        '
        'FRMReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(350, 276)
        Me.Controls.Add(Me.ReportViewer)
        Me.Name = "FRMReportViewer"
        Me.Text = "Plafones e Interiores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
