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

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("PriPROC6.Interface.Web.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to .
        '''</summary>
        Friend ReadOnly Property Install() As String
            Get
                Return ResourceManager.GetString("Install", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to USE [system]
        '''IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N&apos;[dbo].[apiLog]&apos;) AND type in (N&apos;U&apos;))
        '''BEGIN
        '''	CREATE TABLE [dbo].[apiLog](
        '''		[BubbleID] [varchar](64) NOT NULL,
        '''		[logDate] [date] NOT NULL CONSTRAINT [DF_apiLog_logDate]  DEFAULT (getdate()),
        '''		[logTime] [time] NOT NULL CONSTRAINT [DF_apiLog_logTime]  DEFAULT (getdate()),
        '''		[environment] [varchar](50) NOT NULL,
        '''		[method] [nchar](10) NOT NULL,
        '''		[endpoint] [varchar](250) NOT NULL,
        '''		[severity] [int] NULL,
        '''		[logXml [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property log() As String
            Get
                Return ResourceManager.GetString("log", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to declare @dd int --mandatory
        '''declare @mm int --mandatory
        '''declare @yy int --mandatory
        '''
        '''set @dd = datepart(day, getdate()) -1
        '''set @mm = datepart(MONTH, getdate())
        '''set @yy = datepart(year, getdate())
        '''
        '''declare @environment varchar(24) --mandatory
        '''set @environment = &apos;demo&apos;
        '''
        '''declare @BubbleID varchar(64) --mandatory
        '''set @BubbleID = &apos;e4592754-7f54-421c-8437-f54c00780a04&apos;
        '''
        '''select
        '''	1 as Tag,
        '''	Null as Parent,		
        '''	@BubbleID as &quot;Log!1!BubbleID&quot;,  
        '''	[severity] as &quot;Log!1!Severity&quot;,
        '''	environment as &quot;Log!1 [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property logDetail() As String
            Get
                Return ResourceManager.GetString("logDetail", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to declare @dd int --mandatory
        '''declare @mm int --mandatory
        '''declare @yy int --mandatory
        '''
        '''set @dd = datepart(day, getdate()) -1
        '''set @mm = datepart(MONTH, getdate())
        '''set @yy = datepart(year, getdate())
        '''
        '''declare @environment varchar(24) --mandatory
        '''set @environment = &apos;demo&apos;
        '''
        '''declare @BubbleID varchar(64) --mandatory
        '''set @BubbleID = &apos;e4592754-7f54-421c-8437-f54c00780a04&apos;
        '''
        '''select
        '''	logXml
        '''	 
        '''FROM [system].[dbo].[apiLog]
        '''where 0=0
        '''	and [logYear] = @yy
        '''	and [logMonth] = @mm
        '''	and [logDay]= @dd
        '''	and [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property logXML() As String
            Get
                Return ResourceManager.GetString("logXML", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to declare @dd int
        '''declare @mm int
        '''declare @yy int
        '''
        '''declare @environment varchar(24) --mandatory
        '''set @environment = &apos;demo&apos;
        '''
        '''declare @endpoint varchar(255) --mandatory
        '''set @endpoint = &apos;basda-order-v3.ashx&apos;
        '''
        '''set @dd = datepart(day, getdate())
        '''set @mm = datepart(MONTH, getdate())
        '''set @yy = datepart(year, getdate())
        '''
        '''select &apos;&apos;, (
        '''	SELECT 
        '''		[displayTime] as &quot;@Time&quot;
        '''		  ,[BubbleID] as &quot;@BubbleID&quot;
        '''      
        '''		  --,[method]
        '''		  --,[endpoint]
        '''		  ,[severity] as &quot;@Severity&quot;
        '''		  ,[fKey] as &quot;@fkey&quot;
        '''		 [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Query() As String
            Get
                Return ResourceManager.GetString("Query", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to USE [system]
        '''declare @BubbleID varchar(64)
        '''select top 1 
        '''	@BubbleID = BubbleID 
        '''from [dbo].[apiLog]
        '''WHERE BubbleID = &apos;{0}&apos;
        '''order by logDate Desc, logTime Desc;
        '''update [dbo].[apiLog] 
        '''set [fKey] = &apos;{1}&apos;
        '''where BubbleID = @BubbleID.
        '''</summary>
        Friend ReadOnly Property setfKey() As String
            Get
                Return ResourceManager.GetString("setfKey", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to USE [system]
        '''declare @BubbleID varchar(64)
        '''select top 1 
        '''	@BubbleID = BubbleID 
        '''from [dbo].[apiLog]
        '''WHERE BubbleID = &apos;{0}&apos;
        '''order by logDate Desc, logTime Desc;
        '''update [dbo].[apiLog] 
        '''set [fKey] = @BubbleID
        '''where [fKey] = &apos;{1}&apos;
        '''update [dbo].[apiLog] 
        '''set [fKey] = &apos;{1}&apos;
        '''where BubbleID = @BubbleID.
        '''</summary>
        Friend ReadOnly Property setfKeyReplace() As String
            Get
                Return ResourceManager.GetString("setfKeyReplace", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to USE [system]
        '''declare @BubbleID varchar(64)
        '''select top 1 
        '''	@BubbleID = BubbleID 
        '''from [dbo].[apiLog]
        '''WHERE BubbleID = &apos;{0}&apos;
        '''order by logDate Desc, logTime Desc
        '''
        '''update [dbo].[apiLog] set 
        '''[severity] = &apos;{2}&apos;,
        '''[logText] = &apos;{1}&apos;
        '''where BubbleID = @BubbleID.
        '''</summary>
        Friend ReadOnly Property setLog() As String
            Get
                Return ResourceManager.GetString("setLog", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to USE [system]
        '''declare @BubbleID varchar(64)
        '''select top 1 
        '''	@BubbleID = BubbleID 
        '''from [dbo].[apiLog]
        '''WHERE BubbleID = &apos;{0}&apos;
        '''order by logDate Desc, logTime Desc;
        '''declare @request xml;
        '''set @request = &apos;{1}&apos;;
        '''update [dbo].[apiLog] set 
        '''[logXml] = @request
        '''where BubbleID = @BubbleID.
        '''</summary>
        Friend ReadOnly Property setXML() As String
            Get
                Return ResourceManager.GetString("setXML", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
