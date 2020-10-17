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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl.SuspendLayout()
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
        Me.UpdateTabPage.Location = New System.Drawing.Point(4, 29)
        Me.UpdateTabPage.Name = "UpdateTabPage"
        Me.UpdateTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.UpdateTabPage.Size = New System.Drawing.Size(814, 591)
        Me.UpdateTabPage.TabIndex = 1
        Me.UpdateTabPage.Text = "Update Parms"
        Me.UpdateTabPage.UseVisualStyleBackColor = True
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents PaintEventTabPage As TabPage
    Friend WithEvents UpdateTabPage As TabPage
    Friend WithEvents TabPage1 As TabPage
End Class
