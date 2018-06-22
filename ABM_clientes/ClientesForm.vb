Public Class ClientesForm



    Dim operacion_ As String
    Dim Micliente As New ClientesClass

    Public Property operacion() As String
        Get
            Return operacion_


        End Get

        Set(ByVal value As String)

            operacion_ = value

        End Set



    End Property




    Dim indice_ As Byte
    'a hace referncia a la ubicacion en la grilla

    Public Property indice() As String
        Get
            Return indice_

        End Get
        Set(ByVal value As String)
            indice_ = value

        End Set

    End Property



    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click

        Me.Close()

    End Sub




    Private Sub Aceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Aceptar.Click




        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox5.Text = "" Then


            MsgBox("No Debe haber Campos vacios")

            Exit Sub

        End If

        'If TextBox2.Text = "" Then

        '    MsgBox("Ingrese Nombre")

        '    Exit Sub

        'End If




        'If TextBox3.Text = "" Then

        '    MsgBox("Ingrese Direccion")

        '    Exit Sub

        'End If





        'If ComboBox1.Text = "" Then

        '    MsgBox("Elija categoria")

        '    Exit Sub

        'End If



        'If TextBox5.Text = "" Then

        '    MsgBox("INGRESE EL NRO DE SALDO")

        '    Exit Sub

        'End If




        Micliente.Id = CInt(TextBox1.Text)

        Micliente.Nomb = TextBox2.Text

        Micliente.Direccion = TextBox3.Text
        Micliente.categiva = (ComboBox1.SelectedItem)


        Micliente.Saldo = CDec(TextBox5.Text)


        'ComboBox1.DataSource = listacativa





        Select Case operacion_

            Case "Agregar"

                lst.Add(Micliente)

            Case "Eliminar"


                lst.RemoveAt(indice_)

            Case "Modificar"

                lst.Item(indice_) = Micliente





                Clientesgrid.DataGridView1.Refresh()

        End Select



        Me.Close()


    End Sub



    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then


            e.Handled = True


        End If

        'If TextBox1.Text = 0 Then

        '    MsgBox(" Ingrese Id ")

        '    TextBox1.Focus()

        'End If
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then

            e.Handled = True


        End If




    End Sub


    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsNumber(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then

            e.Handled = True


        End If

    End Sub



    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress


        e.Handled = True


    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "," Then


            e.Handled = True


        End If


    End Sub

End Class
