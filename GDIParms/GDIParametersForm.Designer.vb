<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GDIParametersForm
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
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.PaintEventTabPage = New System.Windows.Forms.TabPage()
        Me.UpdateTabPage = New System.Windows.Forms.TabPage()
        Me.SliderGroupBox = New System.Windows.Forms.GroupBox()
        Me.LocationTrackBar = New System.Windows.Forms.TrackBar()
        Me.YOffsetTrackBar = New System.Windows.Forms.TrackBar()
        Me.XOffsetTrackBar = New System.Windows.Forms.TrackBar()
        Me.RotateTrackBar = New System.Windows.Forms.TrackBar()
        Me.YScaleTrackBar = New System.Windows.Forms.TrackBar()
        Me.XScaleTrackBar = New System.Windows.Forms.TrackBar()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl.SuspendLayout()
        Me.UpdateTabPage.SuspendLayout()
        Me.SliderGroupBox.SuspendLayout()
        CType(Me.LocationTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YOffsetTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XOffsetTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RotateTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YScaleTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XScaleTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.PaintEventTabPage)
        Me.TabControl.Controls.Add(Me.UpdateTabPage)
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.HotTrack = True
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(822, 624)
        Me.TabControl.TabIndex = 0
        '
        'PaintEventTabPage
        '
        Me.PaintEventTabPage.Location = New System.Drawing.Point(4, 29)
        Me.PaintEventTabPage.Name = "PaintEventTabPage"
        Me.PaintEventTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.PaintEventTabPage.Size = New System.Drawing.Size(814, 591)
        Me.PaintEventTabPage.TabIndex = 0
        Me.PaintEventTabPage.Text = "Paint Event"
        Me.PaintEventTabPage.UseVisualStyleBackColor = True
        '
        'UpdateTabPage
        '
        Me.UpdateTabPage.Controls.Add(Me.SliderGroupBox)
        Me.UpdateTabPage.Location = New System.Drawing.Point(4, 29)
        Me.UpdateTabPage.Name = "UpdateTabPage"
        Me.UpdateTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.UpdateTabPage.Size = New System.Drawing.Size(814, 591)
        Me.UpdateTabPage.TabIndex = 1
        Me.UpdateTabPage.Text = "Update Parms"
        Me.UpdateTabPage.UseVisualStyleBackColor = True
        '
        'SliderGroupBox
        '
        Me.SliderGroupBox.Controls.Add(Me.LocationTrackBar)
        Me.SliderGroupBox.Controls.Add(Me.YOffsetTrackBar)
        Me.SliderGroupBox.Controls.Add(Me.XOffsetTrackBar)
        Me.SliderGroupBox.Controls.Add(Me.RotateTrackBar)
        Me.SliderGroupBox.Controls.Add(Me.YScaleTrackBar)
        Me.SliderGroupBox.Controls.Add(Me.XScaleTrackBar)
        Me.SliderGroupBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.SliderGroupBox.Location = New System.Drawing.Point(517, 3)
        Me.SliderGroupBox.Name = "SliderGroupBox"
        Me.SliderGroupBox.Size = New System.Drawing.Size(294, 585)
        Me.SliderGroupBox.TabIndex = 1
        Me.SliderGroupBox.TabStop = False
        '
        'LocationTrackBar
        '
        Me.LocationTrackBar.AutoSize = False
        Me.LocationTrackBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.LocationTrackBar.LargeChange = 20
        Me.LocationTrackBar.Location = New System.Drawing.Point(3, 297)
        Me.LocationTrackBar.Maximum = 100
        Me.LocationTrackBar.Name = "LocationTrackBar"
        Me.LocationTrackBar.Size = New System.Drawing.Size(288, 55)
        Me.LocationTrackBar.TabIndex = 5
        '
        'YOffsetTrackBar
        '
        Me.YOffsetTrackBar.AutoSize = False
        Me.YOffsetTrackBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.YOffsetTrackBar.LargeChange = 20
        Me.YOffsetTrackBar.Location = New System.Drawing.Point(3, 242)
        Me.YOffsetTrackBar.Maximum = 100
        Me.YOffsetTrackBar.Name = "YOffsetTrackBar"
        Me.YOffsetTrackBar.Size = New System.Drawing.Size(288, 55)
        Me.YOffsetTrackBar.TabIndex = 4
        '
        'XOffsetTrackBar
        '
        Me.XOffsetTrackBar.AutoSize = False
        Me.XOffsetTrackBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.XOffsetTrackBar.LargeChange = 20
        Me.XOffsetTrackBar.Location = New System.Drawing.Point(3, 187)
        Me.XOffsetTrackBar.Maximum = 100
        Me.XOffsetTrackBar.Name = "XOffsetTrackBar"
        Me.XOffsetTrackBar.Size = New System.Drawing.Size(288, 55)
        Me.XOffsetTrackBar.TabIndex = 3
        '
        'RotateTrackBar
        '
        Me.RotateTrackBar.AutoSize = False
        Me.RotateTrackBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.RotateTrackBar.LargeChange = 45
        Me.RotateTrackBar.Location = New System.Drawing.Point(3, 132)
        Me.RotateTrackBar.Maximum = 360
        Me.RotateTrackBar.Name = "RotateTrackBar"
        Me.RotateTrackBar.Size = New System.Drawing.Size(288, 55)
        Me.RotateTrackBar.SmallChange = 115
        Me.RotateTrackBar.TabIndex = 2
        Me.RotateTrackBar.TickFrequency = 15
        '
        'YScaleTrackBar
        '
        Me.YScaleTrackBar.AutoSize = False
        Me.YScaleTrackBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.YScaleTrackBar.LargeChange = 10
        Me.YScaleTrackBar.Location = New System.Drawing.Point(3, 77)
        Me.YScaleTrackBar.Maximum = 100
        Me.YScaleTrackBar.Minimum = 1
        Me.YScaleTrackBar.Name = "YScaleTrackBar"
        Me.YScaleTrackBar.Size = New System.Drawing.Size(288, 55)
        Me.YScaleTrackBar.TabIndex = 1
        Me.YScaleTrackBar.Value = 10
        '
        'XScaleTrackBar
        '
        Me.XScaleTrackBar.AutoSize = False
        Me.XScaleTrackBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.XScaleTrackBar.LargeChange = 10
        Me.XScaleTrackBar.Location = New System.Drawing.Point(3, 22)
        Me.XScaleTrackBar.Maximum = 100
        Me.XScaleTrackBar.Minimum = 1
        Me.XScaleTrackBar.Name = "XScaleTrackBar"
        Me.XScaleTrackBar.Size = New System.Drawing.Size(288, 55)
        Me.XScaleTrackBar.TabIndex = 0
        Me.XScaleTrackBar.Value = 10
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(814, 591)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GDIParametersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 624)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "GDIParametersForm"
        Me.Text = "Form1"
        Me.TabControl.ResumeLayout(False)
        Me.UpdateTabPage.ResumeLayout(False)
        Me.SliderGroupBox.ResumeLayout(False)
        CType(Me.LocationTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YOffsetTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XOffsetTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RotateTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YScaleTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XScaleTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents PaintEventTabPage As TabPage
    Friend WithEvents UpdateTabPage As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents SliderGroupBox As GroupBox
    Friend WithEvents LocationTrackBar As TrackBar
    Friend WithEvents YOffsetTrackBar As TrackBar
    Friend WithEvents XOffsetTrackBar As TrackBar
    Friend WithEvents RotateTrackBar As TrackBar
    Friend WithEvents YScaleTrackBar As TrackBar
    Friend WithEvents XScaleTrackBar As TrackBar
End Class
