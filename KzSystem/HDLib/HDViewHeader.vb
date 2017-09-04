Imports System.IO

Public Class HDViewHeader

    Private _LibInfo As HDLibInf

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        CoverBox.ErrorImage = My.Resources.lib_nocover
        CoverBox.InitialImage = My.Resources.lib_archive
    End Sub

    Public Property LibInfo As HDLibInf
        Get
            Return _LibInfo
        End Get
        Set(value As HDLibInf)
            _LibInfo = value
            UISetting()
        End Set
    End Property

    Public Property LibRoot As String

    Public ReadOnly Property AddFullPath As String
        Get
            Return Path.Combine(LibRoot, _LibInfo.Address)
        End Get
    End Property

    Public Sub UISetting()
        If _LibInfo Is Nothing Then
            _LibInfo = New HDLibInf
        End If

        IDLabel.Text = _LibInfo.ID
        TitleLabel.Text = _LibInfo.Name
        AuthorLabel.Text = _LibInfo.Author
        PilotLabel.Text = _LibInfo.Description

        If Directory.Exists(AddFullPath) Then
            CoverBox.Image = Image.FromFile(Path.Combine(AddFullPath, _LibInfo.Logo))
        End If
    End Sub
End Class
