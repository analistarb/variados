Public Class Poligono

    Public Sub New()
        Me.Lados = New HashSet(Of Lado)()
    End Sub

    Public Property Nome() As String
        Get
            Return m_Nome
        End Get
        Set(value As String)
            m_Nome = value
        End Set
    End Property
    Private m_Nome As String
    
    Public Property Lados() As ICollection(Of Lado)
        Get
            Return m_Lados
        End Get
        Set(value As ICollection(Of Lado))
            m_Lados = value
        End Set
    End Property
    Private m_Lados As ICollection(Of Lado)

    Public Function GetQtdLados() As Integer
        Return Lados.Count
    End Function

End Class
