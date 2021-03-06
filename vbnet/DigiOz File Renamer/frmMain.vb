Imports System.IO

Public Class frmMain
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents lblSelectedDirectory As System.Windows.Forms.Label
    Friend WithEvents lstFinal As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStartFilenameWith As System.Windows.Forms.TextBox
    Friend WithEvents btnRename As System.Windows.Forms.Button
    Friend WithEvents fbd1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lstInitial As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbPosition As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbFilter As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.lblSelectedDirectory = New System.Windows.Forms.Label
        Me.lstInitial = New System.Windows.Forms.ListBox
        Me.lstFinal = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtStartFilenameWith = New System.Windows.Forms.TextBox
        Me.btnRename = New System.Windows.Forms.Button
        Me.fbd1 = New System.Windows.Forms.FolderBrowserDialog
        Me.btnExit = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbPosition = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbFilter = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnBrowse.Location = New System.Drawing.Point(568, 16)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Browse"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(136, 16)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(424, 20)
        Me.txtPath.TabIndex = 1
        Me.txtPath.Text = ""
        '
        'lblSelectedDirectory
        '
        Me.lblSelectedDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedDirectory.Location = New System.Drawing.Point(24, 16)
        Me.lblSelectedDirectory.Name = "lblSelectedDirectory"
        Me.lblSelectedDirectory.Size = New System.Drawing.Size(104, 23)
        Me.lblSelectedDirectory.TabIndex = 2
        Me.lblSelectedDirectory.Text = "Selected Directory"
        Me.lblSelectedDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lstInitial
        '
        Me.lstInitial.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lstInitial.HorizontalScrollbar = True
        Me.lstInitial.Location = New System.Drawing.Point(24, 152)
        Me.lstInitial.Name = "lstInitial"
        Me.lstInitial.ScrollAlwaysVisible = True
        Me.lstInitial.Size = New System.Drawing.Size(276, 342)
        Me.lstInitial.TabIndex = 3
        '
        'lstFinal
        '
        Me.lstFinal.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Me.lstFinal.HorizontalScrollbar = True
        Me.lstFinal.Location = New System.Drawing.Point(376, 152)
        Me.lstFinal.Name = "lstFinal"
        Me.lstFinal.ScrollAlwaysVisible = True
        Me.lstFinal.Size = New System.Drawing.Size(276, 342)
        Me.lstFinal.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Add To Filename"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStartFilenameWith
        '
        Me.txtStartFilenameWith.Location = New System.Drawing.Point(136, 48)
        Me.txtStartFilenameWith.Name = "txtStartFilenameWith"
        Me.txtStartFilenameWith.Size = New System.Drawing.Size(177, 20)
        Me.txtStartFilenameWith.TabIndex = 6
        Me.txtStartFilenameWith.Text = ""
        '
        'btnRename
        '
        Me.btnRename.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnRename.Location = New System.Drawing.Point(312, 304)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(56, 23)
        Me.btnRename.TabIndex = 7
        Me.btnRename.Text = "Rename"
        '
        'fbd1
        '
        Me.fbd1.Description = "Folder Browse Dialog"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnExit.Location = New System.Drawing.Point(568, 48)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Initial File List"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(376, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Renamed File List"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Position In File"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbPosition
        '
        Me.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPosition.Items.AddRange(New Object() {"Beginning Of File Name", "End Of The File Name", "Numeric Increment"})
        Me.cmbPosition.Location = New System.Drawing.Point(408, 48)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(152, 21)
        Me.cmbPosition.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Filter By File Type"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbFilter
        '
        Me.cmbFilter.Location = New System.Drawing.Point(136, 80)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(176, 21)
        Me.cmbFilter.TabIndex = 14
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(680, 525)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbPosition)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.txtStartFilenameWith)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstFinal)
        Me.Controls.Add(Me.lstInitial)
        Me.Controls.Add(Me.lblSelectedDirectory)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnBrowse)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DigiOz Mass File Renamer Version 1.0"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim listfiles As Directory
    Dim files As Array
    Dim file As String
    Dim fileExtension As String
    Dim fileShort As String
    Dim fileShortRenamed As String
    Dim i As Integer = 1

    Function getFileExtension(ByVal f As String) As String
        Dim nf As Array
        Dim q As String
        Dim countQ As Integer

        nf = Split(f, ".")
        countQ = nf.Length

        'MessageBox.Show(nf(countQ - 1))
        getFileExtension = nf(countQ - 1)
    End Function

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim fileExtension As String
        Dim uniqueExtensions As Array
        Dim colExtensions As Collection

        lstInitial.Items.Clear()
        lstFinal.Items.Clear()
        fbd1.ShowDialog()
        txtPath.Text = fbd1.SelectedPath.ToString()
        files = listfiles.GetFiles(fbd1.SelectedPath.ToString())

        For Each file In files
            fileShort = Replace(file, txtPath.Text & "\", "")
            lstInitial.Items.Add(fileShort)
            'getFileExtension(fileShort)
            fileExtension = getFileExtension(fileShort)
            cmbFilter.Items.Add(fileExtension)
        Next

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRename.Click
        i = 1
        Dim x As Integer
        Dim iNumItems As Integer

        If lstInitial.Items.Count <= 0 Then
            MessageBox.Show("There are no files in your initial file list!")
            Exit Sub
        End If

        If txtStartFilenameWith.Text = "" And cmbPosition.SelectedItem <> "Numeric Increment" Then
            MessageBox.Show("Please Enter a phrase to use for file rename!")
            Exit Sub
        End If

        iNumItems = lstInitial.Items.Count()

        'For x = 0 To iNumItems - 1
        'MessageBox.Show(lstInitial.Items.Item(x))
        'Next x

        'For Each file In files
        For x = 0 To iNumItems - 1
            If cmbPosition.SelectedItem = "Beginning Of File Name" Then
                fileShortRenamed = txtPath.Text & "\" & txtStartFilenameWith.Text & "_" & i & "." & getFileExtension(lstInitial.Items.Item(x))
            ElseIf cmbPosition.SelectedItem = "Numeric Increment" Then
                fileShortRenamed = txtPath.Text & "\" & i & "." & getFileExtension(lstInitial.Items.Item(x))
            Else
                fileShortRenamed = txtPath.Text & "\" & i & "_" & txtStartFilenameWith.Text & "." & getFileExtension(lstInitial.Items.Item(x))
            End If

            listfiles.Move(txtPath.Text & "\" & lstInitial.Items.Item(x), fileShortRenamed)
            i = i + 1
            fileShortRenamed = Replace(fileShortRenamed, txtPath.Text & "\", "")
            lstFinal.Items.Add(fileShortRenamed)
        Next x
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbPosition.SelectedItem = "Beginning Of File Name"
    End Sub


End Class
