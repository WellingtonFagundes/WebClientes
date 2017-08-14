Public Class ClientesDTO

    Private _idCliente As Integer
    Private _nome As String
    Private _endereco As String
    Private _cidade As String
    Private _telefone As String
    Private _email As String
    Private _ativo As Boolean

    Public Property IdCliente As Integer
        Get
            Return _idCliente
        End Get
        Set(value As Integer)
            _idCliente = value
        End Set
    End Property

    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Public Property Endereco As String
        Get
            Return _endereco
        End Get
        Set(value As String)
            _endereco = value
        End Set
    End Property

    Public Property Cidade As String
        Get
            Return _cidade
        End Get
        Set(value As String)
            _cidade = value
        End Set
    End Property

    Public Property Telefone As String
        Get
            Return _telefone
        End Get
        Set(value As String)
            _telefone = value
        End Set
    End Property
    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property
    Public Property Ativo As Boolean
        Get
            Return _ativo
        End Get
        Set(value As Boolean)
            _ativo = value
        End Set
    End Property
End Class
