Imports System.IO

Public Class KzImageView
    Private _Folder As String
    Private _ISideLength As Integer

    'Public Event ImageListChanged(sender As Object, e As EventArgs)

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Public Property Folder As String
        Get
            Return _Folder
        End Get
        Set(value As String)
            _Folder = value
            GetImageList(_Folder)
        End Set
    End Property

    Public Property ISideLength As Integer
        Get
            Return _ISideLength
        End Get
        Set(value As Integer)
            _ISideLength = value

            If IListFlow.Controls.Count > 0 Then
                For Each c As Control In IListFlow.Controls
                    Try
                        CType(c, PictureBox).Size = New Size(_ISideLength, _ISideLength)
                    Catch ex As Exception

                    End Try
                Next
            End If

        End Set
    End Property

    Public Property Checked As Boolean

    Private Sub GetImageList(ByVal Folder As String)
        IViewList.Images.Clear()

        If Directory.Exists(Folder) Then
            Dim di As New DirectoryInfo(Folder)
            Dim fis As FileInfo() = di.GetFiles

            For Each fi As FileInfo In fis
                If KzFiles.IsImageFile(fi) Then
                    Try
                        IViewList.Images.Add(Image.FromFile(fi.FullName))
                    Catch ex As Exception

                    End Try
                End If
            Next
        End If

    End Sub

    Private Sub RefreshFlow()
        IListFlow.Controls.Clear()
        Dim pb As PictureBox

        If IViewList.Images.Count > 0 Then
            For i As Integer = 0 To IViewList.Images.Count - 1
                pb = New PictureBox()
                pb.Size = New Size(_ISideLength, _ISideLength)
                pb.Image = IViewList.Images(i)
                pb.SizeMode = PictureBoxSizeMode.Zoom
                pb.Tag = i
                AddHandler pb.Click, AddressOf PictureBoxClick
                AddHandler pb.DoubleClick, AddressOf PictureBoxDoubleClick

                IListFlow.Controls.Add(pb)
            Next
        End If
    End Sub

    Private SelectedBox As PictureBox

    Private Sub PictureBoxClick(sender As Object, e As EventArgs)
        Dim pb As PictureBox = CType(sender, PictureBox)

        If Not pb.Equals(SelectedBox) Then
            SelectedBox = pb

            'Dim sbce As New ImageViewSelectedChangedEventArgs
            'sbce.Box = SelectedBox
            'sbce.Index = SelectedBox.Tag
            'RaiseEvent FlowListSelectedChanged(SelectedBox, sbce)
        End If
    End Sub

    Private Sub PictureBoxDoubleClick(sender As Object, e As EventArgs)

    End Sub

End Class

Public Class ImageViewStatusChangedEventArgs
    Inherits EventArgs

    Public Property Index As Integer
    Public Property Checked As Boolean
    Public Property Selected As Boolean
End Class

Public Class KzImageBox
    Inherits PictureBox

    Private _Checked As Boolean
    Private _Selected As Boolean
    Private _Index As Integer

    Public Sub New()

    End Sub

    Private Function GetCurrentArgs() As ImageViewStatusChangedEventArgs
        Return New ImageViewStatusChangedEventArgs With {
            .Index = _Index, .Checked = _Checked, .Selected = _Selected}
    End Function

    Public Property Index As Integer
        Get
            Return _Index
        End Get
        Set(value As Integer)
            If _Index <> value Then
                _Index = value

                OnIndexChanged(GetCurrentArgs())
            End If
        End Set
    End Property

    Public Property Checked As Boolean
        Get
            Return _Checked
        End Get
        Set(value As Boolean)
            If _Checked <> value Then
                _Checked = value

                OnCheckedChanged(GetCurrentArgs())
            End If
        End Set
    End Property

    Public Property Selected As Boolean
        Get
            Return _Selected
        End Get
        Set(value As Boolean)
            If _Selected <> value Then
                _Selected = value

                OnSelectedChanged(GetCurrentArgs())
            End If
        End Set
    End Property

    Public Shadows Property BorderStyle As BorderStyle

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        MyBase.OnPaint(pe)

        'ControlPaint.DrawBorder(pe.Graphics,)
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        _Selected = Not _Selected
        OnSelectedChanged(GetCurrentArgs())

        MyBase.OnClick(e)
    End Sub

    Protected Overrides Sub OnDoubleClick(e As EventArgs)
        _Checked = Not _Checked
        OnCheckedChanged(GetCurrentArgs())

        MyBase.OnDoubleClick(e)
    End Sub

    Protected Overridable Sub OnCheckedChanged(e As ImageViewStatusChangedEventArgs)
        If Me.Checked Then

        Else

        End If
        RaiseEvent CheckedChanged(Me, e)
    End Sub

    Protected Overridable Sub OnSelectedChanged(e As ImageViewStatusChangedEventArgs)
        RaiseEvent SelectedChanged(Me, e)
    End Sub

    Protected Overridable Sub OnIndexChanged(e As ImageViewStatusChangedEventArgs)
        RaiseEvent IndexChenged(Me, e)
    End Sub

    Public Event CheckedChanged As EventHandler(Of ImageViewStatusChangedEventArgs)
    Public Event SelectedChanged As EventHandler(Of ImageViewStatusChangedEventArgs)
    Public Event IndexChenged As EventHandler(Of ImageViewStatusChangedEventArgs)
