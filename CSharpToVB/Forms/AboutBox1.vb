﻿' Licensed to the .NET Foundation under one or more agreements.
' The .NET Foundation licenses this file to you under the MIT license.
' See the LICENSE file in the project root for more information.

Imports Microsoft.VisualBasic.ApplicationServices

Public NotInheritable Class AboutBox1

    Private Sub AboutBox1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String = If(My.Application.Info.Title, IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName))
        Text = $"About {ApplicationTitle}"
        ' Initialize all of the text displayed on the About Box.

        LabelProductName.Text = $"{My.Application.Info.ProductName}"
        LabelVersion.Text = $"Version {My.Application.Info.Version}"

        LabelCopyright.Text = My.Application.Info.Copyright
        LabelCompanyName.Text = $"Developer {My.Application.Info.CompanyName}"
        Dim coreinfo As New AssemblyInfo(GetType(CSharpToVBConverter.CodeWithOptions).Assembly)
        TextBoxDescription.Text = $"{My.Application.Info.Description}{vbCrLf}{vbCrLf}{coreinfo.ProductName} {coreinfo.Version}"
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
