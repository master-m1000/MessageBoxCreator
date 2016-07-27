Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.MessageBoxCreator
        If GetIcon(Me.Handle, "%SystemRoot%\System32\imageres.dll", 76) <> CType(0, IntPtr) And GetIcon(Me.Handle, "%SystemRoot%\System32\imageres.dll", 76) <> CType(1, IntPtr) Then
            PbInformation.Image = Icon.FromHandle(GetIcon(Me.Handle, "%SystemRoot%\System32\imageres.dll", 76)).ToBitmap
        End If
        If GetIcon(Me.Handle, "%SystemRoot%\System32\imageres.dll", 79) <> CType(0, IntPtr) And GetIcon(Me.Handle, "%SystemRoot%\System32\imageres.dll", 79) <> CType(1, IntPtr) Then
            PbWarning.Image = Icon.FromHandle(GetIcon(Me.Handle, "%SystemRoot%\System32\imageres.dll", 79)).ToBitmap
        End If
        If GetIcon(Me.Handle, "%SystemRoot%\System32\imageres.dll", 93) <> CType(0, IntPtr) And GetIcon(Me.Handle, "%SystemRoot%\System32\imageres.dll", 93) <> CType(1, IntPtr) Then
            PbError.Image = Icon.FromHandle(GetIcon(Me.Handle, "%SystemRoot%\System32\imageres.dll", 93)).ToBitmap
        End If
        If GetIcon(Me.Handle, "%SystemRoot%\System32\imageres.dll", 94) <> CType(0, IntPtr) And GetIcon(Me.Handle, "%SystemRoot%\System32\imageres.dll", 94) <> CType(1, IntPtr) Then
            PbQuestion.Image = Icon.FromHandle(GetIcon(Me.Handle, "%SystemRoot%\System32\imageres.dll", 94)).ToBitmap
        End If
        CbButtons.SelectedIndex = 0
        CbDefaultButton.SelectedIndex = 0
    End Sub

    Private Sub PbInformation_Click(sender As Object, e As EventArgs) Handles PbInformation.Click, PbWarning.Click, PbError.Click, PbQuestion.Click, PbNone.Click
        If sender Is PbInformation Then
            RbInformation.Select()
        ElseIf sender Is PbWarning Then
            RbWarning.Select()
        ElseIf sender Is PbError Then
            RbError.Select()
        ElseIf sender Is PbQuestion Then
            RbQuestion.Select()
        ElseIf sender Is PbNone Then
            RbNone.Select()
        End If
    End Sub

    Private Sub CbButtons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbButtons.SelectedIndexChanged
        Dim oldSelectedIndex As Integer = CbDefaultButton.SelectedIndex
        CbDefaultButton.Items.Clear()
        CbDefaultButton.Items.Add("Button 1")
        If Not CbButtons.SelectedIndex = 0 Then
            CbDefaultButton.Items.Add("Button 2")
        End If
        If CbButtons.SelectedIndex = 2 Or CbButtons.SelectedIndex = 3 Then
            CbDefaultButton.Items.Add("Button 3")
        End If
        If oldSelectedIndex > CbDefaultButton.Items.Count - 1 Then
            CbDefaultButton.SelectedIndex = 0
        Else
            CbDefaultButton.SelectedIndex = oldSelectedIndex
        End If
    End Sub

    Private Sub PropertiesChanged(sender As Object, e As EventArgs) Handles TbOwner.TextChanged, TbText.TextChanged, TbCaption.TextChanged, CbButtons.SelectedIndexChanged, RbInformation.CheckedChanged, RbWarning.CheckedChanged, RbError.CheckedChanged, RbQuestion.CheckedChanged, RbNone.CheckedChanged, CbDefaultButton.SelectedIndexChanged
        TbCode.Text = GenerateCode()
    End Sub

    Private Sub BtnCopyCode_Click(sender As Object, e As EventArgs) Handles BtnCopyCode.Click
        My.Computer.Clipboard.SetText(TbCode.Text)
    End Sub

    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        Dim selectedMessageBoxIcon As MessageBoxIcon
        If RbInformation.Checked = True Then
            selectedMessageBoxIcon = MessageBoxIcon.Information
        ElseIf RbWarning.Checked = True Then
            selectedMessageBoxIcon = MessageBoxIcon.Warning
        ElseIf RbError.Checked = True Then
            selectedMessageBoxIcon = MessageBoxIcon.Error
        ElseIf RbQuestion.Checked = True Then
            selectedMessageBoxIcon = MessageBoxIcon.Question
        ElseIf RbNone.Checked = True Then
            selectedMessageBoxIcon = MessageBoxIcon.None
        End If

        Dim defaultButton As MessageBoxDefaultButton
        Select Case CbDefaultButton.SelectedIndex
            Case 0
                defaultButton = MessageBoxDefaultButton.Button1
            Case 1
                defaultButton = MessageBoxDefaultButton.Button2
            Case 2
                defaultButton = MessageBoxDefaultButton.Button3
        End Select

        MessageBox.Show(Me, TbText.Text, TbCaption.Text, CType(CbButtons.SelectedIndex, MessageBoxButtons), selectedMessageBoxIcon, defaultButton)
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Process.Start("https://github.com/master-m1000/MessageBoxCreator")
    End Sub

    Private Declare Function GetIcon Lib "shell32.dll" Alias "ExtractIconA" (ByVal hInst As IntPtr, ByVal lpszExeFileName As String, ByVal nIconIndex As Integer) As IntPtr

    Public Function GenerateCode() As String
        Dim result As String = "MessageBox.Show("

        If String.IsNullOrWhiteSpace(TbOwner.Text) = False Then
            result &= TbOwner.Text & ", "
        End If

        result &= """" & TbText.Text & """, """ & TbCaption.Text & """"

        Select Case CbButtons.SelectedIndex
            Case 0
                result &= ", MessageBoxButtons.OK"
            Case 1
                result &= ", MessageBoxButtons.OKCancel"
            Case 2
                result &= ", MessageBoxButtons.AbortRetryIgnore"
            Case 3
                result &= ", MessageBoxButtons.YesNoCancel"
            Case 4
                result &= ", MessageBoxButtons.YesNo"
            Case 5
                result &= ", MessageBoxButtons.RetryCancel"
        End Select

        If RbInformation.Checked = True Then
            result &= ", MessageBoxIcon.Information"
        ElseIf RbWarning.Checked = True Then
            result &= ", MessageBoxIcon.Warning"
        ElseIf RbError.Checked = True Then
            result &= ", MessageBoxIcon.Error"
        ElseIf RbQuestion.Checked = True Then
            result &= ", MessageBoxIcon.Question"
        ElseIf RbNone.Checked = True Then
            result &= ", MessageBoxIcon.None"
        End If

        Select Case CbButtons.SelectedIndex
            Case 0
                result &= ", MessageBoxDefaultButton.Button1"
            Case 1
                result &= ", MessageBoxDefaultButton.Button2"
            Case 2
                result &= ", MessageBoxDefaultButton.Button3"
        End Select

        result &= ")"
        Return result
    End Function


End Class
