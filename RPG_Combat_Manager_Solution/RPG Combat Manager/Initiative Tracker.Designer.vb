﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInitiativeTracker
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
        Me.txtPlayer1 = New System.Windows.Forms.TextBox()
        Me.txtPlayer2 = New System.Windows.Forms.TextBox()
        Me.txtPlayer3 = New System.Windows.Forms.TextBox()
        Me.txtPlayer4 = New System.Windows.Forms.TextBox()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLoadPlayerNames = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSavePlayerNames = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRollInitiative = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lblMonsterName = New System.Windows.Forms.Label()
        Me.txtMonster1 = New System.Windows.Forms.TextBox()
        Me.txtMonster2 = New System.Windows.Forms.TextBox()
        Me.txtMonster3 = New System.Windows.Forms.TextBox()
        Me.txtMonster4 = New System.Windows.Forms.TextBox()
        Me.btnAddP = New System.Windows.Forms.Button()
        Me.btnRollInitiative = New System.Windows.Forms.Button()
        Me.lstIntOrder = New System.Windows.Forms.ListBox()
        Me.CharacterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddM = New System.Windows.Forms.Button()
        Me.txtPlayer1Initiative = New System.Windows.Forms.TextBox()
        Me.txtPlayer2Initiative = New System.Windows.Forms.TextBox()
        Me.txtPlayer3Initiative = New System.Windows.Forms.TextBox()
        Me.txtPlayer4Initiative = New System.Windows.Forms.TextBox()
        Me.txtMonster1Initiative = New System.Windows.Forms.TextBox()
        Me.txtMonster2Initiative = New System.Windows.Forms.TextBox()
        Me.txtMonster3Initiative = New System.Windows.Forms.TextBox()
        Me.txtMonster4Initiative = New System.Windows.Forms.TextBox()
        Me.lblPlayerInitiative = New System.Windows.Forms.Label()
        Me.lblMonsterInitiative = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        CType(Me.CharacterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPlayer1
        '
        Me.txtPlayer1.Location = New System.Drawing.Point(12, 54)
        Me.txtPlayer1.Name = "txtPlayer1"
        Me.txtPlayer1.Size = New System.Drawing.Size(182, 20)
        Me.txtPlayer1.TabIndex = 1
        '
        'txtPlayer2
        '
        Me.txtPlayer2.Location = New System.Drawing.Point(12, 80)
        Me.txtPlayer2.Name = "txtPlayer2"
        Me.txtPlayer2.Size = New System.Drawing.Size(182, 20)
        Me.txtPlayer2.TabIndex = 3
        '
        'txtPlayer3
        '
        Me.txtPlayer3.Location = New System.Drawing.Point(12, 106)
        Me.txtPlayer3.Name = "txtPlayer3"
        Me.txtPlayer3.Size = New System.Drawing.Size(182, 20)
        Me.txtPlayer3.TabIndex = 5
        '
        'txtPlayer4
        '
        Me.txtPlayer4.Location = New System.Drawing.Point(12, 132)
        Me.txtPlayer4.Name = "txtPlayer4"
        Me.txtPlayer4.Size = New System.Drawing.Size(182, 20)
        Me.txtPlayer4.TabIndex = 7
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Location = New System.Drawing.Point(12, 34)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(65, 13)
        Me.lblPlayerName.TabIndex = 23
        Me.lblPlayerName.Text = "Player name"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(604, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLoadPlayerNames, Me.mnuSavePlayerNames, Me.ToolStripSeparator2, Me.mnuRollInitiative, Me.ToolStripSeparator1, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuLoadPlayerNames
        '
        Me.mnuLoadPlayerNames.Name = "mnuLoadPlayerNames"
        Me.mnuLoadPlayerNames.Size = New System.Drawing.Size(175, 22)
        Me.mnuLoadPlayerNames.Text = "&Load Player Names"
        '
        'mnuSavePlayerNames
        '
        Me.mnuSavePlayerNames.Name = "mnuSavePlayerNames"
        Me.mnuSavePlayerNames.Size = New System.Drawing.Size(175, 22)
        Me.mnuSavePlayerNames.Text = "&Save Player Names"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(172, 6)
        '
        'mnuRollInitiative
        '
        Me.mnuRollInitiative.Name = "mnuRollInitiative"
        Me.mnuRollInitiative.Size = New System.Drawing.Size(175, 22)
        Me.mnuRollInitiative.Text = "&Roll Initiative!"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(172, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(175, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(303, 63)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(303, 89)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 18
        Me.btnLoad.Text = "&Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'lblMonsterName
        '
        Me.lblMonsterName.AutoSize = True
        Me.lblMonsterName.Location = New System.Drawing.Point(12, 174)
        Me.lblMonsterName.Name = "lblMonsterName"
        Me.lblMonsterName.Size = New System.Drawing.Size(128, 13)
        Me.lblMonsterName.TabIndex = 26
        Me.lblMonsterName.Text = "Monster/Opponent Name"
        '
        'txtMonster1
        '
        Me.txtMonster1.Location = New System.Drawing.Point(15, 191)
        Me.txtMonster1.Name = "txtMonster1"
        Me.txtMonster1.Size = New System.Drawing.Size(179, 20)
        Me.txtMonster1.TabIndex = 9
        '
        'txtMonster2
        '
        Me.txtMonster2.Location = New System.Drawing.Point(15, 218)
        Me.txtMonster2.Name = "txtMonster2"
        Me.txtMonster2.Size = New System.Drawing.Size(179, 20)
        Me.txtMonster2.TabIndex = 11
        '
        'txtMonster3
        '
        Me.txtMonster3.Location = New System.Drawing.Point(15, 245)
        Me.txtMonster3.Name = "txtMonster3"
        Me.txtMonster3.Size = New System.Drawing.Size(179, 20)
        Me.txtMonster3.TabIndex = 13
        '
        'txtMonster4
        '
        Me.txtMonster4.Location = New System.Drawing.Point(15, 272)
        Me.txtMonster4.Name = "txtMonster4"
        Me.txtMonster4.Size = New System.Drawing.Size(179, 20)
        Me.txtMonster4.TabIndex = 15
        '
        'btnAddP
        '
        Me.btnAddP.Location = New System.Drawing.Point(303, 116)
        Me.btnAddP.Name = "btnAddP"
        Me.btnAddP.Size = New System.Drawing.Size(75, 23)
        Me.btnAddP.TabIndex = 19
        Me.btnAddP.Text = "&Add"
        Me.btnAddP.UseVisualStyleBackColor = True
        '
        'btnRollInitiative
        '
        Me.btnRollInitiative.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRollInitiative.Location = New System.Drawing.Point(220, 302)
        Me.btnRollInitiative.Name = "btnRollInitiative"
        Me.btnRollInitiative.Size = New System.Drawing.Size(158, 23)
        Me.btnRollInitiative.TabIndex = 21
        Me.btnRollInitiative.Text = "Roll Initiative!"
        Me.btnRollInitiative.UseVisualStyleBackColor = True
        '
        'lstIntOrder
        '
        Me.lstIntOrder.FormattingEnabled = True
        Me.lstIntOrder.Location = New System.Drawing.Point(391, 43)
        Me.lstIntOrder.Name = "lstIntOrder"
        Me.lstIntOrder.Size = New System.Drawing.Size(179, 251)
        Me.lstIntOrder.TabIndex = 22
        '
        'CharacterBindingSource
        '
        Me.CharacterBindingSource.DataSource = GetType(RPG_Combat_Manager.Character)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(391, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Initiative Order:"
        '
        'btnAddM
        '
        Me.btnAddM.Location = New System.Drawing.Point(303, 218)
        Me.btnAddM.Name = "btnAddM"
        Me.btnAddM.Size = New System.Drawing.Size(75, 23)
        Me.btnAddM.TabIndex = 20
        Me.btnAddM.Text = "&Add"
        Me.btnAddM.UseVisualStyleBackColor = True
        '
        'txtPlayer1Initiative
        '
        Me.txtPlayer1Initiative.Location = New System.Drawing.Point(200, 54)
        Me.txtPlayer1Initiative.Name = "txtPlayer1Initiative"
        Me.txtPlayer1Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtPlayer1Initiative.TabIndex = 2
        '
        'txtPlayer2Initiative
        '
        Me.txtPlayer2Initiative.Location = New System.Drawing.Point(200, 80)
        Me.txtPlayer2Initiative.Name = "txtPlayer2Initiative"
        Me.txtPlayer2Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtPlayer2Initiative.TabIndex = 4
        '
        'txtPlayer3Initiative
        '
        Me.txtPlayer3Initiative.Location = New System.Drawing.Point(201, 105)
        Me.txtPlayer3Initiative.Name = "txtPlayer3Initiative"
        Me.txtPlayer3Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtPlayer3Initiative.TabIndex = 6
        '
        'txtPlayer4Initiative
        '
        Me.txtPlayer4Initiative.Location = New System.Drawing.Point(200, 132)
        Me.txtPlayer4Initiative.Name = "txtPlayer4Initiative"
        Me.txtPlayer4Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtPlayer4Initiative.TabIndex = 8
        '
        'txtMonster1Initiative
        '
        Me.txtMonster1Initiative.Location = New System.Drawing.Point(201, 191)
        Me.txtMonster1Initiative.Name = "txtMonster1Initiative"
        Me.txtMonster1Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtMonster1Initiative.TabIndex = 10
        '
        'txtMonster2Initiative
        '
        Me.txtMonster2Initiative.Location = New System.Drawing.Point(201, 218)
        Me.txtMonster2Initiative.Name = "txtMonster2Initiative"
        Me.txtMonster2Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtMonster2Initiative.TabIndex = 12
        '
        'txtMonster3Initiative
        '
        Me.txtMonster3Initiative.Location = New System.Drawing.Point(200, 245)
        Me.txtMonster3Initiative.Name = "txtMonster3Initiative"
        Me.txtMonster3Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtMonster3Initiative.TabIndex = 14
        '
        'txtMonster4Initiative
        '
        Me.txtMonster4Initiative.Location = New System.Drawing.Point(200, 272)
        Me.txtMonster4Initiative.Name = "txtMonster4Initiative"
        Me.txtMonster4Initiative.Size = New System.Drawing.Size(29, 20)
        Me.txtMonster4Initiative.TabIndex = 16
        '
        'lblPlayerInitiative
        '
        Me.lblPlayerInitiative.AutoSize = True
        Me.lblPlayerInitiative.Location = New System.Drawing.Point(191, 34)
        Me.lblPlayerInitiative.Name = "lblPlayerInitiative"
        Me.lblPlayerInitiative.Size = New System.Drawing.Size(46, 13)
        Me.lblPlayerInitiative.TabIndex = 24
        Me.lblPlayerInitiative.Text = "Initiative"
        '
        'lblMonsterInitiative
        '
        Me.lblMonsterInitiative.AutoSize = True
        Me.lblMonsterInitiative.Location = New System.Drawing.Point(191, 174)
        Me.lblMonsterInitiative.Name = "lblMonsterInitiative"
        Me.lblMonsterInitiative.Size = New System.Drawing.Size(46, 13)
        Me.lblMonsterInitiative.TabIndex = 27
        Me.lblMonsterInitiative.Text = "Initiative"
        '
        'frmInitiativeTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 340)
        Me.Controls.Add(Me.lblMonsterInitiative)
        Me.Controls.Add(Me.lblPlayerInitiative)
        Me.Controls.Add(Me.txtMonster4Initiative)
        Me.Controls.Add(Me.txtMonster3Initiative)
        Me.Controls.Add(Me.txtMonster2Initiative)
        Me.Controls.Add(Me.txtMonster1Initiative)
        Me.Controls.Add(Me.txtPlayer4Initiative)
        Me.Controls.Add(Me.txtPlayer3Initiative)
        Me.Controls.Add(Me.txtPlayer2Initiative)
        Me.Controls.Add(Me.txtPlayer1Initiative)
        Me.Controls.Add(Me.btnAddM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstIntOrder)
        Me.Controls.Add(Me.btnRollInitiative)
        Me.Controls.Add(Me.btnAddP)
        Me.Controls.Add(Me.txtMonster4)
        Me.Controls.Add(Me.txtMonster3)
        Me.Controls.Add(Me.txtMonster2)
        Me.Controls.Add(Me.txtMonster1)
        Me.Controls.Add(Me.lblMonsterName)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.txtPlayer4)
        Me.Controls.Add(Me.txtPlayer3)
        Me.Controls.Add(Me.txtPlayer2)
        Me.Controls.Add(Me.txtPlayer1)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmInitiativeTracker"
        Me.Text = "Initiative Tracker"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.CharacterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPlayer1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer4 As System.Windows.Forms.TextBox
    Friend WithEvents lblPlayerName As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLoadPlayerNames As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSavePlayerNames As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuRollInitiative As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents lblMonsterName As System.Windows.Forms.Label
    Friend WithEvents txtMonster1 As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster3 As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster4 As System.Windows.Forms.TextBox
    Friend WithEvents btnAddP As System.Windows.Forms.Button
    Friend WithEvents btnRollInitiative As System.Windows.Forms.Button
    Friend WithEvents lstIntOrder As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAddM As System.Windows.Forms.Button
    Friend WithEvents txtPlayer1Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer2Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer3Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer4Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster1Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster2Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster3Initiative As System.Windows.Forms.TextBox
    Friend WithEvents txtMonster4Initiative As System.Windows.Forms.TextBox
    Friend WithEvents lblPlayerInitiative As System.Windows.Forms.Label
    Friend WithEvents lblMonsterInitiative As System.Windows.Forms.Label
    Friend WithEvents CharacterBindingSource As System.Windows.Forms.BindingSource
End Class
