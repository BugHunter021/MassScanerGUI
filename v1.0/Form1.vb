Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Net.Security
Imports System.Text
Imports System.Xml

Public Class form1

    Dim logincookie As CookieContainer
    Dim oPro As New Process
    Dim ScanST As Boolean

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbcntry1.SelectedIndex = 0
        cmbexc.SelectedIndex = 0
        cmbtyp.SelectedIndex = 0
        cmbprs.SelectedIndex = 1

        Dim toolTip1 As New ToolTip()
        toolTip1.ShowAlways = True
        toolTip1.SetToolTip(btncpy, "Copy ip list")
        toolTip1.SetToolTip(btnrnddel, "Clear List")
        toolTip1.SetToolTip(btnclean, "Clean List from bad Character")
        toolTip1.SetToolTip(btnrnd, "Resort list by Random")
        'toolTip1.SetToolTip(btnclear, "Clear List")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        btnload.Visible = True
        If Not (ckmulti.Checked) Then txtip.Text = "" : lblcountip.Text = "0"
        tolst1.Text = "Geting IP from Web..."


        Application.DoEvents()
        Dim OpenForms
        Dim tempCookies As New CookieContainer
        Dim encoding As New UTF8Encoding


        Dim postReq As HttpWebRequest = DirectCast(WebRequest.Create("https://www.countryipblocks.net/acl.php"), HttpWebRequest)

        Dim cntrysel As String = cmbcntry1.SelectedItem
        cntrysel = cntrysel.Substring(cntrysel.Length - 3, 2)

        Dim postData As String = "countries[]=" + cntrysel + "&format1=1&get_acl=Create ACL"
        Dim byteData As Byte() = encoding.GetBytes(postData)
        'MessageBox.Show(postData)


        'ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        'ServicePointManager.SecurityProtocol = DirectCast(&HC0 Or &H300 Or &HC00, SecurityProtocolType)
        'ServicePointManager.Expect100Continue = True
        'ServicePointManager.ServerCertificateValidationCallback = Function() True
        'ServicePointManager.Expect100Continue = False
        ServicePointManager.Expect100Continue = False
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12

        getFromURL("https://www.countryipblocks.net/acl.php")

        postReq.Method = "POST"
        postReq.KeepAlive = True
        postReq.CookieContainer = tempCookies
        postReq.ContentType = "application/x-www-form-urlencoded"
        postReq.Referer = "https://www.countryipblocks.net/acl.php"
        postReq.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)"
        postReq.ContentLength = byteData.Length

        Dim postreqstream As Stream = postReq.GetRequestStream()
        postreqstream.Write(byteData, 0, byteData.Length)
        postreqstream.Close()
        Dim postresponse As HttpWebResponse

        'Application.DoEvents()
        postresponse = DirectCast(postReq.GetResponse(), HttpWebResponse)
        Application.DoEvents()
        tempCookies.Add(postresponse.Cookies)
        logincookie = tempCookies
        Dim postreqreader As New StreamReader(postresponse.GetResponseStream())

        Dim thepage As String = postreqreader.ReadToEnd

        '------- Clear Source WebPage
        Dim FirstCharacter = thepage.IndexOf("textareaAll")
        Dim endCharacter = thepage.IndexOf("</textarea>")
        'MessageBox.Show(FirstCharacter.ToString & "   " & endCharacter.ToString)
        Dim IPtext = thepage.Substring(FirstCharacter + 13, endCharacter - FirstCharacter - 13)
        IPtext = IPtext.Replace(" ", vbCrLf)
        '------- Counter IP
        Dim countip = IPtext.Split("/").Length - 1
        lblcountip.Text = (Val(lblcountip.Text) + countip).ToString
        btnload.Visible = False

        txtip.Text = txtip.Text + IPtext + vbCrLf

        'MessageBox.Show(ex.Message)
        tolst1.Text = "Get IP Finished"


    End Sub

    Function getFromURL(ByVal url As String) As String
        Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(url)
        request.Headers.Add("HTTP_USER_AGENT", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.40607; .NET CLR 1.1.4322; .NET CLR 2.0.50215)")
        System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12
        Dim response As System.Net.WebResponse

        response = request.GetResponse()

        Dim responseStream As System.IO.Stream = response.GetResponseStream()

        Dim reader As System.IO.StreamReader = New System.IO.StreamReader(responseStream)

        Return reader.ReadToEnd()

    End Function


    Private Sub btnscan_Click(sender As Object, e As EventArgs) Handles btnscan.Click
        If Not (ScanST) Then
            Dim typeport As String = ""
            ' Create or overwrite the file.
            Dim pathinp As String = "input.txt"
            Dim fileinp As FileStream = File.Create(pathinp)
            Dim fileout As FileStream = File.Create("output.txt")
            fileout.Close()

            ' Add text to the file.
            Dim textbyte As Byte() = New UTF8Encoding(True).GetBytes(txtip.Text)
            fileinp.Write(textbyte, 0, textbyte.Length)
            fileinp.Close()
            If cmbtyp.SelectedItem = "UDP" Then typeport = "U"
            Dim argmas = "-iL input.txt -oL output.txt --open --rate " + txtrate.Text + " -p" + typeport + " " + txtports.Text + " --exclude " + cmbexc.SelectedItem + " " + txtarg.Text

            With oPro

                .StartInfo.UseShellExecute = True
                .StartInfo.Arguments = argmas
                .StartInfo.FileName = "masscan.exe"
                .Start()
            End With
            'MessageBox.Show("ssssssss")
            btnscan.Text = "Stop Scan"
            btnscan.BackColor = Color.FromArgb(255, 128, 128)
            btnload.Visible = True
            tmrscan.Enabled = True
            tolst1.Text = "Scaning..."
            ScanST = True
        Else
            oPro.CloseMainWindow()
            btnscan.Text = "Start Scan"
            btnscan.BackColor = Color.FromArgb(128, 255, 128)
            tolst1.Text = "Scan stoped"
            ScanST = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tmrscan_Tick(sender As Object, e As EventArgs) Handles tmrscan.Tick
        If oPro.HasExited Then
            tmrscan.Enabled = False
            btnload.Visible = False
            tolst1.Text = "Scan Finished"
            ': MessageBox.Show("Closed")
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("output.txt")
            Dim countip = fileReader.Split("open").Length - 1
            lbltotal.Text = countip
            'MsgBox(fileReader)
            btnscan.Text = "Start Scan"
            btnscan.BackColor = Color.FromArgb(128, 255, 128)
            ScanST = False
        End If

    End Sub

    Private Sub txtip_TextChanged(sender As Object, e As EventArgs) Handles txtip.TextChanged
        Dim countip = txtip.Text.Split("/").Length - 1
        lblcountip.Text = countip
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btncpy_Click(sender As Object, e As EventArgs) Handles btncpy.Click
        On Error Resume Next
        My.Computer.Clipboard.SetText(txtip.Text)
    End Sub

    Private Sub btnrnddel_Click(sender As Object, e As EventArgs) Handles btnrnddel.Click
        txtip.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub btnparser_Click(sender As Object, e As EventArgs) Handles btnparser.Click
        'On Error Resume Next
        Dim readerout As StreamReader = My.Computer.FileSystem.OpenTextFileReader("output.txt")
        Dim fileReader, portex, ipex As String
        Dim posport, posip, posipend
        Dim pathinp As String = "outparser.txt"
        Dim fileinp As FileStream = File.Create(pathinp)
        Dim textbyte As Byte()
        Dim num
        tolst1.Text = "Parsing..."
        Do
            num = num + 1
            lblprsint.Text = num.ToString
            fileReader = readerout.ReadLine
            Application.DoEvents()
            If Not (IsNothing(fileReader)) Then

                If fileReader.IndexOf("open") >= 0 Or fileReader = "" Then
                    'MsgBox(fileReader)
                    posport = fileReader.IndexOf(" ", fileReader.IndexOf(" ") + 1)
                    posip = fileReader.IndexOf(" ", posport + 1)
                    portex = fileReader.Substring(posport, posip - posport)
                    posipend = fileReader.IndexOf(" ", posip + 1)
                    ipex = fileReader.Substring(posip, posipend - posip)
                    If cmbprs.SelectedItem = "IP:Port" Then
                        textbyte = New UTF8Encoding(True).GetBytes(ipex.Trim() + ":" + portex.Trim() + vbCrLf)
                    ElseIf cmbprs.SelectedItem = "IP" Then
                        textbyte = New UTF8Encoding(True).GetBytes(ipex.Trim() + vbCrLf)
                    End If
                    fileinp.Write(textbyte, 0, textbyte.Length)
                        'MsgBox(posport.ToString + "  " + posip.ToString)
                    End If
                End If

        Loop Until fileReader Is Nothing

        fileinp.Close()
        readerout.Close()
        tolst1.Text = "Parser finished"
        MsgBox("Parser finished to file : outparser.txt ")
    End Sub
End Class
