Imports System.IO
Imports System.Net

Public Class KzBrowser

    Private WithEvents iBro As WebBrowser
    Private WithEvents iTab As TabPage

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        BroTabs.TabsAppearance = KzLook.TabsRoyalBlue
        BroTabs.ShowAddNewTab = True
        BroTabs.NewTabType = KzTabControlNewTabType.WebTab
    End Sub

    Private Sub BroTabs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BroTabs.SelectedIndexChanged
        If BroTabs.NewTabType = KzTabControlNewTabType.WebTab Then
            iBro = CType(BroTabs.SelectedTab, KzWebTap).Browser

            UrlTextBox.Text = iBro.DocumentTitle
        End If
    End Sub

    Private Sub WebIcons()
        Dim wc As New WebClient
        Dim mStream As New MemoryStream(wc.DownloadData("http://" & New Uri(iBro.Url.ToString).Host & "/favicon.ico"))
        Dim icon As New Icon(mStream)

        If Icons.Images.Count = -1 Then
            Icons.Images.Add(icon.ToBitmap)
            iTab.ImageIndex = 0
        Else
            Icons.Images.Clear()
            Icons.Images.Add(icon.ToBitmap)
            iTab.ImageIndex = 0
        End If
    End Sub
End Class
