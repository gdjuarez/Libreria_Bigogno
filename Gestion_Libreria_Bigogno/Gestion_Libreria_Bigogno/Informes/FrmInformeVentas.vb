﻿Public Class FrmInformeVentas

    Private Sub FrmInformeVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'libreria_bigognoDataSetVentasXDia.get_inf_Venta_4' Puede moverla o quitarla según sea necesario.
        Me.get_inf_Venta_4TableAdapter.Fill(Me.libreria_bigognoDataSetVentasXDia.get_inf_Venta_4, GlobalDesdeVentas, GlobalHastaVentas)
        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Parametro1", GlobalDesdeVentas))
        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Parametro2", GlobalHastaVentas))
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class