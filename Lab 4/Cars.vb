﻿Option Strict On
Public Class Cars
    Private Shared carCount As Integer
    Private carIdentificationNumber As Integer = 0
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As String = String.Empty
    Private carPrice As String = String.Empty
    Private carNewStatus As Boolean = False


    Public Sub New()

        carCount += 1
        carIdentificationNumber = carCount

    End Sub


    Public Sub New(make As String, model As String, year As String, price As String, newStatus As Boolean)

        Me.New()


        carMake = make
        carModel = model
        carYear = year
        carPrice = price
        carNewStatus = newStatus

    End Sub


    ''' <summary>
    ''' Count ReadOnly Property - Gets the number of customers that have been created
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property


    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carIdentificationNumber

        End Get
    End Property


    Public Property newStatus() As Boolean
        Get
            Return carNewStatus
        End Get
        Set(ByVal value As Boolean)
            carNewStatus = value
        End Set
    End Property

    ''' <summary>
    ''' Title property - Gets and Sets the title of a customer
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' FirstName property - Gets and Sets the first name of a customer
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' LastName property - Gets and Sets the last name of a customer
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Year() As String
        Get
            Return carYear
        End Get
        Set(ByVal value As String)
            carYear = value
        End Set
    End Property


    Public Property Price() As String
        Get
            Return carPrice
        End Get
        Set(ByVal value As String)
            carPrice = value
        End Set
    End Property
    ''' <summary>
    ''' GetSalutation is a function that a salutation based on the private properties within the class scope
    ''' </summary>
    ''' <returns>String</returns>
    Public Function GetSalutation() As String

        Return "It Worked!!!".ToString()

    End Function
End Class
