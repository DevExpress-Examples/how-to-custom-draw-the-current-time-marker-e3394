﻿Imports Microsoft.VisualBasic
Imports System
Namespace SchedulerCustomDrawCurrentTimeMarker
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
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.schedulerControl1.Location = New System.Drawing.Point(12, 12)
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.Size = New System.Drawing.Size(614, 219)
			Me.schedulerControl1.Start = New System.DateTime(2008, 9, 4, 0, 0, 0, 0)
			Me.schedulerControl1.TabIndex = 0
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
'			Me.schedulerControl1.CustomDrawDayViewTimeRuler += New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(Me.schedulerControl1_CustomDrawDayViewTimeRuler);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(638, 274)
			Me.Controls.Add(Me.schedulerControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
	End Class
End Namespace

