Public Class ClientesClass



    Dim Id_ As Integer


    Dim Nomb_, categiva_, Direccion_ As String

    Dim Saldo_ As Decimal



    Public Property Id() As Integer
        Get

            Return Id_

        End Get
        Set(ByVal value As Integer)

            Id_ = value

        End Set
    End Property

    Public Property categiva() As String
        Get

            Return categiva_

        End Get
        Set(ByVal value As String)

            categiva_ = value

        End Set

    End Property



    Public Property Nomb() As String
        Get

            Return Nomb_

        End Get
        Set(ByVal value As String)

            Nomb_ = value

        End Set
    End Property


   

    Public Property Direccion() As String
        Get

            Return Direccion_

        End Get
        Set(ByVal value As String)

            Direccion_ = value

        End Set

    End Property


    Public Property Saldo() As Decimal
        Get

            Return Saldo_

        End Get

        Set(ByVal value As Decimal)

            Saldo_ = value


        End Set

    End Property

End Class
