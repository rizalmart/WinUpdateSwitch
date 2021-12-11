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
        Me.cmdcancel = New System.Windows.Forms.Button()
        Me.cmdok = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkupdatems = New System.Windows.Forms.CheckBox()
        Me.chknoautoreboot = New System.Windows.Forms.CheckBox()
        Me.chknotifyrestart = New System.Windows.Forms.CheckBox()
        Me.chkincludedrv = New System.Windows.Forms.CheckBox()
        Me.cboupdateopt = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkautoupdate = New System.Windows.Forms.CheckBox()
        Me.chkautoupdateapps = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtwustatusserver = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtwuserver = New System.Windows.Forms.TextBox()
        Me.chkwuserver = New System.Windows.Forms.CheckBox()
        Me.chkdownloadmetered = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdcancel
        '
        Me.cmdcancel.Location = New System.Drawing.Point(335, 330)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(75, 33)
        Me.cmdcancel.TabIndex = 7
        Me.cmdcancel.Text = "Cancel"
        Me.cmdcancel.UseVisualStyleBackColor = True
        '
        'cmdok
        '
        Me.cmdok.Location = New System.Drawing.Point(254, 330)
        Me.cmdok.Name = "cmdok"
        Me.cmdok.Size = New System.Drawing.Size(75, 33)
        Me.cmdok.TabIndex = 9
        Me.cmdok.Text = "OK"
        Me.cmdok.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(411, 317)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(403, 289)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkdownloadmetered)
        Me.GroupBox2.Controls.Add(Me.chkupdatems)
        Me.GroupBox2.Controls.Add(Me.chknoautoreboot)
        Me.GroupBox2.Controls.Add(Me.chknotifyrestart)
        Me.GroupBox2.Controls.Add(Me.chkincludedrv)
        Me.GroupBox2.Controls.Add(Me.cboupdateopt)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(391, 191)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "System Update"
        '
        'chkupdatems
        '
        Me.chkupdatems.AutoSize = True
        Me.chkupdatems.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkupdatems.Location = New System.Drawing.Point(9, 92)
        Me.chkupdatems.Name = "chkupdatems"
        Me.chkupdatems.Size = New System.Drawing.Size(203, 19)
        Me.chkupdatems.TabIndex = 14
        Me.chkupdatems.Text = "Update Other Microsoft Products"
        Me.chkupdatems.UseVisualStyleBackColor = True
        '
        'chknoautoreboot
        '
        Me.chknoautoreboot.AutoSize = True
        Me.chknoautoreboot.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chknoautoreboot.Location = New System.Drawing.Point(9, 142)
        Me.chknoautoreboot.Name = "chknoautoreboot"
        Me.chknoautoreboot.Size = New System.Drawing.Size(111, 19)
        Me.chknoautoreboot.TabIndex = 13
        Me.chknoautoreboot.Text = "No Auto Reboot"
        Me.chknoautoreboot.UseVisualStyleBackColor = True
        '
        'chknotifyrestart
        '
        Me.chknotifyrestart.AutoSize = True
        Me.chknotifyrestart.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chknotifyrestart.Location = New System.Drawing.Point(9, 117)
        Me.chknotifyrestart.Name = "chknotifyrestart"
        Me.chknotifyrestart.Size = New System.Drawing.Size(205, 19)
        Me.chknotifyrestart.TabIndex = 12
        Me.chknotifyrestart.Text = "Notify Restart To Finish Updating"
        Me.chknotifyrestart.UseVisualStyleBackColor = True
        '
        'chkincludedrv
        '
        Me.chkincludedrv.AutoSize = True
        Me.chkincludedrv.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkincludedrv.Location = New System.Drawing.Point(9, 67)
        Me.chkincludedrv.Name = "chkincludedrv"
        Me.chkincludedrv.Size = New System.Drawing.Size(191, 19)
        Me.chkincludedrv.TabIndex = 11
        Me.chkincludedrv.Text = "Include Device Driver Updates"
        Me.chkincludedrv.UseVisualStyleBackColor = True
        '
        'cboupdateopt
        '
        Me.cboupdateopt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboupdateopt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboupdateopt.FormattingEnabled = True
        Me.cboupdateopt.Items.AddRange(New Object() {"Don't Install", "Notify Download and Install", "Download and Notify Install", "Automatically Install"})
        Me.cboupdateopt.Location = New System.Drawing.Point(101, 29)
        Me.cboupdateopt.Name = "cboupdateopt"
        Me.cboupdateopt.Size = New System.Drawing.Size(283, 23)
        Me.cboupdateopt.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Update Option:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkautoupdate)
        Me.GroupBox1.Controls.Add(Me.chkautoupdateapps)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 80)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Auto Update"
        '
        'chkautoupdate
        '
        Me.chkautoupdate.AutoSize = True
        Me.chkautoupdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkautoupdate.Location = New System.Drawing.Point(8, 53)
        Me.chkautoupdate.Name = "chkautoupdate"
        Me.chkautoupdate.Size = New System.Drawing.Size(121, 19)
        Me.chkautoupdate.TabIndex = 3
        Me.chkautoupdate.Text = "Windows System"
        Me.chkautoupdate.UseVisualStyleBackColor = True
        '
        'chkautoupdateapps
        '
        Me.chkautoupdateapps.AutoSize = True
        Me.chkautoupdateapps.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkautoupdateapps.Location = New System.Drawing.Point(8, 28)
        Me.chkautoupdateapps.Name = "chkautoupdateapps"
        Me.chkautoupdateapps.Size = New System.Drawing.Size(139, 19)
        Me.chkautoupdateapps.TabIndex = 0
        Me.chkautoupdateapps.Text = "Windows Store Apps"
        Me.chkautoupdateapps.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtwustatusserver)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtwuserver)
        Me.TabPage2.Controls.Add(Me.chkwuserver)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(403, 271)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "WU Server"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtwustatusserver
        '
        Me.txtwustatusserver.Location = New System.Drawing.Point(117, 74)
        Me.txtwustatusserver.Name = "txtwustatusserver"
        Me.txtwustatusserver.Size = New System.Drawing.Size(279, 21)
        Me.txtwustatusserver.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "WU Status Server:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "WU Server:"
        '
        'txtwuserver
        '
        Me.txtwuserver.Location = New System.Drawing.Point(117, 43)
        Me.txtwuserver.Name = "txtwuserver"
        Me.txtwuserver.Size = New System.Drawing.Size(279, 21)
        Me.txtwuserver.TabIndex = 5
        '
        'chkwuserver
        '
        Me.chkwuserver.AutoSize = True
        Me.chkwuserver.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkwuserver.Location = New System.Drawing.Point(6, 15)
        Me.chkwuserver.Name = "chkwuserver"
        Me.chkwuserver.Size = New System.Drawing.Size(184, 19)
        Me.chkwuserver.TabIndex = 4
        Me.chkwuserver.Text = "Use Windows Update Server"
        Me.chkwuserver.UseVisualStyleBackColor = True
        '
        'chkdownloadmetered
        '
        Me.chkdownloadmetered.AutoSize = True
        Me.chkdownloadmetered.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkdownloadmetered.Location = New System.Drawing.Point(9, 166)
        Me.chkdownloadmetered.Name = "chkdownloadmetered"
        Me.chkdownloadmetered.Size = New System.Drawing.Size(205, 19)
        Me.chkdownloadmetered.TabIndex = 15
        Me.chkdownloadmetered.Text = "Download Over Metered Network"
        Me.chkdownloadmetered.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 375)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdok)
        Me.Controls.Add(Me.cmdcancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows Update Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents cmdok As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chknoautoreboot As System.Windows.Forms.CheckBox
    Friend WithEvents chknotifyrestart As System.Windows.Forms.CheckBox
    Friend WithEvents chkincludedrv As System.Windows.Forms.CheckBox
    Friend WithEvents cboupdateopt As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkautoupdate As System.Windows.Forms.CheckBox
    Friend WithEvents chkautoupdateapps As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtwustatusserver As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtwuserver As System.Windows.Forms.TextBox
    Friend WithEvents chkwuserver As System.Windows.Forms.CheckBox
    Friend WithEvents chkupdatems As System.Windows.Forms.CheckBox
    Friend WithEvents chkdownloadmetered As System.Windows.Forms.CheckBox

End Class
