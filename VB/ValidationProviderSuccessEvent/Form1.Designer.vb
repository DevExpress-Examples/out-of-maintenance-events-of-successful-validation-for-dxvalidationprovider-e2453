Imports Microsoft.VisualBasic
Imports System
Namespace ValidationProviderSuccessEvent
	Partial Public Class Form1
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
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit3 = New DevExpress.XtraEditors.TextEdit()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(81, 12)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Properties.ValidateOnEnterKey = True
			Me.textEdit1.Size = New System.Drawing.Size(274, 20)
			Me.textEdit1.TabIndex = 0
			' 
			' textEdit2
			' 
			Me.textEdit2.Location = New System.Drawing.Point(81, 39)
			Me.textEdit2.Name = "textEdit2"
			Me.textEdit2.Properties.ValidateOnEnterKey = True
			Me.textEdit2.Size = New System.Drawing.Size(274, 20)
			Me.textEdit2.TabIndex = 1
			' 
			' textEdit3
			' 
			Me.textEdit3.Location = New System.Drawing.Point(81, 65)
			Me.textEdit3.Name = "textEdit3"
			Me.textEdit3.Properties.ValidateOnEnterKey = True
			Me.textEdit3.Size = New System.Drawing.Size(274, 20)
			Me.textEdit3.TabIndex = 3
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Enabled = False
			Me.simpleButton1.Location = New System.Drawing.Point(280, 177)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 4
			Me.simpleButton1.Text = "Next >"
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(21, 15)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(54, 13)
			Me.labelControl1.TabIndex = 5
			Me.labelControl1.Text = "First name:"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(12, 42)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(63, 13)
			Me.labelControl2.TabIndex = 6
			Me.labelControl2.Text = "Middle name:"
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(22, 68)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(53, 13)
			Me.labelControl3.TabIndex = 7
			Me.labelControl3.Text = "Last name:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
			Me.ClientSize = New System.Drawing.Size(367, 211)
			Me.Controls.Add(Me.labelControl3)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.textEdit3)
			Me.Controls.Add(Me.textEdit2)
			Me.Controls.Add(Me.textEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private textEdit2 As DevExpress.XtraEditors.TextEdit
		Private textEdit3 As DevExpress.XtraEditors.TextEdit
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace

