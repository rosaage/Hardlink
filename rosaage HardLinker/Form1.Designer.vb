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
        Me.source = New System.Windows.Forms.TextBox()
        Me.out = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.source_dialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.out_dialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.Browse_source = New System.Windows.Forms.Button()
        Me.Browse_out = New System.Windows.Forms.Button()
        Me.make = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'source
        '
        Me.source.Location = New System.Drawing.Point(12, 25)
        Me.source.Name = "source"
        Me.source.Size = New System.Drawing.Size(279, 20)
        Me.source.TabIndex = 0
        '
        'out
        '
        Me.out.Location = New System.Drawing.Point(12, 83)
        Me.out.Name = "out"
        Me.out.Size = New System.Drawing.Size(279, 20)
        Me.out.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pick Source Folder (links all files, including files in subdirectories)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Where to put all the hardlinks"
        '
        'Browse_source
        '
        Me.Browse_source.Location = New System.Drawing.Point(297, 23)
        Me.Browse_source.Name = "Browse_source"
        Me.Browse_source.Size = New System.Drawing.Size(75, 23)
        Me.Browse_source.TabIndex = 4
        Me.Browse_source.Text = "Browse"
        Me.Browse_source.UseVisualStyleBackColor = True
        '
        'Browse_out
        '
        Me.Browse_out.Location = New System.Drawing.Point(297, 81)
        Me.Browse_out.Name = "Browse_out"
        Me.Browse_out.Size = New System.Drawing.Size(75, 23)
        Me.Browse_out.TabIndex = 5
        Me.Browse_out.Text = "Browse"
        Me.Browse_out.UseVisualStyleBackColor = True
        '
        'make
        '
        Me.make.Location = New System.Drawing.Point(265, 52)
        Me.make.Name = "make"
        Me.make.Size = New System.Drawing.Size(107, 23)
        Me.make.TabIndex = 6
        Me.make.Text = "Make Hardlink"
        Me.make.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 121)
        Me.Controls.Add(Me.make)
        Me.Controls.Add(Me.Browse_out)
        Me.Controls.Add(Me.Browse_source)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.out)
        Me.Controls.Add(Me.source)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents source As System.Windows.Forms.TextBox
    Friend WithEvents out As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents source_dialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents out_dialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Browse_source As System.Windows.Forms.Button
    Friend WithEvents Browse_out As System.Windows.Forms.Button
    Friend WithEvents make As System.Windows.Forms.Button

End Class
