Imports System.IO
Imports System.IO.TextReader
Imports System.Data.OleDb
Imports System.Text
Public Class Carga_Masiva_Sucursales
    Dim Domicilio As String
    Dim Nombre As String
    Dim fk_Encargado As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim UsuarioData As LogInData = LogInData.Instance
        Dim Enlace As New EnlaceBD
        Try





            Dim fname As String = "C:\Users\Victoria\Desktop\sucursales.csv"
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
                For i As Integer = 0 To 2
                    DataGridView1.Rows(r).Cells(i).Value = words(i)
                    Select Case i
                        Case 0
                            Nombre = DataGridView1.Rows(r).Cells(i).Value
                        Case 1
                            Domicilio = DataGridView1.Rows(r).Cells(i).Value
                        Case 2
                            fk_Encargado = DataGridView1.Rows(r).Cells(i).Value

                    End Select


                Next
                Enlace.AddSucursal(UsuarioData.getIdUsuario, Nombre, Domicilio, fk_Encargado)



                r = r + 1
            Loop
            reader.Close()
        Catch ex As Exception
        End Try




        MessageBox.Show("Se han dado de alta las sucursales")





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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class