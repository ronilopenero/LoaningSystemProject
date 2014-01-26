Imports System.IO
Imports System.Xml

Public Class Application_Form
    Dim cPage As Integer = 3
    Dim minPage As Integer = 3
    Dim maxPage As Integer = 7

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Panel3.Parent = Panel2
        Panel4.Parent = Panel2
        Panel5.Parent = Panel2
        Panel6.Parent = Panel2
        Panel7.Parent = Panel2
        Panel3.Visible = True
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = False
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cPage += 1
        If (cPage > maxPage) Then
            Dim result = MessageBox.Show("Are all information entered correct?", "Save", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                cPage -= 1
            ElseIf result = DialogResult.Yes Then
                MessageBox.Show("All information saved")
                Me.Close()
            End If
        End If
        If (cPage = 3) Then
            Panel3.Visible = True
            Panel4.Visible = False
            Panel5.Visible = False
            Panel6.Visible = False
        End If
        If (cPage = 4) Then
            Panel3.Visible = False
            Panel4.Visible = True
            Panel5.Visible = False
            Panel6.Visible = False
        End If
        If (cPage = 5) Then
            Panel3.Visible = False
            Panel4.Visible = False
            Panel5.Visible = True
            Panel6.Visible = False
        End If
        If (cPage = 6) Then
            Panel3.Visible = False
            Panel4.Visible = False
            Panel5.Visible = False
            Panel6.Visible = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cPage -= 1
        If (cPage < minPage) Then
            Me.Close()
        End If
        If (cPage = 3) Then
            Panel3.Visible = True
            Panel4.Visible = False
            Panel5.Visible = False
            Panel6.Visible = False
        End If
        If (cPage = 4) Then
            Panel3.Visible = False
            Panel4.Visible = True
            Panel5.Visible = False
            Panel6.Visible = False
        End If
        If (cPage = 5) Then
            Panel3.Visible = False
            Panel4.Visible = False
            Panel5.Visible = True
            Panel6.Visible = False
        End If
        If (cPage = 6) Then
            Panel3.Visible = False
            Panel4.Visible = False
            Panel5.Visible = False
            Panel6.Visible = True
        End If
    End Sub

End Class