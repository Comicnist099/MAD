
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data.SqlClient
Imports System.Text

Imports System.Data
Public Class Reporte_de_Carrito_y_Horas

    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-F3NR79S\SQLEXPRESS;Initial Catalog=MAD;Integrated Security=True")

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu_Usuario3Marco_Admin.Show()
        Me.Close()
    End Sub

    Private Sub Reporte_de_Carrito_y_Horas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UsuarioData As LogInData = LogInData.Instance
        Dim id3 As Integer = UsuarioData.getIdUsuario()
        Try

            con.Open()

            Dim cmd As SqlCommand = New SqlCommand("select * from Horas", con)

            Dim drd As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleResult)
            Dim bs As New BindingSource
            bs.DataSource = drd

            DataGridView1.DataSource = bs




            drd.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("No se pudo conectar a la base", "ADVERTEnCIA", MessageBoxButtons.OK)

            Me.Close()
        End Try


        Try

            con.Open()

            Dim cmd As SqlCommand = New SqlCommand("select * from Ejemplo ORDER BY fk_Usuario", con)

            Dim drd As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleResult)
            Dim bs As New BindingSource
            bs.DataSource = drd

            DataGridView2.DataSource = bs




            drd.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("No se pudo conectar a la base", "ADVERTEnCIA", MessageBoxButtons.OK)

            Me.Close()
        End Try

    End Sub

    Public Function getColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values

    End Function



    Public Sub ExportarDatosPDF2(ByVal document As Document)

        Dim datable As New PdfPTable(DataGridView2.Columns.Count)
        datable.DefaultCell.Padding = 3
        Dim headerwidhs As Single() = getColumnasSize(DataGridView2)
        datable.SetWidths(headerwidhs)
        datable.WidthPercentage = 100
        datable.DefaultCell.BorderWidth = 2
        datable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        Dim encabezado As New Paragraph("Reporte de Carritos/Compras", New Font(Font.Name = "Tahoma", 20, Font.Bold))
        Dim texto As New Phrase("Fecha:" + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))

        For i As Integer = 0 To DataGridView2.Columns.Count - 1
            datable.AddCell(DataGridView2.Columns(i).HeaderText)

        Next
        datable.HeaderRows = 1
        datable.DefaultCell.BorderWidth = 1

        For i As Integer = 0 To DataGridView2.Rows.Count - 1
            For j As Integer = 0 To DataGridView2.Columns.Count - 1
                datable.AddCell(DataGridView2(j, i).Value.ToString())
            Next
            datable.CompleteRow()

        Next
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datable)






    End Sub



    Public Sub ExportarDatosPDF(ByVal document As Document)

        Dim datable As New PdfPTable(DataGridView1.Columns.Count)
        datable.DefaultCell.Padding = 3
        Dim headerwidhs As Single() = getColumnasSize(DataGridView1)
        datable.SetWidths(headerwidhs)
        datable.WidthPercentage = 100
        datable.DefaultCell.BorderWidth = 2
        datable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        Dim encabezado As New Paragraph("Reporte del Horas", New Font(Font.Name = "Tahoma", 20, Font.Bold))
        Dim texto As New Phrase("Fecha:" + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))

        For i As Integer = 0 To DataGridView1.Columns.Count - 1
            datable.AddCell(DataGridView1.Columns(i).HeaderText)

        Next
        datable.HeaderRows = 1
        datable.DefaultCell.BorderWidth = 1

        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            For j As Integer = 0 To DataGridView1.Columns.Count - 1
                datable.AddCell(DataGridView1(j, i).Value.ToString())
            Next
            datable.CompleteRow()

        Next
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datable)






    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Try
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte Horas.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)

            Dim UsuarioData As LogInData = LogInData.Instance
            Dim Sucursal As String = UsuarioData.getSucursal()






            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            MessageBox.Show("No se puede generar el documento Pdf", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)







        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte Horas.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF2(doc)

            Dim UsuarioData As LogInData = LogInData.Instance
            Dim Sucursal As String = UsuarioData.getSucursal()






            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            MessageBox.Show("No se puede generar el documento Pdf", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)




        End Try
    End Sub
End Class