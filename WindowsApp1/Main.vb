Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get a list of drives
        Dim drives As System.Collections.ObjectModel.ReadOnlyCollection(Of IO.DriveInfo) = My.Computer.FileSystem.Drives
        Dim rootDir As String = String.Empty
        'Now loop thru each drive and populate the treeview
        For i As Integer = 0 To 0
            rootDir = My.Settings.fullLogLocation
            'Add this drive as a root node
            Dim root As TreeNode = TreeView1.Nodes.Add(rootDir)
            root.Tag = rootDir
            'Populate this root node
            PopulateTreeView(rootDir, TreeView1.Nodes(i))

        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Label2.Text = Nothing Then
            MsgBox("Please select a log file.")
        Else
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PopulateTreeView(ByVal dir As String, ByVal parentNode As TreeNode)
        Dim folder As String = String.Empty
        Try
            'Add the files to treeview
            Dim files() As String = IO.Directory.GetFiles(dir)
            If files.Length <> 0 Then
                Dim fileNode As TreeNode = Nothing
                For Each file As String In files
                    fileNode = parentNode.Nodes.Add(IO.Path.GetFileName(file))
                    fileNode.Tag = file

                Next
            End If
            'Add folders to treeview
            Dim folders() As String = IO.Directory.GetDirectories(dir)
            If folders.Length <> 0 Then
                Dim folderNode As TreeNode = Nothing
                Dim folderName As String = String.Empty
                For Each folder In folders
                    folderName = IO.Path.GetFileName(folder)
                    folderNode = parentNode.Nodes.Add(folderName)
                    folderNode.Tag = folder
                    PopulateTreeView(folder, folderNode)
                Next
            End If
        Catch ex As UnauthorizedAccessException
            parentNode.Nodes.Add("Access Denied")


        End Try
        TreeView1.ExpandAll()
    End Sub

    Private Sub TreeView1_Click(sender As Object, e As EventArgs) Handles TreeView1.Click
        Label2.Text = DirectCast(TreeView1.SelectedNode.Tag, Object).ToString
    End Sub
End Class