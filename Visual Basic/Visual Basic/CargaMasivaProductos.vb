Imports System.IO
Imports System.IO.TextReader
Imports System.Data.OleDb
Imports System.Text

Public Class CargaMasivaProductos
    Dim fk_Empleado As String
    Dim Nombre As String
    Dim Descripcion As String
    Dim Categoria As String
    Dim Precio As Decimal
    Dim Descuento As Decimal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Enlace As New EnlaceBD
        Try





            Dim fname As String = "C:\Users\Victoria\Desktop\prueba.csv"
            Dim reader As New StreamReader(fname, Encoding.Default)
            Dim sline As String = ""
            Dim colsexpected As Integer = 4
            Dim r As Integer = 0


            sline = reader.ReadLine

            Do
                sline = reader.ReadLine
                If sline Is Nothing Then Exit Do
                Dim words() As String = sline.Split(",")
                DataGridView1.Rows.Add()
                For i As Integer = 0 To 5
                    DataGridView1.Rows(r).Cells(i).Value = words(i)
                    Select Case i
                        Case 0
                            fk_Empleado = DataGridView1.Rows(r).Cells(i).Value
                        Case 1
                            Nombre = DataGridView1.Rows(r).Cells(i).Value
                        Case 2
                            Descripcion = DataGridView1.Rows(r).Cells(i).Value
                        Case 3
                            Categoria = DataGridView1.Rows(r).Cells(i).Value
                        Case 4
                            Precio = DataGridView1.Rows(r).Cells(i).Value
                        Case 5
                            Descuento = DataGridView1.Rows(r).Cells(i).Value

                    End Select


                Next
                Enlace.AddProducto(fk_Empleado, Precio, Descuento, Nombre, Descripcion, Categoria)


                r = r + 1
            Loop
            reader.Close()
        Catch ex As Exception
        End Try
        MessageBox.Show("Se han dado de alta los productos")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim UsuarioData As LogInData = LogInData.Instance

        If UsuarioData.getPuesto() = "Admin" Then

            Menu_Usuario3Marco_Admin.Show()
        Else
            Menu_UsuarioMarco.Show()
        End If
        Me.Close()

    End Sub
End Class