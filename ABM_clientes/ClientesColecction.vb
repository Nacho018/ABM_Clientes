

Imports System.ComponentModel
Public Class ClientesColecction

    Inherits BindingList(Of ClientesClass)



    Protected Overrides Sub onAddingNew(ByVal e As AddingNewEventArgs)


        e.NewObject = New ClientesClass()



    End Sub


End Class
