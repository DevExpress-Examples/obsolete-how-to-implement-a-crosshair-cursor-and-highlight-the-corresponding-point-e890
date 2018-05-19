Imports Microsoft.VisualBasic
Imports System
Namespace ValueLines
	Partial Public Class frmMain
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim constantLine1 As New DevExpress.XtraCharts.ConstantLine()
			Dim constantLine2 As New DevExpress.XtraCharts.ConstantLine()
			Dim constantLine3 As New DevExpress.XtraCharts.ConstantLine()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim areaSeriesView1 As New DevExpress.XtraCharts.AreaSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel2 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(areaSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chart
			' 
			Me.chart.AppearanceName = "Northern Lights"
			constantLine1.AxisValueSerializable = "1"
			constantLine1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(64))))), (CInt(Fix((CByte(0))))))
			constantLine1.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dash
			constantLine1.LineStyle.Thickness = 2
			constantLine1.Name = "Argument"
			constantLine1.ShowInLegend = False
			constantLine1.Title.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
			constantLine1.Visible = False
			xyDiagram1.AxisX.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() { constantLine1})
			xyDiagram1.AxisX.GridLines.MinorVisible = True
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisX.Range.SideMarginsEnabled = False
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			constantLine2.AxisValueSerializable = "1"
			constantLine2.Color = System.Drawing.Color.Blue
			constantLine2.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dash
			constantLine2.LineStyle.Thickness = 2
			constantLine2.Name = "Area Value"
			constantLine2.ShowInLegend = False
			constantLine2.Title.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
			constantLine2.Visible = False
			constantLine3.AxisValueSerializable = "1"
			constantLine3.Color = System.Drawing.Color.Red
			constantLine3.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dash
			constantLine3.LineStyle.Thickness = 2
			constantLine3.Name = "Line Value"
			constantLine3.ShowInLegend = False
			constantLine3.Title.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
			constantLine3.Visible = False
			xyDiagram1.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() { constantLine2, constantLine3})
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Location = New System.Drawing.Point(0, 0)
			Me.chart.Name = "chart"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			pointSeriesLabel1.LineVisible = True
			pointSeriesLabel1.Visible = False
			series1.Label = pointSeriesLabel1
			series1.Name = "Area"
			areaSeriesView1.MarkerOptions.Visible = False
			series1.View = areaSeriesView1
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			pointSeriesLabel2.LineVisible = True
			pointSeriesLabel2.Visible = False
			series2.Label = pointSeriesLabel2
			series2.Name = "Line"
			lineSeriesView1.LineMarkerOptions.Visible = False
			series2.View = lineSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			sideBySideBarSeriesLabel1.LineVisible = True
			Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1
			Me.chart.Size = New System.Drawing.Size(711, 545)
			Me.chart.TabIndex = 0
'			Me.chart.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.chart_MouseMove);
			' 
			' frmMain
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(711, 545)
			Me.Controls.Add(Me.chart)
			Me.Name = "frmMain"
			Me.Text = "Dynamic constant lines"
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(areaSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chart As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

