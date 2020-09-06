﻿' Licensed to the .NET Foundation under one or more agreements.
' The .NET Foundation licenses this file to you under the MIT license.
' See the LICENSE file in the project root for more information.

Friend Module Program

    <STAThread()>
    Friend Sub Main(args As String())
        Application.SetHighDpiMode(HighDpiMode.PerMonitorV2)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
#If Not NET5_0 Then
        Using MyApp As New My.MyApplication
            MyApp.Run(args)
        End Using
#Else
        Dim MyApp As New My.MyApplication
        MyApp.Run(args)
#End If
    End Sub

End Module
