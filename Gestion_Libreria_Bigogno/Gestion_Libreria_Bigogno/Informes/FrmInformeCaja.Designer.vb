﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInformeCaja
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.libreria_bigognoDataSetCajaXDia = New GestionLibreriaBigogno.libreria_bigognoDataSetCajaXDia()
        Me.get_inf_CajaxDiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.get_inf_CajaxDiaTableAdapter = New GestionLibreriaBigogno.libreria_bigognoDataSetCajaXDiaTableAdapters.get_inf_CajaxDiaTableAdapter()
        CType(Me.libreria_bigognoDataSetCajaXDia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.get_inf_CajaxDiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetCajaXDia"
        ReportDataSource1.Value = Me.get_inf_CajaxDiaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionLibreriaBigogno.ReportCaja.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(669, 571)
        Me.ReportViewer1.TabIndex = 0
        '
        'libreria_bigognoDataSetCajaXDia
        '
        Me.libreria_bigognoDataSetCajaXDia.DataSetName = "libreria_bigognoDataSetCajaXDia"
        Me.libreria_bigognoDataSetCajaXDia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'get_inf_CajaxDiaBindingSource
        '
        Me.get_inf_CajaxDiaBindingSource.DataMember = "get_inf_CajaxDia"
        Me.get_inf_CajaxDiaBindingSource.DataSource = Me.libreria_bigognoDataSetCajaXDia
        '
        'get_inf_CajaxDiaTableAdapter
        '
        Me.get_inf_CajaxDiaTableAdapter.ClearBeforeFill = True
        '
        'FrmInformeCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 571)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInformeCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmInformeCaja"
        CType(Me.libreria_bigognoDataSetCajaXDia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.get_inf_CajaxDiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents get_inf_CajaxDiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents libreria_bigognoDataSetCajaXDia As GestionLibreriaBigogno.libreria_bigognoDataSetCajaXDia
    Friend WithEvents get_inf_CajaxDiaTableAdapter As GestionLibreriaBigogno.libreria_bigognoDataSetCajaXDiaTableAdapters.get_inf_CajaxDiaTableAdapter
End Class
