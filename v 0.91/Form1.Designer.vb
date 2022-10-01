<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.txtip = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.cmbprs = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtarg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtports = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.cmbtyp = New System.Windows.Forms.ComboBox()
        Me.cmbexc = New System.Windows.Forms.ComboBox()
        Me.ckmulti = New System.Windows.Forms.CheckBox()
        Me.cmbcntry1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblcountip = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnclean = New System.Windows.Forms.Button()
        Me.btnrnd = New System.Windows.Forms.Button()
        Me.btnrnddel = New System.Windows.Forms.Button()
        Me.btncpy = New System.Windows.Forms.Button()
        Me.btnscan = New System.Windows.Forms.Button()
        Me.btnload = New System.Windows.Forms.Button()
        Me.tmrscan = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tolst1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtip
        '
        Me.txtip.Location = New System.Drawing.Point(335, 24)
        Me.txtip.Multiline = True
        Me.txtip.Name = "txtip"
        Me.txtip.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtip.Size = New System.Drawing.Size(317, 442)
        Me.txtip.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.cmbprs)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtarg)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtports)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtrate)
        Me.GroupBox1.Controls.Add(Me.cmbtyp)
        Me.GroupBox1.Controls.Add(Me.cmbexc)
        Me.GroupBox1.Controls.Add(Me.ckmulti)
        Me.GroupBox1.Controls.Add(Me.cmbcntry1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 292)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'Button10
        '
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button10.Location = New System.Drawing.Point(186, 19)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(86, 21)
        Me.Button10.TabIndex = 35
        Me.Button10.Text = "Get IP"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.Location = New System.Drawing.Point(157, 267)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(67, 17)
        Me.CheckBox3.TabIndex = 31
        Me.CheckBox3.Text = "-banners"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(16, 267)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(41, 17)
        Me.CheckBox2.TabIndex = 30
        Me.CheckBox2.Text = "-vv"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'cmbprs
        '
        Me.cmbprs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbprs.FormattingEnabled = True
        Me.cmbprs.Items.AddRange(New Object() {"IP", "IP:Port", "Port->text file"})
        Me.cmbprs.Location = New System.Drawing.Point(16, 240)
        Me.cmbprs.Name = "cmbprs"
        Me.cmbprs.Size = New System.Drawing.Size(255, 21)
        Me.cmbprs.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Pars Format :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Costum Arg : "
        '
        'txtarg
        '
        Me.txtarg.Location = New System.Drawing.Point(16, 196)
        Me.txtarg.Name = "txtarg"
        Me.txtarg.Size = New System.Drawing.Size(256, 20)
        Me.txtarg.TabIndex = 26
        Me.txtarg.Text = "--open-only"
        Me.txtarg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Port : "
        '
        'txtports
        '
        Me.txtports.Location = New System.Drawing.Point(16, 151)
        Me.txtports.Name = "txtports"
        Me.txtports.Size = New System.Drawing.Size(256, 20)
        Me.txtports.TabIndex = 24
        Me.txtports.Text = "3389"
        Me.txtports.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Type : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Rate : "
        '
        'txtrate
        '
        Me.txtrate.Location = New System.Drawing.Point(173, 109)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(99, 20)
        Me.txtrate.TabIndex = 21
        Me.txtrate.Text = "1000000"
        Me.txtrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbtyp
        '
        Me.cmbtyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtyp.FormattingEnabled = True
        Me.cmbtyp.Items.AddRange(New Object() {"TCP", "UDP"})
        Me.cmbtyp.Location = New System.Drawing.Point(17, 109)
        Me.cmbtyp.Name = "cmbtyp"
        Me.cmbtyp.Size = New System.Drawing.Size(98, 21)
        Me.cmbtyp.TabIndex = 20
        '
        'cmbexc
        '
        Me.cmbexc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbexc.FormattingEnabled = True
        Me.cmbexc.Items.AddRange(New Object() {"255.255.255.255", "exclude.txt"})
        Me.cmbexc.Location = New System.Drawing.Point(17, 69)
        Me.cmbexc.Name = "cmbexc"
        Me.cmbexc.Size = New System.Drawing.Size(255, 21)
        Me.cmbexc.TabIndex = 19
        '
        'ckmulti
        '
        Me.ckmulti.AutoSize = True
        Me.ckmulti.Location = New System.Drawing.Point(18, 46)
        Me.ckmulti.Name = "ckmulti"
        Me.ckmulti.Size = New System.Drawing.Size(114, 17)
        Me.ckmulti.TabIndex = 18
        Me.ckmulti.Text = "Multi Country (add)"
        Me.ckmulti.UseVisualStyleBackColor = True
        '
        'cmbcntry1
        '
        Me.cmbcntry1.AccessibleName = ""
        Me.cmbcntry1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcntry1.FormattingEnabled = True
        Me.cmbcntry1.Items.AddRange(New Object() {"Afghanistan (AF)", "Aland (AX)", "Albania (AL)", "Algeria (DZ)", "American (AS)", "Andorra (AD)", "Angola (AO)", "Anguilla (AI)", "Antarctica (AQ)", "Antigua (AG)", "Argentina (AR)", "Armenia (AM)", "Aruba (AW)", "Asia (AP)", "Australia (AU)", "Austria (AT)", "Azerbaijan (AZ)", "Bahamas (BS)", "Bahrain (BH)", "Bangladesh (BD)", "Barbados (BB)", "Belarus (BY)", "Belgium (BE)", "Belize (BZ)", "Benin (BJ)", "Bermuda (BM)", "Bhutan (BT)", "Bolivia (BO)", "Bonaire (BQ)", "Bosnia (BA)", "Botswana (BW)", "Bouvet (BV)", "Brazil (BR)", "British (IO)", "Brunei (BN)", "Bulgaria (BG)", "Burkina (BF)", "Burundi (BI)", "Cambodia (KH)", "Cameroon (CM)", "Canada (CA)", "Cape (CV)", "Cayman (KY)", "Central (CF)", "Chad (TD)", "Chile (CL)", "China (CN)", "Christmas (CX)", "Cocos (CC)", "Colombia (CO)", "Comoros (KM)", "Congo (CG)", "Congo (CD)", "Cook (CK)", "Costa (CR)", "Cote (CI)", "Croatia (HR)", "Cuba (CU)", "Curacao (CW)", "Cyprus (CY)", "Czech (CZ)", "Denmark (DK)", "Djibouti (DJ)", "Dominica (DM)", "Dominican (DO)", "Ecuador (EC)", "Egypt (EG)", "El (SV)", "Equatorial (GQ)", "Eritrea (ER)", "Estonia (EE)", "Ethiopia (ET)", "European (EU)", "Falkland (FK)", "Faroe (FO)", "Fiji (FJ)", "Finland (FI)", "France (FR)", "French (GF)", "French (PF)", "French (TF)", "Gabon (GA)", "Gambia (GM)", "Georgia (GE)", "Germany (DE)", "Ghana (GH)", "Gibraltar (GI)", "Greece (GR)", "Greenland (GL)", "Grenada (GD)", "Guadeloupe (GP)", "Guam (GU)", "Guatemala (GT)", "Guernsey (GG)", "Guinea (GN)", "Guinea-bissau (GW)", "Guyana (GY)", "Haiti (HT)", "Heard (HM)", "Holy (VA)", "Honduras (HN)", "Hong (HK)", "Hungary (HU)", "Iceland (IS)", "India (IN)", "Indonesia (ID)", "Iran (IR)", "Iraq (IQ)", "Ireland (IE)", "Isle (IM)", "Israel (IL)", "Italy (IT)", "Jamaica (JM)", "Japan (JP)", "Jersey (JE)", "Jordan (JO)", "Kazakhstan (KZ)", "Kenya (KE)", "Kiribati (KI)", "Korea (KP)", "Korea (KR)", "Kosovo (CS)", "Kuwait (KW)", "Kyrgyzstan (KG)", "Lao (LA)", "Latvia (LV)", "Lebanon (LB)", "Lesotho (LS)", "Liberia (LR)", "Libyan (LY)", "Liechtenstein (LI)", "Lithuania (LT)", "Luxembourg (LU)", "Macao (MO)", "Macedonia (MK)", "Madagascar (MG)", "Malawi (MW)", "Malaysia (MY)", "Maldives (MV)", "Mali (ML)", "Malta (MT)", "Marshall (MH)", "Martinique (MQ)", "Mauritania (MR)", "Mauritius (MU)", "Mayotte (YT)", "Mexico (MX)", "Micronesia (FM)", "Moldova (MD)", "Monaco (MC)", "Mongolia (MN)", "Montenegro (ME)", "Montserrat (MS)", "Morocco (MA)", "Mozambique (MZ)", "Myanmar (MM)", "Namibia (NA)", "Nauru (NR)", "Nepal (NP)", "Netherlands (NL)", "Netherlands (AN)", "New (NC)", "New (NZ)", "Nicaragua (NI)", "Niger (NE)", "Nigeria (NG)", "Niue (NU)", "Norfolk (NF)", "Northern (MP)", "Norway (NO)", "Oman (OM)", "Pakistan (PK)", "Palau (PW)", "Palestinian (PS)", "Panama (PA)", "Papua (PG)", "Paraguay (PY)", "Peru (PE)", "Philippines (PH)", "Pitcairn (PN)", "Poland (PL)", "Portugal (PT)", "Puerto (PR)", "Qatar (QA)", "Reunion (RE)", "Romania (RO)", "Russian (RU)", "Rwanda (RW)", "Saint (BL)", "Saint (SH)", "Saint (KN)", "Saint (LC)", "Saint (MF)", "Saint (PM)", "Saint (VC)", "Samoa (WS)", "San (SM)", "Sao (ST)", "Saudi (SA)", "Senegal (SN)", "Serbia (RS)", "Seychelles (SC)", "Sierra (SL)", "Singapore (SG)", "Sint (SX)", "Slovakia (SK)", "Slovenia (SI)", "Solomon (SB)", "Somalia (SO)", "South (ZA)", "South (GS)", "South (SS)", "Spain (ES)", "Sri (LK)", "Sudan (SD)", "Suriname (SR)", "Svalbard (SJ)", "Swaziland (SZ)", "Sweden (SE)", "Switzerland (CH)", "Syrian (SY)", "Taiwan (TW)", "Tajikistan (TJ)", "Tanzania (TZ)", "Thailand (TH)", "Timor-leste (TL)", "Togo (TG)", "Tokelau (TK)", "Tonga (TO)", "Trinidad (TT)", "Tunisia (TN)", "Turkey (TR)", "Turkmenistan (TM)", "Turks (TC)", "Tuvalu (TV)", "Uganda (UG)", "Ukraine (UA)", "United (AE)", "United (GB)", "United (US)", "United (UM)", "Uruguay (UY)", "Uzbekistan (UZ)", "Vanuatu (VU)", "Venezuela (VE)", "Viet (VN)", "Virgin (VG)", "Virgin (VI)", "Wallis (WF)", "Western (EH)", "Yemen (YE)", "Zambia (ZM)", "Zimbabwe (ZW)"})
        Me.cmbcntry1.Location = New System.Drawing.Point(18, 19)
        Me.cmbcntry1.Name = "cmbcntry1"
        Me.cmbcntry1.Size = New System.Drawing.Size(162, 21)
        Me.cmbcntry1.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbltotal)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 320)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 99)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Progress"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.ForeColor = System.Drawing.Color.Red
        Me.lbltotal.Location = New System.Drawing.Point(94, 53)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(13, 13)
        Me.lbltotal.TabIndex = 32
        Me.lbltotal.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(94, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Total open port:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Current parser : "
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(159, 426)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 26)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Resume Scan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(19, 458)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 26)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Parse IPs"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(159, 458)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 26)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Download WinPcap"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(332, 472)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Number of IPs :"
        '
        'lblcountip
        '
        Me.lblcountip.AutoSize = True
        Me.lblcountip.ForeColor = System.Drawing.Color.Red
        Me.lblcountip.Location = New System.Drawing.Point(428, 472)
        Me.lblcountip.Name = "lblcountip"
        Me.lblcountip.Size = New System.Drawing.Size(13, 13)
        Me.lblcountip.TabIndex = 33
        Me.lblcountip.Text = "0"
        '
        'btnclear
        '
        Me.btnclear.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.img_3828401
        Me.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnclear.Location = New System.Drawing.Point(602, 131)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(31, 26)
        Me.btnclear.TabIndex = 27
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnclean
        '
        Me.btnclean.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._4197111
        Me.btnclean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclean.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnclean.Location = New System.Drawing.Point(602, 105)
        Me.btnclean.Name = "btnclean"
        Me.btnclean.Size = New System.Drawing.Size(31, 26)
        Me.btnclean.TabIndex = 26
        Me.btnclean.UseVisualStyleBackColor = True
        '
        'btnrnd
        '
        Me.btnrnd.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._852346_random_512x512
        Me.btnrnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnrnd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnrnd.Location = New System.Drawing.Point(602, 79)
        Me.btnrnd.Name = "btnrnd"
        Me.btnrnd.Size = New System.Drawing.Size(31, 26)
        Me.btnrnd.TabIndex = 25
        Me.btnrnd.UseVisualStyleBackColor = True
        '
        'btnrnddel
        '
        Me.btnrnddel.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Close_2_icon
        Me.btnrnddel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnrnddel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnrnddel.Location = New System.Drawing.Point(602, 53)
        Me.btnrnddel.Name = "btnrnddel"
        Me.btnrnddel.Size = New System.Drawing.Size(31, 26)
        Me.btnrnddel.TabIndex = 24
        Me.btnrnddel.UseVisualStyleBackColor = True
        '
        'btncpy
        '
        Me.btncpy.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.copy1
        Me.btncpy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btncpy.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncpy.Location = New System.Drawing.Point(602, 27)
        Me.btncpy.Name = "btncpy"
        Me.btncpy.Size = New System.Drawing.Size(31, 26)
        Me.btncpy.TabIndex = 23
        Me.btncpy.UseVisualStyleBackColor = True
        '
        'btnscan
        '
        Me.btnscan.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnscan.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnscan.Location = New System.Drawing.Point(19, 426)
        Me.btnscan.Name = "btnscan"
        Me.btnscan.Size = New System.Drawing.Size(124, 26)
        Me.btnscan.TabIndex = 19
        Me.btnscan.Text = "Start Scan"
        Me.btnscan.UseVisualStyleBackColor = False
        '
        'btnload
        '
        Me.btnload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnload.ForeColor = System.Drawing.SystemColors.Window
        Me.btnload.Image = Global.WindowsApplication1.My.Resources.Resources.loading_photo
        Me.btnload.Location = New System.Drawing.Point(464, 213)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(56, 48)
        Me.btnload.TabIndex = 33
        Me.btnload.UseVisualStyleBackColor = True
        Me.btnload.Visible = False
        '
        'tmrscan
        '
        Me.tmrscan.Interval = 1000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tolst1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 489)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(664, 22)
        Me.StatusStrip1.TabIndex = 35
        Me.StatusStrip1.Text = "45444"
        '
        'tolst1
        '
        Me.tolst1.Name = "tolst1"
        Me.tolst1.Size = New System.Drawing.Size(51, 17)
        Me.tolst1.Text = "Status ..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 511)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.lblcountip)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnclean)
        Me.Controls.Add(Me.btnrnd)
        Me.Controls.Add(Me.btnrnddel)
        Me.Controls.Add(Me.btncpy)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnscan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scanner With MassScan(BugHunter021) v0.91"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtip As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents cmbprs As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtarg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtports As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtrate As TextBox
    Friend WithEvents cmbtyp As ComboBox
    Friend WithEvents ckmulti As CheckBox
    Friend WithEvents cmbcntry1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnscan As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btncpy As Button
    Friend WithEvents btnrnddel As Button
    Friend WithEvents btnrnd As Button
    Friend WithEvents btnclean As Button
    Friend WithEvents btnclear As Button
    Public WithEvents cmbexc As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblcountip As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents btnload As Button
    Friend WithEvents tmrscan As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tolst1 As ToolStripStatusLabel
End Class
