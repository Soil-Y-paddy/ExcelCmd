Attribute VB_Name = "Module1"

Option Explicit


Sub testExec()
    Dim WSH, wExec, sCmd As String, Result As String
    Dim inputRange As Variant
    Dim nI As Integer
    Dim outputRange As Variant
    Set WSH = CreateObject("WScript.Shell")
    sCmd = ThisWorkbook.Path
    sCmd = sCmd & "\" & Range("path").Value  '�R�}���h�v���O�����̃p�X���������Z��
    Set wExec = WSH.Exec(sCmd)
    wExec.StdIn.WriteLine Range("Input") ' ���̓Z��
        
    Do While wExec.Status = 0
        DoEvents
    Loop
    Result = wExec.StdOut.ReadAll
    Range("Output").Value = Result ' �o�̓Z��

    Error = wExec.StdErr.ReadAll
    Range("Error").Value = Error	' �G���[�e�X�g�Z��

    Range("Length").Value = wExec.ExitCode ' �߂�l�Z��

    
    Set wExec = Nothing
    Set WSH = Nothing
    
End Sub
