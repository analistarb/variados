Public Class Lado

    Public Property Nome() As String
        Get
            Return m_Nome
        End Get
        Set(value As String)
            m_Nome = value
        End Set
    End Property
    Private m_Nome As String
    Public Property Tamanho() As Integer
        Get
            Return m_Tamanho
        End Get
        Set(value As Integer)
            m_Tamanho = value
        End Set
    End Property
    Private m_Tamanho As Integer

End Class
