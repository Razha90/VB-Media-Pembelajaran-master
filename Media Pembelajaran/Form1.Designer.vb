<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        BackPanel = New Panel()
        menu_keluar = New Button()
        menu_latihan = New Button()
        menu_belajar = New Button()
        profile_panel = New Panel()
        profile_role = New Label()
        profile_nama = New Label()
        Latihan = New Panel()
        latihan_kanan = New Panel()
        latihan_soal = New TextBox()
        latihan_next = New Button()
        latihan_pertanyaan = New Panel()
        latihan_1 = New RadioButton()
        latihan_2 = New RadioButton()
        latihan_4 = New RadioButton()
        latihan_3 = New RadioButton()
        latihan_pilih = New Panel()
        Label4 = New Label()
        latihan_kiri = New Panel()
        latihan_flow = New FlowLayoutPanel()
        Panel2 = New Panel()
        latihan_keluar = New Button()
        Label3 = New Label()
        Belajar = New Panel()
        belajar_default = New Panel()
        Label2 = New Label()
        belajar_layout = New Panel()
        belajar_subJudul = New Label()
        WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        belajar_isi = New Panel()
        belajar_text = New TextBox()
        belajar_next = New Button()
        belajar_previous = New Button()
        Panel1 = New Panel()
        belajar_keluar = New Button()
        Panel3 = New Panel()
        Label1 = New Label()
        belajar_flowLayout = New FlowLayoutPanel()
        BackPanel.SuspendLayout()
        profile_panel.SuspendLayout()
        Latihan.SuspendLayout()
        latihan_kanan.SuspendLayout()
        latihan_pertanyaan.SuspendLayout()
        latihan_pilih.SuspendLayout()
        latihan_kiri.SuspendLayout()
        Panel2.SuspendLayout()
        Belajar.SuspendLayout()
        belajar_default.SuspendLayout()
        belajar_layout.SuspendLayout()
        CType(WebView21, ComponentModel.ISupportInitialize).BeginInit()
        belajar_isi.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' BackPanel
        ' 
        BackPanel.Controls.Add(menu_keluar)
        BackPanel.Controls.Add(menu_latihan)
        BackPanel.Controls.Add(menu_belajar)
        BackPanel.Location = New Point(0, 0)
        BackPanel.Margin = New Padding(2)
        BackPanel.Name = "BackPanel"
        BackPanel.Size = New Size(550, 163)
        BackPanel.TabIndex = 2
        ' 
        ' menu_keluar
        ' 
        menu_keluar.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menu_keluar.Location = New Point(213, 118)
        menu_keluar.Margin = New Padding(2)
        menu_keluar.Name = "menu_keluar"
        menu_keluar.Size = New Size(116, 28)
        menu_keluar.TabIndex = 2
        menu_keluar.Text = "Keluar"
        menu_keluar.UseVisualStyleBackColor = True
        ' 
        ' menu_latihan
        ' 
        menu_latihan.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menu_latihan.Location = New Point(314, 20)
        menu_latihan.Margin = New Padding(2)
        menu_latihan.Name = "menu_latihan"
        menu_latihan.Size = New Size(127, 41)
        menu_latihan.TabIndex = 1
        menu_latihan.Text = "Latihan"
        menu_latihan.UseVisualStyleBackColor = True
        ' 
        ' menu_belajar
        ' 
        menu_belajar.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menu_belajar.Location = New Point(92, 20)
        menu_belajar.Margin = New Padding(2)
        menu_belajar.Name = "menu_belajar"
        menu_belajar.Size = New Size(127, 41)
        menu_belajar.TabIndex = 0
        menu_belajar.Text = "Belajar"
        menu_belajar.UseVisualStyleBackColor = True
        ' 
        ' profile_panel
        ' 
        profile_panel.Controls.Add(profile_role)
        profile_panel.Controls.Add(profile_nama)
        profile_panel.Location = New Point(8, 7)
        profile_panel.Margin = New Padding(2)
        profile_panel.Name = "profile_panel"
        profile_panel.Size = New Size(242, 56)
        profile_panel.TabIndex = 3
        ' 
        ' profile_role
        ' 
        profile_role.AutoSize = True
        profile_role.Location = New Point(14, 31)
        profile_role.Margin = New Padding(2, 0, 2, 0)
        profile_role.Name = "profile_role"
        profile_role.Size = New Size(96, 15)
        profile_role.TabIndex = 1
        profile_role.Text = "Role Kamu Disini"
        ' 
        ' profile_nama
        ' 
        profile_nama.AutoSize = True
        profile_nama.Location = New Point(14, 9)
        profile_nama.Margin = New Padding(2, 0, 2, 0)
        profile_nama.Name = "profile_nama"
        profile_nama.Size = New Size(105, 15)
        profile_nama.TabIndex = 0
        profile_nama.Text = "Nama Kamu Disini"
        ' 
        ' Latihan
        ' 
        Latihan.Controls.Add(latihan_kanan)
        Latihan.Controls.Add(latihan_pilih)
        Latihan.Controls.Add(latihan_kiri)
        Latihan.Dock = DockStyle.Fill
        Latihan.Location = New Point(0, 0)
        Latihan.Margin = New Padding(2)
        Latihan.Name = "Latihan"
        Latihan.Size = New Size(813, 364)
        Latihan.TabIndex = 4
        Latihan.Visible = False
        ' 
        ' latihan_kanan
        ' 
        latihan_kanan.Controls.Add(latihan_soal)
        latihan_kanan.Controls.Add(latihan_next)
        latihan_kanan.Controls.Add(latihan_pertanyaan)
        latihan_kanan.Dock = DockStyle.Fill
        latihan_kanan.Location = New Point(210, 0)
        latihan_kanan.Margin = New Padding(2)
        latihan_kanan.Name = "latihan_kanan"
        latihan_kanan.Size = New Size(603, 364)
        latihan_kanan.TabIndex = 1
        ' 
        ' latihan_soal
        ' 
        latihan_soal.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        latihan_soal.Location = New Point(45, 20)
        latihan_soal.Margin = New Padding(2)
        latihan_soal.Multiline = True
        latihan_soal.Name = "latihan_soal"
        latihan_soal.ReadOnly = True
        latihan_soal.Size = New Size(509, 107)
        latihan_soal.TabIndex = 8
        ' 
        ' latihan_next
        ' 
        latihan_next.Font = New Font("Segoe UI Black", 26F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        latihan_next.Location = New Point(558, 167)
        latihan_next.Margin = New Padding(2)
        latihan_next.Name = "latihan_next"
        latihan_next.Size = New Size(37, 98)
        latihan_next.TabIndex = 6
        latihan_next.Text = ">"
        latihan_next.UseVisualStyleBackColor = True
        ' 
        ' latihan_pertanyaan
        ' 
        latihan_pertanyaan.Controls.Add(latihan_1)
        latihan_pertanyaan.Controls.Add(latihan_2)
        latihan_pertanyaan.Controls.Add(latihan_4)
        latihan_pertanyaan.Controls.Add(latihan_3)
        latihan_pertanyaan.Location = New Point(48, 130)
        latihan_pertanyaan.Margin = New Padding(2)
        latihan_pertanyaan.Name = "latihan_pertanyaan"
        latihan_pertanyaan.Size = New Size(505, 145)
        latihan_pertanyaan.TabIndex = 5
        ' 
        ' latihan_1
        ' 
        latihan_1.AutoSize = True
        latihan_1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        latihan_1.Location = New Point(9, 13)
        latihan_1.Margin = New Padding(2)
        latihan_1.Name = "latihan_1"
        latihan_1.Size = New Size(123, 25)
        latihan_1.TabIndex = 0
        latihan_1.TabStop = True
        latihan_1.Text = "RadioButton1"
        latihan_1.UseVisualStyleBackColor = True
        ' 
        ' latihan_2
        ' 
        latihan_2.AutoSize = True
        latihan_2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        latihan_2.Location = New Point(9, 46)
        latihan_2.Margin = New Padding(2)
        latihan_2.Name = "latihan_2"
        latihan_2.Size = New Size(123, 25)
        latihan_2.TabIndex = 1
        latihan_2.TabStop = True
        latihan_2.Text = "RadioButton2"
        latihan_2.UseVisualStyleBackColor = True
        ' 
        ' latihan_4
        ' 
        latihan_4.AutoSize = True
        latihan_4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        latihan_4.Location = New Point(9, 109)
        latihan_4.Margin = New Padding(2)
        latihan_4.Name = "latihan_4"
        latihan_4.Size = New Size(123, 25)
        latihan_4.TabIndex = 3
        latihan_4.TabStop = True
        latihan_4.Text = "RadioButton4"
        latihan_4.UseVisualStyleBackColor = True
        ' 
        ' latihan_3
        ' 
        latihan_3.AutoSize = True
        latihan_3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        latihan_3.Location = New Point(9, 78)
        latihan_3.Margin = New Padding(2)
        latihan_3.Name = "latihan_3"
        latihan_3.Size = New Size(123, 25)
        latihan_3.TabIndex = 2
        latihan_3.TabStop = True
        latihan_3.Text = "RadioButton3"
        latihan_3.UseVisualStyleBackColor = True
        ' 
        ' latihan_pilih
        ' 
        latihan_pilih.BackgroundImage = My.Resources.Resources.bg_materi
        latihan_pilih.BackgroundImageLayout = ImageLayout.Stretch
        latihan_pilih.Controls.Add(Label4)
        latihan_pilih.Dock = DockStyle.Fill
        latihan_pilih.Location = New Point(210, 0)
        latihan_pilih.Margin = New Padding(2)
        latihan_pilih.Name = "latihan_pilih"
        latihan_pilih.Size = New Size(603, 364)
        latihan_pilih.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(318, 17)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(247, 41)
        Label4.TabIndex = 0
        Label4.Text = "Pilihlah Latihan"
        ' 
        ' latihan_kiri
        ' 
        latihan_kiri.BackColor = Color.IndianRed
        latihan_kiri.Controls.Add(latihan_flow)
        latihan_kiri.Controls.Add(Panel2)
        latihan_kiri.Dock = DockStyle.Left
        latihan_kiri.Location = New Point(0, 0)
        latihan_kiri.Margin = New Padding(2)
        latihan_kiri.Name = "latihan_kiri"
        latihan_kiri.Size = New Size(210, 364)
        latihan_kiri.TabIndex = 0
        ' 
        ' latihan_flow
        ' 
        latihan_flow.Dock = DockStyle.Left
        latihan_flow.Location = New Point(0, 90)
        latihan_flow.Margin = New Padding(2)
        latihan_flow.Name = "latihan_flow"
        latihan_flow.Size = New Size(210, 274)
        latihan_flow.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(latihan_keluar)
        Panel2.Controls.Add(Label3)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(210, 90)
        Panel2.TabIndex = 0
        ' 
        ' latihan_keluar
        ' 
        latihan_keluar.Location = New Point(8, 7)
        latihan_keluar.Margin = New Padding(2)
        latihan_keluar.Name = "latihan_keluar"
        latihan_keluar.Size = New Size(78, 20)
        latihan_keluar.TabIndex = 1
        latihan_keluar.Text = "keluar"
        latihan_keluar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(38, 31)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 41)
        Label3.TabIndex = 0
        Label3.Text = "Latihan"
        ' 
        ' Belajar
        ' 
        Belajar.Controls.Add(belajar_default)
        Belajar.Controls.Add(belajar_layout)
        Belajar.Controls.Add(Panel1)
        Belajar.Dock = DockStyle.Fill
        Belajar.Location = New Point(0, 0)
        Belajar.Margin = New Padding(2)
        Belajar.Name = "Belajar"
        Belajar.Size = New Size(813, 364)
        Belajar.TabIndex = 5
        Belajar.Visible = False
        ' 
        ' belajar_default
        ' 
        belajar_default.BackgroundImage = My.Resources.Resources.bg_materi1
        belajar_default.BackgroundImageLayout = ImageLayout.Stretch
        belajar_default.Controls.Add(Label2)
        belajar_default.Dock = DockStyle.Fill
        belajar_default.Location = New Point(210, 0)
        belajar_default.Margin = New Padding(2)
        belajar_default.Name = "belajar_default"
        belajar_default.Size = New Size(603, 364)
        belajar_default.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(500, 38)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(327, 45)
        Label2.TabIndex = 0
        Label2.Text = "Silakan Pilih Materi"
        ' 
        ' belajar_layout
        ' 
        belajar_layout.BackColor = Color.LemonChiffon
        belajar_layout.BackgroundImage = My.Resources.Resources.materis
        belajar_layout.BackgroundImageLayout = ImageLayout.Stretch
        belajar_layout.Controls.Add(belajar_subJudul)
        belajar_layout.Controls.Add(WebView21)
        belajar_layout.Controls.Add(belajar_isi)
        belajar_layout.Controls.Add(belajar_next)
        belajar_layout.Controls.Add(belajar_previous)
        belajar_layout.Dock = DockStyle.Fill
        belajar_layout.Location = New Point(210, 0)
        belajar_layout.Margin = New Padding(2)
        belajar_layout.Name = "belajar_layout"
        belajar_layout.Size = New Size(603, 364)
        belajar_layout.TabIndex = 1
        ' 
        ' belajar_subJudul
        ' 
        belajar_subJudul.AutoSize = True
        belajar_subJudul.Font = New Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        belajar_subJudul.Location = New Point(253, 25)
        belajar_subJudul.Margin = New Padding(2, 0, 2, 0)
        belajar_subJudul.Name = "belajar_subJudul"
        belajar_subJudul.Size = New Size(84, 31)
        belajar_subJudul.TabIndex = 3
        belajar_subJudul.Text = "Label3"
        ' 
        ' WebView21
        ' 
        WebView21.AllowExternalDrop = True
        WebView21.CreationProperties = Nothing
        WebView21.DefaultBackgroundColor = Color.White
        WebView21.Location = New Point(238, 102)
        WebView21.Name = "WebView21"
        WebView21.Size = New Size(75, 23)
        WebView21.TabIndex = 1
        WebView21.ZoomFactor = 1R
        ' 
        ' belajar_isi
        ' 
        belajar_isi.Controls.Add(belajar_text)
        belajar_isi.Location = New Point(55, 7)
        belajar_isi.Margin = New Padding(2)
        belajar_isi.Name = "belajar_isi"
        belajar_isi.Size = New Size(210, 90)
        belajar_isi.TabIndex = 2
        ' 
        ' belajar_text
        ' 
        belajar_text.Location = New Point(2, 2)
        belajar_text.Margin = New Padding(2)
        belajar_text.Multiline = True
        belajar_text.Name = "belajar_text"
        belajar_text.Size = New Size(106, 29)
        belajar_text.TabIndex = 0
        belajar_text.Text = "sdsdsd"
        ' 
        ' belajar_next
        ' 
        belajar_next.BackColor = Color.Red
        belajar_next.BackgroundImage = My.Resources.Resources._next
        belajar_next.BackgroundImageLayout = ImageLayout.Zoom
        belajar_next.Location = New Point(556, 156)
        belajar_next.Margin = New Padding(2)
        belajar_next.Name = "belajar_next"
        belajar_next.Size = New Size(38, 53)
        belajar_next.TabIndex = 1
        belajar_next.UseVisualStyleBackColor = False
        ' 
        ' belajar_previous
        ' 
        belajar_previous.BackColor = Color.Red
        belajar_previous.BackgroundImage = My.Resources.Resources.previous
        belajar_previous.BackgroundImageLayout = ImageLayout.Zoom
        belajar_previous.Location = New Point(4, 143)
        belajar_previous.Margin = New Padding(2)
        belajar_previous.Name = "belajar_previous"
        belajar_previous.Size = New Size(41, 58)
        belajar_previous.TabIndex = 0
        belajar_previous.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.IndianRed
        Panel1.Controls.Add(belajar_keluar)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(belajar_flowLayout)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(210, 364)
        Panel1.TabIndex = 0
        ' 
        ' belajar_keluar
        ' 
        belajar_keluar.Location = New Point(8, 337)
        belajar_keluar.Margin = New Padding(2)
        belajar_keluar.Name = "belajar_keluar"
        belajar_keluar.Size = New Size(78, 20)
        belajar_keluar.TabIndex = 1
        belajar_keluar.Text = "Keluar"
        belajar_keluar.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Margin = New Padding(2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(210, 53)
        Panel3.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(28, 13)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 32)
        Label1.TabIndex = 0
        Label1.Text = "Pilih Materi"
        ' 
        ' belajar_flowLayout
        ' 
        belajar_flowLayout.Location = New Point(0, 55)
        belajar_flowLayout.Margin = New Padding(2)
        belajar_flowLayout.Name = "belajar_flowLayout"
        belajar_flowLayout.Size = New Size(210, 276)
        belajar_flowLayout.TabIndex = 0
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.image_bg
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(813, 364)
        Controls.Add(Belajar)
        Controls.Add(Latihan)
        Controls.Add(profile_panel)
        Controls.Add(BackPanel)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        MinimizeBox = False
        Name = "Home"
        RightToLeft = RightToLeft.No
        StartPosition = FormStartPosition.CenterParent
        Text = "MePA"
        WindowState = FormWindowState.Maximized
        BackPanel.ResumeLayout(False)
        profile_panel.ResumeLayout(False)
        profile_panel.PerformLayout()
        Latihan.ResumeLayout(False)
        latihan_kanan.ResumeLayout(False)
        latihan_kanan.PerformLayout()
        latihan_pertanyaan.ResumeLayout(False)
        latihan_pertanyaan.PerformLayout()
        latihan_pilih.ResumeLayout(False)
        latihan_pilih.PerformLayout()
        latihan_kiri.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Belajar.ResumeLayout(False)
        belajar_default.ResumeLayout(False)
        belajar_default.PerformLayout()
        belajar_layout.ResumeLayout(False)
        belajar_layout.PerformLayout()
        CType(WebView21, ComponentModel.ISupportInitialize).EndInit()
        belajar_isi.ResumeLayout(False)
        belajar_isi.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents profile_panel As Panel
    Friend WithEvents BackPanel As Panel
    Friend WithEvents profile_nama As Label
    Friend WithEvents profile_role As Label
    Friend WithEvents menu_keluar As Button
    Friend WithEvents menu_latihan As Button
    Friend WithEvents menu_belajar As Button
    Friend WithEvents Latihan As Panel
    Friend WithEvents Belajar As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents belajar_layout As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents belajar_flowLayout As FlowLayoutPanel
    Friend WithEvents belajar_next As Button
    Friend WithEvents belajar_previous As Button
    Friend WithEvents belajar_isi As Panel
    Friend WithEvents belajar_text As TextBox
    Friend WithEvents belajar_default As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents belajar_keluar As Button
    Friend WithEvents belajar_subJudul As Label
    Friend WithEvents latihan_kanan As Panel
    Friend WithEvents latihan_kiri As Panel
    Friend WithEvents latihan_flow As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents latihan_keluar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents latihan_pilih As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents latihan_pertanyaan As Panel
    Friend WithEvents latihan_1 As RadioButton
    Friend WithEvents latihan_2 As RadioButton
    Friend WithEvents latihan_4 As RadioButton
    Friend WithEvents latihan_3 As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents latihan_next As Button
    Friend WithEvents latihan_soal As TextBox
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2

End Class
