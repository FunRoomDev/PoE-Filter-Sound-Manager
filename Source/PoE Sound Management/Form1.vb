Imports System.IO
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Public Class Form1


    Private sourceLocation As String
    Private targetLocation As String
    Private config As IniFile
    Private fileRule As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeSettings()
        UpdateList()
    End Sub

    Private Sub InitializeSettings()
        If Not System.IO.File.Exists("config.ini") Then
            Dim fs As FileStream = System.IO.File.Create("config.ini")
            fs.Close()
        End If
        config = New IniFile()
        config.Load("config.ini")
        If config.GetSection("SOURCE") Is Nothing Then
            config.AddSection("SOURCE")
        End If
        If config.GetSection("DESTINATION") Is Nothing Then
            config.AddSection("DESTINATION")
        End If
        If config.GetSection("SYSTEM") Is Nothing Then
            config.AddSection("SYSTEM")
        End If

        If config.GetSection("SOURCE").GetKey("Path") Is Nothing Then
            config.AddSection("SOURCE").AddKey("Path").Value = "C:\"
        End If
        If config.GetSection("DESTINATION").GetKey("Path") Is Nothing Then
            config.AddSection("DESTINATION").AddKey("Path").Value = "C:\"
        End If
        If config.GetSection("SYSTEM").GetKey("FileNameExt") Is Nothing Then
            config.AddSection("SYSTEM").AddKey("FileNameExt").Value = "*.mp3"
        End If
        config.Save("config.ini")

        sourceLocation = config.GetKeyValue("SOURCE", "Path")
        targetLocation = config.GetKeyValue("DESTINATION", "Path")
        fileRule = config.GetKeyValue("SYSTEM", "FileNameExt")
    End Sub

    Sub UpdateList()
        Dim lvi As ListViewItem
        Dim dilist As String() = Directory.GetFiles(sourceLocation, fileRule)
        Dim exts As New List(Of String)
        FileView.Items.Clear()
        For Each fi As String In dilist
            lvi = New ListViewItem
            lvi.Text = Path.GetFileName(fi)
            FileView.Items.Add(lvi)
        Next
        Dim lvi2 As ListViewItem
        Dim dilist2 As String() = Directory.GetFiles(targetLocation, fileRule)
        Dim exts2 As New List(Of String)
        FileView2.Items.Clear()
        For Each fi As String In dilist2
            lvi2 = New ListViewItem
            lvi2.Text = Path.GetFileName(fi)
            FileView2.Items.Add(lvi2)
        Next
    End Sub

    Private Sub SourceFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SourceFileToolStripMenuItem.Click
        Dim folderDlg As New FolderBrowserDialog
        folderDlg.SelectedPath = sourceLocation
        folderDlg.ShowNewFolderButton = True
        If (folderDlg.ShowDialog() = DialogResult.OK) Then
            sourceLocation = folderDlg.SelectedPath
            Dim root As Environment.SpecialFolder = folderDlg.RootFolder
        End If
        config.AddSection("SOURCE").AddKey("Path").Value = sourceLocation
        config.Save("config.ini")
        UpdateList()
    End Sub

    Private Sub TargetFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TargetFileToolStripMenuItem.Click
        Dim folderDlg As New FolderBrowserDialog
        folderDlg.SelectedPath = targetLocation
        folderDlg.ShowNewFolderButton = True
        If (folderDlg.ShowDialog() = DialogResult.OK) Then
            targetLocation = folderDlg.SelectedPath
            Dim root As Environment.SpecialFolder = folderDlg.RootFolder
        End If
        config.AddSection("DESTINATION").AddKey("Path").Value = targetLocation
        config.Save("config.ini")
        UpdateList()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Environment.Exit(0)
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        UpdateList()
    End Sub

    Private Sub Copy_Click(sender As Object, e As EventArgs) Handles Copy.Click
        Dim result As Integer = MessageBox.Show("Selected files will be replaced", "Copy Files", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            For Each item In FileView2.CheckedItems
                Try
                    Dim source As String = sourceLocation & If(sourceLocation(sourceLocation.Length - 1) = "\", "", "\") & FileView.CheckedItems(0).SubItems(0).Text
                    Dim target As String = targetLocation & If(targetLocation(targetLocation.Length - 1) = "\", "", "\") & item.subitems(0).text
                    My.Computer.FileSystem.CopyFile(source, target, True)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
            UpdateList()
        End If
    End Sub
End Class
