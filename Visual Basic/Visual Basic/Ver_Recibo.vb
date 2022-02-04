
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data.SqlClient
Imports System.Text

Imports System.Data



Public Class Ver_Recibo
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-F3NR79S\SQLEXPRESS;Initial Catalog=MAD;Integrated Security=True")

    Private Sub Ver_Recibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UsuarioData As LogInData = LogInData.Instance
        Dim id3 As Integer = UsuarioData.getIdUsuario()
        Try

            con.Open()

            Dim cmd As SqlCommand = New SqlCommand("pb_Carrito", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_Usuario", id3)
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

            Dim cmd As SqlCommand = New SqlCommand("pb_Pagado", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_Usuario", id3)
            Dim drd As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleResult)
            Dim bs As New BindingSource
            bs.DataSource = drd

            DataGridViewPagado.DataSource = bs


            drd.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("No se pudo conectar a la base", "ADVERTEnCIA", MessageBoxButtons.OK)

            Me.Close()
        End Try



        Try
            Dim id As Integer = UsuarioData.getIdUsuario()
            con.Open()

            Dim cmd As SqlCommand = New SqlCommand("pb_Mostrar", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)

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


        Try
            Dim id As Integer = UsuarioData.getIdUsuario()
            con.Open()

            Dim cmd As SqlCommand = New SqlCommand("pb_Total", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_Usuario", id)

            Dim drd As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleResult)
            Dim bs As New BindingSource
            bs.DataSource = drd

            DataGridView3.DataSource = bs




            drd.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("No se pudo conectar a la base", "ADVERTEnCIA", MessageBoxButtons.OK)

            Me.Close()
        End Try

        Dim Sucursal As String = UsuarioData.getSucursal()

        If Sucursal = "" Then


        Else

            Try
                con.Open()

                Dim cmd As SqlCommand = New SqlCommand("pb_Sucursal", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Nombre", Sucursal)

                Dim drd As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleResult)
                Dim bs As New BindingSource
                bs.DataSource = drd

                DataGridView4.DataSource = bs




                drd.Close()
                con.Close()
            Catch ex As Exception
                MessageBox.Show("No se pudo conectar a la base", "ADVERTEnCIA", MessageBoxButtons.OK)

                Me.Close()
            End Try

        End If

    End Sub

    Public Function getColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values

    End Function


    Public Sub ExportarDatosPDF5(ByVal document As Document)

        Dim datable As New PdfPTable(DataGridViewPagado.Columns.Count)
        datable.DefaultCell.Padding = 3
        Dim headerwidhs As Single() = getColumnasSize(DataGridViewPagado)
        datable.SetWidths(headerwidhs)
        datable.WidthPercentage = 100
        datable.DefaultCell.BorderWidth = 2
        datable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        Dim encabezado As New Paragraph("ESTADO", New Font(Font.Name = "Tahoma", 20, Font.Bold))

        For i As Integer = 0 To DataGridViewPagado.Columns.Count - 1
            datable.AddCell(DataGridViewPagado.Columns(i).HeaderText)

        Next
        datable.HeaderRows = 1
        datable.DefaultCell.BorderWidth = 1

        For i As Integer = 0 To DataGridViewPagado.Rows.Count - 1
            For j As Integer = 0 To DataGridViewPagado.Columns.Count - 1
                datable.AddCell(DataGridViewPagado(j, i).Value.ToString())
            Next
            datable.CompleteRow()

        Next
        document.Add(encabezado)
        document.Add(datable)






    End Sub



    Public Sub ExportarDatosPDF4(ByVal document As Document)

        Dim datable As New PdfPTable(DataGridView4.Columns.Count)
        datable.DefaultCell.Padding = 3
        Dim headerwidhs As Single() = getColumnasSize(DataGridView4)
        datable.SetWidths(headerwidhs)
        datable.WidthPercentage = 100
        datable.DefaultCell.BorderWidth = 2
        datable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        Dim encabezado As New Paragraph("Sucursal", New Font(Font.Name = "Tahoma", 20, Font.Bold))

        For i As Integer = 0 To DataGridView4.Columns.Count - 1
            datable.AddCell(DataGridView4.Columns(i).HeaderText)

        Next
        datable.HeaderRows = 1
        datable.DefaultCell.BorderWidth = 1

        For i As Integer = 0 To DataGridView4.Rows.Count - 1
            For j As Integer = 0 To DataGridView4.Columns.Count - 1
                datable.AddCell(DataGridView4(j, i).Value.ToString())
            Next
            datable.CompleteRow()

        Next
        document.Add(encabezado)
        document.Add(datable)






    End Sub
    Public Sub ExportarDatosPDF3(ByVal document As Document)

        Dim datable As New PdfPTable(DataGridView3.Columns.Count)
        datable.DefaultCell.Padding = 3
        Dim headerwidhs As Single() = getColumnasSize(DataGridView3)
        datable.SetWidths(headerwidhs)
        datable.WidthPercentage = 100
        datable.DefaultCell.BorderWidth = 2
        datable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        Dim encabezado As New Paragraph("TOTAL A PAGAR", New Font(Font.Name = "Tahoma", 20, Font.Bold))

        For i As Integer = 0 To DataGridView3.Columns.Count - 1
            datable.AddCell(DataGridView3.Columns(i).HeaderText)

        Next
        datable.HeaderRows = 1
        datable.DefaultCell.BorderWidth = 1

        For i As Integer = 0 To DataGridView3.Rows.Count - 1
            For j As Integer = 0 To DataGridView3.Columns.Count - 1
                datable.AddCell(DataGridView3(j, i).Value.ToString())
            Next
            datable.CompleteRow()

        Next
        document.Add(encabezado)
        document.Add(datable)






    End Sub


    Public Sub ExportarDatosPDF2(ByVal document As Document)

        Dim datable As New PdfPTable(DataGridView2.Columns.Count)
        datable.DefaultCell.Padding = 3
        Dim headerwidhs As Single() = getColumnasSize(DataGridView2)
        datable.SetWidths(headerwidhs)
        datable.WidthPercentage = 100
        datable.DefaultCell.BorderWidth = 2
        datable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        Dim encabezado As New Paragraph("Datos del Cliente", New Font(Font.Name = "Tahoma", 20, Font.Bold))

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

        Dim encabezado As New Paragraph("Recibo del cliente", New Font(Font.Name = "Tahoma", 20, Font.Bold))
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Recibo.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            ExportarDatosPDF3(doc)
            ExportarDatosPDF2(doc)
            ExportarDatosPDF5(doc)
            Dim UsuarioData As LogInData = LogInData.Instance
            Dim Sucursal As String = UsuarioData.getSucursal()
            If Sucursal = "" Then

            Else
                ExportarDatosPDF4(doc)


            End If


            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            MessageBox.Show("No se puede generar el documento Pdf", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)







        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ver_Carrito_Marco.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub DataGridViewPagado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPagado.CellContentClick





    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Enlace As New EnlaceBD
        Dim UsuarioData As LogInData = LogInData.Instance
        Dim EstadoPagado As New DataTable
        Dim fk_Usuario As Integer = UsuarioData.getIdUsuario()


        EstadoPagado = Enlace.getpagado(fk_Usuario)
        MessageBox.Show("Su recibo ha sido pagado", "Aviso :)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim id3 As Integer = UsuarioData.getIdUsuario()

        DataGridViewPagado.Columns.Clear()
        DataGridViewPagado.Rows.Clear()

        Try

            con.Open()

            Dim cmd As SqlCommand = New SqlCommand("pb_Pagado", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_Usuario", id3)
            Dim drd As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleResult)
            Dim bs As New BindingSource
            bs.DataSource = drd

            DataGridViewPagado.DataSource = bs


            drd.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("No se pudo conectar a la base", "ADVERTEnCIA", MessageBoxButtons.OK)

            Me.Close()
        End Try






    End Sub
End Class