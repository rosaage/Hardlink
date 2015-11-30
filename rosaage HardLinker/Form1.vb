Imports System.Runtime.InteropServices
Imports System.IO

Public Class Form1
    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Private Shared Function CreateHardLink(ByVal lpFileName As String, ByVal lpExistingFileName As String, ByVal lpSecurityAttributes As IntPtr) As Boolean
    End Function

    Public Sub GetAllFiles(strPath As String)
        Dim RootFolder As New DirectoryInfo(strPath)
        Dim SubDir As DirectoryInfo
        Dim File As FileInfo

        If RootFolder.Exists Then
            For Each SubDir In RootFolder.GetDirectories
                GetAllFiles(SubDir.FullName)
            Next
            For Each File In RootFolder.GetFiles()
                Console.WriteLine(File.Name)
                CreateHardLink(out.Text + "\" + File.Name, File.FullName, IntPtr.Zero)
            Next
        End If

        MsgBox("Done!", MsgBoxStyle.Information, "Done!")

    End Sub

    Private Sub Browse_source_Click(sender As Object, e As EventArgs) Handles Browse_source.Click
        If source_dialog.ShowDialog() = DialogResult.OK Then
            source.Text = source_dialog.SelectedPath
        End If
    End Sub

    Private Sub Browse_out_Click(sender As Object, e As EventArgs) Handles Browse_out.Click
        If out_dialog.ShowDialog() = DialogResult.OK Then
            out.Text = out_dialog.SelectedPath
        End If
    End Sub

    Private Sub make_Click(sender As Object, e As EventArgs) Handles make.Click
        GetAllFiles(source.Text)
    End Sub

End Class

