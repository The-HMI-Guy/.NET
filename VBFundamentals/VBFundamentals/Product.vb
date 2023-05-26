Public Class Product
    Private _isActive As Boolean
    Public Property IsActive() As Boolean
        Get
            Return _isActive
        End Get
        Set(ByVal value As Boolean)
            _isActive = value
        End Set
    End Property
    Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
    Public Property ProductID As Integer
    Public Property ListPrice As Integer
    Public Property ProductNumber As String
    Public Property SellStartDate As DateTime
    Public Property SellEndDate As DateTime

    Public ReadOnly Property NameAndNumber() As String
        Get
            Return Name + "-" + ProductNumber
        End Get
    End Property
    'Sub CalculateSellEndDate(ByVal days As Integer,
    '                         ByRef sellDate As DateTime)
    '    SellEndDate = SellStartDate.AddDays(days)
    '    'Set the ByRef parameter
    '    sellDate = SellEndDate
    'End Sub
    Function CalculateSellEndDate(ByVal days As Integer) As DateTime
        SellEndDate = SellStartDate.AddDays(days)
        Return SellEndDate
    End Function
    Public Overrides Function ToString() As String
        Return Name + "(" + ProductNumber + ")"
    End Function
End Class
