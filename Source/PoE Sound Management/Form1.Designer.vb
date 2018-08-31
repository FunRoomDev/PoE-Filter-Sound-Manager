<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileView = New System.Windows.Forms.ListView()
        Me.FileView2 = New System.Windows.Forms.ListView()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.Copy = New System.Windows.Forms.Button()
        Me.File = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.File2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SourceFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TargetFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1258, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SourceFileToolStripMenuItem, Me.TargetFileToolStripMenuItem})
        Me.SettingsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(88, 29)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'FileView
        '
        Me.FileView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FileView.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FileView.CheckBoxes = True
        Me.FileView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.File})
        Me.FileView.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileView.ForeColor = System.Drawing.Color.White
        Me.FileView.FullRowSelect = True
        Me.FileView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.FileView.Location = New System.Drawing.Point(0, 36)
        Me.FileView.MultiSelect = False
        Me.FileView.Name = "FileView"
        Me.FileView.Size = New System.Drawing.Size(530, 628)
        Me.FileView.TabIndex = 1
        Me.FileView.UseCompatibleStateImageBehavior = False
        Me.FileView.View = System.Windows.Forms.View.Details
        '
        'FileView2
        '
        Me.FileView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FileView2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FileView2.CheckBoxes = True
        Me.FileView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.File2})
        Me.FileView2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileView2.ForeColor = System.Drawing.Color.White
        Me.FileView2.FullRowSelect = True
        Me.FileView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.FileView2.Location = New System.Drawing.Point(726, 36)
        Me.FileView2.Name = "FileView2"
        Me.FileView2.Size = New System.Drawing.Size(530, 628)
        Me.FileView2.TabIndex = 2
        Me.FileView2.UseCompatibleStateImageBehavior = False
        Me.FileView2.View = System.Windows.Forms.View.Details
        '
        'UpdateButton
        '
        Me.UpdateButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.UpdateButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.Color.White
        Me.UpdateButton.Location = New System.Drawing.Point(538, 621)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(184, 43)
        Me.UpdateButton.TabIndex = 3
        Me.UpdateButton.Text = "Refresh"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'Copy
        '
        Me.Copy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Copy.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Copy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copy.ForeColor = System.Drawing.Color.White
        Me.Copy.Location = New System.Drawing.Point(536, 36)
        Me.Copy.Name = "Copy"
        Me.Copy.Size = New System.Drawing.Size(184, 43)
        Me.Copy.TabIndex = 4
        Me.Copy.Text = "Copy-->"
        Me.Copy.UseVisualStyleBackColor = False
        '
        'File
        '
        Me.File.Text = "File"
        Me.File.Width = 300
        '
        'File2
        '
        Me.File2.Text = "File2"
        Me.File2.Width = 300
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SourceFileToolStripMenuItem
        '
        Me.SourceFileToolStripMenuItem.Name = "SourceFileToolStripMenuItem"
        Me.SourceFileToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.SourceFileToolStripMenuItem.Text = "Source Folder..."
        '
        'TargetFileToolStripMenuItem
        '
        Me.TargetFileToolStripMenuItem.Name = "TargetFileToolStripMenuItem"
        Me.TargetFileToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.TargetFileToolStripMenuItem.Text = "Target Folder..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1258, 664)
        Me.Controls.Add(Me.Copy)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.FileView2)
        Me.Controls.Add(Me.FileView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 1920)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "Form1"
        Me.Text = "PoE Filter Sound Management"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileView As ListView
    Friend WithEvents FileView2 As ListView
    Friend WithEvents UpdateButton As Button
    Friend WithEvents Copy As Button
    Friend WithEvents File As ColumnHeader
    Friend WithEvents File2 As ColumnHeader
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SourceFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TargetFileToolStripMenuItem As ToolStripMenuItem
End Class
