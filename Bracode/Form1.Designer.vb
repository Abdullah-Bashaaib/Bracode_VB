Partial Public Class Form1
    Inherits DevExpress.XtraEditors.XtraForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SaveBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.CreateBracodeBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.PriceClassTxt = New System.Windows.Forms.TextBox()
        Me.PriceClassLap = New System.Windows.Forms.Label()
        Me.NameClassTxt = New System.Windows.Forms.TextBox()
        Me.NameClassLap = New System.Windows.Forms.Label()
        Me.BracodeTxt = New System.Windows.Forms.TextBox()
        Me.BracodeLap = New System.Windows.Forms.Label()
        Me.TypeBracodeComo = New System.Windows.Forms.ComboBox()
        Me.TypeBracodeLap = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.SaveBtn)
        Me.Panel1.Controls.Add(Me.PrintBtn)
        Me.Panel1.Controls.Add(Me.CreateBracodeBtn)
        Me.Panel1.Controls.Add(Me.PriceClassTxt)
        Me.Panel1.Controls.Add(Me.PriceClassLap)
        Me.Panel1.Controls.Add(Me.NameClassTxt)
        Me.Panel1.Controls.Add(Me.NameClassLap)
        Me.Panel1.Controls.Add(Me.BracodeTxt)
        Me.Panel1.Controls.Add(Me.BracodeLap)
        Me.Panel1.Controls.Add(Me.TypeBracodeComo)
        Me.Panel1.Controls.Add(Me.TypeBracodeLap)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(618, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(306, 522)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tajawal Black", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tajawal", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Location = New System.Drawing.Point(15, 338)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tajawal", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(276, 172)
        Me.DataGridView1.TabIndex = 11
        '
        'SaveBtn
        '
        Me.SaveBtn.Appearance.Font = New System.Drawing.Font("Tajawal", 8.0!, System.Drawing.FontStyle.Bold)
        Me.SaveBtn.Appearance.Options.UseFont = True
        Me.SaveBtn.ImageOptions.Image = CType(resources.GetObject("SaveBtn.ImageOptions.Image"), System.Drawing.Image)
        Me.SaveBtn.Location = New System.Drawing.Point(202, 290)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(89, 29)
        Me.SaveBtn.TabIndex = 10
        Me.SaveBtn.Text = "حفظ"
        '
        'PrintBtn
        '
        Me.PrintBtn.Appearance.Font = New System.Drawing.Font("Tajawal", 8.0!, System.Drawing.FontStyle.Bold)
        Me.PrintBtn.Appearance.Options.UseFont = True
        Me.PrintBtn.ImageOptions.Image = CType(resources.GetObject("PrintBtn.ImageOptions.Image"), System.Drawing.Image)
        Me.PrintBtn.Location = New System.Drawing.Point(110, 290)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(89, 29)
        Me.PrintBtn.TabIndex = 9
        Me.PrintBtn.Text = "طباعة"
        '
        'CreateBracodeBtn
        '
        Me.CreateBracodeBtn.Appearance.Font = New System.Drawing.Font("Tajawal", 8.0!, System.Drawing.FontStyle.Bold)
        Me.CreateBracodeBtn.Appearance.Options.UseFont = True
        Me.CreateBracodeBtn.ImageOptions.Image = CType(resources.GetObject("CreateBracodeBtn.ImageOptions.Image"), System.Drawing.Image)
        Me.CreateBracodeBtn.Location = New System.Drawing.Point(15, 290)
        Me.CreateBracodeBtn.Name = "CreateBracodeBtn"
        Me.CreateBracodeBtn.Size = New System.Drawing.Size(89, 29)
        Me.CreateBracodeBtn.TabIndex = 8
        Me.CreateBracodeBtn.Text = "إنشاء باركود"
        '
        'PriceClassTxt
        '
        Me.PriceClassTxt.Font = New System.Drawing.Font("RB", 8.0!)
        Me.PriceClassTxt.Location = New System.Drawing.Point(15, 246)
        Me.PriceClassTxt.Name = "PriceClassTxt"
        Me.PriceClassTxt.Size = New System.Drawing.Size(276, 26)
        Me.PriceClassTxt.TabIndex = 7
        Me.PriceClassTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PriceClassLap
        '
        Me.PriceClassLap.AutoSize = True
        Me.PriceClassLap.Font = New System.Drawing.Font("RB", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceClassLap.Location = New System.Drawing.Point(230, 215)
        Me.PriceClassLap.Name = "PriceClassLap"
        Me.PriceClassLap.Size = New System.Drawing.Size(61, 20)
        Me.PriceClassLap.TabIndex = 6
        Me.PriceClassLap.Text = "سعر الصنف"
        '
        'NameClassTxt
        '
        Me.NameClassTxt.Font = New System.Drawing.Font("RB", 8.0!)
        Me.NameClassTxt.Location = New System.Drawing.Point(15, 179)
        Me.NameClassTxt.Name = "NameClassTxt"
        Me.NameClassTxt.Size = New System.Drawing.Size(276, 26)
        Me.NameClassTxt.TabIndex = 5
        Me.NameClassTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NameClassLap
        '
        Me.NameClassLap.AutoSize = True
        Me.NameClassLap.Font = New System.Drawing.Font("RB", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameClassLap.Location = New System.Drawing.Point(232, 148)
        Me.NameClassLap.Name = "NameClassLap"
        Me.NameClassLap.Size = New System.Drawing.Size(59, 20)
        Me.NameClassLap.TabIndex = 4
        Me.NameClassLap.Text = "اسم الصنف"
        '
        'BracodeTxt
        '
        Me.BracodeTxt.Font = New System.Drawing.Font("RB", 8.0!)
        Me.BracodeTxt.Location = New System.Drawing.Point(15, 112)
        Me.BracodeTxt.Name = "BracodeTxt"
        Me.BracodeTxt.Size = New System.Drawing.Size(276, 26)
        Me.BracodeTxt.TabIndex = 3
        Me.BracodeTxt.Text = "123456789"
        Me.BracodeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BracodeLap
        '
        Me.BracodeLap.AutoSize = True
        Me.BracodeLap.Font = New System.Drawing.Font("RB", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BracodeLap.Location = New System.Drawing.Point(243, 81)
        Me.BracodeLap.Name = "BracodeLap"
        Me.BracodeLap.Size = New System.Drawing.Size(48, 20)
        Me.BracodeLap.TabIndex = 2
        Me.BracodeLap.Text = "الباراكود"
        '
        'TypeBracodeComo
        '
        Me.TypeBracodeComo.Font = New System.Drawing.Font("RB", 8.0!)
        Me.TypeBracodeComo.FormattingEnabled = True
        Me.TypeBracodeComo.Location = New System.Drawing.Point(15, 45)
        Me.TypeBracodeComo.Name = "TypeBracodeComo"
        Me.TypeBracodeComo.Size = New System.Drawing.Size(276, 28)
        Me.TypeBracodeComo.TabIndex = 1
        '
        'TypeBracodeLap
        '
        Me.TypeBracodeLap.AutoSize = True
        Me.TypeBracodeLap.Font = New System.Drawing.Font("RB", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeBracodeLap.Location = New System.Drawing.Point(225, 14)
        Me.TypeBracodeLap.Name = "TypeBracodeLap"
        Me.TypeBracodeLap.Size = New System.Drawing.Size(66, 20)
        Me.TypeBracodeLap.TabIndex = 0
        Me.TypeBracodeLap.Text = "نوع الباراكود"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(174, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(334, 314)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PrintDocument1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("RB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "اسم الصنف"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("RB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(294, 399)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 35)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "سعر الصنف"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 522)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bracode"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TypeBracodeLap As Label
    Friend WithEvents TypeBracodeComo As ComboBox
    Friend WithEvents PriceClassTxt As TextBox
    Friend WithEvents PriceClassLap As Label
    Friend WithEvents NameClassTxt As TextBox
    Friend WithEvents NameClassLap As Label
    Friend WithEvents BracodeTxt As TextBox
    Friend WithEvents BracodeLap As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SaveBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CreateBracodeBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

#End Region

End Class
