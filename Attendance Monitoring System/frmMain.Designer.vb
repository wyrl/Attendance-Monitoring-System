<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.btnStudents = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Draggable1 = New Mimobibo.Draggable(Me.components)
        Me.Draggable2 = New Mimobibo.Draggable(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Attendance1 = New Attendance_Monitoring_System.Attendance()
        Me.StudentList1 = New Attendance_Monitoring_System.StudentList()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 65)
        Me.Panel1.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ImageIndex = 3
        Me.Button3.ImageList = Me.ImageList1
        Me.Button3.Location = New System.Drawing.Point(936, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(31, 30)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "close-icon.png")
        Me.ImageList1.Images.SetKeyName(1, "outline_minimize_black_48dp.png")
        Me.ImageList1.Images.SetKeyName(2, "outline_close_white_48dp.png")
        Me.ImageList1.Images.SetKeyName(3, "outline_minimize_white_48dp.png")
        Me.ImageList1.Images.SetKeyName(4, "outline_groups_white_48dp.png")
        Me.ImageList1.Images.SetKeyName(5, "outline_grading_white_24dp.png")
        Me.ImageList1.Images.SetKeyName(6, "outline_logout_white_24dp.png")
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ImageIndex = 2
        Me.btnClose.ImageList = Me.ImageList1
        Me.btnClose.Location = New System.Drawing.Point(973, 17)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(39, 30)
        Me.btnClose.TabIndex = 1
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(281, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(581, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Attendance Monitoring System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Panel2.Size = New System.Drawing.Size(189, 735)
        Me.Panel2.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnLogout, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAttendance, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnStudents, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 143)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(189, 592)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.ImageIndex = 6
        Me.btnLogout.ImageList = Me.ImageList1
        Me.btnLogout.Location = New System.Drawing.Point(3, 535)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(183, 54)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnAttendance
        '
        Me.btnAttendance.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnAttendance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAttendance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendance.ForeColor = System.Drawing.Color.White
        Me.btnAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAttendance.ImageIndex = 5
        Me.btnAttendance.ImageList = Me.ImageList1
        Me.btnAttendance.Location = New System.Drawing.Point(3, 83)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnAttendance.Size = New System.Drawing.Size(183, 54)
        Me.btnAttendance.TabIndex = 1
        Me.btnAttendance.Text = "Attendance"
        Me.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAttendance.UseVisualStyleBackColor = False
        '
        'btnStudents
        '
        Me.btnStudents.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStudents.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudents.ForeColor = System.Drawing.Color.White
        Me.btnStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudents.ImageIndex = 4
        Me.btnStudents.ImageList = Me.ImageList1
        Me.btnStudents.Location = New System.Drawing.Point(3, 23)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnStudents.Size = New System.Drawing.Size(183, 54)
        Me.btnStudents.TabIndex = 0
        Me.btnStudents.Text = "Students"
        Me.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStudents.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Attendance_Monitoring_System.My.Resources.Resources.official_ctu_logov2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Padding = New System.Windows.Forms.Padding(20)
        Me.PictureBox1.Size = New System.Drawing.Size(189, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Draggable1
        '
        Me.Draggable1.TargetControl = Me.Panel1
        Me.Draggable1.WindowForm = Me
        '
        'Draggable2
        '
        Me.Draggable2.TargetControl = Me.Label1
        Me.Draggable2.WindowForm = Me
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.StudentList1)
        Me.Panel3.Controls.Add(Me.Attendance1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(189, 65)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(835, 735)
        Me.Panel3.TabIndex = 3
        '
        'Attendance1
        '
        Me.Attendance1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Attendance1.Location = New System.Drawing.Point(0, 0)
        Me.Attendance1.Name = "Attendance1"
        Me.Attendance1.Size = New System.Drawing.Size(835, 735)
        Me.Attendance1.TabIndex = 1
        Me.Attendance1.Visible = False
        '
        'StudentList1
        '
        Me.StudentList1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StudentList1.Location = New System.Drawing.Point(0, 0)
        Me.StudentList1.Name = "StudentList1"
        Me.StudentList1.Size = New System.Drawing.Size(835, 735)
        Me.StudentList1.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 800)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Draggable1 As Mimobibo.Draggable
    Friend WithEvents Draggable2 As Mimobibo.Draggable
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnAttendance As Button
    Friend WithEvents btnStudents As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents StudentList1 As StudentList
    Friend WithEvents Attendance1 As Attendance
End Class
