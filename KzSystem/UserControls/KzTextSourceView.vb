Public Class KzTextSourceView

    Private _TextSeparator As Char

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Public Property TextSeparator As Char
        Get
            Return _TextSeparator
        End Get
        Set(value As Char)
            _TextSeparator = value
        End Set
    End Property


End Class
