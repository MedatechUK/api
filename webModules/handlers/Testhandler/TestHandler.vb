﻿Imports System.ComponentModel.Composition
Imports System.Xml
Imports System.Web
Imports PriPROC6.Interface.Web
Imports PriPROC6.svcMessage
Imports PriPROC6.Interface.Message
Imports PriPROC6.Loading

<Export(GetType(xmlHandler))>
<ExportMetadata("EndPoint", "testhandler")>
<ExportMetadata("HandlerStyle", eHandlerStyle.xml)>
Public Class TestHandler : Inherits iHandler : Implements xmlHandler

#Region "Base Methods"

    Shadows Sub ProcessRequest(ByRef context As HttpContext, ByRef log As oMsgLog, ByRef msgFactory As msgFactory) Implements xmlHandler.ProcessRequest
        MyBase.ProcessRequest(context, log, msgFactory)
    End Sub

    Shadows Sub SetMeta(ByRef Metadata As xmlHandlerProps) Implements xmlHandler.SetMeta
        MyBase.SetMeta(Metadata)
    End Sub

#End Region

    Public Overrides Sub XmlStylesheet(ByRef Schemas As Schema.XmlSchemaSet)
        With Schemas

        End With
    End Sub

    Public Overrides Sub XMLHandler(ByRef w As XmlTextWriter, ByRef Request As XmlDocument)

        log.LogData.Append("Some debug info...").AppendLine()

        Using erl As New ldDef
            With erl
                .AddRecordType(1) = New Loading.LoadRow(
                    "Fred"
                )

                Dim exp As New Exception
                If Not .Post(HttpContext.Current, msgfactory, exp) Then Throw exp

            End With
        End Using
    End Sub

End Class