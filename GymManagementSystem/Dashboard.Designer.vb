<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblAllmember = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblActivemember = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.llbl1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblEquipment = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.barChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pieChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GunaTransfarantPictureBox3 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox2 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaPanel3.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.barChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pieChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel3
        '
        Me.GunaPanel3.BackColor = System.Drawing.Color.White
        Me.GunaPanel3.Controls.Add(Me.Guna2Button2)
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(1119, 37)
        Me.GunaPanel3.TabIndex = 2
        '
        'Guna2Button2
        '
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.White
        Me.Guna2Button2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Guna2Button2.ImageOffset = New System.Drawing.Point(-10, 0)
        Me.Guna2Button2.Location = New System.Drawing.Point(5, 3)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(104, 31)
        Me.Guna2Button2.TabIndex = 2
        Me.Guna2Button2.Text = "Dashboard"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.lbl)
        Me.Guna2Panel1.Controls.Add(Me.lblAllmember)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(80, 74)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(284, 207)
        Me.Guna2Panel1.TabIndex = 3
        '
        'lbl
        '
        Me.lbl.BackColor = System.Drawing.Color.Transparent
        Me.lbl.Font = New System.Drawing.Font("LEMON MILK Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbl.Location = New System.Drawing.Point(98, 157)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(88, 25)
        Me.lbl.TabIndex = 160
        Me.lbl.Text = "Members"
        '
        'lblAllmember
        '
        Me.lblAllmember.BackColor = System.Drawing.Color.Transparent
        Me.lblAllmember.Font = New System.Drawing.Font("LEMON MILK Bold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllmember.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblAllmember.Location = New System.Drawing.Point(122, 93)
        Me.lblAllmember.Name = "lblAllmember"
        Me.lblAllmember.Size = New System.Drawing.Size(40, 70)
        Me.lblAllmember.TabIndex = 159
        Me.lblAllmember.Text = "0"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(492, 456)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(8, 4)
        Me.CheckedListBox1.TabIndex = 4
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderRadius = 20
        Me.Guna2Panel2.Controls.Add(Me.GunaTransfarantPictureBox2)
        Me.Guna2Panel2.Controls.Add(Me.lbl1)
        Me.Guna2Panel2.Controls.Add(Me.lblActivemember)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(417, 74)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(284, 207)
        Me.Guna2Panel2.TabIndex = 270
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("LEMON MILK Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbl1.Location = New System.Drawing.Point(63, 157)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(158, 25)
        Me.lbl1.TabIndex = 160
        Me.lbl1.Text = "Active Members"
        '
        'lblActivemember
        '
        Me.lblActivemember.BackColor = System.Drawing.Color.Transparent
        Me.lblActivemember.Font = New System.Drawing.Font("LEMON MILK Bold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivemember.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblActivemember.Location = New System.Drawing.Point(122, 93)
        Me.lblActivemember.Name = "lblActivemember"
        Me.lblActivemember.Size = New System.Drawing.Size(40, 70)
        Me.lblActivemember.TabIndex = 159
        Me.lblActivemember.Text = "0"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderRadius = 20
        Me.Guna2Panel3.Controls.Add(Me.GunaTransfarantPictureBox3)
        Me.Guna2Panel3.Controls.Add(Me.llbl1)
        Me.Guna2Panel3.Controls.Add(Me.lblEquipment)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(754, 74)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(284, 207)
        Me.Guna2Panel3.TabIndex = 270
        '
        'llbl1
        '
        Me.llbl1.BackColor = System.Drawing.Color.Transparent
        Me.llbl1.Font = New System.Drawing.Font("LEMON MILK Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.llbl1.Location = New System.Drawing.Point(70, 157)
        Me.llbl1.Name = "llbl1"
        Me.llbl1.Size = New System.Drawing.Size(145, 25)
        Me.llbl1.TabIndex = 160
        Me.llbl1.Text = "All Equipment"
        '
        'lblEquipment
        '
        Me.lblEquipment.BackColor = System.Drawing.Color.Transparent
        Me.lblEquipment.Font = New System.Drawing.Font("LEMON MILK Bold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquipment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblEquipment.Location = New System.Drawing.Point(122, 93)
        Me.lblEquipment.Name = "lblEquipment"
        Me.lblEquipment.Size = New System.Drawing.Size(40, 70)
        Me.lblEquipment.TabIndex = 159
        Me.lblEquipment.Text = "0"
        '
        'barChart
        '
        ChartArea5.Name = "ChartArea1"
        Me.barChart.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.barChart.Legends.Add(Legend5)
        Me.barChart.Location = New System.Drawing.Point(80, 340)
        Me.barChart.Name = "barChart"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Me.barChart.Series.Add(Series5)
        Me.barChart.Size = New System.Drawing.Size(406, 243)
        Me.barChart.TabIndex = 271
        Me.barChart.Text = "Chart1"
        '
        'pieChart
        '
        ChartArea6.Name = "ChartArea1"
        Me.pieChart.ChartAreas.Add(ChartArea6)
        Legend6.Name = "Legend1"
        Me.pieChart.Legends.Add(Legend6)
        Me.pieChart.Location = New System.Drawing.Point(632, 340)
        Me.pieChart.Name = "pieChart"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series6.Legend = "Legend1"
        Series6.Name = "Series1"
        Me.pieChart.Series.Add(Series6)
        Me.pieChart.Size = New System.Drawing.Size(406, 243)
        Me.pieChart.TabIndex = 271
        Me.pieChart.Text = "Chart1"
        '
        'GunaTransfarantPictureBox3
        '
        Me.GunaTransfarantPictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox3.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox3.Image = Global.GymManagementSystem.My.Resources.Resources.gymEquipment
        Me.GunaTransfarantPictureBox3.Location = New System.Drawing.Point(106, 19)
        Me.GunaTransfarantPictureBox3.Name = "GunaTransfarantPictureBox3"
        Me.GunaTransfarantPictureBox3.Size = New System.Drawing.Size(73, 68)
        Me.GunaTransfarantPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaTransfarantPictureBox3.TabIndex = 269
        Me.GunaTransfarantPictureBox3.TabStop = False
        '
        'GunaTransfarantPictureBox2
        '
        Me.GunaTransfarantPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox2.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox2.Image = Global.GymManagementSystem.My.Resources.Resources.personstatus
        Me.GunaTransfarantPictureBox2.Location = New System.Drawing.Point(106, 19)
        Me.GunaTransfarantPictureBox2.Name = "GunaTransfarantPictureBox2"
        Me.GunaTransfarantPictureBox2.Size = New System.Drawing.Size(73, 68)
        Me.GunaTransfarantPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaTransfarantPictureBox2.TabIndex = 269
        Me.GunaTransfarantPictureBox2.TabStop = False
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = Global.GymManagementSystem.My.Resources.Resources.memberlist
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(106, 19)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(73, 68)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaTransfarantPictureBox1.TabIndex = 269
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1119, 624)
        Me.Controls.Add(Me.pieChart)
        Me.Controls.Add(Me.barChart)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.GunaPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dashboard"
        Me.GunaPanel3.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.barChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pieChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents lbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblAllmember As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaTransfarantPictureBox2 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents lbl1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblActivemember As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaTransfarantPictureBox3 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents llbl1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblEquipment As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents barChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents pieChart As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