End Class


'Ext | Mode | Description | Notes
'ART | R | PFS: 1st Publisher | Format originally used on the Macintosh (MacPaint?) And later used for PFS: 1st Publisher clip art.
'AVI | R | Microsoft Audio/Visual Interleaved | 
'AVS | RW | AVS X image | 
'BMP | RW | Microsoft Windows bitmap | 
'CGM | R | Computer Graphics Metafile | Requires ralcgm To render CGM files.
'CIN | RW | Kodak Cineon Image Format | Use -Set To specify the image gamma Or black And white points (e.g. -Set gamma 1.7, -Set reference-black 95, -Set reference-white 685).
'CMYK | RW | Raw cyan, magenta, yellow, And black samples | Use -size And -depth To specify the image width, height, And depth. To specify a Single precision floating-point format, use -depth 32 -define quantum:format = floating - point.Set the depth To 64 For a Double precision floating-point format.
'CMYKA | RW | Raw cyan, magenta, yellow, black, And alpha samples | Use -size And -depth To specify the image width, height, And depth. To specify a Single precision floating-point format, use -depth 32 -define quantum:format = floating - point.Set the depth To 64 For a Double precision floating-point format.
'CUR | R | Microsoft Cursor Icon | 
'CUT | R | DR Halo | 
'DCM | R | Digital Imaging And Communications In Medicine (DICOM) image | Used by the medical community For images Like X-rays.
'DCX | RW | ZSoft IBM PC multi-page Paintbrush image | 
'DIB | RW | Microsoft Windows Device Independent Bitmap | DIB Is a BMP file without the BMP header. Used To support embedded images In compound formats Like WMF.
'DJVU | R |  | 
'DNG | R | Digital Negative | 
'DOT | R | Graph Visualization | Use -define To specify the layout engine (e.g. -define dot:layout-engine = neato).
'DPX | RW | SMPTE Digital Moving Picture Exchange | Use -Set To specify the image gamma Or black And white points (e.g. -Set gamma 1.7, -Set reference-black 95, -Set reference-white 685).
'EMF | R | Microsoft Enhanced Metafile (32-bit) | Only available under Microsoft Windows.
'EPDF | RW | Encapsulated Portable Document Format | 
'EPI | RW | Adobe Encapsulated PostScript Interchange format | Requires Ghostscript To read.
'EPS | RW | Adobe Encapsulated PostScript | Requires Ghostscript To read.
'EPS2 | W | Adobe Level II Encapsulated PostScript | Requires Ghostscript To read.
'EPS3 | W | Adobe Level III Encapsulated PostScript | Requires Ghostscript To read.
'EPSF | RW | Adobe Encapsulated PostScript | Requires Ghostscript To read.
'EPSI | RW | Adobe Encapsulated PostScript Interchange format | Requires Ghostscript To read.
'EPT | RW |  | 
'OTB | RW | On-the-air Bitmap | 
'P7 | RW | Xv's Visual Schnauzer thumbnail format | 
'PALM | RW | Palm pixmap | 
'PAM | W | Common 2-dimensional bitmap format | 
'PBM | RW | Portable bitmap format (black And white) | 
'PCD | RW | Photo CD | The maximum resolution written Is 768x512 pixels since larger images require huffman compression (which Is Not supported).
'PCDS | RW | Photo CD | Decode With the sRGB color tables.
'PCL | W | HP Page Control Language | For output To HP laser printers.
'PCX | RW | ZSoft IBM PC Paintbrush file | 
'PDB | RW | Palm Database ImageViewer Format | 
'PDF | RW | Portable Document Format | Requires Ghostscript To read. By Default, ImageMagick sets the page size To the MediaBox. Some PDF files, however, have a CropBox that Is smaller than the MediaBox And may include white space, registration Or cutting marks outside the CropBox. To force ImageMagick To use the CropBox rather than the MediaBox, use -define (e.g. -define pdf:use-cropbox = True).
'PFA | R | Postscript Type 1 font (ASCII) | Opening As file returns a preview image.
'PFB | R | Postscript Type 1 font (binary) | Opening As file returns a preview image.
'PGM | RW | Portable graymap format (gray scale) | 
'PICON | RW | Personal Icon | 
'PICT | RW | Apple Macintosh QuickDraw/PICT file | 
'PIX | R | Alias/Wavefront RLE image format | 
'PNG | RW | Portable Network Graphics | Requires libpng-1.0.2 Or later, libpng-1.2.5 Or later recommended.
'PNM | RW | Portable anymap | PNM Is a family Of formats supporting portable bitmaps (PBM) , graymaps (PGM), And pixmaps (PPM). There Is no file format associated With pnm itself. If PNM Is used As the output format specifier, Then ImageMagick automatically selects the most appropriate format To represent the image. The Default Is To write the binary version Of the formats. Use -compress none To write the ASCII version Of the formats.
'PPM | RW | Portable pixmap format (color) | 
'PS | RW | Adobe PostScript file | Requires Ghostscript To read.
'PS2 | RW | Adobe Level II PostScript file | Requires Ghostscript To read.
'PS3 | RW | Adobe Level III PostScript file | Requires Ghostscript To read.
'PSD | RW | Adobe Photoshop bitmap file | 
'PTIF | RW | Pyramid encoded TIFF</a /> | Multi-resolution TIFF containing successively smaller versions Of the image down To the size Of an icon. The desired Sub-image size may be specified When reading via the -size Option.
'PWP | R | Seattle File Works multi-image file | 
'RAD | R | Radiance image file | Requires that ra_ppm from the Radiance software package be installed.
'RGB | RW | Raw red, green, And blue samples | Use -size And -depth To specify the image width, height, And depth. To specify a Single precision floating-point format, use -depth 32 -define quantum:format = floating - point.Set the depth To 64 For a Double precision floating-point format.
'RGBA | RW | Raw red, green, blue, And alpha samples | Use -size And -depth To specify the image width, height, And depth. To specify a Single precision floating-point format, use -depth 32 -define quantum:format = floating - point.Set the depth To 64 For a Double precision floating-point format.
'RLA | R | Alias/Wavefront image file | 
'RLE | R | Utah Run length encoded image file | 
'SCT | R | Scitex Continuous Tone Picture | 
'SFW | R | Seattle File Works image | 
'SGI | RW | Irix RGB image | 
'SHTML | W | Hypertext Markup Language client-side image map | Used To write HTML clickable image maps based On a the output Of montage Or a format which supports tiled images such As MIFF.
'SUN | RW | SUN Rasterfile | 
'SVG | RW | Scalable Vector Graphics | Requires libxml2 And freetype-2. Note that SVG Is a very complex specification so support Is still Not complete.
'TGA | RW | Truevision Targa image | Also known As formats ICB, VDA, And VST.
'TIFF | RW | Tagged Image File Format | Also known As TIF. Requires tiff-v3.6.1.tar.gz Or later. Use -define To specify the rows per strip (e.g. -define tiff:rows-per - strip = 8). To specify a signed format, use -define quantum:format signed. To specify a Single-precision floating-point format, use -depth 32 -define quantum:format = floating - point.Set the depth To 64 For a Double-precision floating-point format. Use -define tiff:photometric = min -Is -black Or -define tiff:photometric = min -Is -white To toggle the photometric interpretation For a bilevel image. Specify the extra samples As associated Or unassociated alpha With, For example, -define tiff:alpha = unassociated.
'TIM | R | PSX TIM file | 
'TTF | R | TrueType font file | Requires freetype 2. Opening as file returns a preview image. Use -set if you do not want to hint glyph outlines after their scaling to device pixels (e.g. -set type:hinting off).
'TXT | RW | Raw text file | 
'UIL | W | X-Motif UIL table | 
'UYVY | RW | Interleaved YUV raw image | Use -size and -depth command line options to specify width and height. Use -sampling-factor to set the desired subsampling (e.g. -sampling-factor 4:2:2).
'VICAR | RW | VICAR rasterfile format | 
'VIFF | RW | Khoros Visualization Image File Format | 
'WBMP | RW | Wireless bitmap | Support for uncompressed monochrome only.
'WMF | R | Windows Metafile | Requires libwmf. By default, renders WMF files using the dimensions specified by the metafile header. Use the -density option to adjust the output resolution, and thereby adjust the output size. The default output resolution is 72DPI so -density 144 results in an image twice as large as the default. Use -background color to specify the WMF background color (default white) or -texture filename to specify a background texture image.
'WPG | R | Word Perfect Graphics File | 
'X | RW | display or import an image to or from an X11 server | Use -define to obtain the image from the root window (e.g. -define x:screen=true).
'XBM | RW | X Windows system bitmap, black and white only | Used by the X Windows System to store monochrome icons.
'XCF | R | GIMP image | 
'XPM | RW | X Windows system pixmap | Also known as PM. Used by the X Windows System to store color icons.
'XWD | RW | X Windows system window dump | Used by the X Windows System to save/display screen dumps.
'YCbCr | RW | Raw Y, Cb, and Cr samples | Use -size and -depth to specify the image width, height, and depth.
'YCbCrA | RW | Raw Y, Cb, Cr, and alpha samples | Use -size and -depth to specify the image width, height, and depth.
'YUV | RW | CCIR 601 4:1:1 | Use -size and -depth command line options to specify width, height, and depth. Use -sampling-factor to set the desired subsampling (e.g. -sampling-factor 4:2:2).

