<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNetStart
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNetStart))
    Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
    Me.pnlConfig = New System.Windows.Forms.TableLayoutPanel()
    Me.grpTest = New System.Windows.Forms.GroupBox()
    Me.pnlTest = New System.Windows.Forms.TableLayoutPanel()
    Me.lblAddress = New System.Windows.Forms.Label()
    Me.lblSize = New System.Windows.Forms.Label()
    Me.txtAddress = New System.Windows.Forms.TextBox()
    Me.cmdTest = New System.Windows.Forms.Button()
    Me.lblStatus = New System.Windows.Forms.Label()
    Me.txtSize = New System.Windows.Forms.NumericUpDown()
    Me.cmdDonate = New System.Windows.Forms.Button()
    Me.cmdSave = New System.Windows.Forms.Button()
    Me.cmdClose = New System.Windows.Forms.Button()
    Me.chkEveryTime = New System.Windows.Forms.CheckBox()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.pnlStartupList = New System.Windows.Forms.TableLayoutPanel()
    Me.lblStartNoNet = New System.Windows.Forms.Label()
    Me.lblStartNet = New System.Windows.Forms.Label()
    Me.lvNoNet = New System.Windows.Forms.ListView()
    Me.colNoNet = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.imlIcons = New System.Windows.Forms.ImageList(Me.components)
    Me.lvNet = New System.Windows.Forms.ListView()
    Me.colNet = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.pnlConfig.SuspendLayout()
    Me.grpTest.SuspendLayout()
    Me.pnlTest.SuspendLayout()
    CType(Me.txtSize, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox1.SuspendLayout()
    Me.pnlStartupList.SuspendLayout()
    Me.SuspendLayout()
    '
    'tmrCheck
    '
    Me.tmrCheck.Interval = 10000
    '
    'pnlConfig
    '
    Me.pnlConfig.ColumnCount = 4
    Me.pnlConfig.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
    Me.pnlConfig.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
    Me.pnlConfig.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
    Me.pnlConfig.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204.0!))
    Me.pnlConfig.Controls.Add(Me.grpTest, 0, 0)
    Me.pnlConfig.Controls.Add(Me.cmdDonate, 0, 2)
    Me.pnlConfig.Controls.Add(Me.cmdSave, 1, 2)
    Me.pnlConfig.Controls.Add(Me.cmdClose, 2, 2)
    Me.pnlConfig.Controls.Add(Me.chkEveryTime, 0, 1)
    Me.pnlConfig.Controls.Add(Me.GroupBox1, 3, 0)
    Me.pnlConfig.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlConfig.Location = New System.Drawing.Point(0, 0)
    Me.pnlConfig.Name = "pnlConfig"
    Me.pnlConfig.RowCount = 3
    Me.pnlConfig.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
    Me.pnlConfig.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.pnlConfig.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.pnlConfig.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.pnlConfig.Size = New System.Drawing.Size(504, 162)
    Me.pnlConfig.TabIndex = 0
    '
    'grpTest
    '
    Me.pnlConfig.SetColumnSpan(Me.grpTest, 3)
    Me.grpTest.Controls.Add(Me.pnlTest)
    Me.grpTest.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grpTest.Location = New System.Drawing.Point(3, 3)
    Me.grpTest.Name = "grpTest"
    Me.grpTest.Size = New System.Drawing.Size(294, 95)
    Me.grpTest.TabIndex = 0
    Me.grpTest.TabStop = False
    Me.grpTest.Text = "Network Test Settings"
    '
    'pnlTest
    '
    Me.pnlTest.ColumnCount = 2
    Me.pnlTest.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.pnlTest.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
    Me.pnlTest.Controls.Add(Me.lblAddress, 0, 0)
    Me.pnlTest.Controls.Add(Me.lblSize, 1, 0)
    Me.pnlTest.Controls.Add(Me.txtAddress, 0, 1)
    Me.pnlTest.Controls.Add(Me.cmdTest, 1, 2)
    Me.pnlTest.Controls.Add(Me.lblStatus, 0, 2)
    Me.pnlTest.Controls.Add(Me.txtSize, 1, 1)
    Me.pnlTest.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlTest.Location = New System.Drawing.Point(3, 16)
    Me.pnlTest.Name = "pnlTest"
    Me.pnlTest.RowCount = 3
    Me.pnlTest.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.pnlTest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.pnlTest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.pnlTest.Size = New System.Drawing.Size(288, 76)
    Me.pnlTest.TabIndex = 1
    '
    'lblAddress
    '
    Me.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Bottom
    Me.lblAddress.AutoSize = True
    Me.lblAddress.Location = New System.Drawing.Point(55, 6)
    Me.lblAddress.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
    Me.lblAddress.Name = "lblAddress"
    Me.lblAddress.Size = New System.Drawing.Size(88, 13)
    Me.lblAddress.TabIndex = 0
    Me.lblAddress.Text = "Remote Address:"
    '
    'lblSize
    '
    Me.lblSize.Anchor = System.Windows.Forms.AnchorStyles.Bottom
    Me.lblSize.AutoSize = True
    Me.lblSize.Location = New System.Drawing.Point(201, 6)
    Me.lblSize.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
    Me.lblSize.Name = "lblSize"
    Me.lblSize.Size = New System.Drawing.Size(84, 13)
    Me.lblSize.TabIndex = 1
    Me.lblSize.Text = "Expected Bytes:"
    '
    'txtAddress
    '
    Me.txtAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtAddress.Location = New System.Drawing.Point(3, 25)
    Me.txtAddress.Name = "txtAddress"
    Me.txtAddress.Size = New System.Drawing.Size(192, 20)
    Me.txtAddress.TabIndex = 2
    Me.txtAddress.Text = "http://realityripple.com/realityripple.com"
    '
    'cmdTest
    '
    Me.cmdTest.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.cmdTest.Location = New System.Drawing.Point(205, 52)
    Me.cmdTest.Name = "cmdTest"
    Me.cmdTest.Size = New System.Drawing.Size(75, 21)
    Me.cmdTest.TabIndex = 5
    Me.cmdTest.Text = "&Test Settings"
    Me.cmdTest.UseVisualStyleBackColor = True
    '
    'lblStatus
    '
    Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblStatus.AutoEllipsis = True
    Me.lblStatus.Location = New System.Drawing.Point(3, 54)
    Me.lblStatus.Name = "lblStatus"
    Me.lblStatus.Size = New System.Drawing.Size(192, 16)
    Me.lblStatus.TabIndex = 6
    Me.lblStatus.Text = "Press ""Test"" to begin."
    '
    'txtSize
    '
    Me.txtSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtSize.Location = New System.Drawing.Point(201, 25)
    Me.txtSize.Maximum = New Decimal(New Integer() {-1, 2147483647, 0, 0})
    Me.txtSize.Name = "txtSize"
    Me.txtSize.Size = New System.Drawing.Size(84, 20)
    Me.txtSize.TabIndex = 3
    Me.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtSize.ThousandsSeparator = True
    Me.txtSize.Value = New Decimal(New Integer() {759, 0, 0, 0})
    '
    'cmdDonate
    '
    Me.cmdDonate.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.cmdDonate.Location = New System.Drawing.Point(4, 132)
    Me.cmdDonate.Name = "cmdDonate"
    Me.cmdDonate.Size = New System.Drawing.Size(111, 23)
    Me.cmdDonate.TabIndex = 1
    Me.cmdDonate.Text = "Make a &Donation"
    Me.cmdDonate.UseVisualStyleBackColor = True
    '
    'cmdSave
    '
    Me.cmdSave.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.cmdSave.Location = New System.Drawing.Point(127, 132)
    Me.cmdSave.Name = "cmdSave"
    Me.cmdSave.Size = New System.Drawing.Size(75, 23)
    Me.cmdSave.TabIndex = 2
    Me.cmdSave.Text = "&Save"
    Me.cmdSave.UseVisualStyleBackColor = True
    '
    'cmdClose
    '
    Me.cmdClose.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.cmdClose.Location = New System.Drawing.Point(217, 132)
    Me.cmdClose.Name = "cmdClose"
    Me.cmdClose.Size = New System.Drawing.Size(75, 23)
    Me.cmdClose.TabIndex = 3
    Me.cmdClose.Text = "Close"
    Me.cmdClose.UseVisualStyleBackColor = True
    '
    'chkEveryTime
    '
    Me.chkEveryTime.Anchor = System.Windows.Forms.AnchorStyles.Left
    Me.chkEveryTime.AutoSize = True
    Me.pnlConfig.SetColumnSpan(Me.chkEveryTime, 3)
    Me.chkEveryTime.Location = New System.Drawing.Point(3, 105)
    Me.chkEveryTime.Name = "chkEveryTime"
    Me.chkEveryTime.Size = New System.Drawing.Size(288, 17)
    Me.chkEveryTime.TabIndex = 2
    Me.chkEveryTime.Text = "Run Startup files every time Internet becomes available."
    Me.chkEveryTime.UseVisualStyleBackColor = True
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.pnlStartupList)
    Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox1.Location = New System.Drawing.Point(303, 3)
    Me.GroupBox1.Name = "GroupBox1"
    Me.pnlConfig.SetRowSpan(Me.GroupBox1, 3)
    Me.GroupBox1.Size = New System.Drawing.Size(198, 156)
    Me.GroupBox1.TabIndex = 5
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Startup Selection"
    '
    'pnlStartupList
    '
    Me.pnlStartupList.ColumnCount = 2
    Me.pnlStartupList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.pnlStartupList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.pnlStartupList.Controls.Add(Me.lblStartNoNet, 0, 0)
    Me.pnlStartupList.Controls.Add(Me.lblStartNet, 1, 0)
    Me.pnlStartupList.Controls.Add(Me.lvNoNet, 0, 1)
    Me.pnlStartupList.Controls.Add(Me.lvNet, 1, 1)
    Me.pnlStartupList.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlStartupList.Location = New System.Drawing.Point(3, 16)
    Me.pnlStartupList.Name = "pnlStartupList"
    Me.pnlStartupList.RowCount = 2
    Me.pnlStartupList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.pnlStartupList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.pnlStartupList.Size = New System.Drawing.Size(192, 137)
    Me.pnlStartupList.TabIndex = 4
    '
    'lblStartNoNet
    '
    Me.lblStartNoNet.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.lblStartNoNet.AutoSize = True
    Me.lblStartNoNet.Location = New System.Drawing.Point(24, 3)
    Me.lblStartNoNet.Name = "lblStartNoNet"
    Me.lblStartNoNet.Size = New System.Drawing.Size(47, 13)
    Me.lblStartNoNet.TabIndex = 0
    Me.lblStartNoNet.Text = "With OS"
    '
    'lblStartNet
    '
    Me.lblStartNet.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.lblStartNet.AutoSize = True
    Me.lblStartNet.Location = New System.Drawing.Point(110, 3)
    Me.lblStartNet.Name = "lblStartNet"
    Me.lblStartNet.Size = New System.Drawing.Size(68, 13)
    Me.lblStartNet.TabIndex = 1
    Me.lblStartNet.Text = "With Internet"
    '
    'lvNoNet
    '
    Me.lvNoNet.AllowDrop = True
    Me.lvNoNet.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNoNet})
    Me.lvNoNet.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvNoNet.FullRowSelect = True
    Me.lvNoNet.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
    Me.lvNoNet.HideSelection = False
    Me.lvNoNet.Location = New System.Drawing.Point(3, 23)
    Me.lvNoNet.Name = "lvNoNet"
    Me.lvNoNet.ShowGroups = False
    Me.lvNoNet.ShowItemToolTips = True
    Me.lvNoNet.Size = New System.Drawing.Size(90, 111)
    Me.lvNoNet.SmallImageList = Me.imlIcons
    Me.lvNoNet.Sorting = System.Windows.Forms.SortOrder.Ascending
    Me.lvNoNet.TabIndex = 2
    Me.lvNoNet.UseCompatibleStateImageBehavior = False
    Me.lvNoNet.View = System.Windows.Forms.View.Details
    '
    'colNoNet
    '
    Me.colNoNet.Text = "Program"
    '
    'imlIcons
    '
    Me.imlIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
    Me.imlIcons.ImageSize = New System.Drawing.Size(16, 16)
    Me.imlIcons.TransparentColor = System.Drawing.Color.Transparent
    '
    'lvNet
    '
    Me.lvNet.AllowDrop = True
    Me.lvNet.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNet})
    Me.lvNet.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvNet.FullRowSelect = True
    Me.lvNet.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
    Me.lvNet.HideSelection = False
    Me.lvNet.Location = New System.Drawing.Point(99, 23)
    Me.lvNet.Name = "lvNet"
    Me.lvNet.ShowGroups = False
    Me.lvNet.ShowItemToolTips = True
    Me.lvNet.Size = New System.Drawing.Size(90, 111)
    Me.lvNet.SmallImageList = Me.imlIcons
    Me.lvNet.Sorting = System.Windows.Forms.SortOrder.Ascending
    Me.lvNet.TabIndex = 3
    Me.lvNet.UseCompatibleStateImageBehavior = False
    Me.lvNet.View = System.Windows.Forms.View.Details
    '
    'colNet
    '
    Me.colNet.Text = "Program"
    '
    'frmNetStart
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.cmdClose
    Me.ClientSize = New System.Drawing.Size(504, 162)
    Me.Controls.Add(Me.pnlConfig)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.MinimumSize = New System.Drawing.Size(520, 200)
    Me.Name = "frmNetStart"
    Me.ShowInTaskbar = False
    Me.Text = "NetStart"
    Me.pnlConfig.ResumeLayout(False)
    Me.pnlConfig.PerformLayout()
    Me.grpTest.ResumeLayout(False)
    Me.pnlTest.ResumeLayout(False)
    Me.pnlTest.PerformLayout()
    CType(Me.txtSize, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox1.ResumeLayout(False)
    Me.pnlStartupList.ResumeLayout(False)
    Me.pnlStartupList.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents tmrCheck As System.Windows.Forms.Timer
  Friend WithEvents pnlConfig As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents grpTest As System.Windows.Forms.GroupBox
  Friend WithEvents pnlTest As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents lblAddress As System.Windows.Forms.Label
  Friend WithEvents lblSize As System.Windows.Forms.Label
  Friend WithEvents txtAddress As System.Windows.Forms.TextBox
  Friend WithEvents txtSize As System.Windows.Forms.NumericUpDown
  Friend WithEvents cmdTest As System.Windows.Forms.Button
  Friend WithEvents lblStatus As System.Windows.Forms.Label
  Friend WithEvents cmdDonate As System.Windows.Forms.Button
  Friend WithEvents cmdSave As System.Windows.Forms.Button
  Friend WithEvents cmdClose As System.Windows.Forms.Button
  Friend WithEvents chkEveryTime As System.Windows.Forms.CheckBox
  Friend WithEvents pnlStartupList As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents lblStartNoNet As System.Windows.Forms.Label
  Friend WithEvents lblStartNet As System.Windows.Forms.Label
  Friend WithEvents lvNoNet As System.Windows.Forms.ListView
  Friend WithEvents lvNet As System.Windows.Forms.ListView
  Friend WithEvents colNoNet As System.Windows.Forms.ColumnHeader
  Friend WithEvents colNet As System.Windows.Forms.ColumnHeader
  Friend WithEvents imlIcons As System.Windows.Forms.ImageList

End Class
