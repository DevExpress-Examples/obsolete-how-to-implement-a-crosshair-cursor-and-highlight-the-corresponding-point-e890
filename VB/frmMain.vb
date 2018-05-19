Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace ValueLines
	Partial Public Class frmMain
		Inherits Form
		Private random As New Random()

		Private ReadOnly Property Diagram() As XYDiagram
			Get
				Return (CType(chart.Diagram, XYDiagram))
			End Get
		End Property
		Private ReadOnly Property AreaSeries() As Series
			Get
				Return chart.Series(0)
			End Get
		End Property
		Private ReadOnly Property LineSeries() As Series
			Get
				Return chart.Series(1)
			End Get
		End Property

		Private ReadOnly Property ArgumentConstantLine() As ConstantLine
			Get
				Return Diagram.AxisX.ConstantLines(0)
			End Get
		End Property
		Private ReadOnly Property AreaValueConstantLine() As ConstantLine
			Get
				Return Diagram.AxisY.ConstantLines(0)
			End Get
		End Property
		Private ReadOnly Property LineValueConstantLine() As ConstantLine
			Get
				Return Diagram.AxisY.ConstantLines(1)
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			Dim isAreaRising As Boolean = True
			Dim isLineRising As Boolean = False
			For i As Integer = 0 To 99
				AddPoint(AreaSeries, isAreaRising, i)
				AddPoint(LineSeries, isLineRising, i)
				isAreaRising = random.NextDouble() > 0.75
				isLineRising = random.NextDouble() > 0.75
			Next i
		End Sub

		Private Sub chart_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chart.MouseMove
			Dim coordinates As DiagramCoordinates = Diagram.PointToDiagram(New Point(e.X, e.Y))
			If coordinates Is Nothing OrElse coordinates.IsEmpty Then
				ArgumentConstantLine.Visible = False
				AreaValueConstantLine.Visible = False
				LineValueConstantLine.Visible = False
				Return
			End If
			UpdateConstantLine(ArgumentConstantLine, coordinates.NumericalArgument)
			UpdateConstantLine(AreaValueConstantLine, GetSeriesValue(AreaSeries, coordinates.NumericalArgument))
			UpdateConstantLine(LineValueConstantLine, GetSeriesValue(LineSeries, coordinates.NumericalArgument))
		End Sub

		Private Sub AddPoint(ByVal series As Series, ByVal isRising As Boolean, ByVal argument As Integer)
			Dim previousValue As Double
			If series.Points.Count > 0 Then
				previousValue = series.Points(series.Points.Count - 1).Values(0)
			Else
				previousValue = (random.NextDouble() + 1) * 10
			End If

			Dim value As Double
			If isRising Then
				value = previousValue + (random.NextDouble())
			Else
				value = previousValue + (-random.NextDouble())
			End If

			series.Points.Add(New SeriesPoint(argument, value))
		End Sub

		Private Sub UpdateConstantLine(ByVal constantLine As ConstantLine, ByVal value As Double)
			constantLine.Visible = True
			constantLine.AxisValue = value
			constantLine.Title.Text = value.ToString("00.00")
		End Sub

		Private Function GetSeriesValue(ByVal series As Series, ByVal argument As Double) As Double
			For i As Integer = 0 To series.Points.Count - 2

				If series.Points(i).NumericalArgument = argument Then
					Return series.Points(i).Values(0)

				ElseIf series.Points(i).NumericalArgument < argument AndAlso series.Points(i + 1).NumericalArgument > argument Then

					Dim ratio As Double = (argument - series.Points(i).NumericalArgument) / (series.Points(i + 1).NumericalArgument - series.Points(i).NumericalArgument)

					Return (series.Points(i + 1).Values(0) - series.Points(i).Values(0)) * ratio + series.Points(i).Values(0)
				End If
			Next i
			Return Double.NaN
		End Function
	End Class
End Namespace
