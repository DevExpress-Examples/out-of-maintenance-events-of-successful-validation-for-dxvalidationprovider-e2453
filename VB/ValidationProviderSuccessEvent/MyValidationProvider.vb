Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.DXErrorProvider

Namespace ValidationProviderSuccessEvent
	Public Class MyValidationProvider
		Inherits DXValidationProvider
		Public Event ControlValidationSucceded As ControlValidationSuccededEventHandler
		Public Event ValidationSuccessfullyComplete As ValidationSuccessfullyCompleteEventHandler

		Public Overrides Sub RemoveControlError(ByVal control As Control)
			MyBase.RemoveControlError(control)

			RaiseControlValidationSucceded(New ControlValidationSuccededEventArgs(control))
			If Me.GetInvalidControls().Count = 0 Then
				RaiseValidationSuccessfullyComplete()
			End If
		End Sub

		Public Sub RaiseControlValidationSucceded(ByVal e As ControlValidationSuccededEventArgs)
			RaiseEvent ControlValidationSucceded(Me, e)
		End Sub

		Public Sub RaiseValidationSuccessfullyComplete()
			RaiseEvent ValidationSuccessfullyComplete(Me, New EventArgs())
		End Sub
	End Class

	Public Delegate Sub ControlValidationSuccededEventHandler(ByVal sender As Object, ByVal e As ControlValidationSuccededEventArgs)
	Public Delegate Sub ValidationSuccessfullyCompleteEventHandler(ByVal sender As Object, ByVal e As EventArgs)

	Public Class ControlValidationSuccededEventArgs
		Inherits EventArgs
		Private control As Control

		Public Sub New(ByVal control As Control)
			Me.control = control
		End Sub

		Public ReadOnly Property ValidControl() As Control
			Get
				Return control
			End Get
		End Property
	End Class
End Namespace
