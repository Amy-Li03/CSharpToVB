﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Namespace My

    'NOTE: This file is auto-generated; do not modify it directly.  To make changes,
    ' or if you encounter build errors in this file, go to the Project Designer
    ' (go to Project Properties or double-click the My Project node in
    ' Solution Explorer), and make changes on the Application tab.
    '
    Partial Friend Class MyApplication
#If NETCOREAPP3_1 Then
        Inherits ApplicationServices.WindowsFormsApplicationBase
#End If

        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>
        Public Sub New()
#If NETCOREAPP3_1 Then
            MyBase.New()
#Else
            MyBase.New(Global.Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
#End If
            Me.EnableVisualStyles = True
            Me.IsSingleInstance = True
            Me.MinimumSplashScreenDisplayTime = 5000
            Me.SaveMySettingsOnExit = True
            Me.ShutdownStyle = Global.Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses
        End Sub

        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>
        Protected Overrides Sub OnCreateMainForm()
#If NETCOREAPP3_1 Then
            Me.MainForm = New Form1
#Else
            Me.MainForm = Global.CSharpToVBApp.Form1
#End If
        End Sub

        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>
        Protected Overrides Sub OnCreateSplashScreen()
#If NETCOREAPP3_1 Then
            Me.SplashScreen = New SplashScreen1
#Else
            Me.SplashScreen = Global.CSharpToVBApp.SplashScreen1
#End If
        End Sub
    End Class
End Namespace
