Imports System.Threading

Class LoginForm

    Public LoggingIn As Boolean
    Private ProxySettingsVisible As Boolean

    Private Sub LoginForm_Load(ByVal s As Object, ByVal e As EventArgs) Handles Me.Load
        GetLocalConfig()

        UseIrc.Checked = Config.IrcMode
        UseRecentchanges.Checked = Not Config.IrcMode
        If RememberMe Then Username.Text = Config.Username

        Version.Text = "Version " & Config.Version.Major & "." & Config.Version.Minor & "." & Config.Version.Build

        For Each Item As String In Config.Projects
            If Item.Contains(";") Then Project.Items.Add(Item.Substring(0, Item.IndexOf(";")))
        Next Item

        If Project.Items.Count > 0 Then Project.SelectedIndex = 0

        ProxyPort.Text = Config.ProxyPort
        If ProxyPort.Text.Length = 0 Then ProxyPort.Text = "80"
        ProxyAddress.Text = Config.ProxyServer
        ProxyDomain.Text = Config.ProxyUserDomain
        ProxyUsername.Text = Config.ProxyUsername
    End Sub

    Private Sub LoginForm_Shown(ByVal s As Object, ByVal e As EventArgs) Handles Me.Shown
        If Username.Text = "" Then Username.Focus() Else Password.Focus()
    End Sub

    Private Sub LoginForm_KeyDown(ByVal s As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then End
    End Sub

    Private Sub Username_KeyDown(ByVal s As Object, ByVal e As KeyEventArgs) Handles Username.KeyDown
        If e.KeyCode = Keys.Enter Then Password.Focus()
    End Sub

    Private Sub Password_KeyDown(ByVal s As Object, ByVal e As KeyEventArgs) Handles Password.KeyDown
        If e.KeyCode = Keys.Enter Then OK_Click()
    End Sub

    Private Sub Password_TextChanged(ByVal s As Object, ByVal e As EventArgs) Handles Password.TextChanged
        OK.Enabled = (Username.Text <> "" AndAlso Password.Text <> "")
    End Sub

    Private Sub Username_TextChanged(ByVal s As Object, ByVal e As EventArgs) Handles Username.TextChanged
        OK.Enabled = (Username.Text <> "" AndAlso Password.Text <> "")
    End Sub

    Private Sub Credit_LinkClicked(ByVal s As Object, ByVal e As LinkLabelLinkClickedEventArgs) _
        Handles Credit.LinkClicked

        Process.Start(Config.CreditUrl)
    End Sub

    Private Sub OK_Click(Optional ByVal s As Object = Nothing, Optional ByVal e As EventArgs = Nothing) _
        Handles OK.Click

        LoggingIn = True

        For Each Item As String In Config.Projects
            If Item.StartsWith(Project.Text) AndAlso Item.Contains(";") _
                Then Config.Project = Item.Substring(Item.IndexOf(";") + 1)
        Next Item

        Config.SitePath = "http://" & Config.Project & "/"

        If Config.Project.Contains(".org") Then Config.IrcChannel = "#" & _
            Config.Project.Substring(0, Config.Project.IndexOf(".org"))

        Options.Enabled = False
        OK.Enabled = False
        ShowProxySettings.Enabled = False
        Progress.Enabled = True
        Cancel.Text = "Cancel"

        Config.IrcMode = UseIrc.Checked
        Config.ProxyPort = ProxyPort.Text
        Config.ProxyServer = ProxyAddress.Text
        Config.ProxyUserDomain = ProxyDomain.Text
        Config.ProxyUsername = ProxyUsername.Text
        Config.Username = Username.Text.Substring(0, 1).ToUpper & Username.Text.Substring(1)

        Login.Password = Password.Text
        Login.ConfigureProxy(ProxyAddress.Text, ProxyPort.Text, ProxyUsername.Text, ProxyPassword.Text, ProxyDomain.Text)
        Login.StartLogin(Me)
    End Sub

    Private Sub ShowProxySettings_Click(ByVal s As Object, ByVal e As EventArgs) Handles ShowProxySettings.Click
        Me.Height += 145
        ProxySettingsVisible = True
        ShowProxySettings.Enabled = False
    End Sub

    Private Sub Cancel_Click(ByVal s As Object, ByVal e As EventArgs) Handles Cancel.Click
        If LoggingIn Then Abort("Cancelled.") Else End
    End Sub

    Sub Done(ByVal O As Object)
        Main.Show()
        Close()
    End Sub

    Sub UpdateStatus(ByVal MessageObject As Object)
        Status.Text = CStr(MessageObject)
        If Progress.Value <= Progress.Maximum - 1 Then Progress.Value += 1
    End Sub

    Sub Abort(ByVal MessageObject As Object)
        LoggingIn = False
        Status.Text = CStr(MessageObject)
        Options.Enabled = True
        OK.Enabled = True
        If Not ProxySettingsVisible Then ShowProxySettings.Enabled = True
        Cancel.Text = "Exit"
        Progress.Enabled = False
        Progress.Value = 0
    End Sub

End Class
