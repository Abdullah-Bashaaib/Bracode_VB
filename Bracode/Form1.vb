Imports System.ComponentModel
Imports System.Text
Imports ZXing


Partial Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        TypeBracodeComo.Items.Clear()

        TypeBracodeComo.Items.Add("CODE_128")
        TypeBracodeComo.Items.Add("EAN_13")
        TypeBracodeComo.Items.Add("CODE_39")
        TypeBracodeComo.Items.Add("CODE_93")
        TypeBracodeComo.Items.Add("QR_CODE")
        TypeBracodeComo.SelectedIndex = 0

        load_item()

        DataGridView1.DataSource = dt_item
        DataGridView1.Columns(0).HeaderText = "الباركود"
        DataGridView1.Columns(1).HeaderText = "الاسم"
        DataGridView1.Columns(2).HeaderText = "السعر"


    End Sub

    Private Sub CreateBracodeBtn_Click(sender As Object, e As EventArgs) Handles CreateBracodeBtn.Click
        On Error Resume Next
        If String.IsNullOrWhiteSpace(BracodeTxt.Text) Then
            Exit Sub
        End If

        Dim barcode As New BarcodeWriter

        If TypeBracodeComo.SelectedIndex = 0 Then barcode.Format = BarcodeFormat.CODE_128
        If TypeBracodeComo.SelectedIndex = 1 Then barcode.Format = BarcodeFormat.EAN_13
        If TypeBracodeComo.SelectedIndex = 2 Then barcode.Format = BarcodeFormat.CODE_39
        If TypeBracodeComo.SelectedIndex = 3 Then barcode.Format = BarcodeFormat.CODE_93
        If TypeBracodeComo.SelectedIndex = 4 Then barcode.Format = BarcodeFormat.QR_CODE

        PictureBox1.Image = barcode.Write(BracodeTxt.Text)


    End Sub

    Private Sub BracodeTxt_TextChanged(sender As Object, e As EventArgs) Handles BracodeTxt.TextChanged
        CreateBracodeBtn_Click(sender, e)
    End Sub

    Private Sub TypeBracodeComo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeBracodeComo.SelectedIndexChanged
        CreateBracodeBtn_Click(sender, e)
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        BracodeTxt.Text = DataGridView1.CurrentRow.Cells(0).Value
        NameClassTxt.Text = DataGridView1.CurrentRow.Cells(1).Value
        PriceClassTxt.Text = DataGridView1.CurrentRow.Cells(2).Value


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        On Error Resume Next
        e.Graphics.DrawImage(PictureBox1.Image.Clone, PictureBox1.Location.X, PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        e.HasMorePages = False


    End Sub

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        On Error Resume Next
        Dim pfd As New PrintDialog
        pfd.Document = PrintDocument1
        If pfd.ShowDialog = DialogResult.OK Then
            PrintDocument1.Print()

        End If
    End Sub
    Dim mouseDownLoc As New Point
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        On Error Resume Next
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            mouseDownLoc = e.Location
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            PictureBox1.Left = e.X + PictureBox1.Left - mouseDownLoc.X
            PictureBox1.Top = e.Y + PictureBox1.Top - mouseDownLoc.Y
        End If
    End Sub

    Private Sub NameClassTxt_TextChanged(sender As Object, e As EventArgs) Handles NameClassTxt.TextChanged
        Label1.Text = NameClassTxt.Text
    End Sub

    Private Sub PriceClassTxt_TextChanged(sender As Object, e As EventArgs) Handles PriceClassTxt.TextChanged
        Label2.Text = PriceClassTxt.Text

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        On Error Resume Next
        Dim sfd As New SaveFileDialog
        sfd.Filter = "File png | *.png"
        If sfd.ShowDialog = DialogResult.OK Then
            PictureBox1.Image.Save(sfd.FileName)
        End If
    End Sub
End Class
