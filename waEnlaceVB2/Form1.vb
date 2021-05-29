Public Class Form1

    Private Sub AlumnosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AlumnosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdEnlaceVBDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdEnlaceVBDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
        Me.AlumnosTableAdapter.Fill(Me.BdEnlaceVBDataSet.Alumnos)

    End Sub

    Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click

        Dim miDataSet As New Data.DataSet

        Dim miDataAdapter As New Data.SqlClient.SqlDataAdapter("select * from alumnos", "Data Source=GGLCG2PC07\SQLEXPRESS;Initial Catalog=bdEnlaceVB;Integrated Security=True")

        miDataAdapter.Fill(miDataSet)

        dgvListar.DataSource = miDataSet.Tables(0)

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim miDataSet As New Data.DataSet

        Dim miDataAdapter As New Data.SqlClient.SqlDataAdapter("insert into alumnos (ctrol,nombre,carrera) values ('" & Me.txtCtrol.Text.Trim & "' , '" & Me.txtNombre.Text.Trim & "' , '" & Me.txtCarrera.Text.Trim & "')", "Data Source=GGLCG2PC07\SQLEXPRESS;Initial Catalog=bdEnlaceVB;Integrated Security=True")

        miDataAdapter.Fill(miDataSet)

        Me.btnListar_Click(sender, e)

    End Sub
End Class
