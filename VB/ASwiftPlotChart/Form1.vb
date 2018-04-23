Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace ASwiftPlotChart
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Const interval As Integer = 20
		Private random As New Random()
		Private TimeInterval As Integer = 10
		Private value1 As Double = 10.0

		Private ReadOnly Property AxisXRange() As Range
			Get
				Dim diagram As SwiftPlotDiagram = TryCast(chartControl1.Diagram, SwiftPlotDiagram)
				If diagram IsNot Nothing Then
					Return diagram.AxisX.VisualRange
				End If
				Return Nothing
			End Get
		End Property

		Private Function CalculateNextValue(ByVal value As Double) As Double
			Return value + (random.NextDouble() * 10.0 - 5.0)
		End Function

		Private Sub UpdateValues()
			value1 = CalculateNextValue(value1)
		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			Dim series1 As Series = chartControl1.Series(0)

			If series1 Is Nothing Then
				Return
			End If
			Dim argument As DateTime = DateTime.Now
			Dim pointsToUpdate1(interval - 1) As SeriesPoint
			For i As Integer = 0 To interval - 1
				pointsToUpdate1(i) = New SeriesPoint(argument, value1)
				argument = argument.AddMilliseconds(1)
				UpdateValues()
			Next i
			Dim minDate As DateTime = argument.AddSeconds(-TimeInterval)
			Dim pointsToRemoveCount As Integer = 0
			For Each point As SeriesPoint In series1.Points
				If point.DateTimeArgument < minDate Then
					pointsToRemoveCount += 1
				End If
			Next point
			If pointsToRemoveCount < series1.Points.Count Then
				pointsToRemoveCount -= 1
			End If
			series1.Points.AddRange(pointsToUpdate1)
			If pointsToRemoveCount > 0 Then
				series1.Points.RemoveRange(0, pointsToRemoveCount)
			End If
			If AxisXRange IsNot Nothing Then
				AxisXRange.SetMinMaxValues(minDate, argument)
			End If

		End Sub

	End Class
End Namespace