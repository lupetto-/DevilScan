Imports System.Text.RegularExpressions

Public Class Form1
    Dim Asquared As String
    Dim Avast As String
    Dim AVG As String
    Dim Avira As String
    Dim BitDefender As String
    Dim ClamAV As String
    Dim Comodo As String
    Dim DrWeb As String
    Dim Fprot As String
    Dim IkarusT3 As String
    Dim Panda As String
    Dim STOPZilla As String
    Dim TrendMicro As String
    Dim VBA32 As String
    Private Sub ExcisionButtonBlue1_Click(sender As Object, e As EventArgs) Handles ExcisionButtonBlue1.Click
        ExcisionButtonBlue2.Enabled = True
        WebBrowser2.Document.GetElementById("submitav").InvokeMember("click")
        WebBrowser2.Document.GetElementById("upfile").InvokeMember("click")
    End Sub

    Private Sub ExcisionButtonBlue2_Click(sender As Object, e As EventArgs) Handles ExcisionButtonBlue2.Click
        ExcisionButtonBlue1.Enabled = False
        ExcisionButtonBlue2.Enabled = False
        WebBrowser2.Document.GetElementById("submitfile").InvokeMember("click")
    End Sub
    Dim FirstTime As Integer = 0

    Private Sub WebBrowser2_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted
        If LCase(e.Url.ToString) = "http://vscan.novirusthanks.org/" Then
            ExcisionButtonBlue1.Enabled = True

        End If
        If LCase(e.Url.ToString).Contains("file") Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If
        If LCase(e.Url.ToString).Contains("analysis") Then
            FirstTime += 1
            If FirstTime > 1 Then
            Else
                Asquared = GetAvResult(WebBrowser2.DocumentText, "Asquared")
                Asquared = GetAvResult(WebBrowser2.DocumentText, "Asquared")
                Avast = GetAvResult(WebBrowser2.DocumentText, "Avast")
                AVG = GetAvResult(WebBrowser2.DocumentText, "AVG")
                Avira = GetAvResult(WebBrowser2.DocumentText, "Avira")
                BitDefender = GetAvResult(WebBrowser2.DocumentText, "BitDefender")
                ClamAV = GetAvResult(WebBrowser2.DocumentText, "ClamAV")
                Comodo = GetAvResult(WebBrowser2.DocumentText, "Comodo")
                DrWeb = GetAvResult(WebBrowser2.DocumentText, "DrWeb")
                Fprot = GetAvResult(WebBrowser2.DocumentText, "Fprot")
                IkarusT3 = GetAvResult(WebBrowser2.DocumentText, "IkarusT3")
                Panda = GetAvResult(WebBrowser2.DocumentText, "Panda")
                STOPZilla = GetAvResult(WebBrowser2.DocumentText, "STOPZilla")
                TrendMicro = GetAvResult(WebBrowser2.DocumentText, "TrendMicro")
                VBA32 = GetAvResult(WebBrowser2.DocumentText, "VBA32")
                Label1.Text += " : -" & Asquared & "-"
                Label2.Text += " : -" & Avast & "-"
                Label3.Text += " : -" & AVG & "-"
                Label4.Text += " : -" & Avira & "-"
                Label5.Text += " : -" & BitDefender & "-"
                Label6.Text += " : -" & ClamAV & "-"
                Label7.Text += " : -" & Comodo & "-"
                Label8.Text += " : -" & DrWeb & "-"
                Label9.Text += " : -" & Fprot & "-"
                Label10.Text += " : -" & IkarusT3 & "-"
                Label11.Text += " : -" & Panda & "-"
                Label12.Text += " : -" & STOPZilla & "-"
                Label13.Text += " : -" & TrendMicro & "-"
                Label14.Text += " : -" & VBA32 & "-"
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Asquared"
        Label2.Text = "Avast"
        Label3.Text = "AVG"
        Label4.Text = "Avira"
        Label5.Text = "BitDefender"
        Label6.Text = "ClamAV"
        Label7.Text = "Comodo"
        Label8.Text = "DrWeb"
        Label9.Text = "Fprot"
        Label10.Text = "IkarusT3"
        Label11.Text = "Panda"
        Label12.Text = "STOPZilla"
        Label13.Text = "TrendMicro"
        Label14.Text = "VBA32"
        WebBrowser2.Navigate("http://vscan.novirusthanks.org/")
    End Sub

    Private Function GetAvResult(ByVal Source As String, ByVal Av As String) As String
        Try
            Dim fRes As String = Regex.Split(Regex.Split(Source, Av)(1), "</span>")(0)
            Dim aRes As String = Split(fRes, "class='infected'>")(1)
            Return aRes
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Private Sub ExcisionButtonWhite1_Click(sender As Object, e As EventArgs) Handles ExcisionButtonWhite1.Click
        WebBrowser1.Navigate("http://api.adf.ly/api.php?key=fc320f1ba6fa89794301fb6493b34a30&uid=3061426&advert_type=int&domain=q.gs&url=" + WebBrowser2.Url.ToString)
    End Sub
End Class
