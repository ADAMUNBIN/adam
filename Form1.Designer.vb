﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.driveList = New System.Windows.Forms.ListBox()
        Me.folderList = New System.Windows.Forms.ListBox()
        Me.filesList = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'driveList
        '
        Me.driveList.FormattingEnabled = True
        Me.driveList.Location = New System.Drawing.Point(12, 149)
        Me.driveList.Name = "driveList"
        Me.driveList.Size = New System.Drawing.Size(170, 82)
        Me.driveList.TabIndex = 1
        '
        'folderList
        '
        Me.folderList.FormattingEnabled = True
        Me.folderList.Location = New System.Drawing.Point(206, 12)
        Me.folderList.Name = "folderList"
        Me.folderList.Size = New System.Drawing.Size(170, 160)
        Me.folderList.TabIndex = 2
        '
        'filesList
        '
        Me.filesList.FormattingEnabled = True
        Me.filesList.Location = New System.Drawing.Point(206, 218)
        Me.filesList.Name = "filesList"
        Me.filesList.Size = New System.Drawing.Size(170, 160)
        Me.filesList.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 390)
        Me.Controls.Add(Me.filesList)
        Me.Controls.Add(Me.folderList)
        Me.Controls.Add(Me.driveList)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents driveList As System.Windows.Forms.ListBox
    Friend WithEvents folderList As System.Windows.Forms.ListBox
    Friend WithEvents filesList As System.Windows.Forms.ListBox

End Class
