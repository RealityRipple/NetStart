Public Class frmNetStart
  Private sPath, sAllPath As String, bActive, bCheck As Boolean

  Private Sub frmNetStart_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    txtAddress.Text = My.Settings.RemoteFile
    txtSize.Value = My.Settings.FileSize
    chkEveryTime.Checked = My.Settings.Persistant
    sPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup) & " with Internet Access"
    If Not String.IsNullOrEmpty(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup)) And String.Compare(Environment.GetFolderPath(Environment.SpecialFolder.Startup), Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup), True) <> 0 Then sAllPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup) & " with Internet Access"
    If Not My.Computer.FileSystem.DirectoryExists(sPath) Then My.Computer.FileSystem.CreateDirectory(sPath)
    If Not String.IsNullOrEmpty(sAllPath) AndAlso Not My.Computer.FileSystem.DirectoryExists(sAllPath) Then My.Computer.FileSystem.CreateDirectory(sAllPath)
    If Not My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup) & "\NetStart.lnk") Then
      Using link As New ShellLink
        link.Target = Application.ExecutablePath
        link.WorkingDirectory = IO.Path.GetDirectoryName(Application.ExecutablePath)
        link.Description = "Starts programs in the """ & IO.Path.GetFileName(sPath) & """ folder when an internet connection becomes available."
        link.DisplayMode = ShellLink.LinkDisplayMode.edmNormal
        link.Save(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup) & "\NetStart.lnk")
      End Using
    End If
    PopulateLists()
    bCheck = True
    tmrCheck.Start()
    Me.Opacity = 0
  End Sub

  Private Sub PopulateLists()
    Dim sOS As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
    Dim sAllOS As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup)
    Dim sNet As String = sPath
    Dim sAllNet As String = sAllPath
    If Not String.IsNullOrEmpty(sOS) Then
      For Each file In My.Computer.FileSystem.GetFiles(sOS)
        If CBool(My.Computer.FileSystem.GetFileInfo(file).Attributes And IO.FileAttributes.Hidden) Then Continue For
        If file = sOS & "\NetStart.lnk" Then Continue For
        AddItem(file, lvNoNet, 0)
      Next
    End If
    If Not String.IsNullOrEmpty(sAllOS) Then
      For Each file In My.Computer.FileSystem.GetFiles(sAllOS)
        If CBool(My.Computer.FileSystem.GetFileInfo(file).Attributes And IO.FileAttributes.Hidden) Then Continue For
        If file = sAllOS & "\NetStart.lnk" Then Continue For
        AddItem(file, lvNoNet, 1)
      Next
    End If
    If Not String.IsNullOrEmpty(sNet) Then
      For Each file In My.Computer.FileSystem.GetFiles(sNet)
        If CBool(My.Computer.FileSystem.GetFileInfo(file).Attributes And IO.FileAttributes.Hidden) Then Continue For
        AddItem(file, lvNet, 2)
      Next
    End If
    If Not String.IsNullOrEmpty(sAllNet) Then
      If Not String.IsNullOrEmpty(sAllNet) Then
        For Each file In My.Computer.FileSystem.GetFiles(sAllNet)
          If CBool(My.Computer.FileSystem.GetFileInfo(file).Attributes And IO.FileAttributes.Hidden) Then Continue For
          AddItem(file, lvNet, 3)
        Next
      End If
    End If
    lvNet.Columns(0).Width = lvNet.ClientSize.Width
    lvNoNet.Columns(0).Width = lvNoNet.ClientSize.Width
  End Sub

  Private Sub AddItem(path As String, ByRef lvList As ListView, type As Byte)
    Dim lstX = lvList.Items.Add(IO.Path.GetFileNameWithoutExtension(path))
    lstX.Tag = path
    Dim icoID As String = "ico_" & Hex(path.GetHashCode)
    Dim icoTmp As Icon = Drawing.Icon.ExtractAssociatedIcon(path).Clone
    lvList.SmallImageList = Nothing
    imlIcons.Images.Add(icoID, icoTmp)
    lvList.SmallImageList = imlIcons
    lstX.ImageKey = icoID
    Select Case type
      Case 0
        lstX.ForeColor = SystemColors.WindowText
        lstX.ToolTipText = IO.Path.GetFileNameWithoutExtension(path) & vbNewLine & "Current User with OS"
      Case 1
        lstX.ForeColor = SystemColors.InactiveCaptionText
        lstX.ToolTipText = IO.Path.GetFileNameWithoutExtension(path) & vbNewLine & "All Users with OS"
      Case 2
        lstX.ForeColor = SystemColors.WindowText
        lstX.ToolTipText = IO.Path.GetFileNameWithoutExtension(path) & vbNewLine & "Current User with Internet"
      Case 3
        lstX.ForeColor = SystemColors.InactiveCaptionText
        lstX.ToolTipText = IO.Path.GetFileNameWithoutExtension(path) & vbNewLine & "All Users with Internet"
    End Select
  End Sub

  Public Sub RunIt()
    For Each sShortcut In My.Computer.FileSystem.GetFiles(sPath)
      If Not CBool(My.Computer.FileSystem.GetFileInfo(sShortcut).Attributes And IO.FileAttributes.Hidden) Then Process.Start(sShortcut)
    Next
    If Not String.IsNullOrEmpty(sAllPath) Then
      For Each sShortcut In My.Computer.FileSystem.GetFiles(sAllPath)
        If Not CBool(My.Computer.FileSystem.GetFileInfo(sShortcut).Attributes And IO.FileAttributes.Hidden) Then Process.Start(sShortcut)
      Next
    End If
  End Sub

  Private Sub tmrCheck_Tick(sender As System.Object, e As System.EventArgs) Handles tmrCheck.Tick
    If Me.Visible And Me.Opacity = 1 Then Exit Sub
    tmrCheck.Stop()
    If Me.Opacity = 0 Then
      Me.Hide()
      Me.Opacity = 1
    End If
    If Not bCheck And My.Settings.Persistant Then If Not CheckNet() Then bCheck = True
    If bCheck Then
      If CheckNet() Then
        bCheck = False
        RunIt()
      End If
    End If
    tmrCheck.Start()
  End Sub

  Private Function CheckNet() As Boolean
    Dim bRet As Boolean = False
    Try
      Dim sInfo As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\info.txt"
      If My.Computer.FileSystem.FileExists(sInfo) Then My.Computer.FileSystem.DeleteFile(sInfo)
      My.Computer.Network.DownloadFile(My.Settings.RemoteFile, sInfo)
      If My.Computer.FileSystem.FileExists(sInfo) Then
        If My.Computer.FileSystem.GetFileInfo(sInfo).Length = My.Settings.FileSize Then
          bRet = True
        End If
        My.Computer.FileSystem.DeleteFile(sInfo)
      End If
    Catch ex As Exception

    End Try
    Return bRet
  End Function

  Private Sub cmdDonate_Click(sender As System.Object, e As System.EventArgs) Handles cmdDonate.Click
    Diagnostics.Process.Start("http://realityripple.com/donate.php")
  End Sub

  Private Sub cmdTest_Click(sender As System.Object, e As System.EventArgs) Handles cmdTest.Click
    lblStatus.Text = "Downloading File..."
    Dim sInfo As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\file.dat"
    If My.Computer.FileSystem.FileExists(sInfo) Then My.Computer.FileSystem.DeleteFile(sInfo)
    Application.DoEvents()
    My.Computer.Network.DownloadFile(txtAddress.Text, sInfo)
    lblStatus.Text = "Size: " & My.Computer.FileSystem.GetFileInfo(sInfo).Length & " bytes"
    If txtSize.Value = 0 Then
      lblStatus.Text &= " (Set)"
      txtSize.Value = My.Computer.FileSystem.GetFileInfo(sInfo).Length
    ElseIf txtSize.Value = My.Computer.FileSystem.GetFileInfo(sInfo).Length Then
      lblStatus.Text &= " (Successful)"
      cmdSave.Focus()
    Else
      lblStatus.Text &= " (Incorrect)"
      txtSize.Focus()
    End If
  End Sub

  Private Sub cmdClose_Click(sender As System.Object, e As System.EventArgs) Handles cmdClose.Click
    Me.Hide()
  End Sub

  Private Sub cmdSave_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click
    If String.IsNullOrEmpty(txtAddress.Text) Then txtAddress.Text = "http://realityripple.com/realityripple.com"
    If txtSize.Value = 0 Then txtSize.Value = 759
    My.Settings.RemoteFile = txtAddress.Text
    My.Settings.FileSize = txtSize.Value
    My.Settings.Persistant = chkEveryTime.Checked
    My.Settings.Save()
    For Each lvItem As ListViewItem In lvNet.Items
      If lvItem.ForeColor = SystemColors.WindowText Then
        If Not CType(lvItem.Tag, String).StartsWith(sPath & "\") Then
          Dim NewPath As String = sPath & "\" & IO.Path.GetFileName(lvItem.Tag)
          My.Computer.FileSystem.MoveFile(lvItem.Tag, NewPath, True)
          lvItem.Tag = NewPath
        End If
      Else
        If Not String.IsNullOrEmpty(sAllPath) Then
          If Not CType(lvItem.Tag, String).StartsWith(sAllPath & "\") Then
            Dim NewPath As String = sAllPath & "\" & IO.Path.GetFileName(lvItem.Tag)
            My.Computer.FileSystem.MoveFile(lvItem.Tag, NewPath, True)
            lvItem.Tag = NewPath
          End If
        End If
      End If
    Next
    For Each lvItem As ListViewItem In lvNoNet.Items
      If lvItem.ForeColor = SystemColors.WindowText Then
        If Not CType(lvItem.Tag, String).StartsWith(Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\") Then
          Dim NewPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\" & IO.Path.GetFileName(lvItem.Tag)
          My.Computer.FileSystem.MoveFile(lvItem.Tag, NewPath, True)
          lvItem.Tag = NewPath
        End If
      Else
        If Not String.IsNullOrEmpty(sAllPath) Then
          If Not CType(lvItem.Tag, String).StartsWith(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup) & "\") Then
            Dim NewPath As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup) & "\" & IO.Path.GetFileName(lvItem.Tag)
            My.Computer.FileSystem.MoveFile(lvItem.Tag, NewPath, True)
            lvItem.Tag = NewPath
          End If
        End If
      End If
    Next
  End Sub

  Private Sub lvNoNet_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles lvNoNet.DragDrop
    If e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then
      Dim lvItems As ListView.SelectedListViewItemCollection = e.Data.GetData(GetType(ListView.SelectedListViewItemCollection))
      For Each lvItem As ListViewItem In lvItems
        lvNet.Items.Remove(lvItem)
        lvNoNet.Items.Add(lvItem)
        If lvItem.ForeColor = SystemColors.WindowText Then
          lvItem.ToolTipText = IO.Path.GetFileNameWithoutExtension(lvItem.Tag) & vbNewLine & "Current User with OS"
        Else
          lvItem.ToolTipText = IO.Path.GetFileNameWithoutExtension(lvItem.Tag) & vbNewLine & "All Users with OS"
        End If
      Next
    End If
  End Sub

  Private Sub lvNoNet_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles lvNoNet.DragEnter
    If e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then
      Dim lvItems As ListView.SelectedListViewItemCollection = e.Data.GetData(GetType(ListView.SelectedListViewItemCollection))
      If lvItems(0).ListView Is lvNet Then e.Effect = DragDropEffects.Move
    End If
  End Sub

  Private Sub lvNoNet_ItemDrag(sender As Object, e As System.Windows.Forms.ItemDragEventArgs) Handles lvNoNet.ItemDrag
    lvNoNet.DoDragDrop(lvNoNet.SelectedItems, DragDropEffects.Move)
  End Sub

  Private Sub lvNet_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles lvNet.DragDrop
    If e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then
      Dim lvItems As ListView.SelectedListViewItemCollection = e.Data.GetData(GetType(ListView.SelectedListViewItemCollection))
      For Each lvItem As ListViewItem In lvItems
        lvNoNet.Items.Remove(lvItem)
        lvNet.Items.Add(lvItem)
        If lvItem.ForeColor = SystemColors.WindowText Then
          lvItem.ToolTipText = IO.Path.GetFileNameWithoutExtension(lvItem.Tag) & vbNewLine & "Current User with Internet"
        Else
          lvItem.ToolTipText = IO.Path.GetFileNameWithoutExtension(lvItem.Tag) & vbNewLine & "All Users with Internet"
        End If
      Next
    End If
  End Sub

  Private Sub lvNet_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles lvNet.DragEnter
    If e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then
      Dim lvItems As ListView.SelectedListViewItemCollection = e.Data.GetData(GetType(ListView.SelectedListViewItemCollection))
      If lvItems(0).ListView Is lvNoNet Then e.Effect = DragDropEffects.Move
    End If
  End Sub

  Private Sub lvNet_ItemDrag(sender As Object, e As System.Windows.Forms.ItemDragEventArgs) Handles lvNet.ItemDrag
    lvNet.DoDragDrop(lvNet.SelectedItems, DragDropEffects.Move)
  End Sub

  Private Sub lvNoNet_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles lvNoNet.KeyUp
    If e.KeyCode = Keys.Right Then
      For Each item As ListViewItem In lvNet.SelectedItems
        item.Selected = False
      Next
      For Each lvItem As ListViewItem In lvNoNet.SelectedItems
        lvNoNet.Items.Remove(lvItem)
        lvNet.Items.Add(lvItem)
        If lvItem.ForeColor = SystemColors.WindowText Then
          lvItem.ToolTipText = IO.Path.GetFileNameWithoutExtension(lvItem.Tag) & vbNewLine & "Current User with Internet"
        Else
          lvItem.ToolTipText = IO.Path.GetFileNameWithoutExtension(lvItem.Tag) & vbNewLine & "All Users with Internet"
        End If
        lvItem.Selected = True
        lvItem.Focused = True
      Next
      e.Handled = True
      lvNet.Focus()
    End If
  End Sub

  Private Sub lvNet_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles lvNet.KeyUp
    If e.KeyCode = Keys.Left Then
      For Each item As ListViewItem In lvNoNet.SelectedItems
        item.Selected = False
      Next
      For Each lvItem As ListViewItem In lvNet.SelectedItems
        lvNet.Items.Remove(lvItem)
        lvNoNet.Items.Add(lvItem)
        If lvItem.ForeColor = SystemColors.WindowText Then
          lvItem.ToolTipText = IO.Path.GetFileNameWithoutExtension(lvItem.Tag) & vbNewLine & "Current User with OS"
        Else
          lvItem.ToolTipText = IO.Path.GetFileNameWithoutExtension(lvItem.Tag) & vbNewLine & "All Users with OS"
        End If
        lvItem.Selected = True
        lvItem.Focused = True
      Next
      e.Handled = True
      lvNoNet.Focus()
    End If
  End Sub
End Class
