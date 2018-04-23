Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.DXErrorProvider

Namespace ValidationProviderSuccessEvent
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim prov As New MyValidationProvider()
			prov.ValidationMode = ValidationMode.Auto
			AddHandler prov.ValidationSuccessfullyComplete, AddressOf OnValidationSuccessfullyComplete

			Dim notEmptyValidationRule As New ConditionValidationRule()
			notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
			notEmptyValidationRule.ErrorText = "Please enter some text here"
			notEmptyValidationRule.ErrorType = ErrorType.Warning

			prov.SetValidationRule(textEdit1, notEmptyValidationRule)
			prov.SetValidationRule(textEdit2, notEmptyValidationRule)
			prov.SetValidationRule(textEdit3, notEmptyValidationRule)

			ValidateChildren()
		End Sub

		Private Sub OnValidationSuccessfullyComplete(ByVal sender As Object, ByVal e As EventArgs)
			simpleButton1.Enabled = True
			simpleButton1.Focus()
		End Sub
	End Class
End Namespace
