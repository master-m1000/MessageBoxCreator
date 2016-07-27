<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TbCaption = New System.Windows.Forms.TextBox()
        Me.TbText = New System.Windows.Forms.TextBox()
        Me.LblOwner = New System.Windows.Forms.Label()
        Me.TbOwner = New System.Windows.Forms.TextBox()
        Me.LblText = New System.Windows.Forms.Label()
        Me.LblCaption = New System.Windows.Forms.Label()
        Me.LblButton = New System.Windows.Forms.Label()
        Me.LblIcon = New System.Windows.Forms.Label()
        Me.LblDefaultButton = New System.Windows.Forms.Label()
        Me.CbDefaultButton = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PbNone = New System.Windows.Forms.PictureBox()
        Me.PbWarning = New System.Windows.Forms.PictureBox()
        Me.RbInformation = New System.Windows.Forms.RadioButton()
        Me.RbWarning = New System.Windows.Forms.RadioButton()
        Me.PbInformation = New System.Windows.Forms.PictureBox()
        Me.RbError = New System.Windows.Forms.RadioButton()
        Me.RbQuestion = New System.Windows.Forms.RadioButton()
        Me.PbError = New System.Windows.Forms.PictureBox()
        Me.PbQuestion = New System.Windows.Forms.PictureBox()
        Me.RbNone = New System.Windows.Forms.RadioButton()
        Me.CbButtons = New System.Windows.Forms.ComboBox()
        Me.TbCode = New System.Windows.Forms.TextBox()
        Me.BtnCopyCode = New System.Windows.Forms.Button()
        Me.BtnShow = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PbNone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbWarning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TbCaption, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TbText, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblOwner, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TbOwner, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblText, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblCaption, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblButton, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblIcon, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LblDefaultButton, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.CbDefaultButton, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CbButtons, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 13)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(277, 218)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TbCaption
        '
        Me.TbCaption.Dock = System.Windows.Forms.DockStyle.Top
        Me.TbCaption.Location = New System.Drawing.Point(82, 55)
        Me.TbCaption.Name = "TbCaption"
        Me.TbCaption.Size = New System.Drawing.Size(192, 20)
        Me.TbCaption.TabIndex = 5
        '
        'TbText
        '
        Me.TbText.Dock = System.Windows.Forms.DockStyle.Top
        Me.TbText.Location = New System.Drawing.Point(82, 29)
        Me.TbText.Name = "TbText"
        Me.TbText.Size = New System.Drawing.Size(192, 20)
        Me.TbText.TabIndex = 3
        '
        'LblOwner
        '
        Me.LblOwner.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblOwner.AutoSize = True
        Me.LblOwner.Location = New System.Drawing.Point(3, 6)
        Me.LblOwner.Name = "LblOwner"
        Me.LblOwner.Size = New System.Drawing.Size(39, 13)
        Me.LblOwner.TabIndex = 0
        Me.LblOwner.Text = "&owner:"
        '
        'TbOwner
        '
        Me.TbOwner.Dock = System.Windows.Forms.DockStyle.Top
        Me.TbOwner.Location = New System.Drawing.Point(82, 3)
        Me.TbOwner.Name = "TbOwner"
        Me.TbOwner.Size = New System.Drawing.Size(192, 20)
        Me.TbOwner.TabIndex = 1
        '
        'LblText
        '
        Me.LblText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblText.AutoSize = True
        Me.LblText.Location = New System.Drawing.Point(3, 32)
        Me.LblText.Name = "LblText"
        Me.LblText.Size = New System.Drawing.Size(27, 13)
        Me.LblText.TabIndex = 2
        Me.LblText.Text = "&text:"
        '
        'LblCaption
        '
        Me.LblCaption.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblCaption.AutoSize = True
        Me.LblCaption.Location = New System.Drawing.Point(3, 58)
        Me.LblCaption.Name = "LblCaption"
        Me.LblCaption.Size = New System.Drawing.Size(45, 13)
        Me.LblCaption.TabIndex = 4
        Me.LblCaption.Text = "&caption:"
        '
        'LblButton
        '
        Me.LblButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblButton.AutoSize = True
        Me.LblButton.Location = New System.Drawing.Point(3, 85)
        Me.LblButton.Name = "LblButton"
        Me.LblButton.Size = New System.Drawing.Size(40, 13)
        Me.LblButton.TabIndex = 6
        Me.LblButton.Text = "&button:"
        '
        'LblIcon
        '
        Me.LblIcon.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblIcon.AutoSize = True
        Me.LblIcon.Location = New System.Drawing.Point(3, 141)
        Me.LblIcon.Name = "LblIcon"
        Me.LblIcon.Size = New System.Drawing.Size(30, 13)
        Me.LblIcon.TabIndex = 8
        Me.LblIcon.Text = "&icon:"
        '
        'LblDefaultButton
        '
        Me.LblDefaultButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblDefaultButton.AutoSize = True
        Me.LblDefaultButton.Location = New System.Drawing.Point(3, 198)
        Me.LblDefaultButton.Name = "LblDefaultButton"
        Me.LblDefaultButton.Size = New System.Drawing.Size(73, 13)
        Me.LblDefaultButton.TabIndex = 10
        Me.LblDefaultButton.Text = "&defaultButton:"
        '
        'CbDefaultButton
        '
        Me.CbDefaultButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.CbDefaultButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbDefaultButton.FormattingEnabled = True
        Me.CbDefaultButton.Items.AddRange(New Object() {"Button 1", "Button 2", "Button 3"})
        Me.CbDefaultButton.Location = New System.Drawing.Point(82, 194)
        Me.CbDefaultButton.Name = "CbDefaultButton"
        Me.CbDefaultButton.Size = New System.Drawing.Size(192, 21)
        Me.CbDefaultButton.TabIndex = 11
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.PbNone, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PbWarning, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.RbInformation, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RbWarning, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.PbInformation, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RbError, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RbQuestion, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.PbError, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PbQuestion, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.RbNone, 4, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(82, 108)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(174, 80)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'PbNone
        '
        Me.PbNone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbNone.Location = New System.Drawing.Point(139, 3)
        Me.PbNone.Name = "PbNone"
        Me.PbNone.Size = New System.Drawing.Size(32, 34)
        Me.PbNone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PbNone.TabIndex = 9
        Me.PbNone.TabStop = False
        '
        'PbWarning
        '
        Me.PbWarning.Location = New System.Drawing.Point(23, 43)
        Me.PbWarning.Name = "PbWarning"
        Me.PbWarning.Size = New System.Drawing.Size(32, 34)
        Me.PbWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PbWarning.TabIndex = 5
        Me.PbWarning.TabStop = False
        '
        'RbInformation
        '
        Me.RbInformation.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RbInformation.AutoSize = True
        Me.RbInformation.Location = New System.Drawing.Point(3, 13)
        Me.RbInformation.Name = "RbInformation"
        Me.RbInformation.Size = New System.Drawing.Size(14, 13)
        Me.RbInformation.TabIndex = 0
        Me.RbInformation.UseVisualStyleBackColor = True
        '
        'RbWarning
        '
        Me.RbWarning.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RbWarning.AutoSize = True
        Me.RbWarning.Location = New System.Drawing.Point(3, 53)
        Me.RbWarning.Name = "RbWarning"
        Me.RbWarning.Size = New System.Drawing.Size(14, 13)
        Me.RbWarning.TabIndex = 1
        Me.RbWarning.UseVisualStyleBackColor = True
        '
        'PbInformation
        '
        Me.PbInformation.Location = New System.Drawing.Point(23, 3)
        Me.PbInformation.Name = "PbInformation"
        Me.PbInformation.Size = New System.Drawing.Size(32, 34)
        Me.PbInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PbInformation.TabIndex = 4
        Me.PbInformation.TabStop = False
        '
        'RbError
        '
        Me.RbError.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RbError.AutoSize = True
        Me.RbError.Location = New System.Drawing.Point(61, 13)
        Me.RbError.Name = "RbError"
        Me.RbError.Size = New System.Drawing.Size(14, 13)
        Me.RbError.TabIndex = 2
        Me.RbError.UseVisualStyleBackColor = True
        '
        'RbQuestion
        '
        Me.RbQuestion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RbQuestion.AutoSize = True
        Me.RbQuestion.Location = New System.Drawing.Point(61, 53)
        Me.RbQuestion.Name = "RbQuestion"
        Me.RbQuestion.Size = New System.Drawing.Size(14, 13)
        Me.RbQuestion.TabIndex = 3
        Me.RbQuestion.UseVisualStyleBackColor = True
        '
        'PbError
        '
        Me.PbError.Location = New System.Drawing.Point(81, 3)
        Me.PbError.Name = "PbError"
        Me.PbError.Size = New System.Drawing.Size(32, 34)
        Me.PbError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PbError.TabIndex = 6
        Me.PbError.TabStop = False
        '
        'PbQuestion
        '
        Me.PbQuestion.Location = New System.Drawing.Point(81, 43)
        Me.PbQuestion.Name = "PbQuestion"
        Me.PbQuestion.Size = New System.Drawing.Size(32, 34)
        Me.PbQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PbQuestion.TabIndex = 7
        Me.PbQuestion.TabStop = False
        '
        'RbNone
        '
        Me.RbNone.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RbNone.AutoSize = True
        Me.RbNone.Checked = True
        Me.RbNone.Location = New System.Drawing.Point(119, 13)
        Me.RbNone.Name = "RbNone"
        Me.RbNone.Size = New System.Drawing.Size(14, 13)
        Me.RbNone.TabIndex = 4
        Me.RbNone.TabStop = True
        Me.RbNone.UseVisualStyleBackColor = True
        '
        'CbButtons
        '
        Me.CbButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.CbButtons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbButtons.FormattingEnabled = True
        Me.CbButtons.Items.AddRange(New Object() {"[OK]", "[OK][Cancel]", "[Abort][Retry][Ignore]", "[Yes][No][Cancel]", "[Yes][No]", "[Retry][Cancel]"})
        Me.CbButtons.Location = New System.Drawing.Point(82, 81)
        Me.CbButtons.Name = "CbButtons"
        Me.CbButtons.Size = New System.Drawing.Size(192, 21)
        Me.CbButtons.TabIndex = 7
        '
        'TbCode
        '
        Me.TbCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbCode.Location = New System.Drawing.Point(12, 237)
        Me.TbCode.Name = "TbCode"
        Me.TbCode.ReadOnly = True
        Me.TbCode.Size = New System.Drawing.Size(278, 20)
        Me.TbCode.TabIndex = 1
        '
        'BtnCopyCode
        '
        Me.BtnCopyCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCopyCode.Location = New System.Drawing.Point(12, 263)
        Me.BtnCopyCode.Name = "BtnCopyCode"
        Me.BtnCopyCode.Size = New System.Drawing.Size(75, 23)
        Me.BtnCopyCode.TabIndex = 2
        Me.BtnCopyCode.Text = "Co&py code"
        Me.BtnCopyCode.UseVisualStyleBackColor = True
        '
        'BtnShow
        '
        Me.BtnShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnShow.Location = New System.Drawing.Point(215, 263)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(75, 23)
        Me.BtnShow.TabIndex = 3
        Me.BtnShow.Text = "&Show"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(93, 263)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(116, 23)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.BtnShow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 295)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnShow)
        Me.Controls.Add(Me.BtnCopyCode)
        Me.Controls.Add(Me.TbCode)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimumSize = New System.Drawing.Size(318, 282)
        Me.Name = "Form1"
        Me.Text = "MessageBoxCreator"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PbNone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbWarning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbQuestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblOwner As Label
    Friend WithEvents TbOwner As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PbQuestion As PictureBox
    Friend WithEvents PbError As PictureBox
    Friend WithEvents PbWarning As PictureBox
    Friend WithEvents RbInformation As RadioButton
    Friend WithEvents RbWarning As RadioButton
    Friend WithEvents RbError As RadioButton
    Friend WithEvents RbQuestion As RadioButton
    Friend WithEvents PbInformation As PictureBox
    Friend WithEvents LblText As Label
    Friend WithEvents LblCaption As Label
    Friend WithEvents LblButton As Label
    Friend WithEvents LblIcon As Label
    Friend WithEvents LblDefaultButton As Label
    Friend WithEvents RbNone As RadioButton
    Friend WithEvents TbCaption As TextBox
    Friend WithEvents TbText As TextBox
    Friend WithEvents CbDefaultButton As ComboBox
    Friend WithEvents CbButtons As ComboBox
    Friend WithEvents PbNone As PictureBox
    Friend WithEvents TbCode As TextBox
    Friend WithEvents BtnCopyCode As Button
    Friend WithEvents BtnShow As Button
    Friend WithEvents BtnExit As Button
End Class
