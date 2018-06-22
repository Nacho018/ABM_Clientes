Public Class Clientesgrid


    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click


        ClientesForm.operacion = "Agregar"

        ClientesForm.Text = "Alta de iva compras"

        ClientesForm.Show()


    End Sub


    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        If lst.Count = 0 Then Exit Sub

        ClientesForm.operacion = "Modificar"

        ClientesForm.Text = "Modifica datos iva"

        ClientesForm.indice = DataGridView1.CurrentRow.Index



        LlenarForm()

        ClientesForm.Show()


    End Sub




    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click

        If lst.Count = 0 Then Exit Sub
        ClientesForm.operacion = "Eliminar"

        ClientesForm.Text = "Elimina datos iva"

        ClientesForm.indice = DataGridView1.CurrentRow.Index



        LlenarForm()

        ClientesForm.Show()
    End Sub

    Private Sub LlenarForm()



        ClientesForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        ClientesForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        ClientesForm.TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        ClientesForm.ComboBox1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString

        ClientesForm.TextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString

    End Sub

    Private Sub Clientesgrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        DataGridView1.DataSource = lst


    End Sub


    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()

    End Sub
End Class