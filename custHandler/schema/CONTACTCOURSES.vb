Imports PriPROC6.Interface.oData
Imports System.Reflection

''' <summary>
'''
''' This code was generated by the Schema Utility.
'''
''' Form: CONTACTCOURSES as List(Of rowCONTACTCOURSES)
''' Date: 06/05/2019
'''
''' </summary>
<oFormClass("rowCONTACTCOURSES")>
Public Class CONTACTCOURSES : Inherits oForm

    ''' <summary>
    ''' CONTACTCOURSES Constructor method.
    ''' </summary>
	''' <param name="Sender">The Assembly.GetExecutingAssembly of your project</param>
    ''' <param name="Parent">Optional: Parent oRow of this form</param>
    Sub New(byref Sender As Assembly, Optional Parent As oRow = Nothing)
        MyBase.New(Sender, Parent)

    End Sub

    ''' <summary>
    ''' Add a new row to the CONTACTCOURSES form.
    ''' </summary>
    ''' <returns>rowCONTACTCOURSES</returns>
    Public Function AddRow() As rowCONTACTCOURSES
        With Me
            .Add(New rowCONTACTCOURSES(Me))
            Return .Last

        End With

    End Function

End Class

''' <summary>
''' Defines rows in the CONTACTCOURSES form.
''' </summary>
<oRowClass("CONTACTCOURSES", "serialCONTACTCOURSES")>
Public Class rowCONTACTCOURSES : Inherits oRow

    ''' <summary>
    ''' rowCONTACTCOURSES Constructor method.
    ''' </summary>
    ''' <param name="Parent">Parent oForm of this row</param>
    Sub New(Parent As oForm)
        MyBase.New(Parent)

    End Sub
    
	''' <summary>
    ''' Get / Set the "Course Number" Value of CONTACTCOURSES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Course Number", length:=16)>
    Public Property COURSENAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Name of Course" Value of CONTACTCOURSES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Name of Course", length:=32)>
    Public Property COURSEDES As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "From Date" Value of CONTACTCOURSES.
    ''' </summary>
    ''' <returns>Date</returns>	
    <oDataColumn("From Date")>
    Public Property FROMDATE As Date
        Get
            Return getProperty()
        End Get
        Set(value As Date)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "To Date" Value of CONTACTCOURSES.
    ''' </summary>
    ''' <returns>Date</returns>	
    <oDataColumn("To Date")>
    Public Property TODATE As Date
        Get
            Return getProperty()
        End Get
        Set(value As Date)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Degree/Certif. Code" Value of CONTACTCOURSES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Degree/Certif. Code", length:=3)>
    Public Property DEGREECODE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Degree/Certificate" Value of CONTACTCOURSES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Degree/Certificate", ReadOnly:=True, length:=20)>
    Public Readonly Property DEGREEDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Passed?" Value of CONTACTCOURSES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Passed?", length:=1)>
    Public Property QUALIFIED As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Feedback Received?" Value of CONTACTCOURSES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Feedback Received?", length:=1)>
    Public Property FEEDBACK As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Credits (Code)" Value of CONTACTCOURSES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Credits (Code)", length:=3)>
    Public Property CREDITPOINTCODE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Description(Credits)" Value of CONTACTCOURSES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Description(Credits)", ReadOnly:=True, length:=32)>
    Public Readonly Property CREDITPOINTDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Details" Value of CONTACTCOURSES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Details", length:=32)>
    Public Property DETAILS As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Course Number" Value of CONTACTCOURSES.
    ''' </summary>
    ''' <returns>Integer</returns>	
    <oDataColumn("Course Number", Key:=True)>
    Public Property STUDCOURSE As Integer
        Get
            Return getProperty()
        End Get
        Set(value As Integer)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Participant" Value of CONTACTCOURSES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Participant", Key:=True, length:=30)>
    Public Property NAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property


End Class

''' <summary>
''' A nullable version of rowCONTACTCOURSES.
'''
''' This is used to deserialise JSON data
''' and should not be instantiated directly.
''' </summary>
Public Class serialCONTACTCOURSES 

    Public Property COURSENAME As String
    Public Property COURSEDES As String
    Public Property FROMDATE As Date?
    Public Property TODATE As Date?
    Public Property DEGREECODE As String
    Public Property DEGREEDES As String
    Public Property QUALIFIED As String
    Public Property FEEDBACK As String
    Public Property CREDITPOINTCODE As String
    Public Property CREDITPOINTDES As String
    Public Property DETAILS As String
    Public Property STUDCOURSE As Integer?
    Public Property NAME As String


End Class