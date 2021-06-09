<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuUtama))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MnMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeeInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstallmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromotionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DueListStaffsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GajiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(854, 47)
        Me.Panel1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(748, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(106, 47)
        Me.Panel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Roboto", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(55, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 47)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "X"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Roboto", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(3, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 47)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "-"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 47)
        Me.Label3.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(45, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 47)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "APLIKASI PENGGAJIAN"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnMaster, Me.StudentToolStripMenuItem1, Me.ToolsToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 47)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(854, 53)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MnMaster
        '
        Me.MnMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FeeToolStripMenuItem, Me.FeeInfoToolStripMenuItem, Me.InstallmentToolStripMenuItem})
        Me.MnMaster.Image = CType(resources.GetObject("MnMaster.Image"), System.Drawing.Image)
        Me.MnMaster.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MnMaster.Name = "MnMaster"
        Me.MnMaster.Size = New System.Drawing.Size(63, 49)
        Me.MnMaster.Text = "MASTER"
        Me.MnMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FeeToolStripMenuItem
        '
        Me.FeeToolStripMenuItem.Image = CType(resources.GetObject("FeeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FeeToolStripMenuItem.Name = "FeeToolStripMenuItem"
        Me.FeeToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.FeeToolStripMenuItem.Text = "Jabatan"
        '
        'FeeInfoToolStripMenuItem
        '
        Me.FeeInfoToolStripMenuItem.Image = CType(resources.GetObject("FeeInfoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FeeInfoToolStripMenuItem.Name = "FeeInfoToolStripMenuItem"
        Me.FeeInfoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FeeInfoToolStripMenuItem.Text = "Karyawan"
        '
        'InstallmentToolStripMenuItem
        '
        Me.InstallmentToolStripMenuItem.Image = CType(resources.GetObject("InstallmentToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InstallmentToolStripMenuItem.Name = "InstallmentToolStripMenuItem"
        Me.InstallmentToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.InstallmentToolStripMenuItem.Text = "Potongan"
        '
        'StudentToolStripMenuItem1
        '
        Me.StudentToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PromotionToolStripMenuItem})
        Me.StudentToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentToolStripMenuItem1.Image = CType(resources.GetObject("StudentToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.StudentToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StudentToolStripMenuItem1.Name = "StudentToolStripMenuItem1"
        Me.StudentToolStripMenuItem1.Size = New System.Drawing.Size(83, 49)
        Me.StudentToolStripMenuItem1.Text = "TRANSAKSI"
        Me.StudentToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PromotionToolStripMenuItem
        '
        Me.PromotionToolStripMenuItem.Image = CType(resources.GetObject("PromotionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PromotionToolStripMenuItem.Name = "PromotionToolStripMenuItem"
        Me.PromotionToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.PromotionToolStripMenuItem.Text = "GAJI"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Image = CType(resources.GetObject("ToolsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ToolsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(94, 49)
        Me.ToolsToolStripMenuItem.Text = "PENGATURAN"
        Me.ToolsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Image = CType(resources.GetObject("CalculatorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(97, 22)
        Me.CalculatorToolStripMenuItem.Text = "User"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DueListStaffsToolStripMenuItem, Me.KaryawanToolStripMenuItem, Me.GajiToolStripMenuItem})
        Me.ReportToolStripMenuItem.Image = CType(resources.GetObject("ReportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(73, 49)
        Me.ReportToolStripMenuItem.Text = "LAPORAN"
        Me.ReportToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DueListStaffsToolStripMenuItem
        '
        Me.DueListStaffsToolStripMenuItem.Image = CType(resources.GetObject("DueListStaffsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DueListStaffsToolStripMenuItem.Name = "DueListStaffsToolStripMenuItem"
        Me.DueListStaffsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.DueListStaffsToolStripMenuItem.Text = "Slip Gaji Karyawan"
        '
        'KaryawanToolStripMenuItem
        '
        Me.KaryawanToolStripMenuItem.Image = CType(resources.GetObject("KaryawanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KaryawanToolStripMenuItem.Name = "KaryawanToolStripMenuItem"
        Me.KaryawanToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.KaryawanToolStripMenuItem.Text = "Laporan Karyawan"
        '
        'GajiToolStripMenuItem
        '
        Me.GajiToolStripMenuItem.Image = CType(resources.GetObject("GajiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GajiToolStripMenuItem.Name = "GajiToolStripMenuItem"
        Me.GajiToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.GajiToolStripMenuItem.Text = "Laporan Gaji"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'frmMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 523)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMenuUtama"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MnMaster As ToolStripMenuItem
    Friend WithEvents FeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeeInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstallmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PromotionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DueListStaffsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KaryawanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GajiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
End Class
